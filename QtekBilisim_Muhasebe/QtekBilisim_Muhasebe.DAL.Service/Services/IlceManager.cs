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
                        temp.KayitTarih = ilce.KayitTarih;
                        temp.SehirID = ilce.SehirID;
                        temp.SilindiMi = ilce.SilindiMi;
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
    }
}
