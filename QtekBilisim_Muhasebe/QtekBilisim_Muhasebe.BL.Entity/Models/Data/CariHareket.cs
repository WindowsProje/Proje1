//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QtekBilisim_Muhasebe.BL.Entity.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CariHareket
    {
        public int CariHareketID { get; set; }
        public int CariID { get; set; }
        public string OzelKod { get; set; }
        public string EvrakNumara { get; set; }
        public string IslemTur { get; set; }
        public Nullable<System.DateTime> VadeTarih { get; set; }
        public Nullable<System.DateTime> IslemTarih { get; set; }
        public Nullable<System.TimeSpan> IslemSaat { get; set; }
        public Nullable<decimal> BorcTutar { get; set; }
        public Nullable<decimal> AlacakTutar { get; set; }
        public string Aciklama { get; set; }
        public string MakbuzNumara { get; set; }
        public bool AktifMi { get; set; }
        public bool SilindiMi { get; set; }
        public System.DateTime KayitTarih { get; set; }
        public System.DateTime GuncellemeTarih { get; set; }
        public int DilID { get; set; }
        public int SirketID { get; set; }
        public int KullaniciID { get; set; }
    }
}
