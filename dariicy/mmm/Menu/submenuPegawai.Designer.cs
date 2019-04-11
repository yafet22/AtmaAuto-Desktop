namespace BengkelAtma.Menu
{
    partial class submenuPegawai
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNotel = new System.Windows.Forms.Label();
            this.btnResetPeg = new System.Windows.Forms.Button();
            this.findHeader = new MetroFramework.Controls.MetroPanel();
            this.btnCariPeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariPeg = new System.Windows.Forms.TextBox();
            this.tbGajiPegawai = new System.Windows.Forms.TextBox();
            this.labelGaji = new System.Windows.Forms.Label();
            this.tbNomorTeleponPegawai = new System.Windows.Forms.TextBox();
            this.dgContainer = new MetroFramework.Controls.MetroPanel();
            this.dataPegawai = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelJabatan = new System.Windows.Forms.Label();
            this.comboJabatan = new System.Windows.Forms.ComboBox();
            this.labelCabang = new System.Windows.Forms.Label();
            this.comboCabang = new System.Windows.Forms.ComboBox();
            this.tbAlamatPegawai = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.tbNamaPegawai = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.btnSimpanPeg = new System.Windows.Forms.Button();
            this.bootomContent = new MetroFramework.Controls.MetroPanel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHapusPeg = new System.Windows.Forms.Button();
            this.findHeader.SuspendLayout();
            this.dgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPegawai)).BeginInit();
            this.panel2.SuspendLayout();
            this.bootomContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNotel
            // 
            this.labelNotel.AutoSize = true;
            this.labelNotel.Location = new System.Drawing.Point(20, 161);
            this.labelNotel.Name = "labelNotel";
            this.labelNotel.Size = new System.Drawing.Size(63, 13);
            this.labelNotel.TabIndex = 4;
            this.labelNotel.Text = "No.Telepon";
            // 
            // btnResetPeg
            // 
            this.btnResetPeg.Location = new System.Drawing.Point(21, 351);
            this.btnResetPeg.Name = "btnResetPeg";
            this.btnResetPeg.Size = new System.Drawing.Size(75, 23);
            this.btnResetPeg.TabIndex = 2;
            this.btnResetPeg.Text = "Reset";
            this.btnResetPeg.UseVisualStyleBackColor = true;
            this.btnResetPeg.Click += new System.EventHandler(this.btnResetPeg_Click);
            // 
            // findHeader
            // 
            this.findHeader.BackColor = System.Drawing.Color.White;
            this.findHeader.Controls.Add(this.btnCariPeg);
            this.findHeader.Controls.Add(this.label1);
            this.findHeader.Controls.Add(this.tbCariPeg);
            this.findHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.findHeader.HorizontalScrollbarBarColor = true;
            this.findHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.findHeader.HorizontalScrollbarSize = 10;
            this.findHeader.Location = new System.Drawing.Point(0, 0);
            this.findHeader.Name = "findHeader";
            this.findHeader.Size = new System.Drawing.Size(320, 82);
            this.findHeader.TabIndex = 16;
            this.findHeader.VerticalScrollbarBarColor = true;
            this.findHeader.VerticalScrollbarHighlightOnWheel = false;
            this.findHeader.VerticalScrollbarSize = 10;
            // 
            // btnCariPeg
            // 
            this.btnCariPeg.Location = new System.Drawing.Point(220, 53);
            this.btnCariPeg.Name = "btnCariPeg";
            this.btnCariPeg.Size = new System.Drawing.Size(49, 23);
            this.btnCariPeg.TabIndex = 11;
            this.btnCariPeg.Text = "Cari";
            this.btnCariPeg.UseVisualStyleBackColor = true;
            this.btnCariPeg.Click += new System.EventHandler(this.btnCariPeg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nama Pegawai:";
            // 
            // tbCariPeg
            // 
            this.tbCariPeg.Location = new System.Drawing.Point(10, 55);
            this.tbCariPeg.Name = "tbCariPeg";
            this.tbCariPeg.Size = new System.Drawing.Size(201, 20);
            this.tbCariPeg.TabIndex = 10;
            // 
            // tbGajiPegawai
            // 
            this.tbGajiPegawai.Location = new System.Drawing.Point(22, 220);
            this.tbGajiPegawai.Name = "tbGajiPegawai";
            this.tbGajiPegawai.Size = new System.Drawing.Size(236, 20);
            this.tbGajiPegawai.TabIndex = 9;
            // 
            // labelGaji
            // 
            this.labelGaji.AutoSize = true;
            this.labelGaji.Location = new System.Drawing.Point(20, 204);
            this.labelGaji.Name = "labelGaji";
            this.labelGaji.Size = new System.Drawing.Size(25, 13);
            this.labelGaji.TabIndex = 8;
            this.labelGaji.Text = "Gaji";
            // 
            // tbNomorTeleponPegawai
            // 
            this.tbNomorTeleponPegawai.Location = new System.Drawing.Point(22, 177);
            this.tbNomorTeleponPegawai.Name = "tbNomorTeleponPegawai";
            this.tbNomorTeleponPegawai.Size = new System.Drawing.Size(236, 20);
            this.tbNomorTeleponPegawai.TabIndex = 7;
            // 
            // dgContainer
            // 
            this.dgContainer.BackColor = System.Drawing.Color.White;
            this.dgContainer.Controls.Add(this.dataPegawai);
            this.dgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgContainer.HorizontalScrollbarBarColor = true;
            this.dgContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.dgContainer.HorizontalScrollbarSize = 10;
            this.dgContainer.Location = new System.Drawing.Point(0, 82);
            this.dgContainer.Name = "dgContainer";
            this.dgContainer.Padding = new System.Windows.Forms.Padding(10);
            this.dgContainer.Size = new System.Drawing.Size(320, 218);
            this.dgContainer.TabIndex = 15;
            this.dgContainer.VerticalScrollbarBarColor = true;
            this.dgContainer.VerticalScrollbarHighlightOnWheel = false;
            this.dgContainer.VerticalScrollbarSize = 10;
            // 
            // dataPegawai
            // 
            this.dataPegawai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPegawai.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataPegawai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPegawai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPegawai.Location = new System.Drawing.Point(10, 10);
            this.dataPegawai.Name = "dataPegawai";
            this.dataPegawai.Size = new System.Drawing.Size(300, 198);
            this.dataPegawai.TabIndex = 13;
            this.dataPegawai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPegawai_CellClick);
            this.dataPegawai.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataPegawai_UserDeletingRow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelJabatan);
            this.panel2.Controls.Add(this.comboJabatan);
            this.panel2.Controls.Add(this.labelCabang);
            this.panel2.Controls.Add(this.comboCabang);
            this.panel2.Controls.Add(this.tbAlamatPegawai);
            this.panel2.Controls.Add(this.labelAlamat);
            this.panel2.Controls.Add(this.tbNamaPegawai);
            this.panel2.Controls.Add(this.labelNama);
            this.panel2.Controls.Add(this.tbGajiPegawai);
            this.panel2.Controls.Add(this.labelGaji);
            this.panel2.Controls.Add(this.tbNomorTeleponPegawai);
            this.panel2.Controls.Add(this.labelNotel);
            this.panel2.Controls.Add(this.btnSimpanPeg);
            this.panel2.Controls.Add(this.btnResetPeg);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 400);
            this.panel2.TabIndex = 1;
            // 
            // labelJabatan
            // 
            this.labelJabatan.AutoSize = true;
            this.labelJabatan.Location = new System.Drawing.Point(19, 298);
            this.labelJabatan.Name = "labelJabatan";
            this.labelJabatan.Size = new System.Drawing.Size(45, 13);
            this.labelJabatan.TabIndex = 17;
            this.labelJabatan.Text = "Jabatan";
            // 
            // comboJabatan
            // 
            this.comboJabatan.FormattingEnabled = true;
            this.comboJabatan.Location = new System.Drawing.Point(22, 314);
            this.comboJabatan.Margin = new System.Windows.Forms.Padding(2);
            this.comboJabatan.Name = "comboJabatan";
            this.comboJabatan.Size = new System.Drawing.Size(236, 21);
            this.comboJabatan.TabIndex = 16;
            // 
            // labelCabang
            // 
            this.labelCabang.AutoSize = true;
            this.labelCabang.Location = new System.Drawing.Point(20, 250);
            this.labelCabang.Name = "labelCabang";
            this.labelCabang.Size = new System.Drawing.Size(44, 13);
            this.labelCabang.TabIndex = 15;
            this.labelCabang.Text = "Cabang";
            // 
            // comboCabang
            // 
            this.comboCabang.FormattingEnabled = true;
            this.comboCabang.Location = new System.Drawing.Point(22, 266);
            this.comboCabang.Margin = new System.Windows.Forms.Padding(2);
            this.comboCabang.Name = "comboCabang";
            this.comboCabang.Size = new System.Drawing.Size(236, 21);
            this.comboCabang.TabIndex = 14;
            // 
            // tbAlamatPegawai
            // 
            this.tbAlamatPegawai.Location = new System.Drawing.Point(22, 135);
            this.tbAlamatPegawai.Name = "tbAlamatPegawai";
            this.tbAlamatPegawai.Size = new System.Drawing.Size(236, 20);
            this.tbAlamatPegawai.TabIndex = 13;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(20, 119);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(39, 13);
            this.labelAlamat.TabIndex = 12;
            this.labelAlamat.Text = "Alamat";
            // 
            // tbNamaPegawai
            // 
            this.tbNamaPegawai.Location = new System.Drawing.Point(22, 92);
            this.tbNamaPegawai.Name = "tbNamaPegawai";
            this.tbNamaPegawai.Size = new System.Drawing.Size(236, 20);
            this.tbNamaPegawai.TabIndex = 11;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(20, 76);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 10;
            this.labelNama.Text = "Nama";
            // 
            // btnSimpanPeg
            // 
            this.btnSimpanPeg.Location = new System.Drawing.Point(104, 352);
            this.btnSimpanPeg.Name = "btnSimpanPeg";
            this.btnSimpanPeg.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanPeg.TabIndex = 3;
            this.btnSimpanPeg.Text = "Simpan";
            this.btnSimpanPeg.UseVisualStyleBackColor = true;
            this.btnSimpanPeg.Click += new System.EventHandler(this.btnSimpanPeg_Click);
            // 
            // bootomContent
            // 
            this.bootomContent.BackColor = System.Drawing.Color.White;
            this.bootomContent.Controls.Add(this.btnHapusPeg);
            this.bootomContent.Controls.Add(this.buttonSimpan);
            this.bootomContent.Controls.Add(this.buttonEdit);
            this.bootomContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bootomContent.HorizontalScrollbarBarColor = true;
            this.bootomContent.HorizontalScrollbarHighlightOnWheel = false;
            this.bootomContent.HorizontalScrollbarSize = 10;
            this.bootomContent.Location = new System.Drawing.Point(0, 300);
            this.bootomContent.Name = "bootomContent";
            this.bootomContent.Size = new System.Drawing.Size(320, 100);
            this.bootomContent.TabIndex = 14;
            this.bootomContent.VerticalScrollbarBarColor = true;
            this.bootomContent.VerticalScrollbarHighlightOnWheel = false;
            this.bootomContent.VerticalScrollbarSize = 10;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(11, 5);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 3;
            this.buttonSimpan.Text = "Input";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(97, 5);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgContainer);
            this.panel1.Controls.Add(this.findHeader);
            this.panel1.Controls.Add(this.bootomContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 400);
            this.panel3.TabIndex = 12;
            // 
            // btnHapusPeg
            // 
            this.btnHapusPeg.Location = new System.Drawing.Point(183, 5);
            this.btnHapusPeg.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapusPeg.Name = "btnHapusPeg";
            this.btnHapusPeg.Size = new System.Drawing.Size(75, 23);
            this.btnHapusPeg.TabIndex = 4;
            this.btnHapusPeg.Text = "Hapus";
            this.btnHapusPeg.UseVisualStyleBackColor = true;
            this.btnHapusPeg.Click += new System.EventHandler(this.btnHapusPeg_Click);
            // 
            // submenuPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "submenuPegawai";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.submenuPegawai_Load);
            this.findHeader.ResumeLayout(false);
            this.findHeader.PerformLayout();
            this.dgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPegawai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bootomContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNotel;
        private System.Windows.Forms.Button btnResetPeg;
        private MetroFramework.Controls.MetroPanel findHeader;
        private System.Windows.Forms.Button btnCariPeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCariPeg;
        private System.Windows.Forms.TextBox tbGajiPegawai;
        private System.Windows.Forms.Label labelGaji;
        private System.Windows.Forms.TextBox tbNomorTeleponPegawai;
        private MetroFramework.Controls.MetroPanel dgContainer;
        private System.Windows.Forms.DataGridView dataPegawai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSimpanPeg;
        private MetroFramework.Controls.MetroPanel bootomContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbAlamatPegawai;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.TextBox tbNamaPegawai;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelCabang;
        private System.Windows.Forms.ComboBox comboCabang;
        private System.Windows.Forms.Label labelJabatan;
        private System.Windows.Forms.ComboBox comboJabatan;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button btnHapusPeg;
    }
}
