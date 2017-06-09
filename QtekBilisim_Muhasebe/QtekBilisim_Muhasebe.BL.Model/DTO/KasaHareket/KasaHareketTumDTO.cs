using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.KasaHareket
{
    public class KasaHareketTumDTO:Model
    {
        public int KasaHareketID { get; set; }
        public int CariID { get; set; }
        public string HareketKod { get; set; }
        public string EvrakNumara { get; set; }
        public string IslemTur { get; set; }
        public string IslemAciklama { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
