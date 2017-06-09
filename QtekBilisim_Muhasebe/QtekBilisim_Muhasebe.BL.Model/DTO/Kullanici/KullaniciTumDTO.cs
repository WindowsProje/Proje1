using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Kullanici
{
    public class KullaniciTumDTO:Model
    {
        public int KullaniciID { get; set; }
        public int RolID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciKod { get; set; }
        public string Bolum { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSifre { get; set; }
        public int VarsayilanSirketID { get; set; }
    }
}
