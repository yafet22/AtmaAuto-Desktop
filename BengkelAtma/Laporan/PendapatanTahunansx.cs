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
    public partial class PendapatanTahunansx : Form
    {
        PendapatanBulanan pth = new PendapatanBulanan();
        public PendapatanTahunansx()
        {
            InitializeComponent();
        }

        public class PendapatanTahunan
        {
            public string Tahun { get; set; }
            public string Cabang { get; set; }
            public double Total { get; set; }
        }

        public void getDataPTahunan()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://192.168.19.140/8991/api/transaction-by-branch").Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<PendapatanTahunan>>(a);
                List<PendapatanTahunan> listPendapatanTahunan = result;
                pth.Database.Tables["PenTahunanNew"].SetDataSource(listPendapatanTahunan);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PendapatanTahunansx_Load(object sender, EventArgs e)
        {
            getDataPTahunan();
            crystalReportViewer1.ReportSource = pth;
        }
    }
}
