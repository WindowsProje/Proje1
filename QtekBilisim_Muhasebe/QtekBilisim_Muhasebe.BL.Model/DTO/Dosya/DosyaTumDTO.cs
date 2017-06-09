using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Dosya
{
    public class DosyaTumDTO:Model
    {
        public int DosyaID { get; set; }
        public int AlanID { get; set; }
        public string AlanTipi { get; set; }
        public string DosyaTipi { get; set; }
        public string DosyaAd { get; set; }
    }
}
