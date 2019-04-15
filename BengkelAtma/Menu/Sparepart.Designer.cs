namespace BengkelAtma.Menu
{
    partial class Sparepart
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCompatibility = new System.Windows.Forms.Button();
            this.comboMotorType = new System.Windows.Forms.ComboBox();
            this.comboMotorBrand = new System.Windows.Forms.ComboBox();
            this.dataCompatibility = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.labelCari = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.comboTempat = new System.Windows.Forms.ComboBox();
            this.comboPosition = new System.Windows.Forms.ComboBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.tbNomor = new System.Windows.Forms.TextBox();
            this.labelNomor = new System.Windows.Forms.Label();
            this.labelTempat = new System.Windows.Forms.Label();
            this.labelPosisi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHargaJual = new System.Windows.Forms.Label();
            this.tbJual = new System.Windows.Forms.TextBox();
            this.tbBeli = new System.Windows.Forms.TextBox();
            this.labelHargaBeli = new System.Windows.Forms.Label();
            this.labelMinStock = new System.Windows.Forms.Label();
            this.tbMinStock = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.comboSparepartType = new System.Windows.Forms.ComboBox();
            this.labelSparepartType = new System.Windows.Forms.Label();
            this.tbMerkSparepart = new System.Windows.Forms.TextBox();
            this.labelMerk = new System.Windows.Forms.Label();
            this.tbNameSparepart = new System.Windows.Forms.TextBox();
            this.labelNamaSparepart = new System.Windows.Forms.Label();
            this.tbKodeSparepart = new System.Windows.Forms.TextBox();
            this.labelKodeSparepart = new System.Windows.Forms.Label();
            this.dataSparepart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKecocokan = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompatibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSparepart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelType);
            this.panel2.Controls.Add(this.labelBrand);
            this.panel2.Controls.Add(this.labelKecocokan);
            this.panel2.Controls.Add(this.btnCompatibility);
            this.panel2.Controls.Add(this.comboMotorType);
            this.panel2.Controls.Add(this.comboMotorBrand);
            this.panel2.Controls.Add(this.dataCompatibility);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnInput);
            this.panel2.Controls.Add(this.btnCari);
            this.panel2.Controls.Add(this.tbCari);
            this.panel2.Controls.Add(this.labelCari);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.comboTempat);
            this.panel2.Controls.Add(this.comboPosition);
            this.panel2.Controls.Add(this.buttonSimpan);
            this.panel2.Controls.Add(this.tbNomor);
            this.panel2.Controls.Add(this.labelNomor);
            this.panel2.Controls.Add(this.labelTempat);
            this.panel2.Controls.Add(this.labelPosisi);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelHargaJual);
            this.panel2.Controls.Add(this.tbJual);
            this.panel2.Controls.Add(this.tbBeli);
            this.panel2.Controls.Add(this.labelHargaBeli);
            this.panel2.Controls.Add(this.labelMinStock);
            this.panel2.Controls.Add(this.tbMinStock);
            this.panel2.Controls.Add(this.tbStock);
            this.panel2.Controls.Add(this.labelStock);
            this.panel2.Controls.Add(this.comboSparepartType);
            this.panel2.Controls.Add(this.labelSparepartType);
            this.panel2.Controls.Add(this.tbMerkSparepart);
            this.panel2.Controls.Add(this.labelMerk);
            this.panel2.Controls.Add(this.tbNameSparepart);
            this.panel2.Controls.Add(this.labelNamaSparepart);
            this.panel2.Controls.Add(this.tbKodeSparepart);
            this.panel2.Controls.Add(this.labelKodeSparepart);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 365);
            this.panel2.TabIndex = 1;
            // 
            // btnCompatibility
            // 
            this.btnCompatibility.Location = new System.Drawing.Point(920, 78);
            this.btnCompatibility.Name = "btnCompatibility";
            this.btnCompatibility.Size = new System.Drawing.Size(117, 23);
            this.btnCompatibility.TabIndex = 51;
            this.btnCompatibility.Text = "Tambah Motor";
            this.btnCompatibility.UseVisualStyleBackColor = true;
            this.btnCompatibility.Click += new System.EventHandler(this.btnCompatibility_Click);
            // 
            // comboMotorType
            // 
            this.comboMotorType.FormattingEnabled = true;
            this.comboMotorType.Location = new System.Drawing.Point(812, 78);
            this.comboMotorType.Name = "comboMotorType";
            this.comboMotorType.Size = new System.Drawing.Size(102, 24);
            this.comboMotorType.TabIndex = 50;
            // 
            // comboMotorBrand
            // 
            this.comboMotorBrand.FormattingEnabled = true;
            this.comboMotorBrand.Location = new System.Drawing.Point(700, 78);
            this.comboMotorBrand.Name = "comboMotorBrand";
            this.comboMotorBrand.Size = new System.Drawing.Size(106, 24);
            this.comboMotorBrand.TabIndex = 49;
            this.comboMotorBrand.SelectedIndexChanged += new System.EventHandler(this.comboMotorBrand_SelectedIndexChanged);
            // 
            // dataCompatibility
            // 
            this.dataCompatibility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCompatibility.Location = new System.Drawing.Point(700, 108);
            this.dataCompatibility.Name = "dataCompatibility";
            this.dataCompatibility.RowTemplate.Height = 24;
            this.dataCompatibility.Size = new System.Drawing.Size(337, 176);
            this.dataCompatibility.TabIndex = 48;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(574, 338);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(445, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Ubah";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(327, 338);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 45;
            this.btnInput.Text = "Tambah";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(947, 338);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(90, 23);
            this.btnCari.TabIndex = 44;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(700, 339);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(240, 22);
            this.tbCari.TabIndex = 43;
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.Location = new System.Drawing.Point(697, 318);
            this.labelCari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(112, 17);
            this.labelCari.TabIndex = 42;
            this.labelCari.Text = "Nama Sparepart";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(496, 298);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 41;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(402, 298);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // comboTempat
            // 
            this.comboTempat.FormattingEnabled = true;
            this.comboTempat.Location = new System.Drawing.Point(445, 260);
            this.comboTempat.Name = "comboTempat";
            this.comboTempat.Size = new System.Drawing.Size(89, 24);
            this.comboTempat.TabIndex = 39;
            // 
            // comboPosition
            // 
            this.comboPosition.FormattingEnabled = true;
            this.comboPosition.Location = new System.Drawing.Point(349, 260);
            this.comboPosition.Name = "comboPosition";
            this.comboPosition.Size = new System.Drawing.Size(89, 24);
            this.comboPosition.TabIndex = 38;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(430, 201);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(117, 23);
            this.buttonSimpan.TabIndex = 37;
            this.buttonSimpan.Text = "Cari Gambar";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // tbNomor
            // 
            this.tbNomor.Location = new System.Drawing.Point(542, 262);
            this.tbNomor.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomor.Name = "tbNomor";
            this.tbNomor.Size = new System.Drawing.Size(89, 22);
            this.tbNomor.TabIndex = 35;
            // 
            // labelNomor
            // 
            this.labelNomor.AutoSize = true;
            this.labelNomor.Location = new System.Drawing.Point(541, 242);
            this.labelNomor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomor.Name = "labelNomor";
            this.labelNomor.Size = new System.Drawing.Size(50, 17);
            this.labelNomor.TabIndex = 34;
            this.labelNomor.Text = "Nomor";
            // 
            // labelTempat
            // 
            this.labelTempat.AutoSize = true;
            this.labelTempat.Location = new System.Drawing.Point(443, 242);
            this.labelTempat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempat.Name = "labelTempat";
            this.labelTempat.Size = new System.Drawing.Size(56, 17);
            this.labelTempat.TabIndex = 32;
            this.labelTempat.Text = "Tempat";
            // 
            // labelPosisi
            // 
            this.labelPosisi.AutoSize = true;
            this.labelPosisi.Location = new System.Drawing.Point(346, 242);
            this.labelPosisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosisi.Name = "labelPosisi";
            this.labelPosisi.Size = new System.Drawing.Size(45, 17);
            this.labelPosisi.TabIndex = 30;
            this.labelPosisi.Text = "Posisi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BengkelAtma.Properties.Resources.profile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(349, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // labelHargaJual
            // 
            this.labelHargaJual.AutoSize = true;
            this.labelHargaJual.Location = new System.Drawing.Point(156, 301);
            this.labelHargaJual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHargaJual.Name = "labelHargaJual";
            this.labelHargaJual.Size = new System.Drawing.Size(77, 17);
            this.labelHargaJual.TabIndex = 28;
            this.labelHargaJual.Text = "Harga Jual";
            // 
            // tbJual
            // 
            this.tbJual.Location = new System.Drawing.Point(159, 320);
            this.tbJual.Margin = new System.Windows.Forms.Padding(4);
            this.tbJual.Name = "tbJual";
            this.tbJual.Size = new System.Drawing.Size(140, 22);
            this.tbJual.TabIndex = 27;
            // 
            // tbBeli
            // 
            this.tbBeli.Location = new System.Drawing.Point(18, 320);
            this.tbBeli.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeli.Name = "tbBeli";
            this.tbBeli.Size = new System.Drawing.Size(133, 22);
            this.tbBeli.TabIndex = 26;
            // 
            // labelHargaBeli
            // 
            this.labelHargaBeli.AutoSize = true;
            this.labelHargaBeli.Location = new System.Drawing.Point(16, 301);
            this.labelHargaBeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHargaBeli.Name = "labelHargaBeli";
            this.labelHargaBeli.Size = new System.Drawing.Size(74, 17);
            this.labelHargaBeli.TabIndex = 25;
            this.labelHargaBeli.Text = "Harga Beli";
            // 
            // labelMinStock
            // 
            this.labelMinStock.AutoSize = true;
            this.labelMinStock.Location = new System.Drawing.Point(156, 242);
            this.labelMinStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinStock.Name = "labelMinStock";
            this.labelMinStock.Size = new System.Drawing.Size(69, 17);
            this.labelMinStock.TabIndex = 24;
            this.labelMinStock.Text = "Min Stock";
            // 
            // tbMinStock
            // 
            this.tbMinStock.Location = new System.Drawing.Point(159, 261);
            this.tbMinStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbMinStock.Name = "tbMinStock";
            this.tbMinStock.Size = new System.Drawing.Size(140, 22);
            this.tbMinStock.TabIndex = 23;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(18, 261);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(133, 22);
            this.tbStock.TabIndex = 22;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(16, 242);
            this.labelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(43, 17);
            this.labelStock.TabIndex = 21;
            this.labelStock.Text = "Stock";
            // 
            // comboSparepartType
            // 
            this.comboSparepartType.FormattingEnabled = true;
            this.comboSparepartType.Location = new System.Drawing.Point(19, 201);
            this.comboSparepartType.Name = "comboSparepartType";
            this.comboSparepartType.Size = new System.Drawing.Size(280, 24);
            this.comboSparepartType.TabIndex = 20;
            // 
            // labelSparepartType
            // 
            this.labelSparepartType.AutoSize = true;
            this.labelSparepartType.Location = new System.Drawing.Point(17, 181);
            this.labelSparepartType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSparepartType.Name = "labelSparepartType";
            this.labelSparepartType.Size = new System.Drawing.Size(103, 17);
            this.labelSparepartType.TabIndex = 18;
            this.labelSparepartType.Text = "Tipe Sparepart";
            // 
            // tbMerkSparepart
            // 
            this.tbMerkSparepart.Location = new System.Drawing.Point(19, 141);
            this.tbMerkSparepart.Margin = new System.Windows.Forms.Padding(4);
            this.tbMerkSparepart.Name = "tbMerkSparepart";
            this.tbMerkSparepart.Size = new System.Drawing.Size(280, 22);
            this.tbMerkSparepart.TabIndex = 17;
            // 
            // labelMerk
            // 
            this.labelMerk.AutoSize = true;
            this.labelMerk.Location = new System.Drawing.Point(17, 122);
            this.labelMerk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMerk.Name = "labelMerk";
            this.labelMerk.Size = new System.Drawing.Size(106, 17);
            this.labelMerk.TabIndex = 16;
            this.labelMerk.Text = "Merk Sparepart";
            // 
            // tbNameSparepart
            // 
            this.tbNameSparepart.Location = new System.Drawing.Point(19, 82);
            this.tbNameSparepart.Margin = new System.Windows.Forms.Padding(4);
            this.tbNameSparepart.Name = "tbNameSparepart";
            this.tbNameSparepart.Size = new System.Drawing.Size(280, 22);
            this.tbNameSparepart.TabIndex = 15;
            // 
            // labelNamaSparepart
            // 
            this.labelNamaSparepart.AutoSize = true;
            this.labelNamaSparepart.Location = new System.Drawing.Point(17, 63);
            this.labelNamaSparepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNamaSparepart.Name = "labelNamaSparepart";
            this.labelNamaSparepart.Size = new System.Drawing.Size(112, 17);
            this.labelNamaSparepart.TabIndex = 14;
            this.labelNamaSparepart.Text = "Nama Sparepart";
            // 
            // tbKodeSparepart
            // 
            this.tbKodeSparepart.Location = new System.Drawing.Point(19, 27);
            this.tbKodeSparepart.Margin = new System.Windows.Forms.Padding(4);
            this.tbKodeSparepart.Name = "tbKodeSparepart";
            this.tbKodeSparepart.Size = new System.Drawing.Size(280, 22);
            this.tbKodeSparepart.TabIndex = 13;
            // 
            // labelKodeSparepart
            // 
            this.labelKodeSparepart.AutoSize = true;
            this.labelKodeSparepart.Location = new System.Drawing.Point(17, 8);
            this.labelKodeSparepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKodeSparepart.Name = "labelKodeSparepart";
            this.labelKodeSparepart.Size = new System.Drawing.Size(108, 17);
            this.labelKodeSparepart.TabIndex = 12;
            this.labelKodeSparepart.Text = "Kode Sparepart";
            // 
            // dataSparepart
            // 
            this.dataSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSparepart.Location = new System.Drawing.Point(4, 4);
            this.dataSparepart.Name = "dataSparepart";
            this.dataSparepart.RowTemplate.Height = 24;
            this.dataSparepart.Size = new System.Drawing.Size(1037, 190);
            this.dataSparepart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataSparepart);
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 204);
            this.panel1.TabIndex = 0;
            // 
            // labelKecocokan
            // 
            this.labelKecocokan.AutoSize = true;
            this.labelKecocokan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKecocokan.Location = new System.Drawing.Point(695, 27);
            this.labelKecocokan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKecocokan.Name = "labelKecocokan";
            this.labelKecocokan.Size = new System.Drawing.Size(303, 29);
            this.labelKecocokan.TabIndex = 52;
            this.labelKecocokan.Text = "Kecocokan Dengan Motor :";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(697, 58);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(39, 17);
            this.labelBrand.TabIndex = 53;
            this.labelBrand.Text = "Merk";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(809, 58);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 54;
            this.labelType.Text = "Type";
            // 
            // Sparepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Sparepart";
            this.Size = new System.Drawing.Size(1047, 568);
            this.Load += new System.EventHandler(this.Sparepart_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompatibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSparepart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboSparepartType;
        private System.Windows.Forms.Label labelSparepartType;
        private System.Windows.Forms.TextBox tbMerkSparepart;
        private System.Windows.Forms.Label labelMerk;
        private System.Windows.Forms.TextBox tbNameSparepart;
        private System.Windows.Forms.Label labelNamaSparepart;
        private System.Windows.Forms.TextBox tbKodeSparepart;
        private System.Windows.Forms.Label labelKodeSparepart;
        private System.Windows.Forms.Label labelMinStock;
        private System.Windows.Forms.TextBox tbMinStock;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelHargaJual;
        private System.Windows.Forms.TextBox tbJual;
        private System.Windows.Forms.TextBox tbBeli;
        private System.Windows.Forms.Label labelHargaBeli;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox comboTempat;
        private System.Windows.Forms.ComboBox comboPosition;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox tbNomor;
        private System.Windows.Forms.Label labelNomor;
        private System.Windows.Forms.Label labelTempat;
        private System.Windows.Forms.Label labelPosisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataSparepart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.DataGridView dataCompatibility;
        private System.Windows.Forms.Button btnCompatibility;
        private System.Windows.Forms.ComboBox comboMotorType;
        private System.Windows.Forms.ComboBox comboMotorBrand;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelKecocokan;
    }
}
