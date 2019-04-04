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
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace BengkelAtma.Menu
{
    public partial class submenuPegawai : UserControl
    {
        static HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public submenuPegawai()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        public class Employee
        {
            public int id_employee { get; set; }
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
        }

        public void disableInput()
        {
            tbNamaPegawai.ReadOnly = true;
            tbAlamatPegawai.ReadOnly = true;
            tbGajiPegawai.ReadOnly = true;
            tbNomorTeleponPegawai.ReadOnly = true;
            comboCabang.Enabled = false;
            comboJabatan.Enabled = false;
        }

        public void enableInput()
        {
            tbNamaPegawai.ReadOnly = false;
            tbAlamatPegawai.ReadOnly = false;
            tbGajiPegawai.ReadOnly = false;
            tbNomorTeleponPegawai.ReadOnly = false;
            comboCabang.Enabled = true;
            comboJabatan.Enabled = true;
        }

        public void clearInput()
        {
            id = 0;
            tbNamaPegawai.Text = "";
            tbAlamatPegawai.Text = "";
            tbNomorTeleponPegawai.Text = "";
            tbGajiPegawai.Text = "";
        }

        private async void submenuPegawai_Load(object sender, EventArgs e)
        {
            disableInput();

            //load tabel pegawai
            DataTable t = await GetPegawai();
            t.Columns.Remove("id_branch");
            t.Columns.Remove("id_role");
            dataPegawai.DataSource = t;

            //load combobox cabang
            comboCabang.DataSource = await GetCabang();
            comboCabang.ValueMember = "id_branch";
            comboCabang.DisplayMember = "branch_name";

            //load combobox jabatan
            comboJabatan.DataSource = await GetJabatan();
            comboJabatan.ValueMember = "id_role";
            comboJabatan.DisplayMember = "role_name";
        }

        static async Task<DataTable> GetPegawai()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/employees");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetCabang()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/branches");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetJabatan()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/roles");

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

        private async void btnSimpanPeg_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNamaPegawai.Text.ToString().Trim() != "" && tbNomorTeleponPegawai.Text.ToString().Trim() != "" && tbAlamatPegawai.Text.ToString().Trim() != "" && tbGajiPegawai.Text.ToString().Trim() != "" && comboCabang.SelectedValue.ToString().Trim() != "" && comboJabatan.SelectedValue.ToString().Trim() != "")
                {
                    if(check.Equals("simpan"))
                    {
                        var name = tbNamaPegawai.Text.ToString();
                        var firstname = name.Split(' ')[0];
                        var lastname = name.Split(' ')[1];

                        Employee employee = new Employee { first_name = firstname, last_name = lastname, address = tbAlamatPegawai.Text.ToString(), phone_number = tbNomorTeleponPegawai.Text.ToString(), salary = double.Parse(tbGajiPegawai.Text.ToString()), id_branch = comboCabang.SelectedIndex + 1, id_role = comboJabatan.SelectedIndex + 1 };

                        var response = client.PostAsJsonAsync("api/employees", employee).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var a = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(a);
                            DataTable t = await GetPegawai();
                            t.Columns.Remove("id_branch");
                            t.Columns.Remove("id_role");
                            dataPegawai.DataSource = t;
                            dataPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            MessageBox.Show("Berhasil Input Data Pegawai");
                        }
                    }
                    else if(check.Equals("edit"))
                    {
                        var name = tbNamaPegawai.Text.ToString();
                        var firstname = name.Split(' ')[0];
                        var lastname = name.Split(' ')[1];

                        Employee employee = new Employee { id_employee = id, first_name = firstname, last_name = lastname, address = tbAlamatPegawai.Text.ToString(), phone_number = tbNomorTeleponPegawai.Text.ToString(), salary = double.Parse(tbGajiPegawai.Text.ToString()), id_branch = comboCabang.SelectedIndex + 1, id_role = comboJabatan.SelectedIndex + 1 };

                        HttpResponseMessage response = await client.PutAsJsonAsync(
                        $"api/employees/{employee.id_employee}", employee);
                        response.EnsureSuccessStatusCode();
                        employee = await response.Content.ReadAsAsync<Employee>();
                        DataTable t = await GetPegawai();
                        t.Columns.Remove("id_branch");
                        t.Columns.Remove("id_role");
                        dataPegawai.DataSource = t;
                        dataPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        MessageBox.Show("Berhasil Update Data Pegawai");
                    }

                    clearInput();
                    disableInput();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private async void btnCariPeg_Click(object sender, EventArgs e)
        {
            string searchValue = tbCariPeg.Text;

            dataPegawai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCariPeg.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dataPegawai.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            id = Convert.ToInt16(row.Cells[0].Value);
                            Debug.WriteLine("bind :" + id);
                            tbNamaPegawai.Text = Convert.ToString(row.Cells["name"].Value);
                            tbAlamatPegawai.Text = row.Cells[2].Value.ToString();
                            tbNomorTeleponPegawai.Text = row.Cells[3].Value.ToString();
                            tbGajiPegawai.Text = row.Cells[4].Value.ToString();
                            row.Selected = true;
                            ((DataTable)dataPegawai.DataSource).DefaultView.RowFilter = string.Format("name like '%{0}%'", tbCariPeg.Text.Trim().Replace("'", "''"));
                            Debug.WriteLine("masuk edit");
                            
                            break;
                        }
                    }
                }
                else
                {
                    DataTable t = await GetPegawai();
                    t.Columns.Remove("id_branch");
                    t.Columns.Remove("id_role");
                    dataPegawai.DataSource = t;
                    dataPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                DataTable t = await GetPegawai();
                t.Columns.Remove("id_branch");
                t.Columns.Remove("id_role");
                dataPegawai.DataSource = t;
                dataPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        private void buttonSimpan_Click(object sender, EventArgs e)
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

        private void btnResetPeg_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private async void dataPegawai_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    HttpResponseMessage response = await client.DeleteAsync(
                    $"api/employees/{Convert.ToInt16(dataPegawai.SelectedRows[0].Cells["id_employee"].Value)}");
                    response.EnsureSuccessStatusCode();
                    DataTable t = await GetPegawai();
                    t.Columns.Remove("id_branch");
                    t.Columns.Remove("id_role");
                    dataPegawai.DataSource = t;
                    dataPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
    }
}
