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
using System.Net.Http;

namespace BengkelAtma.Surat
{
    public partial class FormSPNew : Form
    {
        public SuratPemesanan SP = new SuratPemesanan();

        public FormSPNew(string id)
        {
            InitializeComponent();
            Uri url = new Uri(string.Format("http://p3l.yafetrakan.com/api/generate-sp/" + id));
            string response = Get(url);

            JObject jobject = new JObject();
            jobject = jsonParse(response);
            DataTable dt17 = new DataTable();
     

            dt17 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("report").ToString());
           

            //Notes.Subreports["Subdetailsparepart"].Database.Tables["SparepartSPKNOTA"].SetDataSource(dt10);
            //Notes.Subreports["Subdetailservice"].Database.Tables["ServiceSPKNOTA"].SetDataSource(dt11);

            SP.Database.Tables["CetakSP"].SetDataSource(dt17);
          
        

            crystalReportViewer1.ReportSource = SP;
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
        //Uri url = new Uri(string.Format("http://p3l.yafetrakan.com/api/generate-sp/" + id));
        /*string response = Get(url);

        JObject jobject = new JObject();
        jobject = jsonParse(response);
        DataTable dt17 = new DataTable();

        dt17 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("CetakPemesanan").ToString());
        SP.Database.Tables["CetakSP"].SetDataSource(dt17);

        crystalReportViewer1.ReportSource = SP;*/
    }

        /*public class SPemesanan
        {
            public string supplier_name { get; set; }
            public string supplier_address { get; set; }
            public string supplier_phone_number { get; set; }
            public string date { get; set; }
            public string sparepart_name { get; set; }
            public string merk { get; set; }
            public double price { get; set; }
            public double subtotal { get; set; }
            public int amount { get; set; }
        }


        /*public string GetSP(Uri url)
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
     }*/

        /*public void getPemesanan()
        {
            var client = new HttpClient();
            var response = client.GetAsync(string.Format("http://p3l.yafetrakan.com/api/generate-sp/2")).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<List<SPemesanan>>(a);
                List<SPemesanan> listJasaTerlarisz = result;
                SP.Database.Tables["CetakSP"].SetDataSource(listJasaTerlarisz);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormSPNew_Load(object sender, EventArgs e)
        {
            getPemesanan();
            crystalReportViewer1.ReportSource = SP;
        }*/
    
}

