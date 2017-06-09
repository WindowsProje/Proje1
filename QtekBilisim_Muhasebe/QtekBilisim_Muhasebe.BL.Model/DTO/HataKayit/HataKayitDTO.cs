using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.HataKayit
{
    public class HataKayitDTO:Model
    {
        public int HataKayitID { get; set; }
        public string ErrorType { get; set; }
        public string HelpLink { get; set; }
        public string InnerException { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string StackTrace { get; set; }
        public string TargetSite { get; set; }
        public Nullable<DateTime> HataTarih { get; set; }
        public Nullable<DateTime> HataZaman { get; set; }
        public string HataKod { get; set; }
    }
}
