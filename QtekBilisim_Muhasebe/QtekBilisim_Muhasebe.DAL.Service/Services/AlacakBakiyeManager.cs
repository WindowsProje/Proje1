using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.AlacakBakiye;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    public class AlacakBakiyeManager
    {
        public async Task<bool> AlacakBakiyeEkleAsAsync(AlacakBakiyeTumDTO al)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    unitOfWork.AlacakBakiyeleri.AddData(new AlacakBakiye()
                    {
                        AktifMi = al.AktifMi,
                        Bakiye = al.Bakiye,
                        CariID = al.CariID,
                        DilID = al.DilID,
                        GuncellemeTarih = al.GuncellemeTarih,
                        IslemTarih = al.IslemTarih,
                        KayitTarih = al.KayitTarih,
                        SilindiMi = al.SilindiMi,
                        SirketID = al.SirketID
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
        public async Task<bool> AlacakBakiyeGuncelleAsAsync(AlacakBakiyeTumDTO al)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.AlacakBakiyeleri.FindDataAsync(al.AlacakBakiyeID).Result;
                    if (temp != null)
                    {
                        temp.AktifMi = al.AktifMi;
                        temp.Bakiye = al.Bakiye;
                        temp.CariID = al.CariID;
                        temp.DilID = al.DilID;
                        temp.GuncellemeTarih = al.GuncellemeTarih;
                        temp.IslemTarih = al.IslemTarih;
                        temp.KayitTarih = al.KayitTarih;
                        temp.SilindiMi = al.SilindiMi;
                        temp.SirketID = al.SirketID;
                        if (unitOfWork.AlacakBakiyeleri.IsModified(temp) == true)
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
        public async Task<bool> AlacakBakiyeSilAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = unitOfWork.AlacakBakiyeleri.FindDataAsync(id).Result;
                    if (temp != null)
                    {
                        unitOfWork.AlacakBakiyeleri.RemoveData(temp);
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
        public async Task<AlacakBakiyeTumDTO> AlacakBakiyeSatirGetirAsAsync(int id)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    var temp = await unitOfWork.AlacakBakiyeleri.FindDataAsync(id);
                    if (temp != null)
                    {
                        return new AlacakBakiyeTumDTO()
                        {
                            AktifMi = temp.AktifMi,
                            Bakiye = temp.Bakiye,
                            CariID = temp.CariID,
                            DilID = temp.DilID,
                            GuncellemeTarih = temp.GuncellemeTarih,
                            IslemTarih = temp.IslemTarih,
                            KayitTarih = temp.KayitTarih,
                            SilindiMi = temp.SilindiMi,
                            SirketID = temp.SirketID,
                            AlacakBakiyeID = temp.AlacakBakiyeID
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
        public AlacakBakiyeListeDTO[] AlacakBakiyeListeleAsAsync(AlacakBakiyeFiltreDTO al)
        {
            try
            {
                using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
                {
                    List<AlacakBakiyeListeDTO> lst = new List<AlacakBakiyeListeDTO>();
                    foreach (var item in unitOfWork.AlacakBakiyeleri.ListDataByExpressionAsync(c => c.AktifMi == al.AktifMi && c.DilID == al.DilID && c.SirketID == al.SirketID && c.SilindiMi == al.SilindiMi).Result)
                    {
                        lst.Add(new AlacakBakiyeListeDTO()
                        {
                            AlacakBakiyeID = item.AlacakBakiyeID,
                            CariID = item.CariID
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
