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
    public partial class SuratPerintahKerjax : UserControl
    {
        public SuratPerintahKerjax()
        {
            InitializeComponent();
        }

        private void btnSPK_Click(object sender, EventArgs e)
        {
            FormSPK SPKForm = new FormSPK();
            SPKForm.Show();
        }
    }
}
