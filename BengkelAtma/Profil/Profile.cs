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
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace BengkelAtma.Menu
{
    public partial class Profile : UserControl
    {
        static HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public Profile()
        {
            InitializeComponent();
            disableInput();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
            GetPegawai();
                
        }

       public class Data
        {
            public Data(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jUser = jObject["data"];
                id_employee = (int)jUser["id_employee"];
                name = (string)jUser["name"];
                phone_number = (string)jUser["phone_number"];
                address = (string)jUser["address"];
                salary = (double)jUser["salary"];
                role = (string)jUser["role"];
                branch = (string)jUser["branch"];
            }

            int id_employee { get; set; }
            public string name { get; set; }
            public string phone_number { get; set; }
            public string address { get; set; }
            public double salary { get; set; }
            public int id_role { get; set; }
            public int id_branch { get; set; }
            public string role { get; set; }
            public string branch { get; set; }
            public string password { get; set; }
        }

        public class User
        {
            public int id_user { get; set; }
            public int id_employee { get; set; }
            public string username { get; set; }
            public string password { get; set; }

        }

        public void disableInput()
        {
            tbTampilNamaPegawai.Enabled = false;
            tbTampilAlamatPegawai.Enabled = false;
            tbTampilGajiPegawai.Enabled = false;
            tbTampilNomorTeleponPegawai.Enabled = false;
            tbTampilCabang.Enabled = false;
            tbTampilJabatan.Enabled = false;
        }

        public void enableInput()
        {
            tbTampilPass.Enabled = true;
        }

        public void clearInput()
        {
            tbTampilPass.Text = "";
        }
        public async void GetPegawai()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync($"api/employees/{ucLogin.idUser}");
            var a = await response.Content.ReadAsStringAsync();
            Data data = new Data(a);

            tbTampilNamaPegawai.Text = data.name;
            tbTampilAlamatPegawai.Text = data.address;
            tbTampilCabang.Text = data.branch;
            tbTampilJabatan.Text = data.role;
            tbTampilGajiPegawai.Text = data.salary.ToString();
            tbTampilNomorTeleponPegawai.Text = data.phone_number;
        }

        private void btnEditPass_Click(object sender, EventArgs e)
        {

        }
    }
}
