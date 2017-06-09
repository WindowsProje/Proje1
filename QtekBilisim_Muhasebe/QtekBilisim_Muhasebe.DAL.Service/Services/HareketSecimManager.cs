using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.HareketSecim;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class HareketSecimManager
    //{
    //    public async Task<bool> HareketSecimEkleAsAsync(HareketSecimTumDTO har)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.HareketSecimleri.AddData(new HareketSecim()
    //                {
    //                    AktifMi = har.AktifMi,
    //                    DevirHareket = har.DevirHareket,
    //                    DilID = har.DilID,
    //                    Duzeltme = har.Duzeltme,
    //                    GuncellemeTarih = har.GuncellemeTarih,
    //                    Iade = har.Iade,
    //                    KayitTarih = har.KayitTarih,
    //                    SilindiMi = har.SilindiMi,
    //                    SirketID = har.SirketID,
    //                    Transfer = har.Transfer
    //                });
    //                int affect = await unitOfWork.CompleteAsync();
    //                if (affect > 0)
    //                {
    //                    return true;
    //                }
    //                else
    //                {
    //                    return false;
    //                }
    //            }
    //        }
    //        catch (DbEntityValidationException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new DbEntityValidationException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (FormatException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new FormatException(code.Result);
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception();
    //        }
    //    }
    //    public async Task<bool> HareketSecimGuncelleAsAsync(HareketSecimTumDTO har)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.HareketSecimleri.FindDataAsync(har.HareketSecimID).Result;
    //                if (temp != null)
    //                {
    //                    temp.AktifMi = har.AktifMi;
    //                    temp.DevirHareket = har.DevirHareket;
    //                    temp.DilID = har.DilID;
    //                    temp.Duzeltme = har.Duzeltme;
    //                    temp.GuncellemeTarih = har.GuncellemeTarih;
    //                    temp.Iade = har.Iade;
    //                    temp.KayitTarih = har.KayitTarih;
    //                    temp.SilindiMi = har.SilindiMi;
    //                    temp.SirketID = har.SirketID;
    //                    temp.Transfer = har.Transfer;
    //                    if (unitOfWork.HareketSecimleri.IsModified(temp) == true)
    //                    {
    //                        int affect = await unitOfWork.CompleteAsync();
    //                        if (affect > 0)
    //                        {
    //                            return true;
    //                        }
    //                        else
    //                        {
    //                            return false;
    //                        }
    //                    }
    //                    else
    //                    {
    //                        throw new NotModifiedDataOnDatabaseCustomException();
    //                    }
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (DbEntityValidationException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new DbEntityValidationException(code.Result);
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (FormatException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new FormatException(code.Result);
    //        }
    //        catch (NotModifiedDataOnDatabaseCustomException)
    //        {
    //            throw new NotModifiedDataOnDatabaseCustomException();
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public async Task<bool> HareketSecimSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.HareketSecimleri.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.HareketSecimleri.RemoveData(temp);
    //                    int affect = await unitOfWork.CompleteAsync();
    //                    if (affect > 0)
    //                    {
    //                        return true;
    //                    }
    //                    else
    //                    {
    //                        return false;
    //                    }
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public async Task<HareketSecimTumDTO> HareketSecimSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.HareketSecimleri.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new HareketSecimTumDTO()
    //                    {
    //                        AktifMi = temp.AktifMi,
    //                        DevirHareket = temp.DevirHareket,
    //                        DilID = temp.DilID,
    //                        Duzeltme = temp.Duzeltme,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        Iade = temp.Iade,
    //                        KayitTarih = temp.KayitTarih,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        Transfer = temp.Transfer,
    //                        HareketSecimID = temp.HareketSecimID
    //                    };
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public HareketSecimListeDTO[] HareketSecimListeleAsAsync(HareketSecimFiltreDTO har)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<HareketSecimListeDTO> lst = new List<HareketSecimListeDTO>();
    //                foreach (var item in unitOfWork.HareketSecimleri.ListDataByExpressionAsync(c => c.AktifMi == har.AktifMi && c.DilID == har.DilID && c.SirketID == har.SirketID && c.SilindiMi == har.SilindiMi).Result)
    //                {
    //                    lst.Add(new HareketSecimListeDTO()
    //                    {
    //                        HareketSecimID = item.HareketSecimID
    //                    });
    //                }
    //                return lst.ToArray();
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //}
}
