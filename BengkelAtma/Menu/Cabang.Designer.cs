namespace BengkelAtma.Menu
{
    partial class Cabang
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
            this.tbNamaCabang = new System.Windows.Forms.TextBox();
            this.labelCabang = new System.Windows.Forms.Label();
            this.tbAlamatCabang = new System.Windows.Forms.TextBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.tbNomorTeleponCabang = new System.Windows.Forms.TextBox();
            this.labelNomorTelepon = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dataCabang = new System.Windows.Forms.DataGridView();
            this.buttonCari = new System.Windows.Forms.Button();
            this.labelCari = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCabang)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNamaCabang
            // 
            this.tbNamaCabang.Location = new System.Drawing.Point(17, 141);
            this.tbNamaCabang.Margin = new System.Windows.Forms.Padding(4);
            this.tbNamaCabang.Name = "tbNamaCabang";
            this.tbNamaCabang.Size = new System.Drawing.Size(313, 22);
            this.tbNamaCabang.TabIndex = 9;
            // 
            // labelCabang
            // 
            this.labelCabang.AutoSize = true;
            this.labelCabang.Location = new System.Drawing.Point(13, 122);
            this.labelCabang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCabang.Name = "labelCabang";
            this.labelCabang.Size = new System.Drawing.Size(98, 17);
            this.labelCabang.TabIndex = 8;
            this.labelCabang.Text = "Nama Cabang";
            // 
            // tbAlamatCabang
            // 
            this.tbAlamatCabang.Location = new System.Drawing.Point(17, 198);
            this.tbAlamatCabang.Margin = new System.Windows.Forms.Padding(4);
            this.tbAlamatCabang.Name = "tbAlamatCabang";
            this.tbAlamatCabang.Size = new System.Drawing.Size(313, 22);
            this.tbAlamatCabang.TabIndex = 11;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(13, 179);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(104, 17);
            this.labelAlamat.TabIndex = 10;
            this.labelAlamat.Text = "Alamat Cabang";
            // 
            // tbNomorTeleponCabang
            // 
            this.tbNomorTeleponCabang.Location = new System.Drawing.Point(18, 259);
            this.tbNomorTeleponCabang.Margin = new System.Windows.Forms.Padding(4);
            this.tbNomorTeleponCabang.Name = "tbNomorTeleponCabang";
            this.tbNomorTeleponCabang.Size = new System.Drawing.Size(313, 22);
            this.tbNomorTeleponCabang.TabIndex = 13;
            // 
            // labelNomorTelepon
            // 
            this.labelNomorTelepon.AutoSize = true;
            this.labelNomorTelepon.Location = new System.Drawing.Point(14, 240);
            this.labelNomorTelepon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomorTelepon.Name = "labelNomorTelepon";
            this.labelNomorTelepon.Size = new System.Drawing.Size(159, 17);
            this.labelNomorTelepon.TabIndex = 12;
            this.labelNomorTelepon.Text = "Nomor Telepon Cabang";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(128, 308);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 28);
            this.buttonSimpan.TabIndex = 15;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(17, 308);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 28);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dataCabang
            // 
            this.dataCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCabang.Location = new System.Drawing.Point(367, 141);
            this.dataCabang.Name = "dataCabang";
            this.dataCabang.RowTemplate.Height = 24;
            this.dataCabang.Size = new System.Drawing.Size(648, 247);
            this.dataCabang.TabIndex = 16;
            this.dataCabang.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCabang_CellEndEdit);
            this.dataCabang.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataCabang_UserDeletingRow);
            this.dataCabang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataCabang_KeyDown);
            // 
            // buttonCari
            // 
            this.buttonCari.Location = new System.Drawing.Point(759, 108);
            this.buttonCari.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(103, 28);
            this.buttonCari.TabIndex = 18;
            this.buttonCari.Text = "Cari";
            this.buttonCari.UseVisualStyleBackColor = true;
            this.buttonCari.Click += new System.EventHandler(this.buttonCari_Click);
            // 
            // labelCari
            // 
            this.labelCari.AutoSize = true;
            this.labelCari.BackColor = System.Drawing.Color.Transparent;
            this.labelCari.Location = new System.Drawing.Point(364, 88);
            this.labelCari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCari.Name = "labelCari";
            this.labelCari.Size = new System.Drawing.Size(74, 17);
            this.labelCari.TabIndex = 19;
            this.labelCari.Text = "Cari Nama";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(368, 108);
            this.tbCari.Margin = new System.Windows.Forms.Padding(4);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(368, 22);
            this.tbCari.TabIndex = 17;
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(367, 406);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 21;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(464, 406);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Cabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCari);
            this.Controls.Add(this.labelCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.dataCabang);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.tbNomorTeleponCabang);
            this.Controls.Add(this.labelNomorTelepon);
            this.Controls.Add(this.tbAlamatCabang);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.tbNamaCabang);
            this.Controls.Add(this.labelCabang);
            this.Name = "Cabang";
            this.Size = new System.Drawing.Size(1077, 498);
            this.Load += new System.EventHandler(this.Cabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCabang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNamaCabang;
        private System.Windows.Forms.Label labelCabang;
        private System.Windows.Forms.TextBox tbAlamatCabang;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.TextBox tbNomorTeleponCabang;
        private System.Windows.Forms.Label labelNomorTelepon;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DataGridView dataCabang;
        private System.Windows.Forms.Button buttonCari;
        private System.Windows.Forms.Label labelCari;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonEdit;
    }
}
