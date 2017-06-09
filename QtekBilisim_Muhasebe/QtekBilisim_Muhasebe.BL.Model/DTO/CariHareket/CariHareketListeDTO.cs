using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.CariHareket
{
    public class CariHareketListeDTO
    {
        public int CariHareketID { get; set; }
        public int CariID { get; set; }
        public string OzelKod { get; set; }
        public string EvrakNumara { get; set; }
    }
}
