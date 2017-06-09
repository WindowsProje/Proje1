using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.KasaKayit;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class KasaKayitManager
    {
        public async Task<bool> KasaKayitEkleAsAsync(KasaKayitTumDTO kas)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.KasaKayitlari.AddData(new KasaKayit()
                    {
                        AktifMi = kas.AktifMi,
                        KasaAd = kas.KasaAd,
                        DilID = kas.DilID,
                        GuncellemeTarih = kas.GuncellemeTarih,
                        KasaKod = kas.KasaKod,
                        Yetkili = kas.Yetkili,
                        KayitTarih = kas.KayitTarih,
                        SilindiMi = kas.SilindiMi,
                        SirketID = kas.SirketID
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
        public async Task<bool> KasaKayitGuncelleAsAsync(KasaKayitTumDTO kas)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.KasaKayitlari.FindDataAsync(kas.KasaID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = kas.AktifMi;
                        temp.KasaAd = kas.KasaAd;
                        temp.DilID = kas.DilID;
                        temp.GuncellemeTarih = kas.GuncellemeTarih;
                        temp.KasaKod = kas.KasaKod;
                        temp.Yetkili = kas.Yetkili;
                        temp.KayitTarih = kas.KayitTarih;
                        temp.SilindiMi = kas.SilindiMi;
                        temp.SirketID = kas.SirketID;
                        if (unitOfWork.KasaKayitlari.IsModified(temp) == true)
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
        public async Task<bool> KasaKayitSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.KasaKayitlari.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.KasaKayitlari.RemoveData(temp);
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
        public async Task<KasaKayitTumDTO> KasaKayitSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.KasaKayitlari.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new KasaKayitTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            KasaAd = temp.KasaAd,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            KasaKod = temp.KasaKod,
                            Yetkili = temp.Yetkili,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            KasaID = temp.KasaID
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
        public KasaKayitListeDTO[] KasaKayitListeleAsAsync(KasaKayitFiltreDTO kas)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<KasaKayitListeDTO> lst = new List<KasaKayitListeDTO>();
                    foreach (var item in unitOfWork.KasaKayitlari.ListDataByExpressionAsync(c => c.AktifMi == kas.AktifMi && c.DilID == kas.DilID && c.SirketID == kas.SirketID && c.SilindiMi == kas.SilindiMi).Result)
                    {
                        lst.Add(new KasaKayitListeDTO()
                        {
                            KasaAd = item.KasaAd,
                            KasaID = item.KasaID,
                            KasaKod = item.KasaKod
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
