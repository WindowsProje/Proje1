﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO
{
    public interface IFiltre
    {
        string DilID { get; set; }
        bool AktifMi { get; set; }
        bool SilindiMi { get; set; }
        string SirketID { get; set; }
        string KullaniciID { get; set; }
    }
}
