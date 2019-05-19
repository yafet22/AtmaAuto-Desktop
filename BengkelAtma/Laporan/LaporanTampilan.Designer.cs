namespace BengkelAtma.Laporan
{
    partial class LaporanTampilan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSparepartTerlaris = new System.Windows.Forms.Button();
            this.btnJasa = new System.Windows.Forms.Button();
            this.btnLaporanSisa = new System.Windows.Forms.Button();
            this.btnLaporanPBul = new System.Windows.Forms.Button();
            this.btnLaporanPThn = new System.Windows.Forms.Button();
            this.btnLaporanPenBul = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnSparepartTerlaris, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnJasa, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLaporanSisa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLaporanPBul, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLaporanPThn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLaporanPenBul, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSparepartTerlaris
            // 
            this.btnSparepartTerlaris.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSparepartTerlaris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSparepartTerlaris.ForeColor = System.Drawing.Color.Transparent;
            this.btnSparepartTerlaris.Location = new System.Drawing.Point(18, 18);
            this.btnSparepartTerlaris.Margin = new System.Windows.Forms.Padding(10);
            this.btnSparepartTerlaris.Name = "btnSparepartTerlaris";
            this.btnSparepartTerlaris.Size = new System.Drawing.Size(174, 172);
            this.btnSparepartTerlaris.TabIndex = 0;
            this.btnSparepartTerlaris.Text = "Laporan Sparepart Terlaris";
            this.btnSparepartTerlaris.UseVisualStyleBackColor = false;
            this.btnSparepartTerlaris.Click += new System.EventHandler(this.btnSparepartTerlaris_Click);
            // 
            // btnJasa
            // 
            this.btnJasa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnJasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJasa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJasa.Location = new System.Drawing.Point(212, 18);
            this.btnJasa.Margin = new System.Windows.Forms.Padding(10);
            this.btnJasa.Name = "btnJasa";
            this.btnJasa.Size = new System.Drawing.Size(174, 172);
            this.btnJasa.TabIndex = 1;
            this.btnJasa.Text = "Laporan Penjualan Jasa";
            this.btnJasa.UseVisualStyleBackColor = false;
            this.btnJasa.Click += new System.EventHandler(this.btnJasa_Click);
            // 
            // btnLaporanSisa
            // 
            this.btnLaporanSisa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLaporanSisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaporanSisa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaporanSisa.Location = new System.Drawing.Point(406, 18);
            this.btnLaporanSisa.Margin = new System.Windows.Forms.Padding(10);
            this.btnLaporanSisa.Name = "btnLaporanSisa";
            this.btnLaporanSisa.Size = new System.Drawing.Size(176, 172);
            this.btnLaporanSisa.TabIndex = 2;
            this.btnLaporanSisa.Text = "Laporan Sisa Stok";
            this.btnLaporanSisa.UseVisualStyleBackColor = false;
            this.btnLaporanSisa.Click += new System.EventHandler(this.btnLaporanSisa_Click);
            // 
            // btnLaporanPBul
            // 
            this.btnLaporanPBul.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLaporanPBul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaporanPBul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaporanPBul.Location = new System.Drawing.Point(18, 210);
            this.btnLaporanPBul.Margin = new System.Windows.Forms.Padding(10);
            this.btnLaporanPBul.Name = "btnLaporanPBul";
            this.btnLaporanPBul.Size = new System.Drawing.Size(174, 172);
            this.btnLaporanPBul.TabIndex = 3;
            this.btnLaporanPBul.Text = "Laporan Pendapatan Bulanan";
            this.btnLaporanPBul.UseVisualStyleBackColor = false;
            this.btnLaporanPBul.Click += new System.EventHandler(this.btnLaporanPBul_Click);
            // 
            // btnLaporanPThn
            // 
            this.btnLaporanPThn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLaporanPThn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaporanPThn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaporanPThn.Location = new System.Drawing.Point(212, 210);
            this.btnLaporanPThn.Margin = new System.Windows.Forms.Padding(10);
            this.btnLaporanPThn.Name = "btnLaporanPThn";
            this.btnLaporanPThn.Size = new System.Drawing.Size(174, 172);
            this.btnLaporanPThn.TabIndex = 4;
            this.btnLaporanPThn.Text = "Laporan Pendapatan Tahunan";
            this.btnLaporanPThn.UseVisualStyleBackColor = false;
            this.btnLaporanPThn.Click += new System.EventHandler(this.btnLaporanPThn_Click);
            // 
            // btnLaporanPenBul
            // 
            this.btnLaporanPenBul.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLaporanPenBul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaporanPenBul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaporanPenBul.Location = new System.Drawing.Point(406, 210);
            this.btnLaporanPenBul.Margin = new System.Windows.Forms.Padding(10);
            this.btnLaporanPenBul.Name = "btnLaporanPenBul";
            this.btnLaporanPenBul.Size = new System.Drawing.Size(176, 172);
            this.btnLaporanPenBul.TabIndex = 5;
            this.btnLaporanPenBul.Text = "Laporan Pengeluaran Bulanan";
            this.btnLaporanPenBul.UseVisualStyleBackColor = false;
            this.btnLaporanPenBul.Click += new System.EventHandler(this.btnLaporanPenBul_Click);
            // 
            // LaporanTampilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LaporanTampilan";
            this.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSparepartTerlaris;
        private System.Windows.Forms.Button btnJasa;
        private System.Windows.Forms.Button btnLaporanSisa;
        private System.Windows.Forms.Button btnLaporanPBul;
        private System.Windows.Forms.Button btnLaporanPThn;
        private System.Windows.Forms.Button btnLaporanPenBul;
    }
}
