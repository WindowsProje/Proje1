using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.DovizBirim
{
    public class DovizBirimTumDTO:Model
    {
        public int DovizBirimID { get; set; }
        public string Birim { get; set; }
        public string Simge { get; set; }
    }
}
