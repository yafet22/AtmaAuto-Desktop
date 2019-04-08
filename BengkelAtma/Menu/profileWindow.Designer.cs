namespace BengkelAtma.Menu
{
    partial class profileWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profile1 = new BengkelAtma.Menu.Profile();
            this.SuspendLayout();
            // 
            // profile1
            // 
            this.profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile1.Location = new System.Drawing.Point(0, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(800, 450);
            this.profile1.TabIndex = 0;
            // 
            // profileWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profile1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.profileWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Profile profile1;
    }
}