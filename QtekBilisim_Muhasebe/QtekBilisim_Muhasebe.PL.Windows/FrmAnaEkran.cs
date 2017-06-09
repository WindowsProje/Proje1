using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QtekBilisim_Muhasebe.PL.Windows
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            //pnlIslem.Controls.Clear();
            //FrmCariKayit frm = new FrmCariKayit();
            //frm.TopLevel = false;
            //pnlIslem.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();

           
            TabPage tabcontrol = new TabPage();

            FrmCariKayit frm = new FrmCariKayit();
            frm.TopLevel = false;
            tabcontrol.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.None;
            frm.BringToFront();
            tab.Controls.Add(tabcontrol);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TabPage tabcontrol = new TabPage();

            FrmCariHarektRaporu frm = new FrmCariHarektRaporu();
            frm.TopLevel = false;
            tabcontrol.Controls.Add(frm);
            frm.Show();
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            tab.Controls.Add(tabcontrol);

        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //pnlIslem.Controls.Clear();
            //FrmCariKayit frm = new FrmCariKayit();
            //frm.TopLevel = false;
            //pnlIslem.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.Fill;
            //frm.BringToFront();


            //TabPage tabcontrol = new TabPage();

            FrmCariKayit frm = new FrmCariKayit();
            frm.Show();
            //frm.TopLevel = false;
            //tabcontrol.Controls.Add(frm);
            //frm.Show();
            //frm.Dock = DockStyle.None;
            //frm.BringToFront();
            //tab.Controls.Add(tabcontrol);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
