namespace BengkelAtma.Laporan
{
    partial class SparepartTerlaris
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
            this.panel1kiriSparepart = new System.Windows.Forms.Panel();
            this.panel3atasSparepart = new System.Windows.Forms.Panel();
            this.panel1bawahSparepart = new System.Windows.Forms.Panel();
            this.panel2UtamaSparepart = new System.Windows.Forms.Panel();
            this.labelJasaReport = new System.Windows.Forms.Label();
            this.btnLaporanJasa = new System.Windows.Forms.Button();
            this.panel2UtamaSparepart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1kiriSparepart
            // 
            this.panel1kiriSparepart.BackColor = System.Drawing.Color.White;
            this.panel1kiriSparepart.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1kiriSparepart.Location = new System.Drawing.Point(0, 0);
            this.panel1kiriSparepart.Name = "panel1kiriSparepart";
            this.panel1kiriSparepart.Size = new System.Drawing.Size(256, 400);
            this.panel1kiriSparepart.TabIndex = 1;
            // 
            // panel3atasSparepart
            // 
            this.panel3atasSparepart.BackColor = System.Drawing.Color.White;
            this.panel3atasSparepart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3atasSparepart.Location = new System.Drawing.Point(256, 0);
            this.panel3atasSparepart.Name = "panel3atasSparepart";
            this.panel3atasSparepart.Size = new System.Drawing.Size(344, 98);
            this.panel3atasSparepart.TabIndex = 3;
            // 
            // panel1bawahSparepart
            // 
            this.panel1bawahSparepart.BackColor = System.Drawing.Color.White;
            this.panel1bawahSparepart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1bawahSparepart.Location = new System.Drawing.Point(256, 302);
            this.panel1bawahSparepart.Name = "panel1bawahSparepart";
            this.panel1bawahSparepart.Size = new System.Drawing.Size(344, 98);
            this.panel1bawahSparepart.TabIndex = 4;
            // 
            // panel2UtamaSparepart
            // 
            this.panel2UtamaSparepart.BackColor = System.Drawing.Color.White;
            this.panel2UtamaSparepart.Controls.Add(this.labelJasaReport);
            this.panel2UtamaSparepart.Controls.Add(this.btnLaporanJasa);
            this.panel2UtamaSparepart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2UtamaSparepart.Location = new System.Drawing.Point(256, 98);
            this.panel2UtamaSparepart.Name = "panel2UtamaSparepart";
            this.panel2UtamaSparepart.Size = new System.Drawing.Size(344, 204);
            this.panel2UtamaSparepart.TabIndex = 5;
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
            this.btnLaporanJasa.Text = "Laporan Sparepart Terlaris";
            this.btnLaporanJasa.UseVisualStyleBackColor = false;
            this.btnLaporanJasa.Click += new System.EventHandler(this.btnLaporanJasa_Click);
            // 
            // SparepartTerlaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2UtamaSparepart);
            this.Controls.Add(this.panel1bawahSparepart);
            this.Controls.Add(this.panel3atasSparepart);
            this.Controls.Add(this.panel1kiriSparepart);
            this.Name = "SparepartTerlaris";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel2UtamaSparepart.ResumeLayout(false);
            this.panel2UtamaSparepart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1kiriSparepart;
        private System.Windows.Forms.Panel panel3atasSparepart;
        private System.Windows.Forms.Panel panel1bawahSparepart;
        private System.Windows.Forms.Panel panel2UtamaSparepart;
        private System.Windows.Forms.Label labelJasaReport;
        private System.Windows.Forms.Button btnLaporanJasa;
    }
}
