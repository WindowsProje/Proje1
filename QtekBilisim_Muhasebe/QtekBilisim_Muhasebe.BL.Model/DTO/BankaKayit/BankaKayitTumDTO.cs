using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.BankaKayit
{
    public class BankaKayitTumDTO:Model
    {
        public int BankaID { get; set; }
        public int BankaBilgiID { get; set; }
        public int KrediKartID { get; set; }
        public int PosID { get; set; }
        public int CekID { get; set; }
        public int SenetID { get; set; }
        public string BankaAd { get; set; }
        public string HesapTur { get; set; }
        public string SubeKod { get; set; }
        public string HesapNumara { get; set; }
        public string IBAN { get; set; }
    }
}
