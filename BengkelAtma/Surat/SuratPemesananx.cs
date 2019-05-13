using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelAtma.Surat
{
    public partial class SuratPemesananx : UserControl
    {
        public SuratPemesananx()
        {
            InitializeComponent();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            FormSP SPForm = new FormSP();
            SPForm.Show();
        }
    }
}
