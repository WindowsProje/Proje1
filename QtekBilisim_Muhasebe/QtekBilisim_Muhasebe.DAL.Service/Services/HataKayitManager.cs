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
        public static void HataKayitEkle(Exception error)
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
                    string errorCode = "EC" + "_" + year + month + day + "-" + code.Substring(0, 12);
                    string innerException = string.Empty;
                    if (error.InnerException != null)
                    {
                        innerException = error.InnerException.ToString();
                    }
                    unitOfWork.HataKayitlari.AddData(new HataKayit()
                    {
                        ErrorType = error.GetType().ToString(),
                        HataKod = errorCode,
                        HataTarih = DateTime.Now,
                        HataZaman = DateTime.Now.TimeOfDay,
                        HelpLink = error.HelpLink,
                        InnerException = innerException,
                        Message = error.Message,
                        SilindiMi = false,
                        Source = error.Source,
                        StackTrace = error.StackTrace,
                        TargetSite = error.TargetSite.ToString()
                    });
                    int affect = unitOfWork.Complete();
                    if (affect > 0)
                    {
                        if (error.StackTrace != string.Empty)
                        {
                            int id = unitOfWork.HataKayitlari.EnBuyukHataKayitID();
                            List<StackTraceFrame> lst = new List<StackTraceFrame>();
                            StackTrace st = new StackTrace(error);
                            foreach (var item in st.GetFrames())
                            {
                                lst.Add(new StackTraceFrame()
                                {
                                    HataKayitID = id,
                                    KayitTarih = DateTime.Now,
                                    Method = item.GetMethod().ToString(),
                                    SilindiMi = false
                                });
                            }
                            unitOfWork.StackTraceFrames.AddDataRange(lst);
                            unitOfWork.Complete();
                        }
                    }
                }
            }
            catch { }
        }
    }
}
