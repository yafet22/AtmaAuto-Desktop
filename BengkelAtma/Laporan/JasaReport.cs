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
    public partial class JasaReport : UserControl
    {
        public JasaReport()
        {
            InitializeComponent();
        }

        private void btnLaporanJasa_Click(object sender, EventArgs e)
        {
            FormReportJasa JasaForm = new FormReportJasa();
            JasaForm.Show();
        }
    }
}
