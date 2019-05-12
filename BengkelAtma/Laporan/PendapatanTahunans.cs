using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengkelAtma.Laporan
{
    public partial class PendapatanTahunans : UserControl
    {
        public PendapatanTahunans()
        {
            InitializeComponent();
        }

        private void btnLaporanPThn_Click(object sender, EventArgs e)
        {
            FormReportPendapatanTahunan PendapatanTahunanForm = new FormReportPendapatanTahunan();
            PendapatanTahunanForm.Show();
        }
    }
}
