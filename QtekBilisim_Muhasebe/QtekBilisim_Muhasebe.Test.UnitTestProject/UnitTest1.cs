﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QtekBilisim_Muhasebe.BL.Repository.Repositories;
using QtekBilisim_Muhasebe.BL.Entity.Models.Data;
using System.Linq.Expressions;
using QtekBilisim_Muhasebe.DAL.Service.Services;
using QtekBilisim_Muhasebe.BL.Model.DTO.SirketKayit;
using System.Data.Entity.Validation;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.Test.UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                //throw new DirectoryNotFoundException();
                //SirketKayitManager sk = new SirketKayitManager();
                //sk.SirketKayitEkle(new SirketKayitTumDTO()
                //{
                //    Muhasebeci = "ewrgerw"
                //});
            }
            catch (DirectoryNotFoundException error)
            {
                throw new DirectoryNotFoundException(error.Message);
            }
            catch (IOException error)
            {
                throw new IOException(error.Message);
            }
            catch (ArgumentNullException error)
            {
                string temp = error.GetType().ToString();
                throw new ArgumentNullException(error.Message);
            }
            catch (DbEntityValidationException)
            {
                throw new DbEntityValidationException();
            }
            catch (Exception error)
            {
                string temp = error.GetType().ToString();
                throw new Exception(error.Message);
            }
        }
    }
}
