using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.StokKayit
{
    public class StokKayitListeDTO
    {
        public int StokID { get; set; }
        public int AdetBirimID { get; set; }
        public string StokAd { get; set; }
        public string BarkodNumara { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
    }
}
