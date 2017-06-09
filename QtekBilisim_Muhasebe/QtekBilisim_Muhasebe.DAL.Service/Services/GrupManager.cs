using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Grup;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class GrupManager
    {
        public bool GrupEkle(GrupTumDTO grup)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.GrupKayitlari.AddData(new Grup()
                    {
                        AktifMi = grup.AktifMi,
                        AlanID = grup.AlanID,
                        AlanTipi = grup.AlanTipi,
                        DilID = grup.DilID,
                        GrupAd = grup.GrupAd,
                        GuncellemeTarih = grup.GuncellemeTarih,
                        KayitTarih = grup.KayitTarih,
                        SilindiMi = grup.SilindiMi,
                        SirketID = grup.SirketID,
                        UstGrupID = grup.UstGrupID,
                        KullaniciID = grup.KullaniciID
                    });
                    int affect = unitOfWork.Complete();
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
                var code = HataKayitManager.HataKayitEkle(error);
                throw new DbEntityValidationException(code);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentNullException(code);
            }
            catch (ArgumentException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentException(code);
            }
            catch (InvalidOperationException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new InvalidOperationException(code);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new NullReferenceException(code);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new AggregateException(code);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new FormatException(code);
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new Exception(code);
            }
        }
        public async Task<bool> GrupGuncelleAsAsync(GrupTumDTO grup)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.GrupKayitlari.FindDataAsync(grup.GrupID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = grup.AktifMi;
                        temp.AlanID = grup.AlanID;
                        temp.AlanTipi = grup.AlanTipi;
                        temp.DilID = grup.DilID;
                        temp.GrupAd = grup.GrupAd;
                        temp.GuncellemeTarih = grup.GuncellemeTarih;
                        temp.KayitTarih = grup.KayitTarih;
                        temp.SilindiMi = grup.SilindiMi;
                        temp.SirketID = grup.SirketID;
                        temp.UstGrupID = grup.UstGrupID;
                        if (unitOfWork.GrupKayitlari.IsModified(temp) == true)
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
                var code = HataKayitManager.HataKayitEkle(error);
                throw new DbEntityValidationException(code);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentNullException(code);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new NullReferenceException(code);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new AggregateException(code);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new FormatException(code);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new Exception(code);
            }
        }
        public async Task<bool> GrupSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.GrupKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.GrupKayitlari.RemoveData(temp);
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
            catch (DbEntityValidationException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new DbEntityValidationException(code);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentNullException(code);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new NullReferenceException(code);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new AggregateException(code);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new FormatException(code);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new Exception(code);
            }
        }
        public async Task<GrupTumDTO> GrupSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.GrupKayitlari.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new GrupTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            AlanID = temp.AlanID,
                            AlanTipi = temp.AlanTipi,
                            DilID = temp.DilID,
                            GrupAd = temp.GrupAd,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            UstGrupID = temp.UstGrupID,
                            GrupID = temp.GrupID
                        };
                    }
                    else
                    {
                        throw new NullDataOnDatabaseCustomException();
                    }
                }
            }
            catch (DbEntityValidationException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new DbEntityValidationException(code);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentNullException(code);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new NullReferenceException(code);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new AggregateException(code);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new FormatException(code);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new Exception(code);
            }
        }
        public GrupListeDTO[] GrupListeAsAsync(GrupFiltreDTO grup)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<GrupListeDTO> lst = new List<GrupListeDTO>();
                    foreach (var item in unitOfWork.GrupKayitlari.ListDataByExpressionAsync(b => b.AktifMi == grup.AktifMi && b.DilID == grup.DilID && b.SirketID == grup.SirketID && b.SilindiMi == grup.SilindiMi).Result)
                    {
                        lst.Add(new GrupListeDTO()
                        {
                            GrupAd = item.GrupAd,
                            GrupID = item.GrupID
                        });
                    }
                    return lst.ToArray();
                }
            }
            catch (DbEntityValidationException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new DbEntityValidationException(code);
            }
            catch (ArgumentNullException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new ArgumentNullException(code);
            }
            catch (NullReferenceException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new NullReferenceException(code);
            }
            catch (AggregateException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new AggregateException(code);
            }
            catch (FormatException error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new FormatException(code);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkle(error);
                throw new Exception(code);
            }
        }
    }
}
