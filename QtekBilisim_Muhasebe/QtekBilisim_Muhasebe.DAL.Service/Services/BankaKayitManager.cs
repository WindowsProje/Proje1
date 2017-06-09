using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.BankaKayit;
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
    public class BankaKayitManager
    {
        public async Task<bool> BankaKayitEkleAsAsync(BankaKayitTumDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.BankaKayitlari.AddData(new BankaKayit()
                    {
                        AktifMi = ban.AktifMi,
                        BankaAd = ban.BankaAd,
                        BankaBilgiID = ban.BankaBilgiID,
                        CekID = ban.CekID,
                        DilID = ban.DilID,
                        GuncellemeTarih = ban.GuncellemeTarih,
                        HesapNumara = ban.HesapNumara,
                        HesapTur = ban.HesapTur,
                        IBAN = ban.IBAN,
                        KayitTarih = ban.KayitTarih,
                        KrediKartID = ban.KrediKartID,
                        PosID = ban.PosID,
                        SenetID = ban.SenetID,
                        SilindiMi = ban.SilindiMi,
                        SirketID = ban.SirketID,
                        SubeKod = ban.SubeKod
                    });
                    int affect = await unitOfWork.CompleteAsync();
                    if (affect > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (DbEntityValidationException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new DbEntityValidationException(code.Result);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NullReferenceException(code.Result);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new AggregateException(code.Result);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new FormatException(code.Result);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new ArgumentNullException(code.Result);
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception();
            }
        }
        public async Task<bool> BankaKayitGuncelleAsAsync(BankaKayitTumDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.BankaKayitlari.FindDataAsync(ban.BankaID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = ban.AktifMi;
                        temp.BankaAd = ban.BankaAd;
                        temp.BankaBilgiID = ban.BankaBilgiID;
                        temp.CekID = ban.CekID;
                        temp.DilID = ban.DilID;
                        temp.GuncellemeTarih = ban.GuncellemeTarih;
                        temp.HesapNumara = ban.HesapNumara;
                        temp.HesapTur = ban.HesapTur;
                        temp.IBAN = ban.IBAN;
                        temp.KayitTarih = ban.KayitTarih;
                        temp.KrediKartID = ban.KrediKartID;
                        temp.PosID = ban.PosID;
                        temp.SenetID = ban.SenetID;
                        temp.SilindiMi = ban.SilindiMi;
                        temp.SirketID = ban.SirketID;
                        temp.SubeKod = ban.SubeKod;
                        if (unitOfWork.BankaKayitlari.IsModified(temp) == true)
                        {
                            int affect = await unitOfWork.CompleteAsync();
                            if (affect > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            throw new NotModifiedDataOnDatabaseCustomException();
                        }
                    }
                    else
                    {
                        throw new NullDataOnDatabaseCustomException();
                    }
                }
            }
            catch (DbEntityValidationException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new DbEntityValidationException(code.Result);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new ArgumentNullException(code.Result);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NullReferenceException(code.Result);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new AggregateException(code.Result);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new FormatException(code.Result);
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
        public async Task<bool> BankaKayitSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.BankaKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.BankaKayitlari.RemoveData(temp);
                        int affect = await unitOfWork.CompleteAsync();
                        if (affect > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        throw new NullDataOnDatabaseCustomException();
                    }
                }
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new ArgumentNullException(code.Result);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NullReferenceException(code.Result);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new AggregateException(code.Result);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
        public async Task<BankaKayitTumDTO> BankaKayitSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.BankaKayitlari.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new BankaKayitTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            BankaAd = temp.BankaAd,
                            BankaBilgiID = temp.BankaBilgiID,
                            CekID = temp.CekID,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            HesapNumara = temp.HesapNumara,
                            HesapTur = temp.HesapTur,
                            IBAN = temp.IBAN,
                            KayitTarih = temp.KayitTarih,
                            KrediKartID = temp.KrediKartID,
                            PosID = temp.PosID,
                            SenetID = temp.SenetID,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            SubeKod = temp.SubeKod,
                            BankaID = temp.BankaID
                        };
                    }
                    else
                    {
                        throw new NullDataOnDatabaseCustomException();
                    }
                }
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new ArgumentNullException(code.Result);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NullReferenceException(code.Result);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new AggregateException(code.Result);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
        public BankaKayitListeDTO[] BankaKayitListeleAsAsync(BankaKayitFiltreDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<BankaKayitListeDTO> lst = new List<BankaKayitListeDTO>();
                    foreach (var item in unitOfWork.BankaKayitlari.ListDataByExpressionAsync(c => c.AktifMi == ban.AktifMi && c.DilID == ban.DilID && c.SirketID == ban.SirketID && c.SilindiMi == ban.SilindiMi).Result)
                    {
                        lst.Add(new BankaKayitListeDTO()
                        {
                            BankaAd = item.BankaAd,
                            BankaBilgiID = item.BankaBilgiID,
                            BankaID = item.BankaID,
                            HesapNumara = item.HesapNumara,
                            HesapTur = item.HesapTur,
                            IBAN = item.IBAN,
                            SubeKod = item.SubeKod
                        });
                    }
                    return lst.ToArray();
                }
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new ArgumentNullException(code.Result);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NullReferenceException(code.Result);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new AggregateException(code.Result);
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
    }
}
