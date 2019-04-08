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
    public partial class Akun : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private string check = "";
        private int id;

        public Akun()
        {
            InitializeComponent();
            //client.Dispose();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");

        }



        public class User
        {
            public int id_user { get; set; }
            public int id_employee { get; set; }
            public string username { get; set; }
            public string password { get; set; }
           
        }

        public void disableInput()
        {
            tbOldPassAkun.ReadOnly = true;
            tbNewPassAkun.ReadOnly = true;
        }

        public void enableInput()
        {
            tbOldPassAkun.ReadOnly = false;
            tbNewPassAkun.ReadOnly = false;
        }

        public void clearInput()
        {
            tbOldPassAkun.Text = "";
            tbNewPassAkun.Text = "";
        }

        private async void Akun_Load(object sender, EventArgs e)
        {
            //load tabel pegawai
            disableInput();
            DataTable t = await GetAkun();
            t.Columns.Remove("role");
            t.Columns.Remove("name");
            dgAkun.DataSource = t;
            dgAkun.Columns[dgAkun.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgAkun.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
            
        }

        static async Task<DataTable> GetAkun()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/user");

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


        private async void btnSimpanAkun_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbOldPassAkun.Text.ToString().Trim() != "" && tbNewPassAkun.Text.ToString().Trim() != "" )
                {
                    if (check.Equals("simpan"))
                    {
                        Debug.WriteLine("masuuuk simpan");
                        var pass = tbNewPassAkun.Text.ToString();
                        Debug.WriteLine(pass);

                        User user = new User {  id_user = id, password = tbNewPassAkun.Text.ToString() };

                        var response = client.PostAsJsonAsync("api/user", user).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var a = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(a);
                            DataTable t = await GetAkun();
                            t.Columns.Remove("role");
                            t.Columns.Remove("name");
                            dgAkun.DataSource = t;
                            dgAkun.DataBindingComplete += (o, _) =>
                            {
                                var dataGridView = o as DataGridView;
                                if (dataGridView != null)
                                {
                                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                            };

                            MessageBox.Show("Berhasil Mengganti Password");
                        }
                    }
                    else if (check.Equals("edit"))
                    {
                        var pass = tbNewPassAkun.Text.ToString();

                        User user = new User { id_user = id, password = tbNewPassAkun.Text.ToString() };

                        HttpResponseMessage response = await client.PutAsJsonAsync(
                        $"api/users/{user.id_user}", user);
                        response.EnsureSuccessStatusCode();
                        user = await response.Content.ReadAsAsync<User>();
                        DataTable t = await GetAkun();
                        t.Columns.Remove("role");
                        t.Columns.Remove("name");
                        dgAkun.DataSource = t;
                        dgAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                        dgAkun.DataBindingComplete += (o, _) =>
                        {
                            var dataGridView = o as DataGridView;
                            if (dataGridView != null)
                            {
                                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                                dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            }
                        };

                        MessageBox.Show("Berhasil Update Password");
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

        private async void btnCariAkun_Click(object sender, EventArgs e)
        {
            string searchValue = tbCariAkun.Text;
            disableInput();
            //dgAkun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCariAkun.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dgAkun.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
                        {
                            id = Convert.ToInt16(row.Cells[0].Value);
                            Debug.WriteLine("bind :" + id);
                            //userlabel.Text = "User: "+Convert.ToString(row.Cells["username"].Value);
                            //userlabel.Visible = true;
                            //row.Selected = true;
                            ((DataTable)dgAkun.DataSource).DefaultView.RowFilter = string.Format("username like '%{0}%'", tbCariAkun.Text.Trim().Replace("'", "''"));
                            Debug.WriteLine("masuk edit");

                            break;
                        }
                    }
                }
                else
                {
                    DataTable t = await GetAkun();
                    t.Columns.Remove("role");
                    t.Columns.Remove("name");
                    dgAkun.DataSource = t;
                    dgAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    dgAkun.DataBindingComplete += (o, _) =>
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
                DataTable t = await GetAkun();
                t.Columns.Remove("role");
                t.Columns.Remove("name");
                dgAkun.DataSource = t;
                dgAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgAkun.DataBindingComplete += (o, _) =>
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

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            disableInput();
            check = "simpan";
            clearInput();
            //enableInput();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            check = "edit";
            enableInput();
            dgAkun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dgAkun.Rows)
            {
                if (row.Selected==true)
                {
                    id = Convert.ToInt16(row.Cells[0].Value);
                    Debug.WriteLine("bind :" + id);
                    userlabel.Text = "User: "+Convert.ToString(row.Cells["username"].Value);
                    userlabel.Visible = true;
                    
                    ((DataTable)dgAkun.DataSource).DefaultView.RowFilter = string.Format("username like '%{0}%'", tbCariAkun.Text.Trim().Replace("'", "''"));
                    Debug.WriteLine("masuk edit");

                    break;
                }
            }
        }

        private void btnResetAkun_Click(object sender, EventArgs e)
        {
            clearInput();
            
        }


        private async void dgAkun_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    HttpResponseMessage response = await client.DeleteAsync(
                    $"api/users/{Convert.ToInt16(dgAkun.SelectedRows[0].Cells["id"].Value)}");
                    response.EnsureSuccessStatusCode();
                    DataTable t = await GetAkun();
                    t.Columns.Remove("role");
                    t.Columns.Remove("name");
                    dgAkun.DataSource = t;
                    dgAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void dgAkun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgAkun.Rows[e.RowIndex].ReadOnly = true;
            var a = dgAkun.Rows;
        }

        private async void bootomContent_Click(object sender, EventArgs e)
        {
            dgAkun.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dgAkun.SelectedRows)
            {   if (row.Selected == true)
                {
                    try
                    {
                        DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {

                            HttpResponseMessage response = await client.DeleteAsync(
                            $"api/users/{Convert.ToInt16(dgAkun.SelectedRows[0].Cells["id"].Value)}");
                            response.EnsureSuccessStatusCode();
                            DataTable t = await GetAkun();
                            t.Columns.Remove("role");
                            t.Columns.Remove("name");
                            dgAkun.DataSource = t;
                            dgAkun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
    }
 }




    //private void submenuAkun_SelectedIndexChanged(object sender, EventArgs e)
       // {

        //}

        

 
