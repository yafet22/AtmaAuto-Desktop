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
        private int id_role,id_branch,id;

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
                id_role = (int)jUser["id_role"];
                id_branch = (int)jUser["id_branch"];
            }

            public int id_employee { get; set; }
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

        public class Employee
        {
            public int id_employee { get; set; }
            public string first_name { get; set; }
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

            Debug.WriteLine("iduser" + ucLogin.idUser);
            HttpResponseMessage response = await client.GetAsync($"api/employees/{ucLogin.idUser}");
            var a = await response.Content.ReadAsStringAsync();
            Data data = new Data(a);

            this.id_role = data.id_role;
            this.id_branch = data.id_branch;
            this.id = data.id_employee;

            Debug.WriteLine(" hehehe " + this.id_role);

            tbTampilNamaPegawai.Text = data.name;
            tbTampilAlamatPegawai.Text = data.address;
            tbTampilCabang.Text = data.branch;
            tbTampilJabatan.Text = data.role;
            tbTampilGajiPegawai.Text = data.salary.ToString();
            tbTampilNomorTeleponPegawai.Text = data.phone_number;
        }

        private async void btnEditPass_Click(object sender, EventArgs e)
        {
            if(tbTampilPass.Text.Equals(tbTampilConfirmPass.Text) && tbTampilPass.Text != "" && tbTampilConfirmPass.Text != "")
            {
                User user = new User { id_user = ucLogin.idUser, password = tbTampilPass.Text.ToString() };
                HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/users/{user.id_user}", user);
                response.EnsureSuccessStatusCode();
                user = await response.Content.ReadAsAsync<User>();

                GetPegawai();

                MessageBox.Show("Berhasil Mengganti Password");
            }
            else
            {
                MessageBox.Show("Pastikan Password Baru dan Konfirmasi Password anda sama");
            }
            
        }

        private void buttonEditProfil_Click(object sender, EventArgs e)
        {
            tbTampilNamaPegawai.Enabled = true;
            tbTampilAlamatPegawai.Enabled = true;
            tbTampilNomorTeleponPegawai.Enabled = true;
        }

        private async void buttonSimpanProfil_Click(object sender, EventArgs e)
        {
            try
            {
                var name = tbTampilNamaPegawai.Text.ToString();

                Employee employee = new Employee { id_employee = this.id, first_name = name, address = tbTampilAlamatPegawai.Text.ToString(), phone_number = tbTampilNomorTeleponPegawai.Text.ToString(), salary = double.Parse(tbTampilGajiPegawai.Text.ToString()), id_branch = this.id_branch, id_role = this.id_role };

                HttpResponseMessage response = await client.PutAsJsonAsync(
                            $"api/employees/{employee.id_employee}", employee);
                response.EnsureSuccessStatusCode();
                employee = await response.Content.ReadAsAsync<Employee>();

                disableInput();

                MessageBox.Show("Berhasil Ubah Data Profile");

                GetPegawai();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
