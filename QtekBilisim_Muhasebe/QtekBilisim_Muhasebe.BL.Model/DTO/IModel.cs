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
        string DilID { get; set; }
        string SirketID { get; set; }
        string KullaniciID { get; set; }
    }
}
