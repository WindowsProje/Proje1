using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.BankaBilgi;
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
    public class BankaBilgiManager
    {
        public async Task<bool> BankaBilgiEkleAsAsync(BankaBilgiTumDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.BankaBilgileri.AddData(new BankaBilgi()
                    {
                        Adres = ban.Adres,
                        AktifMi = ban.AktifMi,
                        BankaAd = ban.BankaAd,
                        DilID = ban.DilID,
                        GuncellemeTarih = ban.GuncellemeTarih,
                        KayitTarih = ban.KayitTarih,
                        SilindiMi = ban.SilindiMi,
                        SirketID = ban.SirketID,
                        Telefon = ban.Telefon,
                        Yetkili = ban.Yetkili
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
        public async Task<bool> BankaBilgiGuncelleAsAsync(BankaBilgiTumDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.BankaBilgileri.FindDataAsync(ban.BankaBilgiID).Result;
                    if (temp != null)
                    {
                        temp.Adres = ban.Adres;
                        temp.AktifMi = ban.AktifMi;
                        temp.BankaAd = ban.BankaAd;
                        temp.DilID = ban.DilID;
                        temp.GuncellemeTarih = ban.GuncellemeTarih;
                        temp.KayitTarih = ban.KayitTarih;
                        temp.SilindiMi = ban.SilindiMi;
                        temp.SirketID = ban.SirketID;
                        temp.Telefon = ban.Telefon;
                        temp.Yetkili = ban.Yetkili;
                        if (unitOfWork.BankaBilgileri.IsModified(temp) == true)
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
        public async Task<bool> BankaBilgiSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.BankaBilgileri.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.BankaBilgileri.RemoveData(temp);
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
        public async Task<BankaBilgiTumDTO> BankaBilgiSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.BankaBilgileri.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new BankaBilgiTumDTO()
                        {
                            Adres = temp.Adres,
                            AktifMi = temp.AktifMi,
                            BankaAd = temp.BankaAd,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            Telefon = temp.Telefon,
                            Yetkili = temp.Yetkili,
                            BankaBilgiID = temp.BankaBilgiID
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
        public BankaBilgiListeDTO[] BankaBilgiListeleAsAsync(BankaBilgiFiltreDTO ban)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<BankaBilgiListeDTO> lst = new List<BankaBilgiListeDTO>();
                    foreach (var item in unitOfWork.BankaBilgileri.ListDataByExpressionAsync(c => c.AktifMi == ban.AktifMi && c.DilID == ban.DilID && c.SirketID == ban.SirketID && c.SilindiMi == ban.SilindiMi).Result)
                    {
                        lst.Add(new BankaBilgiListeDTO()
                        {
                            BankaBilgiID = item.BankaBilgiID,
                            BankaAd = item.BankaAd
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
