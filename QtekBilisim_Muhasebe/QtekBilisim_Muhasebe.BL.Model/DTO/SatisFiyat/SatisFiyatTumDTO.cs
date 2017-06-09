﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.SatisFiyat
{
    public class SatisFiyatTumDTO:Model
    {
        public int SatisFiyatID { get; set; }
        public int StokID { get; set; }
        public string FiyatTanim { get; set; }
        public int FiyatNo { get; set; }
        public decimal Fiyat { get; set; }
        public string FiyatAciklama { get; set; }
    }
}
