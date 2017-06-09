using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.FaturaBilgi;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class FaturaBilgiManager
    {
        public async Task<bool> FaturaBilgiEkleAsAsync(FaturaBilgiTumDTO fat)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.FaturaBilgileri.AddData(new FaturaBilgi()
                    {
                        AktifMi = fat.AktifMi,
                        CariBilgiler = fat.CariBilgiler,
                        DilID = fat.DilID,
                        EkBilgiler = fat.EkBilgiler,
                        FaturaNumara = fat.FaturaNumara,
                        FaturaSaat = Convert.ToDateTime(fat.FaturaSaat).TimeOfDay,
                        FaturaTarih = fat.FaturaTarih,
                        Grup = fat.Grup,
                        GuncellemeTarih = fat.GuncellemeTarih,
                        Iskonto = fat.Iskonto,
                        KayitTarih = fat.KayitTarih,
                        KDV = fat.KDV,
                        OzelKod = fat.OzelKod,
                        SilindiMi = fat.SilindiMi,
                        SirketID = fat.SirketID,
                        StokBilgiler = fat.StokBilgiler
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
        public async Task<bool> FaturaBilgiGuncelleAsAsync(FaturaBilgiTumDTO fat)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.FaturaBilgileri.FindDataAsync(fat.FaturaID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = fat.AktifMi;
                        temp.CariBilgiler = fat.CariBilgiler;
                        temp.DilID = fat.DilID;
                        temp.EkBilgiler = fat.EkBilgiler;
                        temp.FaturaNumara = fat.FaturaNumara;
                        temp.FaturaSaat = Convert.ToDateTime(fat.FaturaSaat).TimeOfDay;
                        temp.FaturaTarih = fat.FaturaTarih;
                        temp.Grup = fat.Grup;
                        temp.GuncellemeTarih = fat.GuncellemeTarih;
                        temp.Iskonto = fat.Iskonto;
                        temp.KayitTarih = fat.KayitTarih;
                        temp.KDV = fat.KDV;
                        temp.OzelKod = fat.OzelKod;
                        temp.SilindiMi = fat.SilindiMi;
                        temp.SirketID = fat.SirketID;
                        temp.StokBilgiler = fat.StokBilgiler;
                        if (unitOfWork.FaturaBilgileri.IsModified(temp) == true)
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
        public async Task<bool> FaturaBilgiSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.FaturaBilgileri.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.FaturaBilgileri.RemoveData(temp);
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
        public async Task<FaturaBilgiTumDTO> FaturaBilgiSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.FaturaBilgileri.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new FaturaBilgiTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            CariBilgiler = temp.CariBilgiler,
                            DilID = temp.DilID,
                            EkBilgiler = temp.EkBilgiler,
                            FaturaNumara = temp.FaturaNumara,
                            FaturaSaat = Convert.ToDateTime(temp.FaturaSaat),
                            FaturaTarih = temp.FaturaTarih,
                            Grup = temp.Grup,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            Iskonto = temp.Iskonto,
                            KayitTarih = temp.KayitTarih,
                            KDV = temp.KDV,
                            OzelKod = temp.OzelKod,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            StokBilgiler = temp.StokBilgiler
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
        public FaturaBilgiListeDTO[] FaturaBilgiListeleAsAsync(FaturaBilgiFiltreDTO fat)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<FaturaBilgiListeDTO> lst = new List<FaturaBilgiListeDTO>();
                    foreach (var item in unitOfWork.FaturaBilgileri.ListDataByExpressionAsync(c => c.AktifMi == fat.AktifMi && c.DilID == fat.DilID && c.SirketID == fat.SirketID && c.SilindiMi == fat.SilindiMi).Result)
                    {
                        lst.Add(new FaturaBilgiListeDTO()
                        {
                            FaturaID = item.FaturaID,
                            FaturaNumara = item.FaturaNumara,
                            OzelKod = item.OzelKod
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
