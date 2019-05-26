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
    public partial class LaporanTampilan : UserControl
    {
        public LaporanTampilan()
        {
            InitializeComponent();
        }

        private void btnSparepartTerlaris_Click(object sender, EventArgs e)
        {
            FormSprprtTr SparepartsForm = new FormSprprtTr(tbPilihTahun.Text);
            SparepartsForm.Show();
        }

        private void btnJasa_Click(object sender, EventArgs e)
        {
            JasaTerlarissx JasaForm = new JasaTerlarissx(tbPilihTahun.Text, tbBulanLaporan.Text);
            JasaForm.Show();
        }

        private void btnLaporanSisa_Click(object sender, EventArgs e)
        {
            SisaStocksx SisaStockForm = new SisaStocksx(tbPilihTahun.Text, tbTipeBarang.Text);
            SisaStockForm.Show();
        }

        private void btnLaporanPBul_Click(object sender, EventArgs e)
        {
            PendapatanBulanansx PendapatanBulananForm = new PendapatanBulanansx(tbPilihTahun.Text);
            PendapatanBulananForm.Show();
        }

        private void btnLaporanPThn_Click(object sender, EventArgs e)
        {
            PendapatanTahunansx PendapatanTahunanForm = new PendapatanTahunansx();
            PendapatanTahunanForm.Show();
        }

        private void btnLaporanPenBul_Click(object sender, EventArgs e)
        {
            PengeluaranBulanansx PengeluaranBulananForm = new PengeluaranBulanansx(tbPilihTahun.Text);
            PengeluaranBulananForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

