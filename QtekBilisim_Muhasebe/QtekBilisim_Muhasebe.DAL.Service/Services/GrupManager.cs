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
            catch (NotImplementedException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNotImplementedException();
            }
            catch (DbEntityValidationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyDbEntityValidationException();
            }
            catch (ArgumentNullException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentNullException();
            }
            catch (ArgumentException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentException();
            }
            catch (InvalidOperationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyInvalidOperationException();
            }
            catch (NullReferenceException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNullReferenceException();
            }
            catch (AggregateException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyAggregateException();
            }
            catch (FormatException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyFormatException();
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
                HataKayitManager.HataKayitEkle(error);
                throw new Exception();
            }
        }
        public bool GrupGuncelle(GrupTumDTO grup)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.GrupKayitlari.FindData(grup.GrupID);
                    if (temp != null)
                    {
                        temp.AktifMi = grup.AktifMi;
                        temp.AlanTipi = grup.AlanTipi;
                        temp.DilID = grup.DilID;
                        temp.GrupAd = grup.GrupAd;
                        temp.GuncellemeTarih = grup.GuncellemeTarih;
                        temp.SirketID = grup.SirketID;
                        temp.UstGrupID = grup.UstGrupID;
                        temp.KullaniciID = grup.KullaniciID;
                        if (unitOfWork.GrupKayitlari.IsModified(temp) == true)
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
            catch (NotImplementedException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNotImplementedException();
            }
            catch (DbEntityValidationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyDbEntityValidationException();
            }
            catch (ArgumentNullException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentNullException();
            }
            catch (ArgumentException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentException();
            }
            catch (InvalidOperationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyInvalidOperationException();
            }
            catch (NullReferenceException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNullReferenceException();
            }
            catch (AggregateException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyAggregateException();
            }
            catch (FormatException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyFormatException();
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
                HataKayitManager.HataKayitEkle(error);
                throw new Exception();
            }
        }
        public bool GrupSil(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.GrupKayitlari.FindData(id);
                    if (temp != null)
                    {
                        unitOfWork.GrupKayitlari.RemoveData(temp);
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
            catch (NotImplementedException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNotImplementedException();
            }
            catch (DbEntityValidationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyDbEntityValidationException();
            }
            catch (ArgumentNullException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentNullException();
            }
            catch (ArgumentException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentException();
            }
            catch (InvalidOperationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyInvalidOperationException();
            }
            catch (NullReferenceException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNullReferenceException();
            }
            catch (AggregateException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyAggregateException();
            }
            catch (FormatException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyFormatException();
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
                HataKayitManager.HataKayitEkle(error);
                throw new Exception();
            }
        }
        public GrupTumDTO GrupSatirGetir(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp =  unitOfWork.GrupKayitlari.FindData(id);
                    if (temp != null)
                    {
                        return new GrupTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            AlanTipi = temp.AlanTipi,
                            DilID = temp.DilID,
                            GrupAd = temp.GrupAd,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            UstGrupID = temp.UstGrupID,
                            GrupID = temp.GrupID,
                            KullaniciID = temp.KullaniciID
                        };
                    }
                    else
                    {
                        throw new NullDataOnDatabaseCustomException();
                    }
                }
            }
            catch (NotImplementedException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNotImplementedException();
            }
            catch (DbEntityValidationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyDbEntityValidationException();
            }
            catch (ArgumentNullException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentNullException();
            }
            catch (ArgumentException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentException();
            }
            catch (InvalidOperationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyInvalidOperationException();
            }
            catch (NullReferenceException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNullReferenceException();
            }
            catch (AggregateException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyAggregateException();
            }
            catch (FormatException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyFormatException();
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
                HataKayitManager.HataKayitEkle(error);
                throw new Exception();
            }
        }
        public GrupListeDTO[] GrupListe(GrupFiltreDTO grup)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<GrupListeDTO> lst = new List<GrupListeDTO>();
                    foreach (var item in unitOfWork.GrupKayitlari.ListDataByExpression(b => b.AktifMi == grup.AktifMi && b.DilID == grup.DilID && b.SirketID == grup.SirketID && b.SilindiMi == grup.SilindiMi && b.UstGrupID == grup.UstGrupID))
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
            catch (NotImplementedException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNotImplementedException();
            }
            catch (DbEntityValidationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyDbEntityValidationException();
            }
            catch (ArgumentNullException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentNullException();
            }
            catch (ArgumentException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyArgumentException();
            }
            catch (InvalidOperationException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyInvalidOperationException();
            }
            catch (NullReferenceException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyNullReferenceException();
            }
            catch (AggregateException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyAggregateException();
            }
            catch (FormatException error)
            {
                HataKayitManager.HataKayitEkle(error);
                throw new MyFormatException();
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
                HataKayitManager.HataKayitEkle(error);
                throw new Exception();
            }
        }
    }
}
