﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.CariKayit
{
    public class CariKayitTumDTO:Model
    {
        public int CariID { get; set; }
        public int IlceID { get; set; }
        public int DovizBirimID { get; set; }
        public string CariKod { get; set; }
        public string TicariUnvan { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string CepTelefon { get; set; }
        public string Faks { get; set; }
        public string VergiDaire { get; set; }
        public string VergiNo { get; set; }
        public string TC { get; set; }
        public string OzelKod_1 { get; set; }
        public string OzelKod_2 { get; set; }
        public string OzelKod_3 { get; set; }
        public string Resim { get; set; }
        public Nullable<int> Iskonto { get; set; }
        public Nullable<int> KullanilacakStokFiyat { get; set; }
        public Nullable<int> Vade { get; set; }
        public string KaraListe { get; set; }
        public string Not { get; set; }
        public bool DovizHesabiVarMi { get; set; }
        public string Yetkili { get; set; }
    }
}