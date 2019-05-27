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
    public partial class PendapatanBulanansx : Form
    {
        PendapatanTahunan pt = new PendapatanTahunan();
        private string tahun;
        public PendapatanBulanansx(string tahun)
        {
            InitializeComponent();
            this.tahun = tahun;
        }

        public class PendapatanBulanan
        {
            public string Bulan { get; set; }
            public int Sparepart { get; set; }
            public int Service { get; set; }
            public int Total { get; set; }
        }

        public void getDataPenBul()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://192.168.19.140/8991/api/transaction-per-year/" + tahun).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<PendapatanBulanan>>(a);
                List<PendapatanBulanan> listPendapatanBulanan = result;
                pt.Database.Tables["PendBulananNew"].SetDataSource(listPendapatanBulanan);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PendapatanBulanansx_Load(object sender, EventArgs e)
        {
            getDataPenBul();
            crystalReportViewer1.ReportSource = pt;
        }
    }
}
