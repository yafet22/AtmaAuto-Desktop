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
    public partial class Sales : UserControl
    {
        static HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public Sales()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        public class menuSales
        {
            public int id_sales { get; set; }
            public int id_supplier { get; set; }
            public string sales_name { get; set; }
            public string sales_phone_number { get; set; }
        }

        public void disableInput()
        {
            tbNamaSales.Enabled = false;
            tbNoTelpSales.Enabled = false;
            cbSupplier.Enabled = false;
        }

        public void enableInput()
        {
            tbNamaSales.Enabled = true;
            tbNoTelpSales.Enabled = true;
            cbSupplier.Enabled = true;
        }

        public void clearInput()
        {
            id = 0;
            tbNamaSales.Text = "";
            tbNoTelpSales.Text = "";
        }

        static async Task<DataTable> GetSales()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/sales");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetSuppliers()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/suppliers");

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

        private async void btnSimpanSales_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                if (tbNamaSales.Text.ToString().Trim() != "" && tbNoTelpSales.Text.ToString().Trim() != "" && cbSupplier.SelectedValue.ToString().Trim() != "" )
                {
                    if (check.Equals("simpan"))
                    {
                        Debug.WriteLine("masuuuk simpan");
                        Debug.WriteLine("ceki");
                        Debug.WriteLine(Convert.ToInt16(cbSupplier.SelectedValue.ToString()));
                        menuSales sales = new menuSales { sales_name = tbNamaSales.Text.ToString(), sales_phone_number = tbNoTelpSales.Text.ToString(), id_supplier = Convert.ToInt16(cbSupplier.SelectedValue.ToString())};

                        var response = client.PostAsJsonAsync("api/sales", sales).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var a = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(a);
                            DataTable t = await GetSales();
                            t.Columns.Remove("id_supplier");
                            dgSales.DataSource = t;
                            dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            dgSales.DataBindingComplete += (o, _) =>
                            {
                                var dataGridView = o as DataGridView;
                                if (dataGridView != null)
                                {
                                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                            };

                            MessageBox.Show("Berhasil Input Data Sales");
                        }
                    }
                    else if (check.Equals("edit"))
                    {
                        var name = tbNamaSales.Text.ToString();

                        menuSales sales = new menuSales { id_sales = id, sales_name = tbNamaSales.Text.ToString(), sales_phone_number = tbNoTelpSales.Text.ToString(), id_supplier = Convert.ToInt16(cbSupplier.SelectedValue.ToString()) };

                        HttpResponseMessage response = await client.PutAsJsonAsync(
                        $"api/sales/{sales.id_sales}", sales);
                        response.EnsureSuccessStatusCode();
                        sales = await response.Content.ReadAsAsync<menuSales>();
                        DataTable t = await GetSales();
                        t.Columns.Remove("id_supplier");
                        dgSales.DataSource = t;
                        dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        dgSales.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };

                        MessageBox.Show("Berhasil Update Data Sales");
                    }

                    clearInput();
                    disableInput();
                }
                else
                {
                    MessageBox.Show("Data Anda Masih Kosong atau tidak lengkap");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void Sales_Load(object sender, EventArgs e)
        {
            disableInput();

            //load tabel pegawai
            DataTable t = await GetSales();
            t.Columns.Remove("id_supplier");
            dgSales.DataSource = t;
            dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgSales.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };


            //load combobox cabang
            cbSupplier.DataSource = await GetSuppliers();
            cbSupplier.ValueMember = "id_supplier";
            cbSupplier.DisplayMember = "supplier_name";

            
        }

        private async void btnCariSales_Click(object sender, EventArgs e)
        {
            disableInput();
            string searchValue = tbCariSales.Text;

            dgSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCariSales.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dgSales.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
                        {
                            id = Convert.ToInt16(row.Cells[0].Value);
                            Debug.WriteLine("bind :" + id);
                            //tbNamaPegawai.Text = Convert.ToString(row.Cells["name"].Value);
                            //tbAlamatPegawai.Text = row.Cells[2].Value.ToString();
                            //tbNomorTeleponPegawai.Text = row.Cells[3].Value.ToString();
                            //tbGajiPegawai.Text = row.Cells[4].Value.ToString();
                            row.Selected = true;
                            ((DataTable)dgSales.DataSource).DefaultView.RowFilter = string.Format("sales_name like '%{0}%'", tbCariSales.Text.Trim().Replace("'", "''"));
                            Debug.WriteLine("masuk edit");

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Anda Belum Memasukkan Data");
                    DataTable t = await GetSales();
                    t.Columns.Remove("id_supplier");
                    dgSales.DataSource = t;
                    dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgSales.DataBindingComplete += (o, _) =>
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
                DataTable t = await GetSales();
                t.Columns.Remove("id_supplier");
                dgSales.DataSource = t;
                dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgSales.DataBindingComplete += (o, _) =>
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

        private void btnResetSales_Click(object sender, EventArgs e)
        {
            if (tbNamaSales.Text.ToString().Trim() != "" && tbNoTelpSales.Text.ToString().Trim() != "" && cbSupplier.SelectedValue.ToString().Trim() != "")
            {
                clearInput();
            }
            else
            {
                MessageBox.Show(" Anda harus memilih menu input atau edit terlebih dahulu");
            }
        }

        private void btnEditSales_Click(object sender, EventArgs e)
        {
            check = "edit";
            enableInput();
            foreach (DataGridViewRow row in dgSales.Rows)
            {
                if (row.Selected == true)
                {
                    {

                        id = Convert.ToInt16(row.Cells[0].Value);
                        tbNamaSales.Text = Convert.ToString(row.Cells["sales_name"].Value);
                        tbNoTelpSales.Text = Convert.ToString(row.Cells["sales_phone_number"].Value);
                    }
                }
            }
        }

        private async void btnDeleteSales_Click(object sender, EventArgs e)
        {
            dgSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dgSales.SelectedRows)
            {
                if (row.Selected == true)
                {
                    try
                    {
                        DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {

                            HttpResponseMessage response = await client.DeleteAsync(
                            $"api/sales/{Convert.ToInt16(dgSales.SelectedRows[0].Cells["id_sales"].Value)}");
                            response.EnsureSuccessStatusCode();
                            DataTable t = await GetSales();
                            t.Columns.Remove("id_supplier");
                            dgSales.DataSource = t;
                            dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void btnNewSales_Click(object sender, EventArgs e)
        {
            check = "simpan";
            clearInput();
            enableInput();
        }

        private async void dgSales_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    HttpResponseMessage response = await client.DeleteAsync(
                    $"api/sales/{Convert.ToInt16(dgSales.SelectedRows[0].Cells["id_sales"].Value)}");
                    response.EnsureSuccessStatusCode();
                    DataTable t = await GetSales();
                    t.Columns.Remove("id_supplier");
                    dgSales.DataSource = t;
                    dgSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void dgSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgSales.Rows[e.RowIndex].ReadOnly = true;
        }

        private void tbNamaSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNoTelpSales.Focus();
            }
        }

        private void tbNoTelpSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbSupplier.Focus();
            }
        }

        
    }
}
