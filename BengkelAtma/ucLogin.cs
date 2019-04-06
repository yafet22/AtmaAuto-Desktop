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

namespace BengkelAtma
{
    public partial class ucLogin : UserControl
    {
        static HttpClient client = new HttpClient();

        public ucLogin()
        {
            InitializeComponent();
            
        }

        private void tbMasuk_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.ToString().Trim() != "" && tbPass.Text.ToString().Trim() != "")
            {
                GetLogin(tbUser.Text.ToString(), tbPass.Text.ToString());
            }

        }

        static async void GetLogin(string user, string pass)
        {
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
            LoginClass lgn = new LoginClass { username = user, password = pass };
            var response = client.PostAsJsonAsync("api/mobileauthenticate", lgn).Result;
            if (response.IsSuccessStatusCode)
            {
                var a = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"{a}");
                Data data = new Data(a);
                Console.WriteLine($"{data.name}");
                //var b = JsonConvert.DeserializeObject<Data>(a);
                //Console.WriteLine($"{b.username}");
                SplashScreen.ActiveForm.Hide();
                MainMenu main = new MainMenu();
                main.Show();
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
            }
            public int id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
            public string role { get; set; }
        }

        public static class LoginInfo
        {
            public static int id;
            public static string username;
            public static string name;
            public static string role;
        }
    }
}
