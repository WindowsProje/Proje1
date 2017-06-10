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
        public bool UlkeGuncelle(UlkeTumDTO ul)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindData(ul.UlkeID);
                    if (temp != null)
                    {
                        temp.AktifMi = ul.AktifMi;
                        temp.DilID = ul.DilID;
                        temp.GuncellemeTarih = ul.GuncellemeTarih;
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
        public bool UlkeSil(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindData(id);
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
        public UlkeTumDTO UlkeSatirGetir(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.UlkeKayitlari.FindData(id);
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
        public UlkeListeDTO[] UlkeListe(UlkeFiltreDTO ul)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<UlkeListeDTO> lst = new List<UlkeListeDTO>();
                    foreach (var item in unitOfWork.UlkeKayitlari.ListDataByExpression(b => b.AktifMi == ul.AktifMi && b.DilID == ul.DilID && b.SirketID == ul.SirketID && b.SilindiMi == ul.SilindiMi))
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
