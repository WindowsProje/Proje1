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
            LoadingCity();
        }
        private void LoadingCity()
        {
            SehirManager sm = new SehirManager();
            try
            {
                cmbIl.DataSource = sm.SehirListe(new SehirFiltreDTO()
                {
                    AktifMi = true,
                    DilID = 1,
                    KullaniciID = 0,
                    SilindiMi = false,
                    SirketID = 0,
                    UlkeID = 1
                });
                cmbIl.DisplayMember = "SehirAd";
                cmbIl.ValueMember = "SehirID";
            }
            catch (DbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sm = null;
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
                        DilID = 1,
                        KullaniciID = 0,
                        SilindiMi = false,
                        SirketID = 0,
                        SehirID = temp.SehirID
                    });
                    cmbIlce.DisplayMember = "IlceAd";
                    cmbIlce.ValueMember = "IlceID";
                }
                catch (DbEntityValidationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentNullException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (AggregateException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException error)
                {
                    MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (DbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Test");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Test");
            }
            catch (PathTooLongException)
            {
                MessageBox.Show("Test");
            }
            catch (IOException)
            {
                MessageBox.Show("Test");
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
                
            }
            catch (DbEntityValidationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (AggregateException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
