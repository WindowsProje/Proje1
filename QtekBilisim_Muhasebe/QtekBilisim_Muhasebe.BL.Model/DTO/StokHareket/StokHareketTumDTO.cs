using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.StokHareket
{
    public class StokHareketTumDTO:Model
    {
        public int StokHareketID { get; set; }
        public int StokID { get; set; }
        public int HareketSecimID { get; set; }
        public string OzelKod { get; set; }
        public Nullable<DateTime> IslemTarih { get; set; }
        public Nullable<DateTime> IslemSaat { get; set; }
        public string EvrakNumara { get; set; }
        public Nullable<int> Miktar { get; set; }
        public string IslemTur { get; set; }
        public string Aciklama { get; set; }
    }
}
