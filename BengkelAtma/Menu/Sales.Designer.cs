namespace BengkelAtma.Menu
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1Luar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5DataGrid = new System.Windows.Forms.Panel();
            this.panel4bottom = new System.Windows.Forms.Panel();
            this.btnNewSales = new System.Windows.Forms.Button();
            this.btnEditSales = new System.Windows.Forms.Button();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.panel3Top = new System.Windows.Forms.Panel();
            this.btnCariSales = new System.Windows.Forms.Button();
            this.label1CariNama = new System.Windows.Forms.Label();
            this.tbCariSales = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.tbNoTelpSales = new System.Windows.Forms.TextBox();
            this.label2Telepon = new System.Windows.Forms.Label();
            this.tbNamaSales = new System.Windows.Forms.TextBox();
            this.label3Nama = new System.Windows.Forms.Label();
            this.btnSimpanSales = new System.Windows.Forms.Button();
            this.btnResetSales = new System.Windows.Forms.Button();
            this.dgSales = new MetroFramework.Controls.MetroGrid();
            this.panel1Luar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5DataGrid.SuspendLayout();
            this.panel4bottom.SuspendLayout();
            this.panel3Top.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1Luar
            // 
            this.panel1Luar.Controls.Add(this.panel2);
            this.panel1Luar.Controls.Add(this.panel1);
            this.panel1Luar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Luar.Location = new System.Drawing.Point(0, 0);
            this.panel1Luar.Name = "panel1Luar";
            this.panel1Luar.Size = new System.Drawing.Size(600, 400);
            this.panel1Luar.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5DataGrid);
            this.panel2.Controls.Add(this.panel4bottom);
            this.panel2.Controls.Add(this.panel3Top);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(280, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 400);
            this.panel2.TabIndex = 1;
            // 
            // panel5DataGrid
            // 
            this.panel5DataGrid.BackColor = System.Drawing.Color.White;
            this.panel5DataGrid.Controls.Add(this.dgSales);
            this.panel5DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5DataGrid.Location = new System.Drawing.Point(0, 82);
            this.panel5DataGrid.Name = "panel5DataGrid";
            this.panel5DataGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panel5DataGrid.Size = new System.Drawing.Size(320, 218);
            this.panel5DataGrid.TabIndex = 2;
            // 
            // panel4bottom
            // 
            this.panel4bottom.BackColor = System.Drawing.Color.White;
            this.panel4bottom.Controls.Add(this.btnNewSales);
            this.panel4bottom.Controls.Add(this.btnEditSales);
            this.panel4bottom.Controls.Add(this.btnDeleteSales);
            this.panel4bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4bottom.Location = new System.Drawing.Point(0, 300);
            this.panel4bottom.Name = "panel4bottom";
            this.panel4bottom.Size = new System.Drawing.Size(320, 100);
            this.panel4bottom.TabIndex = 1;
            // 
            // btnNewSales
            // 
            this.btnNewSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnNewSales.Location = new System.Drawing.Point(11, 0);
            this.btnNewSales.Name = "btnNewSales";
            this.btnNewSales.Size = new System.Drawing.Size(75, 23);
            this.btnNewSales.TabIndex = 5;
            this.btnNewSales.Text = "Input";
            this.btnNewSales.UseVisualStyleBackColor = false;
            this.btnNewSales.Click += new System.EventHandler(this.btnNewSales_Click);
            // 
            // btnEditSales
            // 
            this.btnEditSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditSales.Location = new System.Drawing.Point(92, 0);
            this.btnEditSales.Name = "btnEditSales";
            this.btnEditSales.Size = new System.Drawing.Size(75, 23);
            this.btnEditSales.TabIndex = 3;
            this.btnEditSales.Text = "Edit";
            this.btnEditSales.UseVisualStyleBackColor = false;
            this.btnEditSales.Click += new System.EventHandler(this.btnEditSales_Click);
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteSales.Location = new System.Drawing.Point(173, 0);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSales.TabIndex = 4;
            this.btnDeleteSales.Text = "Hapus";
            this.btnDeleteSales.UseVisualStyleBackColor = false;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // panel3Top
            // 
            this.panel3Top.BackColor = System.Drawing.Color.White;
            this.panel3Top.Controls.Add(this.btnCariSales);
            this.panel3Top.Controls.Add(this.label1CariNama);
            this.panel3Top.Controls.Add(this.tbCariSales);
            this.panel3Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3Top.Location = new System.Drawing.Point(0, 0);
            this.panel3Top.Name = "panel3Top";
            this.panel3Top.Size = new System.Drawing.Size(320, 82);
            this.panel3Top.TabIndex = 0;
            // 
            // btnCariSales
            // 
            this.btnCariSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnCariSales.Location = new System.Drawing.Point(225, 53);
            this.btnCariSales.Name = "btnCariSales";
            this.btnCariSales.Size = new System.Drawing.Size(75, 23);
            this.btnCariSales.TabIndex = 14;
            this.btnCariSales.Text = "Cari";
            this.btnCariSales.UseVisualStyleBackColor = false;
            this.btnCariSales.Click += new System.EventHandler(this.btnCariSales_Click);
            // 
            // label1CariNama
            // 
            this.label1CariNama.AutoSize = true;
            this.label1CariNama.BackColor = System.Drawing.Color.White;
            this.label1CariNama.Location = new System.Drawing.Point(12, 39);
            this.label1CariNama.Name = "label1CariNama";
            this.label1CariNama.Size = new System.Drawing.Size(67, 13);
            this.label1CariNama.TabIndex = 15;
            this.label1CariNama.Text = "Nama Sales:";
            // 
            // tbCariSales
            // 
            this.tbCariSales.Location = new System.Drawing.Point(15, 55);
            this.tbCariSales.Name = "tbCariSales";
            this.tbCariSales.Size = new System.Drawing.Size(201, 20);
            this.tbCariSales.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.tbNoTelpSales);
            this.panel1.Controls.Add(this.label2Telepon);
            this.panel1.Controls.Add(this.tbNamaSales);
            this.panel1.Controls.Add(this.label3Nama);
            this.panel1.Controls.Add(this.btnSimpanSales);
            this.panel1.Controls.Add(this.btnResetSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 400);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(29, 182);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(236, 21);
            this.cbSupplier.TabIndex = 20;
            // 
            // tbNoTelpSales
            // 
            this.tbNoTelpSales.Location = new System.Drawing.Point(29, 135);
            this.tbNoTelpSales.Name = "tbNoTelpSales";
            this.tbNoTelpSales.Size = new System.Drawing.Size(236, 20);
            this.tbNoTelpSales.TabIndex = 19;
            // 
            // label2Telepon
            // 
            this.label2Telepon.AutoSize = true;
            this.label2Telepon.Location = new System.Drawing.Point(26, 119);
            this.label2Telepon.Name = "label2Telepon";
            this.label2Telepon.Size = new System.Drawing.Size(80, 13);
            this.label2Telepon.TabIndex = 18;
            this.label2Telepon.Text = "Nomor Telepon";
            // 
            // tbNamaSales
            // 
            this.tbNamaSales.Location = new System.Drawing.Point(29, 92);
            this.tbNamaSales.Name = "tbNamaSales";
            this.tbNamaSales.Size = new System.Drawing.Size(236, 20);
            this.tbNamaSales.TabIndex = 17;
            // 
            // label3Nama
            // 
            this.label3Nama.AutoSize = true;
            this.label3Nama.Location = new System.Drawing.Point(26, 76);
            this.label3Nama.Name = "label3Nama";
            this.label3Nama.Size = new System.Drawing.Size(38, 13);
            this.label3Nama.TabIndex = 16;
            this.label3Nama.Text = "Nama ";
            // 
            // btnSimpanSales
            // 
            this.btnSimpanSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnSimpanSales.Location = new System.Drawing.Point(112, 217);
            this.btnSimpanSales.Name = "btnSimpanSales";
            this.btnSimpanSales.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanSales.TabIndex = 15;
            this.btnSimpanSales.Text = "Simpan";
            this.btnSimpanSales.UseVisualStyleBackColor = false;
            this.btnSimpanSales.Click += new System.EventHandler(this.btnSimpanSales_Click);
            // 
            // btnResetSales
            // 
            this.btnResetSales.BackColor = System.Drawing.Color.LightBlue;
            this.btnResetSales.Location = new System.Drawing.Point(29, 217);
            this.btnResetSales.Name = "btnResetSales";
            this.btnResetSales.Size = new System.Drawing.Size(75, 23);
            this.btnResetSales.TabIndex = 14;
            this.btnResetSales.Text = "Reset";
            this.btnResetSales.UseVisualStyleBackColor = false;
            this.btnResetSales.Click += new System.EventHandler(this.btnResetSales_Click);
            // 
            // dgSales
            // 
            this.dgSales.AllowUserToResizeRows = false;
            this.dgSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSales.EnableHeadersVisualStyles = false;
            this.dgSales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgSales.Location = new System.Drawing.Point(10, 10);
            this.dgSales.Name = "dgSales";
            this.dgSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSales.Size = new System.Drawing.Size(300, 198);
            this.dgSales.TabIndex = 1;
            this.dgSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSales_CellClick);
            this.dgSales.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgSales_UserDeletingRow);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1Luar);
            this.Name = "Sales";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1Luar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5DataGrid.ResumeLayout(false);
            this.panel4bottom.ResumeLayout(false);
            this.panel3Top.ResumeLayout(false);
            this.panel3Top.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Luar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5DataGrid;
        private System.Windows.Forms.Panel panel4bottom;
        private System.Windows.Forms.Panel panel3Top;
        private System.Windows.Forms.TextBox tbNoTelpSales;
        private System.Windows.Forms.Label label2Telepon;
        private System.Windows.Forms.TextBox tbNamaSales;
        private System.Windows.Forms.Label label3Nama;
        private System.Windows.Forms.Button btnSimpanSales;
        private System.Windows.Forms.Button btnResetSales;
        private System.Windows.Forms.Button btnCariSales;
        private System.Windows.Forms.Label label1CariNama;
        private System.Windows.Forms.TextBox tbCariSales;
        private System.Windows.Forms.Button btnNewSales;
        private System.Windows.Forms.Button btnEditSales;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSupplier;
        private MetroFramework.Controls.MetroGrid dgSales;
    }
}
