using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.CariHareket
{
    public class CariHareketTumDTO:Model
    {
        public int CariHareketID { get; set; }
        public int CariID { get; set; }
        public string OzelKod { get; set; }
        public string EvrakNumara { get; set; }
        public string IslemTur { get; set; }
        public Nullable<DateTime> VadeTarih { get; set; }
        public Nullable<DateTime> IslemTarih { get; set; }
        public Nullable<DateTime> IslemSaat { get; set; }
        public Nullable<decimal> BorcTutar { get; set; }
        public Nullable<decimal> AlacakTutar { get; set; }
        public string Aciklama { get; set; }
        public string MakbuzNumara { get; set; }
    }
}
