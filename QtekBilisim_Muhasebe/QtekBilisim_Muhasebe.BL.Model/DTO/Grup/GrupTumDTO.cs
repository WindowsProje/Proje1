using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Grup
{
    public class GrupTumDTO:Model
    {
        public int GrupID { get; set; }
        public int AlanID { get; set; }
        public int UstGrupID { get; set; }
        public string AlanTipi { get; set; }
        public string GrupAd { get; set; }
    }
}
