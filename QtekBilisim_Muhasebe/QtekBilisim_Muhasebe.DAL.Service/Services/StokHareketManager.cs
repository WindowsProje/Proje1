using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.StokHareket;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class StokHareketManager
    {
        public async Task<bool> StokHareketEkleAsAsync(StokHareketTumDTO stok)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.StokHareketleri.AddData(new StokHareket()
                    {
                        AktifMi = stok.AktifMi,
                        DilID = stok.DilID,
                        GuncellemeTarih = stok.GuncellemeTarih,
                        KayitTarih = stok.KayitTarih,
                        SilindiMi = stok.SilindiMi,
                        SirketID = stok.SirketID,
                        Aciklama = stok.Aciklama,
                        EvrakNumara = stok.EvrakNumara,
                        IslemSaat = Convert.ToDateTime(stok.IslemSaat).TimeOfDay,
                        IslemTarih = stok.IslemTarih,
                        IslemTur = stok.IslemTur,
                        Miktar = stok.Miktar,
                        OzelKod = stok.OzelKod,
                        HareketSecimID = stok.HareketSecimID,
                        StokID = stok.StokID
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
        public async Task<bool> StokHareketGuncelleAsAsync(StokHareketTumDTO stok)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.StokHareketleri.FindDataAsync(stok.StokHareketID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = stok.AktifMi;
                        temp.DilID = stok.DilID;
                        temp.GuncellemeTarih = stok.GuncellemeTarih;
                        temp.KayitTarih = stok.KayitTarih;
                        temp.SilindiMi = stok.SilindiMi;
                        temp.SirketID = stok.SirketID;
                        temp.Aciklama = stok.Aciklama;
                        temp.EvrakNumara = stok.EvrakNumara;
                        temp.IslemSaat = Convert.ToDateTime(stok.IslemSaat).TimeOfDay;
                        temp.IslemTarih = stok.IslemTarih;
                        temp.IslemTur = stok.IslemTur;
                        temp.Miktar = stok.Miktar;
                        temp.OzelKod = stok.OzelKod;
                        temp.HareketSecimID = stok.HareketSecimID;
                        temp.StokID = stok.StokID;
                        if (unitOfWork.StokHareketleri.IsModified(temp) == true)
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
        public async Task<bool> StokHareketSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.StokHareketleri.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.StokHareketleri.RemoveData(temp);
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
        public async Task<StokHareketTumDTO> StokHareketSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.StokHareketleri.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new StokHareketTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            Aciklama = temp.Aciklama,
                            EvrakNumara = temp.EvrakNumara,
                            IslemSaat = Convert.ToDateTime(temp.IslemSaat),
                            IslemTarih = temp.IslemTarih,
                            IslemTur = temp.IslemTur,
                            Miktar = temp.Miktar,
                            OzelKod = temp.OzelKod,
                            HareketSecimID = temp.HareketSecimID,
                            StokID = temp.StokID,
                            StokHareketID = temp.StokHareketID
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
        public StokHareketListeDTO[] StokHareketListeleAsAsync(StokHareketFiltreDTO stok)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<StokHareketListeDTO> lst = new List<StokHareketListeDTO>();
                    foreach (var item in unitOfWork.StokHareketleri.ListDataByExpressionAsync(c => c.AktifMi == stok.AktifMi && c.DilID == stok.DilID && c.SilindiMi == stok.SilindiMi).Result)
                    {
                        lst.Add(new StokHareketListeDTO()
                        {
                            EvrakNumara = item.EvrakNumara,
                            IslemTur = item.IslemTur,
                            OzelKod = item.OzelKod,
                            StokHareketID = item.StokHareketID,
                            StokID = item.StokID
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
