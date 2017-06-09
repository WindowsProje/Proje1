using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Sehir
{
    public class SehirListeDTO
    {
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        public override string ToString()
        {
            return this.SehirAd;
        }
    }
}
