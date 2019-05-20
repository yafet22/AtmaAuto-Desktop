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
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using BengkelAtma.Surat;

namespace BengkelAtma.Menu
{
    public partial class SuratSPK : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        public SuratSPK()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        static async Task<DataTable> GetTransaction()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/transactions");
            Console.WriteLine($"cek masukggg");
            var a = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);

            DataTable dt = new DataTable();
            Console.WriteLine($"cek masuk2");
            JArray json_array = JArray.Parse(json_object["data"].ToString());
            Console.WriteLine(json_array);
            json_array.Descendants().OfType<JProperty>()
                  .Where(p => p.Name == "service")
                  .ToList()
                  .ForEach(att => att.Remove());
            json_array.Descendants().OfType<JProperty>()
                  .Where(p => p.Name == "sparepart")
                  .ToList()
                  .ForEach(att => att.Remove());
            json_array.Descendants().OfType<JProperty>()
                 .Where(p => p.Name == "employee")
                 .ToList()
                 .ForEach(att => att.Remove());
            Console.WriteLine(json_array);
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        private async void SuratSPK_Load(object sender, EventArgs e)
        {
            DataTable t = await GetTransaction();

            dgSPK.DataSource = t;
            t.Columns.Remove("id_customer");
            //t.DefaultView.RowFilter = "transaction_status <> 'finish'";
            dgSPK.Columns["customer_name"].DisplayIndex = 1;
            dgSPK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgSPK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSPK.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }

        private void dgSPK_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.WriteLine("pandaa");
            string id = dgSPK.SelectedRows[0].Cells["id_transaction"].Value.ToString();
            FormSPKNew SPKForm = new FormSPKNew(id);
            SPKForm.Show();
        }

        private void dgSPK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgSPK.SelectedRows[0].Cells["id_transaction"].Value.ToString();
            FormSPKNew SPKForm = new FormSPKNew(id);
            SPKForm.Show();
        }
    }
    
}
