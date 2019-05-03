﻿using System;
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

        public pembayaran()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        public class Bayar
        {
            public string id_transaction;
            public int id_costumer;
            public string transaction_status;
            public string transaction_date;
            public string transaction_paid;
            public double transaction_discount;
            public double transaction_total;
            public string transaction_type;
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
    }
  }
