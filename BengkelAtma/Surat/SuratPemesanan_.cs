using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace BengkelAtma.Surat
{
    public partial class SuratPemesanan_ : UserControl
    {

        private static readonly HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public SuratPemesanan_()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        private async void SuratPemesanan__Load(object sender, EventArgs e)
        {
            

            DataTable t = await GetSP();
           
            dgPemesanan.DataSource = t;
            dgPemesanan.Columns[dgPemesanan.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgPemesanan.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }

        static async Task<DataTable> GetSP()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/procurements");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            JObject json_object = JObject.Parse(a);
            dt = JsonConvert.DeserializeObject<DataTable>(json_object.GetValue("data").ToString());
            //dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);

            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }
    }
}
