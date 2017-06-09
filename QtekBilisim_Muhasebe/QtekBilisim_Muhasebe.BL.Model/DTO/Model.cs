using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QtekBilisim_Muhasebe.BL.Model.DTO
{
    public class Model : IModel
    {
        private bool _aktifMi;
        private int _dilID;
        private DateTime _guncellemeTarih;
        private DateTime _kayitTarihi;
        private bool _silindiMi;
        private int _sirketID;
        
        public bool AktifMi
        {
            get
            {
                return _aktifMi;
            }

            set
            {
                _aktifMi = value;
            }
        }
        public int DilID
        {
            get
            {
                return _dilID;
            }

            set
            {
                _dilID = value;
            }
        }
        public DateTime GuncellemeTarih
        {
            get
            {
                return _guncellemeTarih;
            }

            set
            {
                _guncellemeTarih = value;
            }
        }
        public DateTime KayitTarih
        {
            get
            {
                return _kayitTarihi;
            }

            set
            {
                _kayitTarihi = value;
            }
        }
        public bool SilindiMi
        {
            get
            {
                return _silindiMi;
            }

            set
            {
                _silindiMi = value;
            }
        }
        public int SirketID
        {
            get
            {
                return _sirketID;
            }

            set
            {
                _sirketID = value;
            }
        }
    }
}
