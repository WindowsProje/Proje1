using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO.StokKayit
{
    public class StokKayitTumDTO : Model
    {
        public int StokID { get; set; }
        public int AdetBirimID { get; set; }
        public int StokBakiyeUyariID { get; set; }
        public int TedarikciID { get; set; }
        public string Durum { get; set; }
        public string StokAd { get; set; }
        public string BarkodNumara { get; set; }
        public string OzelKod_1 { get; set; }
        public string OzelKod_2 { get; set; }
        public string OTV { get; set; }
        public string OIV { get; set; }
        public string Aciklama { get; set; }
        public int KdvOranAlis { get; set; }
        public int KdvOranSatisParekende { get; set; }
        public int KdvOranSatisToptan { get; set; }
        public string TevkifatOran { get; set; }
        public string Resim { get; set; }
        public string DosyaEvrak { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
    }
}
