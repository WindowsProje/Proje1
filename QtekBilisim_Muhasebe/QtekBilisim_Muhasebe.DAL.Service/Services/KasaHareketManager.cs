using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.KasaHareket;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class KasaHareketManager
    //{
    //    public async Task<bool> KasaHareketEkleAsAsync(KasaHareketTumDTO kas)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.KasaHareketleri.AddData(new KasaHareket()
    //                {
    //                    AktifMi = kas.AktifMi,
    //                    CariID = kas.CariID,
    //                    DilID = kas.DilID,
    //                    EvrakNumara = kas.EvrakNumara,
    //                    GuncellemeTarih = kas.GuncellemeTarih,
    //                    HareketKod = kas.HareketKod,
    //                    IslemAciklama = kas.IslemAciklama,
    //                    IslemTarih = kas.IslemTarih,
    //                    IslemTur = kas.IslemTur,
    //                    KayitTarih = kas.KayitTarih,
    //                    SilindiMi = kas.SilindiMi,
    //                    SirketID = kas.SirketID
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
    //    public async Task<bool> KasaHareketGuncelleAsAsync(KasaHareketTumDTO kas)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.KasaHareketleri.FindDataAsync(kas.KasaHareketID).Result;
    //                if (temp != null)
    //                {
    //                    temp.AktifMi = kas.AktifMi;
    //                    temp.CariID = kas.CariID;
    //                    temp.DilID = kas.DilID;
    //                    temp.EvrakNumara = kas.EvrakNumara;
    //                    temp.GuncellemeTarih = kas.GuncellemeTarih;
    //                    temp.HareketKod = kas.HareketKod;
    //                    temp.IslemAciklama = kas.IslemAciklama;
    //                    temp.IslemTarih = kas.IslemTarih;
    //                    temp.IslemTur = kas.IslemTur;
    //                    temp.KayitTarih = kas.KayitTarih;
    //                    temp.SilindiMi = kas.SilindiMi;
    //                    temp.SirketID = kas.SirketID;
    //                    if (unitOfWork.KasaHareketleri.IsModified(temp) == true)
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
    //    public async Task<bool> KasaHareketSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.KasaHareketleri.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.KasaHareketleri.RemoveData(temp);
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
    //    public async Task<KasaHareketTumDTO> KasaHareketSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.KasaHareketleri.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new KasaHareketTumDTO()
    //                    {
    //                        AktifMi = temp.AktifMi,
    //                        CariID = temp.CariID,
    //                        DilID = temp.DilID,
    //                        EvrakNumara = temp.EvrakNumara,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        HareketKod = temp.HareketKod,
    //                        IslemAciklama = temp.IslemAciklama,
    //                        IslemTarih = Convert.ToDateTime(temp.IslemTarih),
    //                        IslemTur = temp.IslemTur,
    //                        KayitTarih = temp.KayitTarih,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        KasaHareketID = temp.KasaHareketID
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
    //    public KasaHareketListeDTO[] KasaHareketListeleAsAsync(KasaHareketFiltreDTO kas)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<KasaHareketListeDTO> lst = new List<KasaHareketListeDTO>();
    //                foreach (var item in unitOfWork.KasaHareketleri.ListDataByExpressionAsync(c => c.AktifMi == kas.AktifMi && c.DilID == kas.DilID && c.SirketID == kas.SirketID && c.SilindiMi == kas.SilindiMi).Result)
    //                {
    //                    lst.Add(new KasaHareketListeDTO()
    //                    {
    //                        CariID = item.CariID,
    //                        KasaHareketID = item.KasaHareketID,
    //                        EvrakNumara = item.EvrakNumara,
    //                        HareketKod = item.HareketKod
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
