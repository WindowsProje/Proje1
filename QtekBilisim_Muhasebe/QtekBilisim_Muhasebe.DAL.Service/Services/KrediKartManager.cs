using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.KrediKart;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class KrediKartManager
    //{
    //    public async Task<bool> KrediKartEkleAsAsync(KrediKartTumDTO kre)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.KrediKartlari.AddData(new KrediKart()
    //                {
    //                    AktifMi = kre.AktifMi,
    //                    DilID = kre.DilID,
    //                    GuncellemeTarih = kre.GuncellemeTarih,
    //                    KayitTarih = kre.KayitTarih,
    //                    SilindiMi = kre.SilindiMi,
    //                    SirketID = kre.SirketID
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
    //    public async Task<bool> KrediKartGuncelleAsAsync(KrediKartTumDTO kre)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.KrediKartlari.FindDataAsync(kre.KrediKartID).Result;
    //                if (temp != null)
    //                {
    //                    temp.AktifMi = kre.AktifMi;
    //                    temp.DilID = kre.DilID;
    //                    temp.GuncellemeTarih = kre.GuncellemeTarih;
    //                    temp.KayitTarih = kre.KayitTarih;
    //                    temp.SilindiMi = kre.SilindiMi;
    //                    temp.SirketID = kre.SirketID;
    //                    if (unitOfWork.KrediKartlari.IsModified(temp) == true)
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
    //    public async Task<bool> KrediKartSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.KrediKartlari.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.KrediKartlari.RemoveData(temp);
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
    //    public async Task<KrediKartTumDTO> KrediKartSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.KrediKartlari.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new KrediKartTumDTO()
    //                    {
    //                        AktifMi = temp.AktifMi,
    //                        DilID = temp.DilID,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        KayitTarih = temp.KayitTarih,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        KrediKartID = temp.KrediKartID
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
    //    public KrediKartListeDTO[] KrediKartListeleAsAsync(KrediKartFiltreDTO kre)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<KrediKartListeDTO> lst = new List<KrediKartListeDTO>();
    //                foreach (var item in unitOfWork.KrediKartlari.ListDataByExpressionAsync(c => c.AktifMi == kre.AktifMi && c.DilID == kre.DilID && c.SirketID == kre.SirketID && c.SilindiMi == kre.SilindiMi).Result)
    //                {
    //                    lst.Add(new KrediKartListeDTO()
    //                    {
    //                        KrediKartID = item.KrediKartID
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
