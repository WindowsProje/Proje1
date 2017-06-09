using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO
{
    public interface IFiltre
    {
        int DilID { get; set; }
        bool AktifMi { get; set; }
        bool SilindiMi { get; set; }
        int SirketID { get; set; }
        int KullaniciID { get; set; }
    }
}
