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

namespace BengkelAtma.Nota
{
    public partial class FormNotaNew : Form
    {
        public Notas Notes = new Notas();
        public FormNotaNew(string id)
        {
            InitializeComponent();

            Uri url = new Uri(string.Format("http://192.168.19.140/8991/api/generate-spk/" + id));
            string response = Get(url);

            JObject jobject = new JObject();
            jobject = jsonParse(response);
            DataTable dt9 = new DataTable();
            DataTable dt10 = new DataTable();
            DataTable dt11 = new DataTable();
            DataTable dt12 = new DataTable();
            DataTable dt13 = new DataTable();
            DataTable dt14 = new DataTable();
            DataTable dt15 = new DataTable();
            DataTable dt16 = new DataTable();

            dt9 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("customerservice").ToString());
            dt10 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("sparepart").ToString());
           
            dt11 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("service").ToString());
            
            dt12 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("motorsparepart").ToString());
            dt13 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("motorservice").ToString());
            dt14 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("customer").ToString());
            dt15 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("mechanicsparepart").ToString());
            dt16 = JsonConvert.DeserializeObject<DataTable>(jobject.GetValue("mechanicjasa").ToString());

            Notes.Subreports["Subdetailsparepart"].Database.Tables["SparepartSPKNOTA"].SetDataSource(dt10);
            Notes.Subreports["Subdetailservice"].Database.Tables["ServiceSPKNOTA"].SetDataSource(dt11);

            Notes.Database.Tables["CustomerServiceSPKNOTA"].SetDataSource(dt9);
            Notes.Database.Tables["SparepartSPKNOTA"].SetDataSource(dt10);
            Notes.Database.Tables["ServiceSPKNOTA"].SetDataSource(dt11);
            Notes.Database.Tables["MotorSparepartSPKNOTA"].SetDataSource(dt12);
            Notes.Database.Tables["MotorServiceSPKNOTA"].SetDataSource(dt13);
            Notes.Database.Tables["WorkOrderSPKNOTA"].SetDataSource(dt14);
            Notes.Database.Tables["MDSparepartSPKNOTA"].SetDataSource(dt15);
            Notes.Database.Tables["MDServiceSPKNOTA"].SetDataSource(dt16);

            crystalReportViewer1.ReportSource = Notes;
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
