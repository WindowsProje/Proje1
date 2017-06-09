using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.StokKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class StokKayitManager
    //{
    //    public async Task<bool> StokKayitEkleAsAsync(StokKayitTumDTO stok)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.StokKayitlari.AddData(new StokKayit()
    //                {
    //                    AktifMi = stok.AktifMi,
    //                    DilID = stok.DilID,
    //                    GuncellemeTarih = stok.GuncellemeTarih,
    //                    KayitTarih = stok.KayitTarih,
    //                    SilindiMi = stok.SilindiMi,
    //                    SirketID = stok.SirketID,
    //                    Aciklama = stok.Aciklama,
    //                    AdetBirimID = stok.AdetBirimID,
    //                    AlisFiyat = stok.AlisFiyat,
    //                    BarkodNumara = stok.BarkodNumara,
    //                    DosyaEvrak = stok.DosyaEvrak,
    //                    Durum = stok.Durum,
    //                    KdvOranAlis = stok.KdvOranAlis,
    //                    KdvOranSatisParekende = stok.KdvOranSatisParekende,
    //                    KdvOranSatisToptan = stok.KdvOranSatisToptan,
    //                    OIV = stok.OIV,
    //                    OTV = stok.OTV,
    //                    OzelKod_1 = stok.OzelKod_1,
    //                    OzelKod_2 = stok.OzelKod_2,
    //                    Resim = stok.Resim,
    //                    SatisFiyat = stok.SatisFiyat,
    //                    StokAd = stok.StokAd,
    //                    StokBakiyeUyariID = stok.StokBakiyeUyariID,
    //                    TedarikciID = stok.TedarikciID,
    //                    TevkifatOran = stok.TevkifatOran
    //                });
    //                int affect = await unitOfWork.CompleteAsync();
    //                if (affect > 0)
    //                {
    //                    return true;
    //                }
    //                else
    //                {
    //                    return false;
    //                }
    //            }
    //        }
    //        catch (DbEntityValidationException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new DbEntityValidationException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (FormatException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new FormatException(code.Result);
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception();
    //        }
    //    }
    //    public async Task<bool> StokKayitGuncelleAsAsync(StokKayitTumDTO stok)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.StokKayitlari.FindDataAsync(stok.StokID).Result;
    //                if (temp != null)
    //                {
    //                    temp.AktifMi = stok.AktifMi;
    //                    temp.DilID = stok.DilID;
    //                    temp.GuncellemeTarih = stok.GuncellemeTarih;
    //                    temp.KayitTarih = stok.KayitTarih;
    //                    temp.SilindiMi = stok.SilindiMi;
    //                    temp.SirketID = stok.SirketID;
    //                    temp.Aciklama = stok.Aciklama;
    //                    temp.AdetBirimID = stok.AdetBirimID;
    //                    temp.AlisFiyat = stok.AlisFiyat;
    //                    temp.BarkodNumara = stok.BarkodNumara;
    //                    temp.DosyaEvrak = stok.DosyaEvrak;
    //                    temp.Durum = stok.Durum;
    //                    temp.KdvOranAlis = stok.KdvOranAlis;
    //                    temp.KdvOranSatisParekende = stok.KdvOranSatisParekende;
    //                    temp.KdvOranSatisToptan = stok.KdvOranSatisToptan;
    //                    temp.OIV = stok.OIV;
    //                    temp.OTV = stok.OTV;
    //                    temp.OzelKod_1 = stok.OzelKod_1;
    //                    temp.OzelKod_2 = stok.OzelKod_2;
    //                    temp.Resim = stok.Resim;
    //                    temp.SatisFiyat = stok.SatisFiyat;
    //                    temp.StokAd = stok.StokAd;
    //                    temp.StokBakiyeUyariID = stok.StokBakiyeUyariID;
    //                    temp.TedarikciID = stok.TedarikciID;
    //                    temp.TevkifatOran = stok.TevkifatOran;
    //                    if (unitOfWork.StokKayitlari.IsModified(temp) == true)
    //                    {
    //                        int affect = await unitOfWork.CompleteAsync();
    //                        if (affect > 0)
    //                        {
    //                            return true;
    //                        }
    //                        else
    //                        {
    //                            return false;
    //                        }
    //                    }
    //                    else
    //                    {
    //                        throw new NotModifiedDataOnDatabaseCustomException();
    //                    }
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (DbEntityValidationException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new DbEntityValidationException(code.Result);
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (FormatException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new FormatException(code.Result);
    //        }
    //        catch (NotModifiedDataOnDatabaseCustomException)
    //        {
    //            throw new NotModifiedDataOnDatabaseCustomException();
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public async Task<bool> StokKayitSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.StokKayitlari.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.StokKayitlari.RemoveData(temp);
    //                    int affect = await unitOfWork.CompleteAsync();
    //                    if (affect > 0)
    //                    {
    //                        return true;
    //                    }
    //                    else
    //                    {
    //                        return false;
    //                    }
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public async Task<StokKayitTumDTO> StokKayitSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.StokKayitlari.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new StokKayitTumDTO()
    //                    {
    //                        AktifMi = temp.AktifMi,
    //                        DilID = temp.DilID,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        KayitTarih = temp.KayitTarih,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        Aciklama = temp.Aciklama,
    //                        AdetBirimID = temp.AdetBirimID,
    //                        AlisFiyat = temp.AlisFiyat,
    //                        BarkodNumara = temp.BarkodNumara,
    //                        DosyaEvrak = temp.DosyaEvrak,
    //                        Durum = temp.Durum,
    //                        KdvOranAlis = temp.KdvOranAlis,
    //                        KdvOranSatisParekende = temp.KdvOranSatisParekende,
    //                        KdvOranSatisToptan = temp.KdvOranSatisToptan,
    //                        OIV = temp.OIV,
    //                        OTV = temp.OTV,
    //                        OzelKod_1 = temp.OzelKod_1,
    //                        OzelKod_2 = temp.OzelKod_2,
    //                        Resim = temp.Resim,
    //                        SatisFiyat = temp.SatisFiyat,
    //                        StokAd = temp.StokAd,
    //                        StokBakiyeUyariID = temp.StokBakiyeUyariID,
    //                        TedarikciID = temp.TedarikciID,
    //                        TevkifatOran = temp.TevkifatOran,
    //                        StokID = temp.StokID
    //                    };
    //                }
    //                else
    //                {
    //                    throw new NullDataOnDatabaseCustomException();
    //                }
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public StokKayitListeDTO[] StokKayitListeleAsAsync(StokKayitFiltreDTO stok)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<StokKayitListeDTO> lst = new List<StokKayitListeDTO>();
    //                foreach (var item in unitOfWork.StokKayitlari.ListDataByExpressionAsync(c => c.AktifMi == stok.AktifMi && c.DilID == stok.DilID && c.SilindiMi == stok.SilindiMi).Result)
    //                {
    //                    lst.Add(new StokKayitListeDTO()
    //                    {
    //                        AdetBirimID = item.AdetBirimID,
    //                        AlisFiyat = (decimal)item.AlisFiyat,
    //                        BarkodNumara = item.BarkodNumara,
    //                        SatisFiyat = (decimal)item.SatisFiyat,
    //                        StokAd = item.StokAd,
    //                        StokID = item.StokID
    //                    });
    //                }
    //                return lst.ToArray();
    //            }
    //        }
    //        catch (ArgumentNullException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new ArgumentNullException(code.Result);
    //        }
    //        catch (NullReferenceException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new NullReferenceException(code.Result);
    //        }
    //        catch (AggregateException error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new AggregateException(code.Result);
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //}
}
