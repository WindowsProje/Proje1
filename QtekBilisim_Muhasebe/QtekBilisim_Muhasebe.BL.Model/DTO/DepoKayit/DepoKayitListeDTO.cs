using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.DepoKayit
{
    public class DepoKayitListeDTO
    {
        public int DepoID { get; set; }
        public string DepoAd { get; set; }
        public int StokID { get; set; }
        public string DepoKod { get; set; }
    }
}
