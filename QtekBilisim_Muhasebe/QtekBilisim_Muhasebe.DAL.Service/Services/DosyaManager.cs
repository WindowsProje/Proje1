using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Dosya;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class DosyaManager
    {
        private readonly string DosyaYol = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public async Task<bool> DosyaEkleAsAsync(DosyaTumDTO dosya)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.DosyaKayitlari.AddData(new Dosya()
                    {
                        AktifMi = dosya.AktifMi,
                        AlanID = dosya.AlanID,
                        AlanTipi = dosya.AlanTipi,
                        DilID = dosya.DilID,
                        DosyaTipi = dosya.DosyaTipi,
                        GuncellemeTarih = dosya.GuncellemeTarih,
                        KayitTarih = dosya.KayitTarih,
                        SilindiMi = dosya.SilindiMi,
                        SirketID = dosya.SirketID,
                        DosyaAd = dosya.DosyaAd
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
            catch (Exception error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
        public async Task<bool> DosyaGuncelleAsAsync(DosyaTumDTO dosya)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.DosyaKayitlari.FindDataAsync(dosya.DosyaID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = dosya.AktifMi;
                        temp.AlanID = dosya.AlanID;
                        temp.AlanTipi = dosya.AlanTipi;
                        temp.DilID = dosya.DilID;
                        temp.DosyaTipi = dosya.DosyaTipi;
                        temp.GuncellemeTarih = dosya.GuncellemeTarih;
                        temp.KayitTarih = dosya.KayitTarih;
                        temp.SilindiMi = dosya.SilindiMi;
                        temp.SirketID = dosya.SirketID;
                        temp.DosyaAd = dosya.DosyaAd;
                        if (unitOfWork.DosyaKayitlari.IsModified(temp) == true)
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
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new Exception(code.Result);
            }
        }
        public async Task<bool> DosyaSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.DosyaKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.DosyaKayitlari.RemoveData(temp);
                        int affect = await unitOfWork.CompleteAsync();
                        if (affect > 0)
                        {
                            File.Delete(DosyaYol + @"\" + temp.DosyaAd);
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
            catch (DirectoryNotFoundException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new DirectoryNotFoundException(code.Result);
            }
            catch (PathTooLongException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new PathTooLongException(code.Result);
            }
            catch(NotSupportedException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new NotSupportedException(code.Result);
            }
            catch (FileNotFoundException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new FileNotFoundException(code.Result);
            }
            catch (IOException error)
            {
                var code = HataKayitManager.HataKayitEkleAsync(error);
                throw new IOException(code.Result);
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
        public async Task<DosyaTumDTO> DosyaSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.DosyaKayitlari.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new DosyaTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            AlanID = temp.AlanID,
                            AlanTipi = temp.AlanTipi,
                            DilID = temp.DilID,
                            DosyaTipi = temp.DosyaTipi,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            DosyaAd = temp.DosyaAd,
                            DosyaID = temp.DosyaID
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
        public DosyaListeDTO[] DosyaListeAsAsync(DosyaFiltreDTO dosya)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<DosyaListeDTO> lst = new List<DosyaListeDTO>();
                    foreach (var item in unitOfWork.DosyaKayitlari.ListDataByExpressionAsync(b => b.AktifMi == dosya.AktifMi && b.DilID == dosya.DilID && b.SirketID == dosya.SirketID && b.SilindiMi == dosya.SilindiMi).Result)
                    {
                        lst.Add(new DosyaListeDTO()
                        {
                            DosyaAd = item.DosyaAd,
                            DosyaID = item.DosyaID,
                            DosyaTipi = item.DosyaTipi
                        });
                    }
                    return lst.ToArray();
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
    }
}
