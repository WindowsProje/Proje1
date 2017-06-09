using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.KasaKayit
{
    public class KasaKayitTumDTO:Model
    {
        public int KasaID { get; set; }
        public string KasaAd { get; set; }
        public string KasaKod { get; set; }
        public string Yetkili { get; set; }
    }
}
