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
    
    public partial class Ulke
    {
        public int UlkeID { get; set; }
        public bool AktifMi { get; set; }
        public bool SilindiMi { get; set; }
        public System.DateTime KayitTarih { get; set; }
        public System.DateTime GuncellemeTarih { get; set; }
        public int DilID { get; set; }
        public int SirketID { get; set; }
        public string UlkeAd { get; set; }
    }
}
