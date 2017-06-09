using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Ulke;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class UlkeManager
    {
        public bool UlkeEkle(UlkeTumDTO ul)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.UlkeKayitlari.AddData(new Ulke()
                    {
                        AktifMi = ul.AktifMi,
                        DilID = ul.DilID,
                        GuncellemeTarih = ul.GuncellemeTarih,
                        KayitTarih = ul.KayitTarih,
                        SilindiMi = ul.SilindiMi,
                        SirketID = ul.SirketID,
                        UlkeAd = ul.UlkeAd,
                        KullaniciID = ul.KullaniciID
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
        public bool UlkeGuncelle(UlkeTumDTO ul)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindDataAsync(ul.UlkeID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = ul.AktifMi;
                        temp.DilID = ul.DilID;
                        temp.GuncellemeTarih = ul.GuncellemeTarih;
                        temp.KayitTarih = ul.KayitTarih;
                        temp.SilindiMi = ul.SilindiMi;
                        temp.SirketID = ul.SirketID;
                        temp.UlkeAd = ul.UlkeAd;
                        temp.KullaniciID = ul.KullaniciID;
                        if (unitOfWork.UlkeKayitlari.IsModified(temp) == true)
                        {
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
        public bool UlkeSil(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.UlkeKayitlari.RemoveData(temp);
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
        public UlkeTumDTO UlkeSatirGetir(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        return new UlkeTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            UlkeAd = temp.UlkeAd,
                            UlkeID = temp.UlkeID,
                            KullaniciID = temp.KullaniciID
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
        public UlkeListeDTO[] UlkeListeAsAsync(UlkeFiltreDTO ul)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<UlkeListeDTO> lst = new List<UlkeListeDTO>();
                    foreach (var item in unitOfWork.UlkeKayitlari.ListDataByExpressionAsync(b => b.AktifMi == ul.AktifMi && b.DilID == ul.DilID && b.SirketID == ul.SirketID && b.SilindiMi == ul.SilindiMi).Result)
                    {
                        lst.Add(new UlkeListeDTO()
                        {
                            UlkeAd = item.UlkeAd,
                            UlkeID = item.UlkeID
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
