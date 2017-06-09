using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QtekBilisim_Muhasebe.BL.Model.DTO.CariKayit;
using QtekBilisim_Muhasebe.BL.Model.DTO.HataKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using System.Data.Entity.Validation;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class CariKayitManager
    {
        public async Task<bool> CariKayitEkleAsAsync(CariKayitTumDTO cari)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.CariKayitlari.AddData(new CariKayit() {
                        Ad = cari.Ad,
                        Adres = cari.Adres,
                        AktifMi = cari.AktifMi,
                        CariKod = cari.CariKod,
                        CepTelefon = cari.CepTelefon,
                        DilID = cari.DilID,
                        DovizBirimID = cari.DovizBirimID,
                        DovizHesabiVarMi = cari.DovizHesabiVarMi,
                        Faks = cari.Faks,
                        GuncellemeTarih = cari.GuncellemeTarih,
                        IlceID = cari.IlceID,
                        Iskonto = cari.Iskonto,
                        KaraListe = cari.KaraListe,
                        KayitTarih = cari.KayitTarih,
                        KullanilacakStokFiyat = cari.KullanilacakStokFiyat,
                        Not = cari.Not,
                        OzelKod_1 = cari.OzelKod_1,
                        OzelKod_2 = cari.OzelKod_2,
                        OzelKod_3 = cari.OzelKod_3,
                        Resim = cari.Resim,
                        SilindiMi = cari.SilindiMi,
                        SirketID = cari.SirketID,
                        Soyad = cari.Soyad,
                        TC = cari.TC,
                        TicariUnvan = cari.TicariUnvan,
                        Vade = cari.Vade,
                        VergiDaire = cari.VergiDaire,
                        VergiNo = cari.VergiNo,
                        Yetkili = cari.Yetkili
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
        public async Task<bool> CariKayitGuncelleAsAsync(CariKayitTumDTO cari)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.CariKayitlari.FindDataAsync(cari.CariID).Result;
                    if (temp != null)
                    {
                        temp.Ad = cari.Ad;
                        temp.Adres = cari.Adres;
                        temp.AktifMi = cari.AktifMi;
                        temp.CariKod = cari.CariKod;
                        temp.CepTelefon = cari.CepTelefon;
                        temp.DilID = cari.DilID;
                        temp.DovizBirimID = cari.DovizBirimID;
                        temp.DovizHesabiVarMi = cari.DovizHesabiVarMi;
                        temp.Faks = cari.Faks;
                        temp.GuncellemeTarih = cari.GuncellemeTarih;
                        temp.IlceID = cari.IlceID;
                        temp.Iskonto = cari.Iskonto;
                        temp.KaraListe = cari.KaraListe;
                        temp.KayitTarih = cari.KayitTarih;
                        temp.KullanilacakStokFiyat = cari.KullanilacakStokFiyat;
                        temp.Not = cari.Not;
                        temp.OzelKod_1 = cari.OzelKod_1;
                        temp.OzelKod_2 = cari.OzelKod_2;
                        temp.OzelKod_3 = cari.OzelKod_3;
                        temp.Resim = cari.Resim;
                        temp.SilindiMi = cari.SilindiMi;
                        temp.SirketID = cari.SirketID;
                        temp.Soyad = cari.Soyad;
                        temp.TC = cari.TC;
                        temp.TicariUnvan = cari.TicariUnvan;
                        temp.Vade = cari.Vade;
                        temp.VergiDaire = cari.VergiDaire;
                        temp.VergiNo = cari.VergiNo;
                        temp.Yetkili = cari.Yetkili;
                        if (unitOfWork.CariKayitlari.IsModified(temp) == true)
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
        public async Task<bool> CariKayitSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.CariKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.CariKayitlari.RemoveData(temp);
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
        public async Task<CariKayitTumDTO> CariKayitSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.CariKayitlari.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new CariKayitTumDTO()
                        {
                            Ad = temp.Ad,
                            Adres = temp.Adres,
                            AktifMi = temp.AktifMi,
                            CariKod = temp.CariKod,
                            CepTelefon = temp.CepTelefon,
                            DilID = temp.DilID,
                            DovizBirimID = (int)temp.DovizBirimID,
                            DovizHesabiVarMi = temp.DovizHesabiVarMi,
                            Faks = temp.Faks,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            IlceID = temp.IlceID,
                            Iskonto = temp.Iskonto,
                            KaraListe = temp.KaraListe,
                            KayitTarih = temp.KayitTarih,
                            KullanilacakStokFiyat = temp.KullanilacakStokFiyat,
                            Not = temp.Not,
                            OzelKod_1 = temp.OzelKod_1,
                            OzelKod_2 = temp.OzelKod_2,
                            OzelKod_3 = temp.OzelKod_3,
                            Resim = temp.Resim,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            Soyad = temp.Soyad,
                            TC = temp.TC,
                            TicariUnvan = temp.TicariUnvan,
                            Vade = temp.Vade,
                            VergiDaire = temp.VergiDaire,
                            VergiNo = temp.VergiNo,
                            Yetkili = temp.Yetkili,
                            CariID = temp.CariID
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
        public CariKayitOzelDTO[] CariKayitOzelListeleAsAsync(CariKayitFiltreDTO cari)
        {
            try
            {
                List<CariKayitOzelDTO> lst = new List<CariKayitOzelDTO>();
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    foreach (var item in unitOfWork.CariKayitlari.ListDataByExpressionAsync(v => v.AktifMi == cari.AktifMi && v.SilindiMi == cari.SilindiMi && v.SirketID == cari.SirketID && v.DilID
                    == cari.DilID).Result)
                    {
                        lst.Add(new CariKayitOzelDTO()
                        {
                            Ad = item.Ad,
                            CariID = item.CariID,
                            CariKod = item.CariKod,
                            Soyad = item.Soyad,
                            TC = item.TC
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
