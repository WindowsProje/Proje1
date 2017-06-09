using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.StokHareket
{
    public class StokHareketListeDTO
    {
        public int StokHareketID { get; set; }
        public int StokID { get; set; }
        public string EvrakNumara { get; set; }
        public string OzelKod { get; set; }
        public string IslemTur { get; set; }
    }
}
