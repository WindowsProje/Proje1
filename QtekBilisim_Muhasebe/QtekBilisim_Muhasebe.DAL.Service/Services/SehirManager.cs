using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Sehir;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class SehirManager
    {
        public bool SehirEkle(SehirTumDTO seh)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.SehirKayitlari.AddData(new Sehir()
                    {
                        AktifMi = seh.AktifMi,
                        DilID = seh.DilID,
                        GuncellemeTarih = seh.GuncellemeTarih,
                        KayitTarih = seh.KayitTarih,
                        SehirAd = seh.SehirAd,
                        SilindiMi = seh.SilindiMi,
                        SirketID = seh.SirketID,
                        UlkeID = seh.UlkeID,
                        KullaniciID = seh.KullaniciID
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
        public bool SehirGuncelle(SehirTumDTO Seh)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.SehirKayitlari.FindDataAsync(Seh.SehirID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = Seh.AktifMi;
                        temp.DilID = Seh.DilID;
                        temp.GuncellemeTarih = Seh.GuncellemeTarih;
                        temp.KayitTarih = Seh.KayitTarih;
                        temp.SehirAd = Seh.SehirAd;
                        temp.SilindiMi = Seh.SilindiMi;
                        temp.SirketID = Seh.SirketID;
                        temp.UlkeID = Seh.UlkeID;
                        temp.KullaniciID = Seh.KullaniciID;
                        if (unitOfWork.SehirKayitlari.IsModified(temp) == true)
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
        public bool SehirSil(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.SehirKayitlari.FindData(id);
                    if (temp != null)
                    {
                        unitOfWork.SehirKayitlari.RemoveData(temp);
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
        public SehirTumDTO SehirSatirGetir(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.SehirKayitlari.FindData(id);
                    if (temp != null)
                    {
                        return new SehirTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SehirAd = temp.SehirAd,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
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
        public SehirListeDTO[] SehirListe(SehirFiltreDTO seh)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<SehirListeDTO> lst = new List<SehirListeDTO>();
                    foreach (var item in unitOfWork.SehirKayitlari.ListDataByExpression(b => b.AktifMi == seh.AktifMi && b.DilID == seh.DilID && b.SirketID == seh.SirketID && b.SilindiMi == seh.SilindiMi && b.UlkeID==seh.UlkeID))
                    {
                        lst.Add(new SehirListeDTO()
                        {
                            SehirID = item.SehirID,
                            SehirAd = item.SehirAd
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
