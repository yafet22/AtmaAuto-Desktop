namespace BengkelAtma.Laporan
{
    partial class PendapatanBulanans
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
            this.panel1kiriSisaStok = new System.Windows.Forms.Panel();
            this.panel3atasSisaStok = new System.Windows.Forms.Panel();
            this.panel1bwahSisaStok = new System.Windows.Forms.Panel();
            this.panel2UtamaSisaStok = new System.Windows.Forms.Panel();
            this.labelJasaReport = new System.Windows.Forms.Label();
            this.btnLaporanPenBul = new System.Windows.Forms.Button();
            this.panel2UtamaSisaStok.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1kiriSisaStok
            // 
            this.panel1kiriSisaStok.BackColor = System.Drawing.Color.White;
            this.panel1kiriSisaStok.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1kiriSisaStok.Location = new System.Drawing.Point(0, 0);
            this.panel1kiriSisaStok.Name = "panel1kiriSisaStok";
            this.panel1kiriSisaStok.Size = new System.Drawing.Size(256, 400);
            this.panel1kiriSisaStok.TabIndex = 3;
            // 
            // panel3atasSisaStok
            // 
            this.panel3atasSisaStok.BackColor = System.Drawing.Color.White;
            this.panel3atasSisaStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3atasSisaStok.Location = new System.Drawing.Point(256, 0);
            this.panel3atasSisaStok.Name = "panel3atasSisaStok";
            this.panel3atasSisaStok.Size = new System.Drawing.Size(344, 98);
            this.panel3atasSisaStok.TabIndex = 5;
            // 
            // panel1bwahSisaStok
            // 
            this.panel1bwahSisaStok.BackColor = System.Drawing.Color.White;
            this.panel1bwahSisaStok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1bwahSisaStok.Location = new System.Drawing.Point(256, 302);
            this.panel1bwahSisaStok.Name = "panel1bwahSisaStok";
            this.panel1bwahSisaStok.Size = new System.Drawing.Size(344, 98);
            this.panel1bwahSisaStok.TabIndex = 6;
            // 
            // panel2UtamaSisaStok
            // 
            this.panel2UtamaSisaStok.BackColor = System.Drawing.Color.White;
            this.panel2UtamaSisaStok.Controls.Add(this.labelJasaReport);
            this.panel2UtamaSisaStok.Controls.Add(this.btnLaporanPenBul);
            this.panel2UtamaSisaStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2UtamaSisaStok.Location = new System.Drawing.Point(256, 98);
            this.panel2UtamaSisaStok.Name = "panel2UtamaSisaStok";
            this.panel2UtamaSisaStok.Size = new System.Drawing.Size(344, 204);
            this.panel2UtamaSisaStok.TabIndex = 7;
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
            // btnLaporanPenBul
            // 
            this.btnLaporanPenBul.BackColor = System.Drawing.Color.Gold;
            this.btnLaporanPenBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPenBul.Location = new System.Drawing.Point(98, 123);
            this.btnLaporanPenBul.Name = "btnLaporanPenBul";
            this.btnLaporanPenBul.Size = new System.Drawing.Size(199, 23);
            this.btnLaporanPenBul.TabIndex = 2;
            this.btnLaporanPenBul.Text = "Laporan Pendapatan Bulanan";
            this.btnLaporanPenBul.UseVisualStyleBackColor = false;
            this.btnLaporanPenBul.Click += new System.EventHandler(this.btnLaporanPenBul_Click);
            // 
            // PendapatanBulanans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2UtamaSisaStok);
            this.Controls.Add(this.panel1bwahSisaStok);
            this.Controls.Add(this.panel3atasSisaStok);
            this.Controls.Add(this.panel1kiriSisaStok);
            this.Name = "PendapatanBulanans";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel2UtamaSisaStok.ResumeLayout(false);
            this.panel2UtamaSisaStok.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1kiriSisaStok;
        private System.Windows.Forms.Panel panel3atasSisaStok;
        private System.Windows.Forms.Panel panel1bwahSisaStok;
        private System.Windows.Forms.Panel panel2UtamaSisaStok;
        private System.Windows.Forms.Label labelJasaReport;
        private System.Windows.Forms.Button btnLaporanPenBul;
    }
}
