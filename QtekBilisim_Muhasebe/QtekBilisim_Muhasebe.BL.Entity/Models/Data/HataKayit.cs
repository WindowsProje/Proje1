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
    
    public partial class HataKayit
    {
        public int HataKayitID { get; set; }
        public string ErrorType { get; set; }
        public string HelpLink { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string TargetSite { get; set; }
        public string StackTrace { get; set; }
        public Nullable<System.DateTime> HataTarih { get; set; }
        public Nullable<System.TimeSpan> HataZaman { get; set; }
        public string HataKod { get; set; }
        public string InnerException { get; set; }
        public bool SilindiMi { get; set; }
    }
}
