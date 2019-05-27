using CrystalDecisions.CrystalReports.Engine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BengkelAtma.Surat
{
    public partial class FormSPKNew : Form
    {
        public SuratPerintahKerja SPK = new SuratPerintahKerja();
       
        public FormSPKNew(string id)
        {
            InitializeComponent();

            Uri url = new Uri(string.Format("http://192.168.19.140/8991/api/generate-spk/" + id));
            string response = Get(url);

            JObject jobject = new JObject();
            jobject = jsonParse(response);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();
            DataTable dt7 = new DataTable();
            DataTable dt8 = new DataTable();

            dt1 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("customerservice").ToString());
            dt2 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("sparepart").ToString());
            dt3 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("service").ToString());
            dt4 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("motorsparepart").ToString());
            dt5 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("motorservice").ToString());
            dt6 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("customer").ToString());
            dt7 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("mechanicsparepart").ToString());
            dt8 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("mechanicjasa").ToString());

            SPK.Database.Tables["CustomerServiceSPKNOTA"].SetDataSource(dt1);
            SPK.Database.Tables["SparepartSPKNOTA"].SetDataSource(dt2);
            SPK.Database.Tables["ServiceSPKNOTA"].SetDataSource(dt3);
            SPK.Database.Tables["MotorSparepartSPKNOTA"].SetDataSource(dt4);
            SPK.Database.Tables["MotorServiceSPKNOTA"].SetDataSource(dt5);
            SPK.Database.Tables["WorkOrderSPKNOTA"].SetDataSource(dt6);
            SPK.Database.Tables["MDSparepartSPKNOTA"].SetDataSource(dt7);
            SPK.Database.Tables["MDServiceSPKNOTA"].SetDataSource(dt8);

            crystalReportViewer1.ReportSource = SPK;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public string Get(Uri url)
        {
            var request = HttpWebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Debug.WriteLine("web_api response = " + responseString);

                return responseString;

            }
            catch (WebException e)
            {
                return null;
            }
        }

        public JObject jsonParse(string json)
        {
            Debug.WriteLine(json);
            JObject json_object = JObject.Parse(json);
            return json_object;
        }
    }
}
