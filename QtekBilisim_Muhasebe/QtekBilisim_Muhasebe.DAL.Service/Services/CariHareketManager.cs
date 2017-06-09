using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.CariHareket;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.HataKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class CariHareketManager
    {
        public async Task<bool> CariHareketEkleAsAsync(CariHareketTumDTO cari)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.CariHareketleri.AddData(new CariHareket()
                    {
                        Aciklama = cari.Aciklama,
                        AktifMi = cari.AktifMi,
                        AlacakTutar = cari.AlacakTutar,
                        BorcTutar = cari.BorcTutar,
                        CariID = cari.CariID,
                        DilID = cari.DilID,
                        EvrakNumara = cari.EvrakNumara,
                        GuncellemeTarih = cari.GuncellemeTarih,
                        IslemSaat = Convert.ToDateTime(cari.IslemSaat).TimeOfDay,
                        IslemTarih = cari.IslemTarih,
                        IslemTur = cari.IslemTur,
                        KayitTarih = cari.KayitTarih,
                        MakbuzNumara = cari.MakbuzNumara,
                        OzelKod = cari.OzelKod,
                        SilindiMi = cari.SilindiMi,
                        SirketID = cari.SirketID,
                        VadeTarih = cari.VadeTarih
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
        public async Task<bool> CariHareketGuncelleAsAsync(CariHareketTumDTO cari)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.CariHareketleri.FindDataAsync(cari.CariHareketID).Result;
                    if (temp != null)
                    {
                        temp.Aciklama = cari.Aciklama;
                        temp.AktifMi = cari.AktifMi;
                        temp.AlacakTutar = cari.AlacakTutar;
                        temp.BorcTutar = cari.BorcTutar;
                        temp.CariID = cari.CariID;
                        temp.DilID = cari.DilID;
                        temp.EvrakNumara = cari.EvrakNumara;
                        temp.GuncellemeTarih = cari.GuncellemeTarih;
                        temp.IslemSaat = Convert.ToDateTime(cari.IslemSaat).TimeOfDay;
                        temp.IslemTarih = cari.IslemTarih;
                        temp.IslemTur = cari.IslemTur;
                        temp.MakbuzNumara = cari.MakbuzNumara;
                        temp.OzelKod = cari.OzelKod;
                        temp.SilindiMi = cari.SilindiMi;
                        temp.SirketID = cari.SirketID;
                        temp.VadeTarih = cari.VadeTarih;
                        if (unitOfWork.CariHareketleri.IsModified(temp) == true)
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
        public async Task<bool> CariHareketSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.CariHareketleri.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.CariHareketleri.RemoveData(temp);
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
        public async Task<CariHareketTumDTO> CariHareketSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.CariHareketleri.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new CariHareketTumDTO()
                        {
                            Aciklama = temp.Aciklama,
                            AktifMi = temp.AktifMi,
                            AlacakTutar = temp.AlacakTutar,
                            BorcTutar = temp.BorcTutar,
                            CariHareketID = temp.CariHareketID,
                            CariID = temp.CariID,
                            DilID = temp.DilID,
                            EvrakNumara = temp.EvrakNumara,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            IslemSaat = Convert.ToDateTime(temp.IslemSaat),
                            IslemTarih = temp.IslemTarih,
                            IslemTur = temp.IslemTur,
                            KayitTarih = temp.KayitTarih,
                            MakbuzNumara = temp.MakbuzNumara,
                            OzelKod = temp.OzelKod,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            VadeTarih = temp.VadeTarih
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
        public CariHareketListeDTO[] CariHareketListeleAsAsync(CariHareketFiltreDTO cari)
        {
            try
            {
                using (var unitOfWork=new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<CariHareketListeDTO> lst = new List<CariHareketListeDTO>();
                    foreach (var item in unitOfWork.CariHareketleri.ListDataByExpressionAsync(c => c.AktifMi == cari.AktifMi && c.DilID == cari.DilID && c.SirketID == cari.SirketID && c.SilindiMi == cari.SilindiMi).Result)
                    {
                        lst.Add(new CariHareketListeDTO()
                        {
                            CariHareketID = item.CariHareketID,
                            CariID = item.CariID,
                            EvrakNumara = item.EvrakNumara,
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
