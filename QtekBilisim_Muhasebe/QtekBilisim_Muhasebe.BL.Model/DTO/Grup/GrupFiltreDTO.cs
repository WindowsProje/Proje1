using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.Grup
{
    public class GrupFiltreDTO:Filtre
    {
        public string AlanTipi { get; set; }
        public string UstGrupID { get; set; }
    }
}
