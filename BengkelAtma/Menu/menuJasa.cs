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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BengkelAtma.Menu
{
    public partial class menuJasa : UserControl
    {
        static HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public menuJasa()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        public class Service
        {
            public int id_service { get; set; }
            public string service_name { get; set; }
            public double price { get; set; }
        }

        public void disableInput()
        {
            tbLynJasa.Enabled = false;
            tbHrgJasa.Enabled = false;
        }

        public void enableInput()
        {
            tbLynJasa.Enabled = true;
            tbHrgJasa.Enabled = true;
        }

        public void clearInput()
        {
            id = 0;
            tbLynJasa.Text = "";
            tbHrgJasa.Text = "";
        }

       /* private async void Jasa_Load(object sender, EventArgs e)
        {
            
        }*/

        static async Task<DataTable> GetDataJasa()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/services");

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

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        private async void btnSimpanJasa_Click(object sender, EventArgs e)
        {
            if (tbLynJasa.Text.ToString().Trim() != "" && tbHrgJasa.Text.ToString().Trim() != "" )
            {
                if (check.Equals("simpan"))
                {
                    Service service = new Service { service_name = tbLynJasa.Text.ToString(), price = Convert.ToDouble(tbHrgJasa.Text.ToString())  };
                    var response = client.PostAsJsonAsync("api/services", service).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var a = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(a);
                        dgJasa.DataSource = await GetDataJasa();
                        dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dgJasa.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };

                        MessageBox.Show("Berhasil Input Data Jasa");
                    }
                    else
                    {
                        Debug.WriteLine("Gagal");
                    }
                }
                else if (check.Equals("edit"))
                {
                    Service service = new Service {id_service = id, service_name = tbLynJasa.Text.ToString(), price = Convert.ToDouble(tbHrgJasa.Text.ToString()) }; 

                    HttpResponseMessage response = await client.PutAsJsonAsync(
                    $"api/services/{service.id_service}", service);
                    response.EnsureSuccessStatusCode();
                    service = await response.Content.ReadAsAsync<Service>();
                    dgJasa.DataSource = await GetDataJasa();
                    dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgJasa.DataBindingComplete += (o, _) =>
                    {
                        var dataGridView = o as DataGridView;
                        if (dataGridView != null)
                        {
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    };

                    MessageBox.Show("Berhasil Update Data Jasa");
                }

                clearInput();
                disableInput();
            }
        }

        private void btnResetJasa_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private async void btnCariJasa_Click(object sender, EventArgs e)
        {
            disableInput();
            string searchValue = tbCariJasa.Text;

            dgJasa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCariJasa.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dgJasa.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
                        {

                            ((DataTable)dgJasa.DataSource).DefaultView.RowFilter = string.Format("service_name like '%{0}%'", tbCariJasa.Text.Trim().Replace("'", "''"));
                            break;
                        }
                    }
                }
                else
                {
                    dgJasa.DataSource = await GetDataJasa();
                    dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgJasa.DataBindingComplete += (o, _) =>
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
                MessageBox.Show(exc.Message);
                dgJasa.DataSource = await GetDataJasa();
                dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgJasa.DataBindingComplete += (o, _) =>
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

        private void dgJasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && dgJasa.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = dgJasa.Rows[0].Cells[0];
                dgJasa.CurrentCell = cell;
                dgJasa.BeginEdit(true);
            }
        }


        private async void dgJasa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgJasa.Rows[e.RowIndex].Selected = true;
                dgJasa.CurrentCell = dgJasa.Rows[e.RowIndex].Cells[1];


                Service service = new Service { id_service = Convert.ToInt16(dgJasa.Rows[e.RowIndex].Cells["id_service"].Value), service_name = Convert.ToString(dgJasa.Rows[e.RowIndex].Cells["service_name"].Value), price = Convert.ToDouble(dgJasa.Rows[e.RowIndex].Cells["price"].Value) };

                HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/services/{service.id_service}", service);
                response.EnsureSuccessStatusCode();
                service = await response.Content.ReadAsAsync<Service>();
                dgJasa.DataSource = await GetDataJasa();
                dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgJasa.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };
                //((DataTable)dataCabang.DataSource).AcceptChanges();

                MessageBox.Show("Berhasil Update Data Jasa");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnNewJasa_Click(object sender, EventArgs e)
        {
            check = "simpan";
            clearInput();
            enableInput();
        }

        private void btnEditJasa_Click(object sender, EventArgs e)
        {
            check = "edit";
            enableInput();
            foreach (DataGridViewRow row in dgJasa.Rows)
            {
                if (row.Selected == true)
                {
                    id = Convert.ToInt16(row.Cells[0].Value);
                    tbLynJasa.Text = row.Cells[1].Value.ToString();
                    tbHrgJasa.Text = row.Cells[2].Value.ToString();
                    row.Selected = true;
                    ((DataTable)dgJasa.DataSource).DefaultView.RowFilter = string.Format("service_name like '%{0}%'", tbCariJasa.Text.Trim().Replace("'", "''"));
                    break;
                }
            }
        }

        private async void btnDeleteJasa_Click(object sender, EventArgs e)
        {
            dgJasa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dgJasa.SelectedRows)
            {
                if (row.Selected == true)
                {
                    try
                    {
                        DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {

                            HttpResponseMessage response = await client.DeleteAsync(
                            $"api/services/{Convert.ToInt16(dgJasa.SelectedRows[0].Cells["id_service"].Value)}");
                            response.EnsureSuccessStatusCode();
                            dgJasa.DataSource = await GetDataJasa();
                            dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            dgJasa.DataBindingComplete += (o, _) =>
                            {
                                var dataGridView = o as DataGridView;
                                if (dataGridView != null)
                                {
                                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                            };
                            //Some task…  
                        }
                        if (res == DialogResult.Cancel)
                        {
                            //e.Cancel = true;
                            //Some task…  
                            break;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }

        private void dgJasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgJasa.Rows[e.RowIndex].ReadOnly = true;
        }

        private async void dgJasa_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    HttpResponseMessage response = await client.DeleteAsync(
                    $"api/services/{Convert.ToInt16(dgJasa.SelectedRows[0].Cells["id_service"].Value)}");
                    response.EnsureSuccessStatusCode();
                    dgJasa.DataSource = await GetDataJasa();
                    dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgJasa.DataBindingComplete += (o, _) =>
                    {
                        var dataGridView = o as DataGridView;
                        if (dataGridView != null)
                        {
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    };
                    //Some task…  
                }
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    //Some task…  
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void menuJasa_Load(object sender, EventArgs e)
        {

            disableInput();
            dgJasa.DataSource = await GetDataJasa();
            dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgJasa.DataBindingComplete += (o, _) =>
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
