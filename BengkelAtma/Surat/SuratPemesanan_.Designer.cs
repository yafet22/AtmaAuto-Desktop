namespace BengkelAtma.Surat
{
    partial class SuratPemesanan_
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
            this.dgPemesanan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPemesanan
            // 
            this.dgPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPemesanan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPemesanan.Location = new System.Drawing.Point(10, 10);
            this.dgPemesanan.Name = "dgPemesanan";
            this.dgPemesanan.Size = new System.Drawing.Size(580, 380);
            this.dgPemesanan.TabIndex = 0;
            this.dgPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPemesanan_CellContentClick);
            this.dgPemesanan.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPemesanan_RowHeaderMouseClick);
            // 
            // SuratPemesanan_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgPemesanan);
            this.Name = "SuratPemesanan_";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.SuratPemesanan__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPemesanan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPemesanan;
    }
}
