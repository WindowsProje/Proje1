using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO
{
    public interface IModel
    {
        bool AktifMi { get; set; }
        bool SilindiMi { get; set; }
        DateTime KayitTarih { get; set; }
        DateTime GuncellemeTarih { get; set; }
        int DilID { get; set; }
        int SirketID { get; set; }
    }
}
