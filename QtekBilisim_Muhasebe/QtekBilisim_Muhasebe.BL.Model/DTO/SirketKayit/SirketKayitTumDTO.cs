using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.SirketKayit
{
    public class SirketKayitTumDTO:Model
    {
        public string TicariUnvan { get; set; }
        public string Yetkili { get; set; }
        public string VergiDaire { get; set; }
        public string VergiNumara { get; set; }
        public string VergiDaireKod { get; set; }
        public string TicariSicilNumara { get; set; }
        public string Adres { get; set; }
        public int IlceID { get; set; }
        public int CalismaYil { get; set; }
        public DateTime KurulusTarih { get; set; }
        public string Telefon_1 { get; set; }
        public string Telefon_2 { get; set; }
        public string Faks { get; set; }
        public int SirketTurID { get; set; }
        public string Muhasebeci { get; set; }
        public string Not { get; set; }
    }
}
