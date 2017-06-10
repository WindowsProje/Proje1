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
        public bool SehirGuncelle(SehirTumDTO Seh)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.SehirKayitlari.FindData(Seh.SehirID);
                    if (temp != null)
                    {
                        temp.AktifMi = Seh.AktifMi;
                        temp.DilID = Seh.DilID;
                        temp.GuncellemeTarih = Seh.GuncellemeTarih;
                        temp.SehirAd = Seh.SehirAd;
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
