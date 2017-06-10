using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Ilce;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class IlceManager
    {
        public bool IlceEkle(IlceTumDTO ilce)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.IlceKayitlari.AddData(new Ilce()
                    {
                        AktifMi = ilce.AktifMi,
                        DilID = ilce.DilID,
                        GuncellemeTarih = ilce.GuncellemeTarih,
                        IlceAd = ilce.IlceAd,
                        KayitTarih = ilce.KayitTarih,
                        SehirID = ilce.SehirID,
                        SilindiMi = ilce.SilindiMi,
                        SirketID = ilce.SirketID,
                        KullaniciID = ilce.KullaniciID
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
        public bool IlceGuncelle(IlceTumDTO ilce)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.IlceKayitlari.FindData(ilce.IlceID);
                    if (temp != null)
                    {
                        temp.AktifMi = ilce.AktifMi;
                        temp.DilID = ilce.DilID;
                        temp.GuncellemeTarih = ilce.GuncellemeTarih;
                        temp.IlceAd = ilce.IlceAd;
                        temp.SehirID = ilce.SehirID;
                        temp.SirketID = ilce.SirketID;
                        temp.KullaniciID = ilce.KullaniciID;
                        if (unitOfWork.IlceKayitlari.IsModified(temp) == true)
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
        public bool IlceSil(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.IlceKayitlari.FindData(id);
                    if (temp != null)
                    {
                        unitOfWork.IlceKayitlari.RemoveData(temp);
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
        public IlceTumDTO IlceSatirGetir(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.IlceKayitlari.FindData(id);
                    if (temp != null)
                    {
                        return new IlceTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            IlceAd = temp.IlceAd,
                            KayitTarih = temp.KayitTarih,
                            SehirID = temp.SehirID,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            IlceID = temp.IlceID,
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
        public IlceListeDTO[] IlceListe(IlceFiltreDTO ilce)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<IlceListeDTO> lst = new List<IlceListeDTO>();
                    foreach (var item in unitOfWork.IlceKayitlari.ListDataByExpression(b => b.AktifMi == ilce.AktifMi && b.DilID == ilce.DilID && b.SirketID == ilce.SirketID && b.SilindiMi == ilce.SilindiMi && b.SehirID==ilce.SehirID))
                    {
                        lst.Add(new IlceListeDTO()
                        {
                            IlceID = item.IlceID,
                            IlceAd = item.IlceAd
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
