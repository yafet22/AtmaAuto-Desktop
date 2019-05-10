namespace BengkelAtma.Menu
{
    partial class menuJasa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewJasa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgContainer = new MetroFramework.Controls.MetroPanel();
            this.dgJasa = new MetroFramework.Controls.MetroGrid();
            this.findHeader = new MetroFramework.Controls.MetroPanel();
            this.btnCariJasa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariJasa = new System.Windows.Forms.TextBox();
            this.bootomContent = new MetroFramework.Controls.MetroPanel();
            this.btnEditJasa = new System.Windows.Forms.Button();
            this.btnDeleteJasa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbHrgJasa = new System.Windows.Forms.TextBox();
            this.tbLynJasa = new System.Windows.Forms.TextBox();
            this.btnSimpanJasa = new System.Windows.Forms.Button();
            this.btnResetJasa = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgJasa)).BeginInit();
            this.findHeader.SuspendLayout();
            this.bootomContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Layanan";
            // 
            // btnNewJasa
            // 
            this.btnNewJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnNewJasa.Location = new System.Drawing.Point(9, 0);
            this.btnNewJasa.Name = "btnNewJasa";
            this.btnNewJasa.Size = new System.Drawing.Size(75, 23);
            this.btnNewJasa.TabIndex = 2;
            this.btnNewJasa.Text = "Input";
            this.btnNewJasa.UseVisualStyleBackColor = false;
            this.btnNewJasa.Click += new System.EventHandler(this.btnNewJasa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 400);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgContainer);
            this.panel1.Controls.Add(this.findHeader);
            this.panel1.Controls.Add(this.bootomContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 400);
            this.panel1.TabIndex = 0;
            // 
            // dgContainer
            // 
            this.dgContainer.BackColor = System.Drawing.Color.White;
            this.dgContainer.Controls.Add(this.dgJasa);
            this.dgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgContainer.HorizontalScrollbarBarColor = true;
            this.dgContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.dgContainer.HorizontalScrollbarSize = 10;
            this.dgContainer.Location = new System.Drawing.Point(0, 82);
            this.dgContainer.Name = "dgContainer";
            this.dgContainer.Padding = new System.Windows.Forms.Padding(10);
            this.dgContainer.Size = new System.Drawing.Size(320, 218);
            this.dgContainer.TabIndex = 15;
            this.dgContainer.VerticalScrollbarBarColor = true;
            this.dgContainer.VerticalScrollbarHighlightOnWheel = false;
            this.dgContainer.VerticalScrollbarSize = 10;
            // 
            // dgJasa
            // 
            this.dgJasa.AllowUserToResizeRows = false;
            this.dgJasa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgJasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgJasa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgJasa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJasa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgJasa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgJasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgJasa.EnableHeadersVisualStyles = false;
            this.dgJasa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgJasa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgJasa.Location = new System.Drawing.Point(10, 10);
            this.dgJasa.Name = "dgJasa";
            this.dgJasa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgJasa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgJasa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgJasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgJasa.Size = new System.Drawing.Size(300, 198);
            this.dgJasa.TabIndex = 14;
            // 
            // findHeader
            // 
            this.findHeader.BackColor = System.Drawing.Color.White;
            this.findHeader.Controls.Add(this.btnCariJasa);
            this.findHeader.Controls.Add(this.label1);
            this.findHeader.Controls.Add(this.tbCariJasa);
            this.findHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.findHeader.HorizontalScrollbarBarColor = true;
            this.findHeader.HorizontalScrollbarHighlightOnWheel = false;
            this.findHeader.HorizontalScrollbarSize = 10;
            this.findHeader.Location = new System.Drawing.Point(0, 0);
            this.findHeader.Name = "findHeader";
            this.findHeader.Size = new System.Drawing.Size(320, 82);
            this.findHeader.TabIndex = 16;
            this.findHeader.VerticalScrollbarBarColor = true;
            this.findHeader.VerticalScrollbarHighlightOnWheel = false;
            this.findHeader.VerticalScrollbarSize = 10;
            // 
            // btnCariJasa
            // 
            this.btnCariJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnCariJasa.Location = new System.Drawing.Point(225, 53);
            this.btnCariJasa.Name = "btnCariJasa";
            this.btnCariJasa.Size = new System.Drawing.Size(75, 23);
            this.btnCariJasa.TabIndex = 11;
            this.btnCariJasa.Text = "Cari";
            this.btnCariJasa.UseVisualStyleBackColor = false;
            this.btnCariJasa.Click += new System.EventHandler(this.btnCariJasa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Layanan Jasa:";
            // 
            // tbCariJasa
            // 
            this.tbCariJasa.Location = new System.Drawing.Point(15, 55);
            this.tbCariJasa.Name = "tbCariJasa";
            this.tbCariJasa.Size = new System.Drawing.Size(201, 20);
            this.tbCariJasa.TabIndex = 10;
            // 
            // bootomContent
            // 
            this.bootomContent.BackColor = System.Drawing.Color.White;
            this.bootomContent.Controls.Add(this.btnNewJasa);
            this.bootomContent.Controls.Add(this.btnEditJasa);
            this.bootomContent.Controls.Add(this.btnDeleteJasa);
            this.bootomContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bootomContent.HorizontalScrollbarBarColor = true;
            this.bootomContent.HorizontalScrollbarHighlightOnWheel = false;
            this.bootomContent.HorizontalScrollbarSize = 10;
            this.bootomContent.Location = new System.Drawing.Point(0, 300);
            this.bootomContent.Name = "bootomContent";
            this.bootomContent.Size = new System.Drawing.Size(320, 100);
            this.bootomContent.TabIndex = 14;
            this.bootomContent.VerticalScrollbarBarColor = true;
            this.bootomContent.VerticalScrollbarHighlightOnWheel = false;
            this.bootomContent.VerticalScrollbarSize = 10;
            // 
            // btnEditJasa
            // 
            this.btnEditJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditJasa.Location = new System.Drawing.Point(90, 0);
            this.btnEditJasa.Name = "btnEditJasa";
            this.btnEditJasa.Size = new System.Drawing.Size(75, 23);
            this.btnEditJasa.TabIndex = 0;
            this.btnEditJasa.Text = "Edit";
            this.btnEditJasa.UseVisualStyleBackColor = false;
            this.btnEditJasa.Click += new System.EventHandler(this.btnEditJasa_Click);
            // 
            // btnDeleteJasa
            // 
            this.btnDeleteJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnDeleteJasa.Location = new System.Drawing.Point(171, 0);
            this.btnDeleteJasa.Name = "btnDeleteJasa";
            this.btnDeleteJasa.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteJasa.TabIndex = 1;
            this.btnDeleteJasa.Text = "Hapus";
            this.btnDeleteJasa.UseVisualStyleBackColor = false;
            this.btnDeleteJasa.Click += new System.EventHandler(this.btnDeleteJasa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbHrgJasa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbLynJasa);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSimpanJasa);
            this.panel2.Controls.Add(this.btnResetJasa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 400);
            this.panel2.TabIndex = 1;
            // 
            // tbHrgJasa
            // 
            this.tbHrgJasa.Location = new System.Drawing.Point(29, 135);
            this.tbHrgJasa.Name = "tbHrgJasa";
            this.tbHrgJasa.Size = new System.Drawing.Size(236, 20);
            this.tbHrgJasa.TabIndex = 13;
            // 
            // tbLynJasa
            // 
            this.tbLynJasa.Location = new System.Drawing.Point(29, 92);
            this.tbLynJasa.Name = "tbLynJasa";
            this.tbLynJasa.Size = new System.Drawing.Size(236, 20);
            this.tbLynJasa.TabIndex = 11;
            this.tbLynJasa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLynJasa_KeyDown);
            // 
            // btnSimpanJasa
            // 
            this.btnSimpanJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnSimpanJasa.Location = new System.Drawing.Point(112, 174);
            this.btnSimpanJasa.Name = "btnSimpanJasa";
            this.btnSimpanJasa.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanJasa.TabIndex = 3;
            this.btnSimpanJasa.Text = "Simpan";
            this.btnSimpanJasa.UseVisualStyleBackColor = false;
            this.btnSimpanJasa.Click += new System.EventHandler(this.btnSimpanJasa_Click);
            // 
            // btnResetJasa
            // 
            this.btnResetJasa.BackColor = System.Drawing.Color.LightBlue;
            this.btnResetJasa.Location = new System.Drawing.Point(29, 174);
            this.btnResetJasa.Name = "btnResetJasa";
            this.btnResetJasa.Size = new System.Drawing.Size(75, 23);
            this.btnResetJasa.TabIndex = 2;
            this.btnResetJasa.Text = "Reset";
            this.btnResetJasa.UseVisualStyleBackColor = false;
            this.btnResetJasa.Click += new System.EventHandler(this.btnResetJasa_Click);
            // 
            // menuJasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "menuJasa";
            this.Size = new System.Drawing.Size(600, 400);
            this.Load += new System.EventHandler(this.menuJasa_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.dgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgJasa)).EndInit();
            this.findHeader.ResumeLayout(false);
            this.findHeader.PerformLayout();
            this.bootomContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewJasa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel dgContainer;
        private MetroFramework.Controls.MetroPanel findHeader;
        private System.Windows.Forms.Button btnCariJasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCariJasa;
        private MetroFramework.Controls.MetroPanel bootomContent;
        private System.Windows.Forms.Button btnEditJasa;
        private System.Windows.Forms.Button btnDeleteJasa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbHrgJasa;
        private System.Windows.Forms.TextBox tbLynJasa;
        private System.Windows.Forms.Button btnSimpanJasa;
        private System.Windows.Forms.Button btnResetJasa;
        private MetroFramework.Controls.MetroGrid dgJasa;
    }
}
