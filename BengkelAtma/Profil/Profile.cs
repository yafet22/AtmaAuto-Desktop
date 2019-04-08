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
        }

       public class Profil
        {
            int id_employee { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string name { get; set; }
            public string phone_number { get; set; }
            public string address { get; set; }
            public double salary { get; set; }
            public int id_role { get; set; }
            public int id_branch { get; set; }
            public string role_name { get; set; }
            public string branch_name { get; set; }
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

        


        }
}
