﻿using System;
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
    public partial class PendapatanBulanans : UserControl
    {
        public PendapatanBulanans()
        {
            InitializeComponent();
        }

        private void btnLaporanPenBul_Click(object sender, EventArgs e)
        {
            FormReportPendapatanBulanan PendapatanBulananForm = new FormReportPendapatanBulanan();
            PendapatanBulananForm.Show();
        }
    }
}
