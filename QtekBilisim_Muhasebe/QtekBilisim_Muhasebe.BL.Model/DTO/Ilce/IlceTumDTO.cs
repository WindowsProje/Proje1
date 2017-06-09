using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Ilce
{
    public class IlceTumDTO:Model
    {
        public int IlceID { get; set; }
        public int SehirID { get; set; }
        public string IlceAd { get; set; }
    }
}
