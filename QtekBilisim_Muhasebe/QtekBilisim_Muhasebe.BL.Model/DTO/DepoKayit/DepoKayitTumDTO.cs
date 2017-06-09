using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.DepoKayit
{
    public class DepoKayitTumDTO:Model
    {
        public int DepoID { get; set; }
        public int StokID { get; set; }
        public string DepoKod { get; set; }
        public string DepoAd { get; set; }
        public string Yetkili { get; set; }
    }
}
