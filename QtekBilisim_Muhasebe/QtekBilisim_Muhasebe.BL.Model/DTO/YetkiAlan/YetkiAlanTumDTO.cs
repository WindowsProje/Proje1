using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.YetkiAlan
{
    public class YetkiAlanTumDTO:Model
    {
        public int YetkiAlanID { get; set; }
        public string UstAlan { get; set; }
        public string Alan { get; set; }
        public string AltAlan { get; set; }
    }
}
