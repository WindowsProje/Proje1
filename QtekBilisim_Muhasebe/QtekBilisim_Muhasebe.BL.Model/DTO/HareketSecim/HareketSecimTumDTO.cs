using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.HareketSecim
{
    public class HareketSecimTumDTO:Model
    {
        public int HareketSecimID { get; set; }
        public bool Iade { get; set; }
        public bool Transfer { get; set; }
        public bool Duzeltme { get; set; }
        public bool DevirHareket { get; set; }
    }
}
