using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.BorcBakiye
{
    public class BorcBakiyeTumDTO:Model
    {
        public int BorcBakiyeID { get; set; }
        public int CariID { get; set; }
        public decimal Bakiye { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
