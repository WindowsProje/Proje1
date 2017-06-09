using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.YetkiDetay
{
    public class YetkiDetayTumDTO:Model
    {
        public int YetkiDetayID { get; set; }
        public int KullaniciID { get; set; }
        public int YetkiID { get; set; }
        public int YetkiAlanID { get; set; }
    }
}
