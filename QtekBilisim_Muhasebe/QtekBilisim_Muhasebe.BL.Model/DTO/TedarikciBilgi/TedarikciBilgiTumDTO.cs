using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.TedarikciBilgi
{
    public class TedarikciBilgiTumDTO:Model
    {
        public int TedarikciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Unvan { get; set; }
        public string Departman { get; set; }
        public string Telefon { get; set; }
    }
}
