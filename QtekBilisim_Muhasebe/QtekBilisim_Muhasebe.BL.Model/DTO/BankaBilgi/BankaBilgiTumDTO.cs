using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.BankaBilgi
{
    public class BankaBilgiTumDTO:Model
    {
        public int BankaBilgiID { get; set; }
        public string BankaAd { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Yetkili { get; set; }
    }
}
