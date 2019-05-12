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
    public partial class PengeluaranBulanans : UserControl
    {
        public PengeluaranBulanans()
        {
            InitializeComponent();
        }

        private void btnLaporanPBul_Click(object sender, EventArgs e)
        {
            FormReportPengeluaranBulanan PengeluaranBulananForm = new FormReportPengeluaranBulanan();
            PengeluaranBulananForm.Show();
        }
    }
}
