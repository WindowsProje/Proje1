using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.KasaHareket
{
    public class KasaHareketListeDTO
    {
        public int KasaHareketID { get; set; }
        public int CariID { get; set; }
        public string HareketKod { get; set; }
        public string EvrakNumara { get; set; }
    }
}
