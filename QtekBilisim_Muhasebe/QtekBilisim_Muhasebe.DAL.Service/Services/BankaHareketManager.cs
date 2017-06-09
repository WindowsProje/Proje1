using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.BankaHareket;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class BankaHareketManager
    //{
    //    public async Task<bool> BankaHareketEkleAsAsync(BankaHareketTumDTO ban)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.BankaHareketleri.AddData(new BankaHareket()
    //                {
    //                    Aciklama = ban.Aciklama,
    //                    AktifMi = ban.AktifMi,
    //                    BankaID = ban.BankaID,
    //                    DilID = ban.DilID,
    //                    EvrakNo = ban.EvrakNo,
    //                    GuncellemeTarih = ban.GuncellemeTarih,
    //                    IslemSaat = ban.IslemSaat.TimeOfDay,
    //                    IslemTarih = ban.IslemTarih,
    //                    IslemTur = ban.IslemTur,
    //                    KayitTarih = ban.KayitTarih,
    //                    OzelKod = ban.OzelKod,
    //                    SilindiMi = ban.SilindiMi,
    //                    SirketID = ban.SirketID,
    //                    TutarAlacak = ban.TutarAlacak,
    //                    TutarBorc = ban.TutarBorc,
    //                    Vade = ban.Vade
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
    //    public async Task<bool> BankaHareketGuncelleAsAsync(BankaHareketTumDTO ban)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.BankaHareketleri.FindDataAsync(ban.BankaHareketID).Result;
    //                if (temp != null)
    //                {
    //                    temp.Aciklama = ban.Aciklama;
    //                    temp.AktifMi = ban.AktifMi;
    //                    temp.BankaID = ban.BankaID;
    //                    temp.DilID = ban.DilID;
    //                    temp.EvrakNo = ban.EvrakNo;
    //                    temp.GuncellemeTarih = ban.GuncellemeTarih;
    //                    temp.IslemSaat = ban.IslemSaat.TimeOfDay;
    //                    temp.IslemTarih = ban.IslemTarih;
    //                    temp.IslemTur = ban.IslemTur;
    //                    temp.KayitTarih = ban.KayitTarih;
    //                    temp.OzelKod = ban.OzelKod;
    //                    temp.SilindiMi = ban.SilindiMi;
    //                    temp.SirketID = ban.SirketID;
    //                    temp.TutarAlacak = ban.TutarAlacak;
    //                    temp.TutarBorc = ban.TutarBorc;
    //                    temp.Vade = ban.Vade;
    //                    if (unitOfWork.BankaHareketleri.IsModified(temp) == true)
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
    //    public async Task<bool> BankaHareketSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.BankaHareketleri.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.BankaHareketleri.RemoveData(temp);
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
    //    public async Task<BankaHareketTumDTO> BankaHareketSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.BankaHareketleri.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new BankaHareketTumDTO()
    //                    {
    //                        Aciklama = temp.Aciklama,
    //                        AktifMi = temp.AktifMi,
    //                        BankaID = temp.BankaID,
    //                        DilID = temp.DilID,
    //                        EvrakNo = temp.EvrakNo,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        IslemSaat = Convert.ToDateTime(temp.IslemSaat),
    //                        IslemTarih = temp.IslemTarih,
    //                        IslemTur = temp.IslemTur,
    //                        KayitTarih = temp.KayitTarih,
    //                        OzelKod = temp.OzelKod,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        TutarAlacak = temp.TutarAlacak,
    //                        TutarBorc = temp.TutarBorc,
    //                        Vade = temp.Vade,
    //                        BankaHareketID = temp.BankaHareketID
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
    //    public BankaHareketListeDTO[] BankaHareketListeleAsAsync(BankaHareketFiltreDTO ban)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<BankaHareketListeDTO> lst = new List<BankaHareketListeDTO>();
    //                foreach (var item in unitOfWork.BankaHareketleri.ListDataByExpressionAsync(c => c.AktifMi == ban.AktifMi && c.DilID == ban.DilID && c.SirketID == ban.SirketID && c.SilindiMi == ban.SilindiMi).Result)
    //                {
    //                    lst.Add(new BankaHareketListeDTO()
    //                    {
    //                        BankaHareketID = item.BankaHareketID,
    //                        BankaID = item.BankaID,
    //                        EvrakNo = item.EvrakNo,
    //                        OzelKod = item.OzelKod,
    //                        TutarAlacak = item.TutarAlacak,
    //                        TutarBorc = item.TutarBorc,
    //                        Vade = item.Vade
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
