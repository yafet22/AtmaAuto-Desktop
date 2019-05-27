using System;
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
    public partial class SisaStocksx : Form
    {
        SisaStock ss = new SisaStock();
        private string tahun;
        private string tipebarang;
        public SisaStocksx(string tahun, string tipebarang)
        {
            InitializeComponent();
            this.tahun = tahun;
            this.tipebarang = tipebarang;
        }

        public class SisaStockx
        {
            public string Bulan { get; set; }
            public int JumlahStokSisa { get; set; }
        }

        public void getDataSisa()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://192.168.19.140/8991/api/remaining-stock/" + tahun + "/" + tipebarang).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<SisaStockx>>(a);
                List<SisaStockx> listSisaStok = result;
                ss.Database.Tables["SisaStockNew"].SetDataSource(listSisaStok);
            }
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void SisaStocksx_Load(object sender, EventArgs e)
        {
            getDataSisa();
            crystalReportViewer1.ReportSource = ss;
        }
    }
}
