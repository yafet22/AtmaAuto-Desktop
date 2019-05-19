namespace BengkelAtma.Surat
{
    partial class SuratPerintahKerjax
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
            this.btnSPK = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnSPK, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSP, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSPK
            // 
            this.btnSPK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSPK.Location = new System.Drawing.Point(3, 115);
            this.btnSPK.Name = "btnSPK";
            this.btnSPK.Size = new System.Drawing.Size(294, 106);
            this.btnSPK.TabIndex = 0;
            this.btnSPK.Text = "Surat Perintah Kerja";
            this.btnSPK.UseVisualStyleBackColor = true;
            // 
            // btnSP
            // 
            this.btnSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSP.Location = new System.Drawing.Point(303, 115);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(294, 106);
            this.btnSP.TabIndex = 1;
            this.btnSP.Text = "Surat Pemesanan";
            this.btnSP.UseVisualStyleBackColor = true;
            // 
            // SuratPerintahKerjax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SuratPerintahKerjax";
            this.Size = new System.Drawing.Size(600, 400);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSPK;
        private System.Windows.Forms.Button btnSP;
    }
}
