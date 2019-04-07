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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Cabang = new MetroFramework.Controls.MetroTabPage();
            this.Jasa = new MetroFramework.Controls.MetroTabPage();
            this.Sales = new MetroFramework.Controls.MetroTabPage();
            this.Pembayaran = new MetroFramework.Controls.MetroTabPage();
            this.Surat = new MetroFramework.Controls.MetroTabPage();
            this.Nota = new MetroFramework.Controls.MetroTabPage();
            this.Laporan = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.akun2 = new BengkelAtma.Menu.Akun();
            this.submenuPegawai1 = new BengkelAtma.Menu.submenuPegawai();
            this.cabang2 = new BengkelAtma.Menu.Cabang();
            this.menuJasa1 = new BengkelAtma.Menu.menuJasa();
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
            this.Jasa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 541);
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
            this.pbProfil.BackgroundImage = global::BengkelAtma.Properties.Resources.user;
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
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
            this.metroPanel1.Location = new System.Drawing.Point(0, 42);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(808, 496);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.AkunCabangTab);
            this.TabMenu.Controls.Add(this.Cabang);
            this.TabMenu.Controls.Add(this.Jasa);
            this.TabMenu.Controls.Add(this.Sales);
            this.TabMenu.Controls.Add(this.Pembayaran);
            this.TabMenu.Controls.Add(this.Surat);
            this.TabMenu.Controls.Add(this.Nota);
            this.TabMenu.Controls.Add(this.Laporan);
            this.TabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabMenu.Location = new System.Drawing.Point(0, 0);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 1;
            this.TabMenu.Size = new System.Drawing.Size(808, 496);
            this.TabMenu.TabIndex = 0;
            // 
            // AkunCabangTab
            // 
            this.AkunCabangTab.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AkunCabangTab.Controls.Add(this.metroTabControl1);
            this.AkunCabangTab.HorizontalScrollbarBarColor = true;
            this.AkunCabangTab.Location = new System.Drawing.Point(4, 35);
            this.AkunCabangTab.Name = "AkunCabangTab";
            this.AkunCabangTab.Size = new System.Drawing.Size(800, 457);
            this.AkunCabangTab.TabIndex = 0;
            this.AkunCabangTab.Text = "Akun && Pegawai";
            this.AkunCabangTab.VerticalScrollbarBarColor = true;
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
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 457);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.akun2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 424);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Akun";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.submenuPegawai1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 29);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 424);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Pegawai";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // Cabang
            // 
            this.Cabang.Controls.Add(this.cabang2);
            this.Cabang.HorizontalScrollbarBarColor = true;
            this.Cabang.Location = new System.Drawing.Point(4, 35);
            this.Cabang.Name = "Cabang";
            this.Cabang.Size = new System.Drawing.Size(800, 457);
            this.Cabang.TabIndex = 2;
            this.Cabang.Text = "Cabang";
            this.Cabang.VerticalScrollbarBarColor = true;
            // 
            // Jasa
            // 
            this.Jasa.Controls.Add(this.menuJasa1);
            this.Jasa.HorizontalScrollbarBarColor = true;
            this.Jasa.Location = new System.Drawing.Point(4, 35);
            this.Jasa.Name = "Jasa";
            this.Jasa.Size = new System.Drawing.Size(800, 457);
            this.Jasa.TabIndex = 3;
            this.Jasa.Text = "Jasa";
            this.Jasa.VerticalScrollbarBarColor = true;
            // 
            // Sales
            // 
            this.Sales.HorizontalScrollbarBarColor = true;
            this.Sales.Location = new System.Drawing.Point(4, 35);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(800, 457);
            this.Sales.TabIndex = 6;
            this.Sales.Text = "Sales";
            this.Sales.VerticalScrollbarBarColor = true;
            // 
            // Pembayaran
            // 
            this.Pembayaran.HorizontalScrollbarBarColor = true;
            this.Pembayaran.Location = new System.Drawing.Point(4, 35);
            this.Pembayaran.Name = "Pembayaran";
            this.Pembayaran.Size = new System.Drawing.Size(800, 457);
            this.Pembayaran.TabIndex = 1;
            this.Pembayaran.Text = "Pembayaran";
            this.Pembayaran.VerticalScrollbarBarColor = true;
            // 
            // Surat
            // 
            this.Surat.HorizontalScrollbarBarColor = true;
            this.Surat.Location = new System.Drawing.Point(4, 35);
            this.Surat.Name = "Surat";
            this.Surat.Size = new System.Drawing.Size(800, 457);
            this.Surat.TabIndex = 5;
            this.Surat.Text = "Surat";
            this.Surat.VerticalScrollbarBarColor = true;
            // 
            // Nota
            // 
            this.Nota.HorizontalScrollbarBarColor = true;
            this.Nota.Location = new System.Drawing.Point(4, 35);
            this.Nota.Name = "Nota";
            this.Nota.Size = new System.Drawing.Size(800, 457);
            this.Nota.TabIndex = 7;
            this.Nota.Text = "Nota";
            this.Nota.VerticalScrollbarBarColor = true;
            // 
            // Laporan
            // 
            this.Laporan.HorizontalScrollbarBarColor = true;
            this.Laporan.Location = new System.Drawing.Point(4, 35);
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(800, 457);
            this.Laporan.TabIndex = 4;
            this.Laporan.Text = "Laporan";
            this.Laporan.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 42);
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
            this.panel5.Location = new System.Drawing.Point(604, 9);
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
            // akun2
            // 
            this.akun2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.akun2.Location = new System.Drawing.Point(0, 0);
            this.akun2.Name = "akun2";
            this.akun2.Size = new System.Drawing.Size(792, 424);
            this.akun2.TabIndex = 2;
            // 
            // submenuPegawai1
            // 
            this.submenuPegawai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submenuPegawai1.Location = new System.Drawing.Point(0, 0);
            this.submenuPegawai1.Margin = new System.Windows.Forms.Padding(4);
            this.submenuPegawai1.Name = "submenuPegawai1";
            this.submenuPegawai1.Size = new System.Drawing.Size(792, 424);
            this.submenuPegawai1.TabIndex = 2;
            // 
            // cabang2
            // 
            this.cabang2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cabang2.Location = new System.Drawing.Point(0, 0);
            this.cabang2.Margin = new System.Windows.Forms.Padding(2);
            this.cabang2.Name = "cabang2";
            this.cabang2.Size = new System.Drawing.Size(800, 457);
            this.cabang2.TabIndex = 2;
            // 
            // menuJasa1
            // 
            this.menuJasa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuJasa1.Location = new System.Drawing.Point(0, 0);
            this.menuJasa1.Margin = new System.Windows.Forms.Padding(4);
            this.menuJasa1.Name = "menuJasa1";
            this.menuJasa1.Size = new System.Drawing.Size(800, 457);
            this.menuJasa1.TabIndex = 2;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
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
            this.Jasa.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
    }
}