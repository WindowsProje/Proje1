using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.FaturaBilgi
{
    public class FaturaBilgiTumDTO:Model
    {
        public int FaturaID { get; set; }
        public string FaturaNumara { get; set; }
        public Nullable<DateTime> FaturaTarih { get; set; }
        public Nullable<DateTime> FaturaSaat { get; set; }
        public string CariBilgiler { get; set; }
        public string Grup { get; set; }
        public string OzelKod { get; set; }
        public string StokBilgiler { get; set; }
        public string KDV { get; set; }
        public Nullable<int> Iskonto { get; set; }
        public string EkBilgiler { get; set; }
    }
}
