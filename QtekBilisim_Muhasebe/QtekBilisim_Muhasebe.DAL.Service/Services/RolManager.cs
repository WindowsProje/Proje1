using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Rol;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.DAL.Service.Services
{
    //public class RolManager
    //{
    //    public async Task<bool> RolEkleAsAsync(RolTumDTO rol)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                unitOfWork.Roller.AddData(new Rol()
    //                {
    //                    AktifMi = rol.AktifMi,
    //                    DilID = rol.DilID,
    //                    GuncellemeTarih = rol.GuncellemeTarih,
    //                    KayitTarih = rol.KayitTarih,
    //                    RolAd = rol.RolAd,
    //                    SilindiMi = rol.SilindiMi,
    //                    SirketID = rol.SirketID
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
    //    public async Task<bool> RolGuncelleAsAsync(RolTumDTO rol)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.Roller.FindDataAsync(rol.RolID).Result;
    //                if (temp != null)
    //                {
    //                    temp.AktifMi = rol.AktifMi;
    //                    temp.DilID = rol.DilID;
    //                    temp.GuncellemeTarih = rol.GuncellemeTarih;
    //                    temp.KayitTarih = rol.KayitTarih;
    //                    temp.RolAd = rol.RolAd;
    //                    temp.SilindiMi = rol.SilindiMi;
    //                    temp.SirketID = rol.SirketID;
    //                    if (unitOfWork.Roller.IsModified(temp) == true)
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
    //    public async Task<bool> RolSilAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = unitOfWork.Roller.FindDataAsync(id).Result;
    //                if (temp != null)
    //                {
    //                    unitOfWork.Roller.RemoveData(temp);
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
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public async Task<RolTumDTO> RolSatirGetirAsAsync(int id)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                var temp = await unitOfWork.Roller.FindDataAsync(id);
    //                if (temp != null)
    //                {
    //                    return new RolTumDTO()
    //                    {
    //                        AktifMi = temp.AktifMi,
    //                        DilID = temp.DilID,
    //                        GuncellemeTarih = temp.GuncellemeTarih,
    //                        KayitTarih = temp.KayitTarih,
    //                        RolAd = temp.RolAd,
    //                        SilindiMi = temp.SilindiMi,
    //                        SirketID = temp.SirketID
    //                    };
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
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //    public RolListeDTO[] RolListeAsAsync(RolFiltreDTO rol)
    //    {
    //        try
    //        {
    //            using (var unitOfWork = new UnitOfWork(new QtekBilisim_MuhasebeContext()))
    //            {
    //                List<RolListeDTO> lst = new List<RolListeDTO>();
    //                foreach (var item in unitOfWork.Roller.ListDataByExpressionAsync(b => b.AktifMi == rol.AktifMi && b.DilID == rol.DilID && b.SirketID == rol.SirketID && b.SilindiMi == rol.SilindiMi).Result)
    //                {
    //                    lst.Add(new RolListeDTO()
    //                    {
    //                        RolAd = item.RolAd,
    //                        RolID = item.RolID
    //                    });
    //                }
    //                return lst.ToArray();
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
    //        catch (Exception error)
    //        {
    //            var code = HataKayitManager.HataKayitEkleAsync(error);
    //            throw new Exception(code.Result);
    //        }
    //    }
    //}
}
