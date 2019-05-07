using BengkelAtma.Menu;

namespace BengkelAtma
{
    partial class MainMenu
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.pbProfil = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.TabMenu = new MetroFramework.Controls.MetroTabControl();
            this.AkunCabangTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.akun2 = new BengkelAtma.Menu.Akun();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.submenuPegawai1 = new BengkelAtma.Menu.submenuPegawai();
            this.Cabang = new MetroFramework.Controls.MetroTabPage();
            this.cabang2 = new BengkelAtma.Menu.Cabang();
            this.Sparepart = new MetroFramework.Controls.MetroTabPage();
            this.sparepart1 = new BengkelAtma.Menu.Sparepart();
            this.Sales = new MetroFramework.Controls.MetroTabPage();
            this.sales1 = new BengkelAtma.Menu.Sales();
            this.Jasa = new MetroFramework.Controls.MetroTabPage();
            this.menuJasa1 = new BengkelAtma.Menu.menuJasa();
            this.Surat = new MetroFramework.Controls.MetroTabPage();
            this.Laporan = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.Pembayaran = new MetroFramework.Controls.MetroTabPage();
            this.Nota = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.jasaReport1 = new BengkelAtma.Laporan.JasaReport();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.AkunCabangTab.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.Cabang.SuspendLayout();
            this.Sparepart.SuspendLayout();
            this.Sales.SuspendLayout();
            this.Jasa.SuspendLayout();
            this.Laporan.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.leftPanel.Controls.Add(this.btnKeluar);
            this.leftPanel.Controls.Add(this.btnProfil);
            this.leftPanel.Controls.Add(this.btnHome);
            this.leftPanel.Controls.Add(this.lbUser);
            this.leftPanel.Controls.Add(this.pbProfil);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 47);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 494);
            this.leftPanel.TabIndex = 0;
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.Transparent;
            this.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKeluar.Image = global::BengkelAtma.Properties.Resources.checkered_flag;
            this.btnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKeluar.Location = new System.Drawing.Point(0, 289);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(172, 39);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfil.Image = global::BengkelAtma.Properties.Resources.client_user;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(3, 178);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(172, 39);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            this.btnProfil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProfil_MouseClick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Image = global::BengkelAtma.Properties.Resources.positioning;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 133);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(172, 39);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Beranda";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(81, 83);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(33, 15);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "User";
            // 
            // pbProfil
            // 
            this.pbProfil.BackgroundImage = global::BengkelAtma.Properties.Resources.logo;
            this.pbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbProfil.Location = new System.Drawing.Point(39, 12);
            this.pbProfil.Name = "pbProfil";
            this.pbProfil.Size = new System.Drawing.Size(114, 63);
            this.pbProfil.TabIndex = 0;
            this.pbProfil.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 538);
            this.panel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.TabMenu);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(808, 538);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.AkunCabangTab);
            this.TabMenu.Controls.Add(this.Cabang);
            this.TabMenu.Controls.Add(this.Sparepart);
            this.TabMenu.Controls.Add(this.Sales);
            this.TabMenu.Controls.Add(this.Jasa);
            this.TabMenu.Controls.Add(this.Laporan);
            this.TabMenu.Controls.Add(this.Surat);
            this.TabMenu.Controls.Add(this.Pembayaran);
            this.TabMenu.Controls.Add(this.Nota);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 6;
            this.TabMenu.Size = new System.Drawing.Size(808, 538);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.UseSelectable = true;
            // 
            // AkunCabangTab
            // 
            this.AkunCabangTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AkunCabangTab.Controls.Add(this.metroTabControl1);
            this.AkunCabangTab.HorizontalScrollbarBarColor = true;
            this.AkunCabangTab.HorizontalScrollbarHighlightOnWheel = false;
            this.AkunCabangTab.HorizontalScrollbarSize = 10;
            this.AkunCabangTab.Location = new System.Drawing.Point(4, 35);
            this.AkunCabangTab.Name = "AkunCabangTab";
            this.AkunCabangTab.Size = new System.Drawing.Size(800, 499);
            this.AkunCabangTab.TabIndex = 0;
            this.AkunCabangTab.Text = "Akun && Pegawai";
            this.AkunCabangTab.VerticalScrollbarBarColor = true;
            this.AkunCabangTab.VerticalScrollbarHighlightOnWheel = false;
            this.AkunCabangTab.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.metroTabControl1.ItemSize = new System.Drawing.Size(54, 25);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 499);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.akun2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 463);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Akun";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // akun2
            // 
            this.akun2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akun2.Location = new System.Drawing.Point(0, 0);
            this.akun2.Margin = new System.Windows.Forms.Padding(4);
            this.akun2.Name = "akun2";
            this.akun2.Size = new System.Drawing.Size(792, 463);
            this.akun2.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.submenuPegawai1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 466);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Pegawai";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // submenuPegawai1
            // 
            this.submenuPegawai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submenuPegawai1.Location = new System.Drawing.Point(0, 0);
            this.submenuPegawai1.Margin = new System.Windows.Forms.Padding(4);
            this.submenuPegawai1.Name = "submenuPegawai1";
            this.submenuPegawai1.Size = new System.Drawing.Size(792, 466);
            this.submenuPegawai1.TabIndex = 2;
            // 
            // Cabang
            // 
            this.Cabang.Controls.Add(this.cabang2);
            this.Cabang.HorizontalScrollbarBarColor = true;
            this.Cabang.HorizontalScrollbarHighlightOnWheel = false;
            this.Cabang.HorizontalScrollbarSize = 10;
            this.Cabang.Location = new System.Drawing.Point(4, 35);
            this.Cabang.Name = "Cabang";
            this.Cabang.Size = new System.Drawing.Size(800, 499);
            this.Cabang.TabIndex = 2;
            this.Cabang.Text = "Cabang";
            this.Cabang.VerticalScrollbarBarColor = true;
            this.Cabang.VerticalScrollbarHighlightOnWheel = false;
            this.Cabang.VerticalScrollbarSize = 10;
            // 
            // cabang2
            // 
            this.cabang2.BackColor = System.Drawing.SystemColors.Window;
            this.cabang2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cabang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabang2.Location = new System.Drawing.Point(0, 0);
            this.cabang2.Margin = new System.Windows.Forms.Padding(2);
            this.cabang2.Name = "cabang2";
            this.cabang2.Size = new System.Drawing.Size(800, 499);
            this.cabang2.TabIndex = 2;
            // 
            // Sparepart
            // 
            this.Sparepart.BackColor = System.Drawing.Color.White;
            this.Sparepart.Controls.Add(this.sparepart1);
            this.Sparepart.HorizontalScrollbarBarColor = true;
            this.Sparepart.HorizontalScrollbarHighlightOnWheel = false;
            this.Sparepart.HorizontalScrollbarSize = 10;
            this.Sparepart.Location = new System.Drawing.Point(4, 35);
            this.Sparepart.Name = "Sparepart";
            this.Sparepart.Size = new System.Drawing.Size(800, 499);
            this.Sparepart.TabIndex = 8;
            this.Sparepart.Text = "Sparepart";
            this.Sparepart.VerticalScrollbarBarColor = true;
            this.Sparepart.VerticalScrollbarHighlightOnWheel = false;
            this.Sparepart.VerticalScrollbarSize = 10;
            // 
            // sparepart1
            // 
            this.sparepart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sparepart1.Location = new System.Drawing.Point(0, 0);
            this.sparepart1.Margin = new System.Windows.Forms.Padding(2);
            this.sparepart1.Name = "sparepart1";
            this.sparepart1.Size = new System.Drawing.Size(800, 499);
            this.sparepart1.TabIndex = 2;
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.sales1);
            this.Sales.HorizontalScrollbarBarColor = true;
            this.Sales.HorizontalScrollbarHighlightOnWheel = false;
            this.Sales.HorizontalScrollbarSize = 10;
            this.Sales.Location = new System.Drawing.Point(4, 35);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(800, 499);
            this.Sales.TabIndex = 6;
            this.Sales.Text = "Sales";
            this.Sales.VerticalScrollbarBarColor = true;
            this.Sales.VerticalScrollbarHighlightOnWheel = false;
            this.Sales.VerticalScrollbarSize = 10;
            // 
            // sales1
            // 
            this.sales1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales1.Location = new System.Drawing.Point(0, 0);
            this.sales1.Name = "sales1";
            this.sales1.Size = new System.Drawing.Size(800, 499);
            this.sales1.TabIndex = 2;
            // 
            // Jasa
            // 
            this.Jasa.Controls.Add(this.menuJasa1);
            this.Jasa.HorizontalScrollbarBarColor = true;
            this.Jasa.HorizontalScrollbarHighlightOnWheel = false;
            this.Jasa.HorizontalScrollbarSize = 10;
            this.Jasa.Location = new System.Drawing.Point(4, 35);
            this.Jasa.Name = "Jasa";
            this.Jasa.Size = new System.Drawing.Size(800, 499);
            this.Jasa.TabIndex = 3;
            this.Jasa.Text = "Jasa";
            this.Jasa.VerticalScrollbarBarColor = true;
            this.Jasa.VerticalScrollbarHighlightOnWheel = false;
            this.Jasa.VerticalScrollbarSize = 10;
            // 
            // menuJasa1
            // 
            this.menuJasa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuJasa1.Location = new System.Drawing.Point(0, 0);
            this.menuJasa1.Margin = new System.Windows.Forms.Padding(4);
            this.menuJasa1.Name = "menuJasa1";
            this.menuJasa1.Size = new System.Drawing.Size(800, 499);
            this.menuJasa1.TabIndex = 2;
            // 
            // Surat
            // 
            this.Surat.HorizontalScrollbarBarColor = true;
            this.Surat.HorizontalScrollbarHighlightOnWheel = false;
            this.Surat.HorizontalScrollbarSize = 10;
            this.Surat.Location = new System.Drawing.Point(4, 35);
            this.Surat.Name = "Surat";
            this.Surat.Size = new System.Drawing.Size(800, 499);
            this.Surat.TabIndex = 5;
            this.Surat.Text = "Surat";
            this.Surat.VerticalScrollbarBarColor = true;
            this.Surat.VerticalScrollbarHighlightOnWheel = false;
            this.Surat.VerticalScrollbarSize = 10;
            // 
            // Laporan
            // 
            this.Laporan.Controls.Add(this.metroTabControl2);
            this.Laporan.HorizontalScrollbarBarColor = true;
            this.Laporan.HorizontalScrollbarHighlightOnWheel = false;
            this.Laporan.HorizontalScrollbarSize = 10;
            this.Laporan.Location = new System.Drawing.Point(4, 38);
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(800, 496);
            this.Laporan.TabIndex = 4;
            this.Laporan.Text = "Laporan";
            this.Laporan.VerticalScrollbarBarColor = true;
            this.Laporan.VerticalScrollbarHighlightOnWheel = false;
            this.Laporan.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage8);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Controls.Add(this.metroTabPage5);
            this.metroTabControl2.Controls.Add(this.metroTabPage6);
            this.metroTabControl2.Controls.Add(this.metroTabPage7);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(800, 496);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.jasaReport1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(792, 454);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "Penjualan Jasa";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(792, 457);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "Sparepart Terlaris";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(792, 457);
            this.metroTabPage5.TabIndex = 2;
            this.metroTabPage5.Text = "Grafik Sisa Stock";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(792, 457);
            this.metroTabPage6.TabIndex = 3;
            this.metroTabPage6.Text = "Pendapatan Bulanan";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(792, 457);
            this.metroTabPage7.TabIndex = 4;
            this.metroTabPage7.Text = "Pendapatan Tahunan";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(792, 454);
            this.metroTabPage8.TabIndex = 5;
            this.metroTabPage8.Text = "Pengeluaran Bulanan";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // Pembayaran
            // 
            this.Pembayaran.HorizontalScrollbarBarColor = true;
            this.Pembayaran.HorizontalScrollbarHighlightOnWheel = false;
            this.Pembayaran.HorizontalScrollbarSize = 10;
            this.Pembayaran.Location = new System.Drawing.Point(4, 35);
            this.Pembayaran.Name = "Pembayaran";
            this.Pembayaran.Size = new System.Drawing.Size(800, 499);
            this.Pembayaran.TabIndex = 1;
            this.Pembayaran.Text = "Pembayaran";
            this.Pembayaran.VerticalScrollbarBarColor = true;
            this.Pembayaran.VerticalScrollbarHighlightOnWheel = false;
            this.Pembayaran.VerticalScrollbarSize = 10;
            // 
            // Nota
            // 
            this.Nota.HorizontalScrollbarBarColor = true;
            this.Nota.HorizontalScrollbarHighlightOnWheel = false;
            this.Nota.HorizontalScrollbarSize = 10;
            this.Nota.Location = new System.Drawing.Point(4, 38);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(800, 496);
            this.Nota.TabIndex = 7;
            this.Nota.Text = "Nota";
            this.Nota.VerticalScrollbarBarColor = true;
            this.Nota.VerticalScrollbarHighlightOnWheel = false;
            this.Nota.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 47);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::BengkelAtma.Properties.Resources.btnBlue;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(804, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 30);
            this.panel5.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(39, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(147, 25);
            this.label.TabIndex = 1;
            this.label.Text = "Ayo Pilih Menu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 47);
            this.panel3.TabIndex = 5;
            // 
            // jasaReport1
            // 
            this.jasaReport1.BackColor = System.Drawing.Color.White;
            this.jasaReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jasaReport1.Location = new System.Drawing.Point(0, 0);
            this.jasaReport1.Name = "jasaReport1";
            this.jasaReport1.Size = new System.Drawing.Size(792, 454);
            this.jasaReport1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1024, 580);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.AkunCabangTab.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.Cabang.ResumeLayout(false);
            this.Sparepart.ResumeLayout(false);
            this.Sales.ResumeLayout(false);
            this.Jasa.ResumeLayout(false);
            this.Laporan.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pbProfil;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl TabMenu;
        private MetroFramework.Controls.MetroTabPage AkunCabangTab;
        private MetroFramework.Controls.MetroTabPage Pembayaran;
        private MetroFramework.Controls.MetroTabPage Cabang;
        private MetroFramework.Controls.MetroTabPage Jasa;
        private MetroFramework.Controls.MetroTabPage Laporan;
        private MetroFramework.Controls.MetroTabPage Surat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private submenuPegawai submenuPegawai1;
        private menuJasa menuJasa1;
        private Cabang cabang2;
        private MetroFramework.Controls.MetroTabPage Sales;
        private MetroFramework.Controls.MetroTabPage Nota;
        private Akun akun2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTabPage Sparepart;
        private Sparepart sparepart1;
        private Sales sales1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private Laporan.JasaReport jasaReport1;
    }
}