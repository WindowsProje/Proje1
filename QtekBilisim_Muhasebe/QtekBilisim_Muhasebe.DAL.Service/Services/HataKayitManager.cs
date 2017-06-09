using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.HataKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    static class HataKayitManager
    {
        public async static Task<string> HataKayitEkleAsync(Exception error)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    Guid guid = Guid.NewGuid();
                    string code = (guid.ToString()).Replace("-", "");
                    int year = DateTime.Now.Year;
                    int month = DateTime.Now.Month;
                    int day = DateTime.Now.Day;
                    string errorCode = "ECoX" + year + month + day + "-" + code.Substring(0, 12);
                    string innerException = string.Empty;
                    if (error.InnerException != null)
                    {
                        innerException = error.InnerException.ToString();
                    }
                    unitOfWork.HataKayitlari.AddData(new HataKayit()
                    {
                        ErrorType = error.GetType().ToString(),
                        AktifMi = true,
                        DilID = 0,
                        GuncellemeTarih = DateTime.Now,
                        HataKod = errorCode,
                        HataTarih = DateTime.Now,
                        HataZaman = DateTime.Now.TimeOfDay,
                        HelpLink = error.HelpLink,
                        InnerException = innerException,
                        KayitTarih = DateTime.Now,
                        Message = error.Message,
                        SilindiMi = false,
                        SirketID = 0,
                        Source = error.Source,
                        StackTrace = error.StackTrace,
                        TargetSite = error.TargetSite.ToString()
                    });
                    Task<int> affect = unitOfWork.CompleteAsync();
                    if (affect.Result > 0)
                    {
                        if (error.StackTrace != string.Empty)
                        {
                            int id = unitOfWork.HataKayitlari.EnBuyukHataKayitIDAsync().Result;
                            List<StackTraceFrame> lst = new List<StackTraceFrame>();
                            StackTrace st = new StackTrace(error);
                            foreach (var item in st.GetFrames())
                            {
                                lst.Add(new StackTraceFrame()
                                {
                                    AktifMi = true,
                                    DilID = 0,
                                    GuncellemeTarih = DateTime.Now,
                                    HataKayitID = id,
                                    KayitTarih = DateTime.Now,
                                    Method = item.GetMethod().ToString(),
                                    SilindiMi = false,
                                    SirketID = 0
                                });
                            }
                            unitOfWork.StackTraceFrames.AddDataRange(lst);
                            await unitOfWork.CompleteAsync();
                        }
                        return await Task<string>.Factory.StartNew(() =>
                        {
                            return errorCode;
                        });
                    }
                    else
                    {
                        return await Task<string>.Factory.StartNew(() =>
                        {
                            return string.Empty;
                        });
                    }
                }
            }
            catch
            {
                return await Task<string>.Factory.StartNew(() =>
                {
                    return string.Empty;
                });
            }
        }
    }
}
