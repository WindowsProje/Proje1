using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.AlacakBakiye
{
    public class AlacakBakiyeTumDTO:Model
    {
        public int AlacakBakiyeID { get; set; }
        public int CariID { get; set; }
        public decimal Bakiye { get; set; }
        public DateTime IslemTarih { get; set; }
    }
}
