namespace BengkelAtma.Laporan
{
    partial class JasaReport
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
            this.panel2UtamaJasa = new System.Windows.Forms.Panel();
            this.labelJasaReport = new System.Windows.Forms.Label();
            this.btnLaporanJasa = new System.Windows.Forms.Button();
            this.panel1bwahJasa = new System.Windows.Forms.Panel();
            this.panel3atasJasa = new System.Windows.Forms.Panel();
            this.panel1kiriJasa = new System.Windows.Forms.Panel();
            this.panel2UtamaJasa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2UtamaJasa
            // 
            this.panel2UtamaJasa.BackColor = System.Drawing.Color.White;
            this.panel2UtamaJasa.Controls.Add(this.labelJasaReport);
            this.panel2UtamaJasa.Controls.Add(this.btnLaporanJasa);
            this.panel2UtamaJasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2UtamaJasa.Location = new System.Drawing.Point(256, 98);
            this.panel2UtamaJasa.Name = "panel2UtamaJasa";
            this.panel2UtamaJasa.Size = new System.Drawing.Size(344, 204);
            this.panel2UtamaJasa.TabIndex = 4;
            // 
            // labelJasaReport
            // 
            this.labelJasaReport.AutoSize = true;
            this.labelJasaReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJasaReport.Location = new System.Drawing.Point(84, 59);
            this.labelJasaReport.Name = "labelJasaReport";
            this.labelJasaReport.Size = new System.Drawing.Size(240, 18);
            this.labelJasaReport.TabIndex = 3;
            this.labelJasaReport.Text = "Silahkan Tekan Tombol dibawah ini\r\n";
            // 
            // btnLaporanJasa
            // 
            this.btnLaporanJasa.BackColor = System.Drawing.Color.Gold;
            this.btnLaporanJasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanJasa.Location = new System.Drawing.Point(117, 122);
            this.btnLaporanJasa.Name = "btnLaporanJasa";
            this.btnLaporanJasa.Size = new System.Drawing.Size(169, 23);
            this.btnLaporanJasa.TabIndex = 2;
            this.btnLaporanJasa.Text = "Laporan Penjualan Jasa";
            this.btnLaporanJasa.UseVisualStyleBackColor = false;
            this.btnLaporanJasa.Click += new System.EventHandler(this.btnLaporanJasa_Click);
            // 
            // panel1bwahJasa
            // 
            this.panel1bwahJasa.BackColor = System.Drawing.Color.White;
            this.panel1bwahJasa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1bwahJasa.Location = new System.Drawing.Point(256, 302);
            this.panel1bwahJasa.Name = "panel1bwahJasa";
            this.panel1bwahJasa.Size = new System.Drawing.Size(344, 98);
            this.panel1bwahJasa.TabIndex = 3;
            // 
            // panel3atasJasa
            // 
            this.panel3atasJasa.BackColor = System.Drawing.Color.White;
            this.panel3atasJasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3atasJasa.Location = new System.Drawing.Point(256, 0);
            this.panel3atasJasa.Name = "panel3atasJasa";
            this.panel3atasJasa.Size = new System.Drawing.Size(344, 98);
            this.panel3atasJasa.TabIndex = 2;
            // 
            // panel1kiriJasa
            // 
            this.panel1kiriJasa.BackColor = System.Drawing.Color.White;
            this.panel1kiriJasa.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1kiriJasa.Location = new System.Drawing.Point(0, 0);
            this.panel1kiriJasa.Name = "panel1kiriJasa";
            this.panel1kiriJasa.Size = new System.Drawing.Size(256, 400);
            this.panel1kiriJasa.TabIndex = 0;
            // 
            // JasaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2UtamaJasa);
            this.Controls.Add(this.panel1bwahJasa);
            this.Controls.Add(this.panel3atasJasa);
            this.Controls.Add(this.panel1kiriJasa);
            this.Name = "JasaReport";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel2UtamaJasa.ResumeLayout(false);
            this.panel2UtamaJasa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2UtamaJasa;
        private System.Windows.Forms.Label labelJasaReport;
        private System.Windows.Forms.Button btnLaporanJasa;
        private System.Windows.Forms.Panel panel1bwahJasa;
        private System.Windows.Forms.Panel panel3atasJasa;
        private System.Windows.Forms.Panel panel1kiriJasa;
    }
}
