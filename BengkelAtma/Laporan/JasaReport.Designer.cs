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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelJasaReport = new System.Windows.Forms.Label();
            this.btnLaporanJasa = new System.Windows.Forms.Button();
            this.panel3atas = new System.Windows.Forms.Panel();
            this.panel1kiri = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(145, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 98);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelJasaReport);
            this.panel2.Controls.Add(this.btnLaporanJasa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(145, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 204);
            this.panel2.TabIndex = 4;
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
            // 
            // panel3atas
            // 
            this.panel3atas.BackColor = System.Drawing.Color.White;
            this.panel3atas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3atas.Location = new System.Drawing.Point(145, 0);
            this.panel3atas.Name = "panel3atas";
            this.panel3atas.Size = new System.Drawing.Size(455, 98);
            this.panel3atas.TabIndex = 2;
            // 
            // panel1kiri
            // 
            this.panel1kiri.BackColor = System.Drawing.Color.White;
            this.panel1kiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1kiri.Location = new System.Drawing.Point(0, 0);
            this.panel1kiri.Name = "panel1kiri";
            this.panel1kiri.Size = new System.Drawing.Size(145, 400);
            this.panel1kiri.TabIndex = 0;
            // 
            // JasaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3atas);
            this.Controls.Add(this.panel1kiri);
            this.Name = "JasaReport";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelJasaReport;
        private System.Windows.Forms.Button btnLaporanJasa;
        private System.Windows.Forms.Panel panel3atas;
        private System.Windows.Forms.Panel panel1kiri;
    }
}
