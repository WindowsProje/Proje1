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
        private string _dilID;
        private DateTime _guncellemeTarih;
        private DateTime _kayitTarihi;
        private string _kullaniciID;
        private bool _silindiMi;
        private string _sirketID;
        
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
        public string DilID
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

        public string KullaniciID
        {
            get
            {
                return _kullaniciID;
            }

            set
            {
                _kullaniciID = value;
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
        public string SirketID
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
