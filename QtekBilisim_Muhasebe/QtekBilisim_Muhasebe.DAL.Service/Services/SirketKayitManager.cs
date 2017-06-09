using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.HataKayit;
using QtekBilisim_Muhasebe.BL.Model.DTO.SirketKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class SirketKayitManager
    //{
    //    public bool SirketKayitEkle(SirketKayitTumDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.SirketKayitlari.AddData(new SirketKayit()
    //                {
    //                    Adres = sir.Adres,
    //                    AktifMi = sir.AktifMi,
    //                    CalismaYil = sir.CalismaYil,
    //                    DilID = sir.DilID,
    //                    Faks = sir.Faks,
    //                    GuncellemeTarih = sir.GuncellemeTarih,
    //                    IlceID = sir.IlceID,
    //                    KayitTarih = sir.KayitTarih,
    //                    KurulusTarih = sir.KurulusTarih,
    //                    Muhasebeci = sir.Muhasebeci,
    //                    Not = sir.Not,
    //                    SilindiMi = sir.SilindiMi,
    //                    SirketTurID = sir.SirketTurID,
    //                    Telefon_1 = sir.Telefon_1,
    //                    Telefon_2 = sir.Telefon_2,
    //                    TicariSicilNumara = sir.TicariSicilNumara,
    //                    TicariUnvan = sir.TicariUnvan,
    //                    VergiDaire = sir.VergiDaire,
    //                    VergiDaireKod = sir.VergiDaireKod,
    //                    VergiNumara = sir.VergiNumara,
    //                    Yetkili = sir.Yetkili
    //                });
    //                int affect = unitOfWork.Complete();
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
    //        catch(DbEntityValidationException error)
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
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }

    //    public async Task<bool> SirketKayitEkleAsAsync(SirketKayitTumDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.SirketKayitlari.AddData(new SirketKayit()
    //                {
    //                    Adres = sir.Adres,
    //                    AktifMi = sir.AktifMi,
    //                    CalismaYil = sir.CalismaYil,
    //                    DilID = sir.DilID,
    //                    Faks = sir.Faks,
    //                    GuncellemeTarih = sir.GuncellemeTarih,
    //                    IlceID = sir.IlceID,
    //                    KayitTarih = sir.KayitTarih,
    //                    KurulusTarih = sir.KurulusTarih,
    //                    Muhasebeci = sir.Muhasebeci,
    //                    Not = sir.Not,
    //                    SilindiMi = sir.SilindiMi,
    //                    SirketTurID = sir.SirketTurID,
    //                    Telefon_1 = sir.Telefon_1,
    //                    Telefon_2 = sir.Telefon_2,
    //                    TicariSicilNumara = sir.TicariSicilNumara,
    //                    TicariUnvan = sir.TicariUnvan,
    //                    VergiDaire = sir.VergiDaire,
    //                    VergiDaireKod = sir.VergiDaireKod,
    //                    VergiNumara = sir.VergiNumara,
    //                    Yetkili = sir.Yetkili
    //                });
    //                var affect = await unitOfWork.CompleteAsync();
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
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }

    //    public bool SirketKayitGuncelle(SirketKayitTumDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.SirketKayitlari.FindData(sir.SirketID);
    //                if (temp != null)
    //                {
    //                    temp.Adres = sir.Adres;
    //                    temp.AktifMi = sir.AktifMi;
    //                    temp.CalismaYil = sir.CalismaYil;
    //                    temp.DilID = sir.DilID;
    //                    temp.Faks = sir.Faks;
    //                    temp.GuncellemeTarih = sir.GuncellemeTarih;
    //                    temp.IlceID = sir.IlceID;
    //                    temp.KayitTarih = sir.KayitTarih;
    //                    temp.KurulusTarih = sir.KurulusTarih;
    //                    temp.Muhasebeci = sir.Muhasebeci;
    //                    temp.Not = sir.Not;
    //                    temp.SilindiMi = sir.SilindiMi;
    //                    temp.SirketTurID = sir.SirketTurID;
    //                    temp.Telefon_1 = sir.Telefon_1;
    //                    temp.Telefon_2 = sir.Telefon_2;
    //                    temp.TicariSicilNumara = sir.TicariSicilNumara;
    //                    temp.TicariUnvan = sir.TicariUnvan;
    //                    temp.VergiDaire = sir.VergiDaire;
    //                    temp.VergiDaireKod = sir.VergiDaireKod;
    //                    temp.VergiNumara = sir.VergiNumara;
    //                    temp.Yetkili = sir.Yetkili;
    //                    bool isModified = unitOfWork.SirketKayitlari.IsModified(temp);
    //                    if (isModified == true)
    //                    {
    //                        int affect = unitOfWork.Complete();
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
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (NotModifiedDataOnDatabaseCustomException)
    //        {
    //            throw new NotModifiedDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }

    //    public async Task<bool> SirketKayitGuncelleAsAsync(SirketKayitTumDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                Task<SirketKayit> temp = unitOfWork.SirketKayitlari.FindDataAsync(sir.SirketID);
    //                if (temp.Result != null)
    //                {
    //                    temp.Result.Adres = sir.Adres;
    //                    temp.Result.AktifMi = sir.AktifMi;
    //                    temp.Result.CalismaYil = sir.CalismaYil;
    //                    temp.Result.DilID = sir.DilID;
    //                    temp.Result.Faks = sir.Faks;
    //                    temp.Result.GuncellemeTarih = sir.GuncellemeTarih;
    //                    temp.Result.IlceID = sir.IlceID;
    //                    temp.Result.KayitTarih = sir.KayitTarih;
    //                    temp.Result.KurulusTarih = sir.KurulusTarih;
    //                    temp.Result.Muhasebeci = sir.Muhasebeci;
    //                    temp.Result.Not = sir.Not;
    //                    temp.Result.SilindiMi = sir.SilindiMi;
    //                    temp.Result.SirketTurID = sir.SirketTurID;
    //                    temp.Result.Telefon_1 = sir.Telefon_1;
    //                    temp.Result.Telefon_2 = sir.Telefon_2;
    //                    temp.Result.TicariSicilNumara = sir.TicariSicilNumara;
    //                    temp.Result.TicariUnvan = sir.TicariUnvan;
    //                    temp.Result.VergiDaire = sir.VergiDaire;
    //                    temp.Result.VergiDaireKod = sir.VergiDaireKod;
    //                    temp.Result.VergiNumara = sir.VergiNumara;
    //                    temp.Result.Yetkili = sir.Yetkili;
    //                    bool isModified = unitOfWork.SirketKayitlari.IsModified(temp.Result);
    //                    if (isModified == true)
    //                    {
    //                        var affect = await unitOfWork.CompleteAsync();
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
    //        catch (NullDataOnDatabaseCustomException)
    //        {
    //            throw new NullDataOnDatabaseCustomException();
    //        }
    //        catch (NotModifiedDataOnDatabaseCustomException)
    //        {
    //            throw new NotModifiedDataOnDatabaseCustomException();
    //        }
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }

    //    public SirketKayitListeDTO[] SirketKayitListele()
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<SirketKayitListeDTO> lst = new List<SirketKayitListeDTO>();
    //                foreach (var item in unitOfWork.SirketKayitlari.ListData())
    //                {
    //                    lst.Add(new SirketKayitListeDTO()
    //                    {
    //                        SirketID = item.SirketID,
    //                        TicariUnvan = item.TicariUnvan
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

    //    public SirketKayitListeDTO[] SirketKayitListeleAsAsync()
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<SirketKayitListeDTO> lst = new List<SirketKayitListeDTO>();
    //                foreach (var item in unitOfWork.SirketKayitlari.ListDataAsync().Result)
    //                {
    //                    lst.Add(new SirketKayitListeDTO()
    //                    {
    //                        SirketID = item.SirketID,
    //                        TicariUnvan = item.TicariUnvan
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

    //    public SirketKayitListeDTO[] SirketKayitOzelListele(SirketKayitFiltreDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<SirketKayitListeDTO> lst = new List<SirketKayitListeDTO>();
    //                foreach (var item in unitOfWork.SirketKayitlari.ListDataByExpression(x => x.AktifMi == sir.AktifMi && x.SilindiMi == sir.SilindiMi && x.DilID == sir.DilID))
    //                {
    //                    lst.Add(new SirketKayitListeDTO()
    //                    {
    //                        SirketID = item.SirketID,
    //                        TicariUnvan = item.TicariUnvan
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

    //    public SirketKayitListeDTO[] SirketKayitOzelListeleAsAsync(SirketKayitFiltreDTO sir)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<SirketKayitListeDTO> lst = new List<SirketKayitListeDTO>();
    //                foreach (var item in unitOfWork.SirketKayitlari.ListDataByExpressionAsync(x => x.AktifMi == sir.AktifMi && x.SilindiMi == sir.SilindiMi && x.DilID == sir.DilID).Result)
    //                {
    //                    lst.Add(new SirketKayitListeDTO()
    //                    {
    //                        SirketID = item.SirketID,
    //                        TicariUnvan = item.TicariUnvan
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

    //    public SirketKayitTumDTO SirketKayitSatirGetir(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.SirketKayitlari.FindData(id);
    //                if (temp != null)
    //                {
    //                    return new SirketKayitTumDTO()
    //                    {
    //                        Adres = temp.Adres,
    //                        AktifMi = temp.AktifMi,
    //                        CalismaYil = temp.CalismaYil,
    //                        DilID = temp.DilID,
    //                        Faks = temp.Faks,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        IlceID = temp.IlceID,
    //                        KayitTarih = temp.KayitTarih,
    //                        KurulusTarih = temp.KurulusTarih,
    //                        Muhasebeci = temp.Muhasebeci,
    //                        Not = temp.Not,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        SirketTurID = temp.SirketTurID,
    //                        Telefon_1 = temp.Telefon_1,
    //                        Telefon_2 = temp.Telefon_2,
    //                        TicariSicilNumara = temp.TicariSicilNumara,
    //                        TicariUnvan = temp.TicariUnvan,
    //                        VergiDaire = temp.VergiDaire,
    //                        VergiDaireKod = temp.VergiDaireKod,
    //                        VergiNumara = temp.VergiNumara,
    //                        Yetkili = temp.Yetkili
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

    //    public async Task<SirketKayitTumDTO> SirketKayitSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.SirketKayitlari.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new SirketKayitTumDTO()
    //                    {
    //                        Adres = temp.Adres,
    //                        AktifMi = temp.AktifMi,
    //                        CalismaYil = temp.CalismaYil,
    //                        DilID = temp.DilID,
    //                        Faks = temp.Faks,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        IlceID = temp.IlceID,
    //                        KayitTarih = temp.KayitTarih,
    //                        KurulusTarih = temp.KurulusTarih,
    //                        Muhasebeci = temp.Muhasebeci,
    //                        Not = temp.Not,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID,
    //                        SirketTurID = temp.SirketTurID,
    //                        Telefon_1 = temp.Telefon_1,
    //                        Telefon_2 = temp.Telefon_2,
    //                        TicariSicilNumara = temp.TicariSicilNumara,
    //                        TicariUnvan = temp.TicariUnvan,
    //                        VergiDaire = temp.VergiDaire,
    //                        VergiDaireKod = temp.VergiDaireKod,
    //                        VergiNumara = temp.VergiNumara,
    //                        Yetkili = temp.Yetkili
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

    //    public bool SirketKayitSil(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.SirketKayitlari.FindData(id);
    //                if (temp != null)
    //                {
    //                    unitOfWork.SirketKayitlari.RemoveData(temp);
    //                    int affect = unitOfWork.Complete();
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

    //    public async Task<bool> SirketKayitSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.SirketKayitlari.FindDataAsync(id);
    //                if (temp.Result != null)
    //                {
    //                    unitOfWork.SirketKayitlari.RemoveData(temp.Result);
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
    //}
}
