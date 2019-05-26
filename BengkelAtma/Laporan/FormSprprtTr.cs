
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

    public partial class FormSprprtTr : Form
    {
        Sprpat sp = new Sprpat();
        private string tahun;
        public FormSprprtTr(string tahun)
        {
            this.tahun = tahun;
            InitializeComponent();
        }

        public class SparepartsTer
        {
            public string Bulan { get; set; }
            public string NamaBarang { get; set; }
            public string TipeBarang { get; set; }
            public string JumlahPenjualan { get; set; }
             
        }

        public void getData()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://p3l.yafetrakan.com/api/best-seller-sparepart/" +tahun).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<SparepartsTer>>(a);
                List<SparepartsTer> listSpareparts = result;
                sp.Database.Tables["SparepartNew"].SetDataSource(listSpareparts);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormSprprtTr_Load(object sender, EventArgs e)
        {
            getData();
            crystalReportViewer1.ReportSource = sp;
        }
    }
}

