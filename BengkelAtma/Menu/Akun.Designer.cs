namespace BengkelAtma.Menu
{
    partial class Akun
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
            this.dgContainer = new MetroFramework.Controls.MetroPanel();
            this.dgAkun = new System.Windows.Forms.DataGridView();
            this.findHeader = new MetroFramework.Controls.MetroPanel();
            this.btnCariAkun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCariAkun = new System.Windows.Forms.TextBox();
            this.bootomContent = new MetroFramework.Controls.MetroPanel();
            this.btnEditAkun = new System.Windows.Forms.Button();
            this.btnDeleteAkun = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNewPassAkun = new System.Windows.Forms.TextBox();
            this.newPass = new System.Windows.Forms.Label();
            this.tbOldPassAkun = new System.Windows.Forms.TextBox();
            this.oldPass = new System.Windows.Forms.Label();
            this.btnSimpanAkun = new System.Windows.Forms.Button();
            this.btnResetAkun = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.dgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).BeginInit();
            this.findHeader.SuspendLayout();
            this.bootomContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.dgContainer.Controls.Add(this.dgAkun);
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
            // dgAkun
            // 
            this.dgAkun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAkun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAkun.Location = new System.Drawing.Point(10, 10);
            this.dgAkun.Name = "dgAkun";
            this.dgAkun.Size = new System.Drawing.Size(300, 198);
            this.dgAkun.TabIndex = 13;
            // 
            // findHeader
            // 
            this.findHeader.BackColor = System.Drawing.Color.White;
            this.findHeader.Controls.Add(this.btnCariAkun);
            this.findHeader.Controls.Add(this.label1);
            this.findHeader.Controls.Add(this.tbCariAkun);
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
            // btnCariAkun
            // 
            this.btnCariAkun.Location = new System.Drawing.Point(225, 53);
            this.btnCariAkun.Name = "btnCariAkun";
            this.btnCariAkun.Size = new System.Drawing.Size(49, 23);
            this.btnCariAkun.TabIndex = 11;
            this.btnCariAkun.Text = "Cari";
            this.btnCariAkun.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username Akun:";
            // 
            // tbCariAkun
            // 
            this.tbCariAkun.Location = new System.Drawing.Point(15, 55);
            this.tbCariAkun.Name = "tbCariAkun";
            this.tbCariAkun.Size = new System.Drawing.Size(201, 20);
            this.tbCariAkun.TabIndex = 10;
            // 
            // bootomContent
            // 
            this.bootomContent.BackColor = System.Drawing.Color.White;
            this.bootomContent.Controls.Add(this.btnEditAkun);
            this.bootomContent.Controls.Add(this.btnDeleteAkun);
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
            // btnEditAkun
            // 
            this.btnEditAkun.Location = new System.Drawing.Point(15, 0);
            this.btnEditAkun.Name = "btnEditAkun";
            this.btnEditAkun.Size = new System.Drawing.Size(75, 23);
            this.btnEditAkun.TabIndex = 0;
            this.btnEditAkun.Text = "Edit";
            this.btnEditAkun.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAkun
            // 
            this.btnDeleteAkun.Location = new System.Drawing.Point(96, 0);
            this.btnDeleteAkun.Name = "btnDeleteAkun";
            this.btnDeleteAkun.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAkun.TabIndex = 1;
            this.btnDeleteAkun.Text = "Hapus";
            this.btnDeleteAkun.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbNewPassAkun);
            this.panel2.Controls.Add(this.newPass);
            this.panel2.Controls.Add(this.tbOldPassAkun);
            this.panel2.Controls.Add(this.oldPass);
            this.panel2.Controls.Add(this.btnSimpanAkun);
            this.panel2.Controls.Add(this.btnResetAkun);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 400);
            this.panel2.TabIndex = 1;
            // 
            // tbNewPassAkun
            // 
            this.tbNewPassAkun.Location = new System.Drawing.Point(29, 135);
            this.tbNewPassAkun.Name = "tbNewPassAkun";
            this.tbNewPassAkun.Size = new System.Drawing.Size(236, 20);
            this.tbNewPassAkun.TabIndex = 9;
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Location = new System.Drawing.Point(26, 119);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(78, 13);
            this.newPass.TabIndex = 8;
            this.newPass.Text = "Password Baru";
            // 
            // tbOldPassAkun
            // 
            this.tbOldPassAkun.Location = new System.Drawing.Point(29, 92);
            this.tbOldPassAkun.Name = "tbOldPassAkun";
            this.tbOldPassAkun.Size = new System.Drawing.Size(236, 20);
            this.tbOldPassAkun.TabIndex = 7;
            // 
            // oldPass
            // 
            this.oldPass.AutoSize = true;
            this.oldPass.Location = new System.Drawing.Point(26, 76);
            this.oldPass.Name = "oldPass";
            this.oldPass.Size = new System.Drawing.Size(82, 13);
            this.oldPass.TabIndex = 4;
            this.oldPass.Text = "Password Lama";
            // 
            // btnSimpanAkun
            // 
            this.btnSimpanAkun.Location = new System.Drawing.Point(111, 183);
            this.btnSimpanAkun.Name = "btnSimpanAkun";
            this.btnSimpanAkun.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanAkun.TabIndex = 3;
            this.btnSimpanAkun.Text = "Simpan";
            this.btnSimpanAkun.UseVisualStyleBackColor = true;
            // 
            // btnResetAkun
            // 
            this.btnResetAkun.Location = new System.Drawing.Point(28, 183);
            this.btnResetAkun.Name = "btnResetAkun";
            this.btnResetAkun.Size = new System.Drawing.Size(75, 23);
            this.btnResetAkun.TabIndex = 2;
            this.btnResetAkun.Text = "Reset";
            this.btnResetAkun.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 400);
            this.panel3.TabIndex = 11;
            // 
            // Akun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "Akun";
            this.Size = new System.Drawing.Size(600, 400);
            this.panel1.ResumeLayout(false);
            this.dgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAkun)).EndInit();
            this.findHeader.ResumeLayout(false);
            this.findHeader.PerformLayout();
            this.bootomContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label oldPass;
        private System.Windows.Forms.Button btnSimpanAkun;
        private System.Windows.Forms.Button btnResetAkun;
        private System.Windows.Forms.Button btnDeleteAkun;
        private System.Windows.Forms.Button btnEditAkun;
        private System.Windows.Forms.TextBox tbNewPassAkun;
        private System.Windows.Forms.Label newPass;
        private System.Windows.Forms.TextBox tbOldPassAkun;
        private System.Windows.Forms.DataGridView dgAkun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCariAkun;
        private System.Windows.Forms.TextBox tbCariAkun;
        private MetroFramework.Controls.MetroPanel findHeader;
        private MetroFramework.Controls.MetroPanel dgContainer;
        private MetroFramework.Controls.MetroPanel bootomContent;
        private System.Windows.Forms.Panel panel3;
    }
}
