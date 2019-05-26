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
    public partial class JasaTerlarissx : Form
    {
        jasa js = new jasa();
        private string tahun;
        private string bulan;
        public JasaTerlarissx(string tahun, string bulan)
        {
            InitializeComponent();
            this.tahun = tahun;
            this.bulan = bulan;
        }

        public class JasaTerlarisxx
        {
            public string motorcycle_brand_name { get; set; }
            public string motorcycle_type_name { get; set; }
            public string service_name { get; set; }
            public int jumlah_jasa { get; set; }
        }

        public void getDataJasa()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://p3l.yafetrakan.com/api/service-selling/" +tahun + "/" + bulan).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<JasaTerlarisxx>>(a);
                List<JasaTerlarisxx> listJasaTerlarisz = result;
                js.Database.Tables["JasaTerlariss"].SetDataSource(listJasaTerlarisz);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void JasaTerlarissx_Load(object sender, EventArgs e)
        {
            getDataJasa();
            crystalReportViewer1.ReportSource = js;
        }
    }
}
