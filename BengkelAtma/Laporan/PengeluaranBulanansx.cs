﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Net.Http;

namespace BengkelAtma.Laporan
{
    public partial class PengeluaranBulanansx : Form
    {
        PengeluaranBulanan pb = new PengeluaranBulanan();
        private string tahun;
        public PengeluaranBulanansx(string tahun)
        {
            
            InitializeComponent();
            this.tahun = tahun;
        }
        public class PBulanan
        {
            public string Bulan { get; set; }
            public double Total { get; set; }
        }

        public void getDataPengBul()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://192.168.19.140/8991/api/expense-per-year/" + tahun).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<PBulanan>>(a);
                List<PBulanan> listPengeluaranBulanan = result;
                pb.Database.Tables["PengBulNew"].SetDataSource(listPengeluaranBulanan);
            }
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PengeluaranBulanansx_Load(object sender, EventArgs e)
        {
            getDataPengBul();
            crystalReportViewer1.ReportSource = pb;
        }
    }
}
