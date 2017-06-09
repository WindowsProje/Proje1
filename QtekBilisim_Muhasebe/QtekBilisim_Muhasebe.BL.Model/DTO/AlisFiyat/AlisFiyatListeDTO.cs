using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.AlisFiyat
{
    public class AlisFiyatListeDTO
    {
        public int AlisFiyatID { get; set; }
        public string FiyatTanim { get; set; }
        public int FiyatNo { get; set; }
        public decimal Fiyat { get; set; }
    }
}
