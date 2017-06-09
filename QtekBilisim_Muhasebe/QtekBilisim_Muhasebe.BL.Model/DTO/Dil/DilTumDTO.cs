using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Dil
{
    public class DilTumDTO:Model
    {
        public string DilAd { get; set; }
        public string DilSembol { get; set; }
        public string DilKod { get; set; }
        public string ParaBirim { get; set; }
        public string ParaBirimSembol { get; set; }
    }
}
