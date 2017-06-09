using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.BankaHareket
{
    public class BankaHareketTumDTO:Model
    {
        public int BankaHareketID { get; set; }
        public int BankaID { get; set; }
        public string OzelKod { get; set; }
        public string EvrakNo { get; set; }
        public string IslemTur { get; set; }
        public int Vade { get; set; }
        public DateTime IslemTarih { get; set; }
        public DateTime IslemSaat { get; set; }
        public string Aciklama { get; set; }
        public Nullable<decimal> TutarBorc { get; set; }
        public Nullable<decimal> TutarAlacak { get; set; }
    }
}
