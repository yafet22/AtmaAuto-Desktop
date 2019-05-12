using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BengkelAtma.Kasir;

namespace BengkelAtma
{
    public partial class ucLogin : UserControl
    {
        static HttpClient client = new HttpClient();

        public static int idUser { get; set; }
        public static string role { get; set; }

        public ucLogin()
        {

            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");


        }

        private void tbMasuk_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.ToString().Trim() != "" && tbPass.Text.ToString().Trim() != "")
            {
                GetLogin(tbUser.Text.ToString(), tbPass.Text.ToString());
            }
            else
            {
                MessageBox.Show(" Username atau password harus diisi");
            }

        }

        static async void GetLogin(string user, string pass)
        {
            LoginClass lgn = new LoginClass { username = user, password = pass };
            var response = client.PostAsJsonAsync("api/mobileauthenticate", lgn).Result;
            if (response.IsSuccessStatusCode)
            {
                var a = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{a}");
                Data data = new Data(a);
                Console.WriteLine($"{data.name}");
                Console.WriteLine($"{data.id}");
                idUser = data.id_employee;
                role = data.role;
                //var b = JsonConvert.DeserializeObject<Data>(a);
                //Console.WriteLine($"{b.username}");
                SplashScreen.ActiveForm.Hide();
                if (role == "Cashier")
                {
                   
                    MainMenuKasir kasir = new MainMenuKasir();
                    kasir.Show();

                }
                else if (role == "Administrator")
                {
                    
                    MainMenu main = new MainMenu();
                    var userlogin = user;
                    main.Show();  //bukan ini.,,
                }
                else
                {
                    MessageBox.Show(" Maaf Selain admin dan kasir, tidak dapat Login! ");
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show(" Username atau password tidak benar");
            }
        }


        public class LoginClass
        {
            public int id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string role { get; set; }
        }

        public class Data
        {
            public Data(string json)
            {
                JObject jObject = JObject.Parse(json);
                JToken jUser = jObject["data"];
                name = (string)jUser["name"];
                username = (string)jUser["username"];
                id = (int)jUser["id"];
                role = (string)jUser["role"];
                id_employee = (int)jUser["id_employee"];
            }
            public int id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public int id_employee { get; set; }
        }

        public static class LoginInfo
        {
            public static int id;
            public static string username;
            public static string name;
            public static string role;
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbPass.Focus();
            }
        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbMasuk.Focus();
            }
        }

        private void tbMasuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbUser.Text.ToString().Trim() != "" && tbPass.Text.ToString().Trim() != "")
            {
                GetLogin(tbUser.Text.ToString(), tbPass.Text.ToString());
            }
            else
            {
                MessageBox.Show(" Username atau password harus diisi");
            }
        }

        
    }
}
