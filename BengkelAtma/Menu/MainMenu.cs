using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BengkelAtma.Laporan;
using BengkelAtma.Menu;
using Newtonsoft.Json.Linq;

namespace BengkelAtma
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
            disableProfil();
            //disableHome();

        }

        public void enableHome() {
            metroPanel1.Show();
           
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        public void disableHome()
        {
            metroPanel1.Hide();
        }

        public void enableProfil()
        {
           // profile1.Show();
            //CenterControlInParent(profile1);
           
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //    profileWindow p = new profileWindow();
            //    p.Show();
            //
        }

        public void disableProfil()
        {
            //profile1.Hide();
            //profileWindow p = new profileWindow();
            //p.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            enableHome();
            disableProfil();
        }

        private void btnProfil_MouseClick(object sender, MouseEventArgs e)
        {
            disableHome();
            enableProfil();


            
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin Ingin keluar dari sistem?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Application.Restart();
                }
                else { }
            }
            catch
            {
                MessageBox.Show("Keluar, dibatalkan.");
            }
        }


        private void btnProfil_Click(object sender, EventArgs e)
        {

        }

        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        
    }
}
