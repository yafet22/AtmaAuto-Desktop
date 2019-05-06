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

namespace BengkelAtma.Kasir
{
    public partial class pembayaran : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private string check = "";
        private string id;
        private double payamount;

        public pembayaran()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }


        public void clearInput()
        {
            labelID.Text = "";
            labelCstmr.Text = "";
            labelWkt.Text = "";
            
            
        }

        static async Task<DataTable> GetTransaction()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/transactions");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetSparepart(string id)
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync($"api/transactions/{id}");

            var a = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
            //JObject jsonResponse = JObject.Parse(a);
            //var sparepart = jsonResponse["data"]["compatibility"];
            //var comp = sparepart.Children();
            //Debug.WriteLine(a);
            DataTable dt = new DataTable();
            dt = json_convertsparepart(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetService(string id)
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync($"api/transactions/{id}");

            var a = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
            //JObject jsonResponse = JObject.Parse(a);
            //var sparepart = jsonResponse["data"]["compatibility"];
            //var comp = sparepart.Children();
            //Debug.WriteLine(a);
            DataTable dt = new DataTable();
            dt = json_convertservice(a);
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

        public static DataTable json_convertservice(string json)
        {
            JObject json_object = JObject.Parse(json);
            Debug.WriteLine(json_object);
            DataTable dt = new DataTable();
            Debug.WriteLine("yi");
            JArray json_array = JArray.Parse(json_object["data"]["service"]["data"].ToString());

            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        public static DataTable json_convertsparepart(string json)
        {
            JObject json_object = JObject.Parse(json);
            Debug.WriteLine(json_object);
            DataTable dt = new DataTable();
            Debug.WriteLine("yi");
            JArray json_array = JArray.Parse(json_object["data"]["sparepart"]["data"].ToString());

            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        private async void pembayaran_Load(object sender, EventArgs e)
        {
            DataTable t = await GetTransaction();
            t.Columns.Remove("id_customer");
            dgTransaksi.DataSource = t;
            dgTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgTransaksi.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }

        private async void btnCariByr_Click(object sender, EventArgs e)
        {
            string searchValue = tbCariByr.Text;

            dgTransaksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                Debug.WriteLine(searchValue);
                if (tbCariByr.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dgTransaksi.Rows)
                    {
                        Debug.WriteLine(searchValue);
                        if (row.Cells[7].Value.ToString().Contains(searchValue))
                        {
                            Debug.WriteLine("masokk");
                            id = Convert.ToString(row.Cells[0].Value);
                            row.Selected = true;
                            ((DataTable)dgTransaksi.DataSource).DefaultView.RowFilter = string.Format("customer_name like '%{0}%'", tbCariByr.Text.Trim().Replace("'", "''"));

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Anda Belum Memasukkan Data");
                    DataTable t = await GetTransaction();
                    t.Columns.Remove("id_customer");
                    dgTransaksi.DataSource = t;
                    dgTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgTransaksi.DataBindingComplete += (o, _) =>
                    {
                        var dataGridView = o as DataGridView;
                        if (dataGridView != null)
                        {
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    };
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Data yang Anda cari tidak ada");
                DataTable t = await GetTransaction();
                t.Columns.Remove("id_customer");
                dgTransaksi.DataSource = t;
                dgTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgTransaksi.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };
            }

        }

       

        private void dgTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("cekmassuk");
            check = "edit";
            //enableInput();
            foreach (DataGridViewRow row in dgTransaksi.Rows)
            {
                if (row.Selected == true)
                {
                    //id = Convert.ToString(row.Cells[0].Value);
                    labelID.Text = row.Cells[0].Value.ToString();
                    labelCstmr.Text = row.Cells[7].Value.ToString();
                    labelWkt.Text = row.Cells[2].Value.ToString();
                    row.Selected = true;
                    ((DataTable)dgTransaksi.DataSource).DefaultView.RowFilter = string.Format("customer_name like '%{0}%'", tbCariByr.Text.Trim().Replace("'", "''"));
                    break;
                }
            }
        }

        private async void dgTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("cekmassuk");
            check = "edit";
            //enableInput();
            foreach (DataGridViewRow row in dgTransaksi.Rows)
            {
                if (row.Selected == true)
                {
                    //id = Convert.ToString(row.Cells[0].Value);
                    labelID.Text = row.Cells[0].Value.ToString();
                    labelCstmr.Text = row.Cells[7].Value.ToString();
                    labelWkt.Text = row.Cells[2].Value.ToString();
                    tbTotal.Text = row.Cells[6].Value.ToString();
                    row.Selected = true;
                    
                    if (row.Cells[4].Value.ToString().Equals("Sparepart") || row.Cells[4].Value.ToString().Equals("Service And Sparepart"))
                    {
                        DataTable t = await GetSparepart(id);
                        dgSparepart.DataSource = t;
                        dgSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgSparepart.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };
                    }
                    if (row.Cells[4].Value.ToString().Equals("Service") || row.Cells[4].Value.ToString().Equals("Service And Sparepart"))
                    {
                        DataTable t = await GetService(id);
                        dgService.DataSource = t;
                        dgService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgService.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };
                    }


                    break;
                }
            }
        }

        private async void dgTransaksi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Debug.WriteLine("cekmassuk");
            check = "edit";
            //enableInput();
            foreach (DataGridViewRow row in dgTransaksi.Rows)
            {
                if (row.Selected == true)
                {
                    id = Convert.ToString(row.Cells[0].Value);
                    labelID.Text = row.Cells[0].Value.ToString();
                    labelCstmr.Text = row.Cells[7].Value.ToString();
                    labelWkt.Text = row.Cells[2].Value.ToString();
                    tbTotal.Text = row.Cells[6].Value.ToString();

                    if (row.Cells[4].Value.ToString().Equals("Sparepart") || row.Cells[4].Value.ToString().Equals("Service And Sparepart"))
                    {
                        DataTable t = await GetSparepart(id);
                        dgSparepart.DataSource = t;
                        dgSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgSparepart.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };
                    }
                    if (row.Cells[4].Value.ToString().Equals("Service") || row.Cells[4].Value.ToString().Equals("Service And Sparepart"))
                    {
                        DataTable t = await GetService(id);
                        dgService.DataSource = t;
                        dgService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dgService.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgService.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };
                    }


                    break;
                }
            }
        }

        private void btnResetByr_Click(object sender, EventArgs e)
        {
            if (labelID.Text.ToString().Trim() != "" && labelCstmr.Text.ToString().Trim() != "" && labelWkt.Text.ToString().Trim() != "" && dgSparepart != null && dgService != null)
            {
                clearInput();
                DataTable t = null;
                dgSparepart.DataSource = t;
                dgService.DataSource = t;
                MessageBox.Show("Anda Sukses Melakukan Reset");

            }
            
        }

        private async void btnBayar_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine(labelID.Text);
                Pay pay = new Pay { id_transaction = labelID.Text, transaction_discount = Convert.ToInt64(tbDiskon.Text), transaction_total = Convert.ToInt64(tbUangBayar.Text) };

                HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/payment/{pay.id_transaction}", pay);
                response.EnsureSuccessStatusCode();
                pay = await response.Content.ReadAsAsync<Pay>();
                dgTransaksi.DataSource = await GetTransaction();
                dgTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgTransaksi.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };
                //((DataTable)dataCabang.DataSource).AcceptChanges();

                MessageBox.Show("Berhasil Update Data Cabang");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            
        }

        public class Pay
        {
            public string id_transaction { get; set; }
            public double transaction_discount { get; set; }
            public double transaction_total { get; set; }
        }

        public class Bayar
        {
            public string id_transaction { get; set; }
            public double transaction_discount { get; set; }
            public double transaction_total { get; set; }
            public double payamount { get; set; }
        }

        private void tbDiskon_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("sososk1");
            //tbTotal.Text = Convert.ToString((Convert.ToInt64(tbTotal.Text) - Convert.ToInt64(tbDiskon.Text)));
        }

        private void tbDiskon_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("sososk2");
            //tbTotal.Text = Convert.ToString((Convert.ToInt64(tbTotal.Text) - Convert.ToInt64(tbDiskon.Text)));
        }

        private void tbDiskon_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("sososk3");
            //tbTotal.Text = Convert.ToString((Convert.ToInt64(tbTotal.Text) - Convert.ToInt64(tbDiskon.Text)));
        }
    }
  }
