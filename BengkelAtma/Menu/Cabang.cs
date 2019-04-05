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
    public partial class Cabang : UserControl
    {
        static HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public Cabang()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");

        }

        public void disableInput()
        {
            tbNamaCabang.ReadOnly = true;
            tbAlamatCabang.ReadOnly = true;
            tbNomorTeleponCabang.ReadOnly = true;
        }

        public void enableInput()
        {
            tbNamaCabang.ReadOnly = false;
            tbAlamatCabang.ReadOnly = false;
            tbNomorTeleponCabang.ReadOnly = false;
        }

        public void clearInput()
        {
            id = 0;
            tbNamaCabang.Text = "";
            tbAlamatCabang.Text = "";
            tbNomorTeleponCabang.Text = "";
        }

        private async void Cabang_Load(object sender, EventArgs e)
        {
            disableInput();
            dataCabang.DataSource = await GetData();
            dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public class Branch
        {
            public int id_branch { get; set; }
            public string branch_name { get; set; }
            public string branch_address { get; set; }
            public string branch_phone_number { get; set; }
        }

        static async Task<DataTable> GetData()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/branches");

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

        private async void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (tbNamaCabang.Text.ToString().Trim() != "" && tbAlamatCabang.Text.ToString().Trim() != "" && tbNomorTeleponCabang.Text.ToString().Trim() != "")
            {
                if (check.Equals("simpan"))
                {
                    Branch branch = new Branch { branch_name = tbNamaCabang.Text.ToString(), branch_address = tbAlamatCabang.Text.ToString(), branch_phone_number = tbNomorTeleponCabang.Text.ToString() };
                    var response = client.PostAsJsonAsync("api/branches", branch).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var a = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(a);
                        dataCabang.DataSource = await GetData();
                        dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        MessageBox.Show("Berhasil Input Data Cabang");
                    }
                    else
                    {
                        Debug.WriteLine("Gagal");
                    }
                }
                else if (check.Equals("edit"))
                {
                    Branch branch = new Branch { id_branch = id, branch_name = tbNamaCabang.Text.ToString(), branch_address = tbAlamatCabang.Text.ToString(), branch_phone_number = tbNomorTeleponCabang.Text.ToString() };

                    HttpResponseMessage response = await client.PutAsJsonAsync(
                    $"api/branches/{branch.id_branch}", branch);
                    response.EnsureSuccessStatusCode();
                    branch = await response.Content.ReadAsAsync<Branch>();
                    dataCabang.DataSource = await GetData();
                    dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    MessageBox.Show("Berhasil Update Data Cabang");
                }

                clearInput();
                disableInput();
            }
        }

        private async void buttonCari_Click(object sender, EventArgs e)
        {
            string searchValue = tbCari.Text;

            dataCabang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCari.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dataCabang.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            id = Convert.ToInt16(row.Cells[0].Value);
                            tbNamaCabang.Text = row.Cells[1].Value.ToString();
                            tbAlamatCabang.Text = row.Cells[2].Value.ToString();
                            tbNomorTeleponCabang.Text = row.Cells[3].Value.ToString();
                            row.Selected = true;
                            ((DataTable)dataCabang.DataSource).DefaultView.RowFilter = string.Format("branch_name like '%{0}%'", tbCari.Text.Trim().Replace("'", "''"));
                            break;
                        }
                    }
                }
                else
                {
                    dataCabang.DataSource = await GetData();
                    dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                dataCabang.DataSource = await GetData();
                dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void dataCabang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && dataCabang.CurrentCell.ColumnIndex == 1)
            {
                e.Handled = true;
                DataGridViewCell cell = dataCabang.Rows[0].Cells[0];
                dataCabang.CurrentCell = cell;
                dataCabang.BeginEdit(true);
            }
        }

        private async void dataCabang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataCabang.Rows[e.RowIndex].Selected = true;
                dataCabang.CurrentCell = dataCabang.Rows[e.RowIndex].Cells[1];


                Branch branch = new Branch { id_branch = Convert.ToInt16(dataCabang.Rows[e.RowIndex].Cells["id_branch"].Value), branch_name = Convert.ToString(dataCabang.Rows[e.RowIndex].Cells["branch_name"].Value), branch_address = Convert.ToString(dataCabang.Rows[e.RowIndex].Cells["branch_address"].Value), branch_phone_number = Convert.ToString(dataCabang.Rows[e.RowIndex].Cells["branch_phone_number"].Value) };

                HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/branches/{branch.id_branch}", branch);
                response.EnsureSuccessStatusCode();
                branch = await response.Content.ReadAsAsync<Branch>();
                dataCabang.DataSource = await GetData();
                dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //((DataTable)dataCabang.DataSource).AcceptChanges();

                MessageBox.Show("Berhasil Update Data Cabang");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void dataCabang_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
          
                    HttpResponseMessage response = await client.DeleteAsync(
                    $"api/branches/{Convert.ToInt16(dataCabang.SelectedRows[0].Cells["id_branch"].Value)}");
                    response.EnsureSuccessStatusCode();
                    dataCabang.DataSource = await GetData();
                    dataCabang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void buttonInput_Click(object sender, EventArgs e)
        {
            check = "simpan";
            clearInput();
            enableInput();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            check = "edit";
            enableInput();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clearInput();
        }

      
    }
}
