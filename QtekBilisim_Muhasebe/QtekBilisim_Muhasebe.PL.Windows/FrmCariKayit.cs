using QtekBilisim_Muhasebe.BL.Model.DTO.CariKayit;
using QtekBilisim_Muhasebe.BL.Model.DTO.Exceptions;
using QtekBilisim_Muhasebe.BL.Model.DTO.Grup;
using QtekBilisim_Muhasebe.BL.Model.DTO.Ilce;
using QtekBilisim_Muhasebe.BL.Model.DTO.Sehir;
using QtekBilisim_Muhasebe.DAL.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QtekBilisim_Muhasebe.PL.Windows
{
    public partial class FrmCariKayit : Form
    {
        public FrmCariKayit()
        {
            InitializeComponent();
        }

        private void FrmCariKayit_Load(object sender, EventArgs e)
        {
            Loading();
        }
        private void Loading()
        {
            SehirManager sm = new SehirManager();
            GrupManager gm = new GrupManager();
            try
            {
                cmbIl.DataSource = sm.SehirListe(new SehirFiltreDTO()
                {
                    AktifMi = true,
                    DilID = Properties.Settings.Default.DilID,
                    KullaniciID = Properties.Settings.Default.KullaniciID,
                    SilindiMi = false,
                    SirketID = Properties.Settings.Default.SirketID,
                    UlkeID = "1"
                });
                cmbIl.DisplayMember = "SehirAd";
                cmbIl.ValueMember = "SehirID";

                cmbGrup.DataSource = gm.GrupListe(new GrupFiltreDTO()
                {
                    AktifMi = true,
                    DilID = Properties.Settings.Default.DilID,
                    KullaniciID = Properties.Settings.Default.KullaniciID,
                    SilindiMi = false,
                    SirketID = Properties.Settings.Default.SirketID,
                    UstGrupID = "0",
                    AlanTipi = "Cari"
                });
                cmbGrup.DisplayMember = "GrupAd";
                cmbGrup.ValueMember = "GrupID";
            }
            catch (MyNotImplementedException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyDbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyInvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyAggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyFormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sm = null;
                gm = null;
            }
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIl.SelectedItem != null)
            {
                IlceManager im = new IlceManager();
                try
                {
                    SehirListeDTO temp = (SehirListeDTO)cmbIl.SelectedItem;
                    cmbIlce.DataSource = im.IlceListe(new IlceFiltreDTO()
                    {
                        AktifMi = true,
                        DilID = Properties.Settings.Default.DilID,
                        KullaniciID = Properties.Settings.Default.KullaniciID,
                        SilindiMi = false,
                        SirketID = Properties.Settings.Default.SirketID,
                        SehirID = temp.SehirID.ToString()
                    });
                    cmbIlce.DisplayMember = "IlceAd";
                    cmbIlce.ValueMember = "IlceID";
                }
                catch (MyNotImplementedException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyDbEntityValidationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentNullException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyInvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyNullReferenceException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyAggregateException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyFormatException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullDataOnDatabaseCustomException)
                {
                    throw new NullDataOnDatabaseCustomException();
                }
                catch (NotModifiedDataOnDatabaseCustomException)
                {
                    throw new NotModifiedDataOnDatabaseCustomException();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    im = null;
                }
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = openFileDialog1.ShowDialog();
                if (dia == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog1.FileName);
                    pbxCariResim.Image = img;
                }
            }
            catch (MyNotImplementedException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyDbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyInvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyAggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyFormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(new MyFileNotFoundException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(new MyDirectoryNotFoundException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show(new MyPathTooLongException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            pbxCariResim.Image = Properties.Resources.boss;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            CariKayitManager cm = new CariKayitManager();
            try
            {
                int id = Convert.ToInt32(btnSil.Tag);
                bool result = cm.CariKayitSil(id);
                if (result == true)
                {
                    MessageBox.Show("Silme İşlemi Başarılı Olmuştur", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız Olmuştur", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MyNotImplementedException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyDbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyInvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyAggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyFormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cm = null;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtAciklama.Text = String.Empty;
            txtAd.Text = String.Empty;
            txtAdres.Text = String.Empty;
            txtCariKodu.Text = String.Empty;
            txtIskonto.Text = String.Empty;
            txtNot.Text = String.Empty;
            txtOzelKod_1.Text = String.Empty;
            txtOzelKod_2.Text = String.Empty;
            txtOzelKod_3.Text = String.Empty;
            txtSoyad.Text = String.Empty;
            txtTicariUnvan.Text = String.Empty;
            txtVade.Text = String.Empty;
            txtVergiDairesi.Text = String.Empty;
            txtVergiNumarasi.Text = String.Empty;
            cmbAltGrup.SelectedIndex = -1;
            cmbAraGrup.SelectedIndex = -1;
            cmbDurumu.SelectedIndex = -1;
            cmbGrup.SelectedIndex = -1;
            cmbIl.SelectedIndex = -1;
            cmbIlce.SelectedIndex = -1;
            cmbAltGrup.Text = String.Empty;
            cmbAraGrup.Text = String.Empty;
            cmbGrup.Text = String.Empty;
            cmbIl.Text = String.Empty;
            cmbIlce.Text = String.Empty;
            cmbKullanilacakStokFiyati.SelectedIndex = -1;
            chbDovizHesabiKullan.Checked = false;
            chbKaraListeyeAlinsin.Checked = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CariKayitManager cm = new CariKayitManager();
            try
            {
                string img = String.Empty;
                string cariKod = String.Empty;
                if (openFileDialog1.FileName != String.Empty)
                {
                    Guid guid = Guid.NewGuid();
                    string name = openFileDialog1.SafeFileName;
                    FileInfo info = new FileInfo(openFileDialog1.FileName);
                    string suffix = (guid.ToString()).Replace("-", "");
                    string code = suffix.Substring(0, 5);
                    string folder = Properties.Settings.Default.CariKlasorAdi;
                    string imageFolder = Properties.Settings.Default.ResimKlasorYolu;
                    if (Directory.Exists(imageFolder + @"\" + folder) == false)
                    {
                        Directory.CreateDirectory(imageFolder + @"\" + folder);
                    }
                    if (File.Exists(imageFolder + @"\" + folder + @"\" + name + "_" + code + info.Extension) == false)
                    {
                        File.Create(imageFolder + @"\" + folder + @"\" + name + "_" + code + info.Extension).Close();
                    }
                    img = name + "_" + code + info.Extension;
                }
                if (txtCariKodu.Text == String.Empty)
                {
                    cariKod = cm.EnSonCariKoduGetir();
                }
                bool result = cm.CariKayitEkle(new CariKayitTumDTO() {

                });
                if (result == true)
                {
                    MessageBox.Show("Kayıt İşlemi Başarılı Olmuştur", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız Olmuştur", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(new MyFileNotFoundException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(new MyDirectoryNotFoundException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show(new MyPathTooLongException().Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNotImplementedException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyDbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyInvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyAggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyFormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cm = null;
            }
        }

        private void cmbGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGrup.SelectedItem != null)
            {
                GrupManager gm = new GrupManager();
                try
                {
                    GrupListeDTO temp = (GrupListeDTO)cmbGrup.SelectedItem;
                    cmbAraGrup.DataSource = gm.GrupListe(new GrupFiltreDTO()
                    {
                        AktifMi = true,
                        DilID = Properties.Settings.Default.DilID,
                        KullaniciID = Properties.Settings.Default.KullaniciID,
                        SilindiMi = false,
                        SirketID = Properties.Settings.Default.SirketID,
                        AlanTipi = "Cari",
                        UstGrupID = temp.GrupID.ToString()
                    });
                    cmbAraGrup.DisplayMember = "GrupAd";
                    cmbAraGrup.ValueMember = "GrupID";
                    cmbAltGrup.SelectedIndex = -1;
                }
                catch (MyNotImplementedException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyDbEntityValidationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentNullException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyInvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyNullReferenceException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyAggregateException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyFormatException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullDataOnDatabaseCustomException)
                {
                    throw new NullDataOnDatabaseCustomException();
                }
                catch (NotModifiedDataOnDatabaseCustomException)
                {
                    throw new NotModifiedDataOnDatabaseCustomException();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    gm = null;
                }
            }
        }

        private void cmbAraGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAraGrup.SelectedItem != null)
            {
                GrupManager gm = new GrupManager();
                try
                {
                    GrupListeDTO temp = (GrupListeDTO)cmbAraGrup.SelectedItem;
                    cmbAltGrup.DataSource = gm.GrupListe(new GrupFiltreDTO()
                    {
                        AktifMi = true,
                        DilID = Properties.Settings.Default.DilID,
                        KullaniciID = Properties.Settings.Default.KullaniciID,
                        SilindiMi = false,
                        SirketID = Properties.Settings.Default.SirketID,
                        AlanTipi = "Cari",
                        UstGrupID = temp.GrupID.ToString()
                    });
                    cmbAltGrup.DisplayMember = "GrupAd";
                    cmbAltGrup.ValueMember = "GrupID";
                }
                catch (MyNotImplementedException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyDbEntityValidationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentNullException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyArgumentException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyInvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyNullReferenceException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyAggregateException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (MyFormatException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullDataOnDatabaseCustomException)
                {
                    throw new NullDataOnDatabaseCustomException();
                }
                catch (NotModifiedDataOnDatabaseCustomException)
                {
                    throw new NotModifiedDataOnDatabaseCustomException();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    gm = null;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            CariKayitManager cm = new CariKayitManager();
            try
            {
                Clear();
                txtCariKodu.Text = cm.EnSonCariKoduGetir();
            }
            catch (MyNotImplementedException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyDbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyInvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyNullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyAggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MyFormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullDataOnDatabaseCustomException)
            {
                throw new NullDataOnDatabaseCustomException();
            }
            catch (NotModifiedDataOnDatabaseCustomException)
            {
                throw new NotModifiedDataOnDatabaseCustomException();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cm = null;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
