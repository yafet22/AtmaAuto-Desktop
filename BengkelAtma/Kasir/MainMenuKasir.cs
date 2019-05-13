using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelAtma.Kasir
{
    public partial class MainMenuKasir : Form
    {
        public MainMenuKasir()
        {
            InitializeComponent();
        }

        private void btnKeluarKasir_Click(object sender, EventArgs e)
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

        
    }
}
