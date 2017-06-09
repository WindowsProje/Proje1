namespace QtekBilisim_Muhasebe.PL.Windows
{
    partial class FrmAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaEkran));
            this.pnlMenuler = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlIslem = new System.Windows.Forms.Panel();
            this.tab = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fİNANSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARİKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARİHAREKETGİRİŞİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOKYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATINALMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sATIŞYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJEYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÜTÇEYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVİSYÖNETİMİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlMenuler.SuspendLayout();
            this.pnlIslem.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuler
            // 
            this.pnlMenuler.Controls.Add(this.tabControl1);
            this.pnlMenuler.Controls.Add(this.menuStrip1);
            this.pnlMenuler.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuler.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuler.Name = "pnlMenuler";
            this.pnlMenuler.Size = new System.Drawing.Size(1247, 158);
            this.pnlMenuler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "CariHareketGirişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cari Kayıt";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(49, 16);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(153, 44);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // pnlIslem
            // 
            this.pnlIslem.Controls.Add(this.tab);
            this.pnlIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIslem.Location = new System.Drawing.Point(0, 158);
            this.pnlIslem.Name = "pnlIslem";
            this.pnlIslem.Size = new System.Drawing.Size(1247, 488);
            this.pnlIslem.TabIndex = 1;
            // 
            // tab
            // 
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1247, 488);
            this.tab.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fİNANSToolStripMenuItem,
            this.sTOKYÖNETİMİToolStripMenuItem,
            this.sATINALMAToolStripMenuItem,
            this.sATIŞYÖNETİMİToolStripMenuItem,
            this.pROJEYÖNETİMİToolStripMenuItem,
            this.bÜTÇEYÖNETİMİToolStripMenuItem,
            this.sERVİSYÖNETİMİToolStripMenuItem,
            this.cRMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fİNANSToolStripMenuItem
            // 
            this.fİNANSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARİToolStripMenuItem});
            this.fİNANSToolStripMenuItem.Name = "fİNANSToolStripMenuItem";
            this.fİNANSToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.fİNANSToolStripMenuItem.Text = "FİNANS";
            // 
            // cARİToolStripMenuItem
            // 
            this.cARİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cARİKAYITToolStripMenuItem,
            this.cARİHAREKETGİRİŞİToolStripMenuItem});
            this.cARİToolStripMenuItem.Name = "cARİToolStripMenuItem";
            this.cARİToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cARİToolStripMenuItem.Text = "CARİ";
            // 
            // cARİKAYITToolStripMenuItem
            // 
            this.cARİKAYITToolStripMenuItem.Name = "cARİKAYITToolStripMenuItem";
            this.cARİKAYITToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cARİKAYITToolStripMenuItem.Text = "CARİ KAYIT";
            // 
            // cARİHAREKETGİRİŞİToolStripMenuItem
            // 
            this.cARİHAREKETGİRİŞİToolStripMenuItem.Name = "cARİHAREKETGİRİŞİToolStripMenuItem";
            this.cARİHAREKETGİRİŞİToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cARİHAREKETGİRİŞİToolStripMenuItem.Text = "CARİ HAREKET GİRİŞİ";
            // 
            // sTOKYÖNETİMİToolStripMenuItem
            // 
            this.sTOKYÖNETİMİToolStripMenuItem.Name = "sTOKYÖNETİMİToolStripMenuItem";
            this.sTOKYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.sTOKYÖNETİMİToolStripMenuItem.Text = "STOK YÖNETİMİ";
            // 
            // sATINALMAToolStripMenuItem
            // 
            this.sATINALMAToolStripMenuItem.Name = "sATINALMAToolStripMenuItem";
            this.sATINALMAToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.sATINALMAToolStripMenuItem.Text = "SATIN ALMA";
            // 
            // sATIŞYÖNETİMİToolStripMenuItem
            // 
            this.sATIŞYÖNETİMİToolStripMenuItem.Name = "sATIŞYÖNETİMİToolStripMenuItem";
            this.sATIŞYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.sATIŞYÖNETİMİToolStripMenuItem.Text = "SATIŞ YÖNETİMİ";
            // 
            // pROJEYÖNETİMİToolStripMenuItem
            // 
            this.pROJEYÖNETİMİToolStripMenuItem.Name = "pROJEYÖNETİMİToolStripMenuItem";
            this.pROJEYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.pROJEYÖNETİMİToolStripMenuItem.Text = "PROJE YÖNETİMİ";
            // 
            // bÜTÇEYÖNETİMİToolStripMenuItem
            // 
            this.bÜTÇEYÖNETİMİToolStripMenuItem.Name = "bÜTÇEYÖNETİMİToolStripMenuItem";
            this.bÜTÇEYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(124, 21);
            this.bÜTÇEYÖNETİMİToolStripMenuItem.Text = "BÜTÇE YÖNETİMİ";
            // 
            // sERVİSYÖNETİMİToolStripMenuItem
            // 
            this.sERVİSYÖNETİMİToolStripMenuItem.Name = "sERVİSYÖNETİMİToolStripMenuItem";
            this.sERVİSYÖNETİMİToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.sERVİSYÖNETİMİToolStripMenuItem.Text = "SERVİS YÖNETİMİ";
            // 
            // cRMToolStripMenuItem
            // 
            this.cRMToolStripMenuItem.Name = "cRMToolStripMenuItem";
            this.cRMToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.cRMToolStripMenuItem.Text = "CRM";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 133);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.bunifuFlatButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1239, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1239, 105);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 646);
            this.Controls.Add(this.pnlIslem);
            this.Controls.Add(this.pnlMenuler);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaEkran";
            this.Text = "FrmAnaEkran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnaEkran_Load);
            this.pnlMenuler.ResumeLayout(false);
            this.pnlMenuler.PerformLayout();
            this.pnlIslem.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuler;
        private System.Windows.Forms.Panel pnlIslem;
        private System.Windows.Forms.TabControl tab;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fİNANSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARİKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARİHAREKETGİRİŞİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTOKYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATINALMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sATIŞYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJEYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÜTÇEYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVİSYÖNETİMİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRMToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}