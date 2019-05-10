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

namespace BengkelAtma.Menu
{
    public partial class Sparepart : UserControl
    {
        static HttpClient client = new HttpClient();
        OpenFileDialog open = new OpenFileDialog();
        private string check = "";
        private string id = "";
        private Boolean upload = false;
        private DataTable t2;
        public Sparepart()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("http://p3l.yafetrakan.com/");
        }

        private async void Sparepart_Load(object sender, EventArgs e)
        {
            //dtColumn = new DataColumn();
            //dtColumn.DataType = typeof(String);
            //dtColumn.ColumnName = "text";
            //Table.Columns.Add(dtColumn);

            disableInput();
            pictureBox1.Load("http://p3l.yafetrakan.com/asset/default.png");
            DataTable t = await GetSparepart();
            //t.Columns.Remove("id_branch");
            //t.Columns.Remove("id_role");
            dataSparepart.DataSource = t;
            dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataSparepart.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

            comboSparepartType.DataSource = await GetSparepartType();
            comboSparepartType.ValueMember = "id_sparepart_type";
            comboSparepartType.DisplayMember = "sparepart_type_name";

            comboPosition.DataSource = dataPosisi();
            comboPosition.ValueMember = "id";
            comboPosition.DisplayMember = "text";

            comboTempat.DataSource = dataTempat();
            comboTempat.ValueMember = "id";
            comboTempat.DisplayMember = "text";

            comboMotorBrand.DataSource = await GetMotorBrand();
            comboMotorBrand.ValueMember = "id_motorcycle_brand";
            comboMotorBrand.DisplayMember = "motorcycle_brand_name";

            DataView dv1 = new DataView(await GetMotorType());
            dv1.RowFilter = "id_motorcycle_brand = " + comboMotorBrand.SelectedValue.ToString() + "";
            comboMotorType.DataSource = dv1;
            comboMotorType.ValueMember = "id_motorcycle_type";
            comboMotorType.DisplayMember = "motorcycle_type_name";
        }

        public class SparepartData
        {
            public int id_sparepart { get; set; }
            public string sparepart_name { get; set; }
            public string merk { get; set; }
            public int stock { get; set; }
            public int min_stock { get; set; }
            public double purchase_price { get; set; }
            public double sell_price { get; set; }
            public string placement { get; set; }
            public string position { get; set; }
            public string place { get; set; }
            public string number { get; set; }
            public string image { get; set; }
            public string sparepart_type_name { get; set; }
            public int id_sparepart_type { get; set; }
        }

        public void disableInput()
        {
            tbNameSparepart.Enabled = false;
            tbKodeSparepart.Enabled = false;
            tbMerkSparepart.Enabled = false;
            tbStock.Enabled = false;
            tbMinStock.Enabled = false;
            tbBeli.Enabled = false;
            tbJual.Enabled = false;
            tbNomor.Enabled = false;
            comboSparepartType.Enabled = false;
            comboPosition.Enabled = false;
            comboTempat.Enabled = false;
        }

        public void enableInput()
        {
            tbNameSparepart.Enabled = true;
            tbKodeSparepart.Enabled = true;
            tbMerkSparepart.Enabled = true;
            tbStock.Enabled = true;
            tbMinStock.Enabled = true;
            tbBeli.Enabled = true;
            tbJual.Enabled = true;
            tbNomor.Enabled = true;
            comboSparepartType.Enabled = true;
            comboPosition.Enabled = true;
            comboTempat.Enabled = true;
        }

        public void clearInput()
        {
            id = "";
            tbNameSparepart.Text = "";
            tbKodeSparepart.Text = "";
            tbMerkSparepart.Text = "";
            tbStock.Text = "";
            tbMinStock.Text = "";
            tbBeli.Text = "";
            tbJual.Text = "";
            tbNomor.Text = "";
            pictureBox1.Load("http://p3l.yafetrakan.com/asset/default.png");
            t2 = null;
        }

        static async Task<DataTable> GetSparepart()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/spareparts");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convertSP(a);
            Debug.WriteLine("masuk?");
            Debug.WriteLine(dt);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetMotorBrand()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/motorcycle_brands");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetMotorType()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/motorcycle_types");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetSparepartType()
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync("api/sparepart_types");

            var a = await response.Content.ReadAsStringAsync();
            DataTable dt = new DataTable();
            dt = json_convert(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        static async Task<DataTable> GetCompatibility(string id)
        {
            Console.WriteLine($"cek masuk");

            HttpResponseMessage response = await client.GetAsync($"api/spareparts/{id}");

            var a = await response.Content.ReadAsStringAsync();
            Debug.WriteLine(a);
            //JObject jsonResponse = JObject.Parse(a);
            //var sparepart = jsonResponse["data"]["compatibility"];
            //var comp = sparepart.Children();
            //Debug.WriteLine(a);
            DataTable dt = new DataTable();
            dt = json_convert2(a);
            Debug.WriteLine(dt.Rows.Count);


            return dt;

        }

        public static DataTable json_convert(string json)
        {
            JObject json_object = JObject.Parse(json);

            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            Debug.WriteLine(json_array);
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }
        public static DataTable json_convertSP(string json)
        {
            JObject json_object = JObject.Parse(json);
            DataTable dt = new DataTable();

            JArray json_array = JArray.Parse(json_object["data"].ToString());
            json_array.Descendants().OfType<JProperty>()
                  .Where(p => p.Name == "compatibility")
                  .ToList()
                  .ForEach(att => att.Remove());
            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        public static DataTable json_convert2(string json)
        {
            JObject json_object = JObject.Parse(json);
            Debug.WriteLine(json_object);
            DataTable dt = new DataTable();
            Debug.WriteLine("yi");
            JArray json_array = JArray.Parse(json_object["data"]["compatibility"]["data"].ToString());

            dt = JsonConvert.DeserializeObject<DataTable>(json_array.ToString());

            return dt;
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> motorcycleTypes = new List<int>();
                string motor = "";
                foreach (DataGridViewRow row in dataCompatibility.Rows)
                {
                    string id_motorcycle_type = Convert.ToString(row.Cells["id_motorcycle_type"].Value);
                    if (!id_motorcycle_type.Equals(""))
                    {
                        if (!motor.Equals(""))
                        {
                            motor = motor + "," + id_motorcycle_type;
                        }
                        else
                        {
                            motor = id_motorcycle_type;
                        }
                    }


                }
                Debug.WriteLine(motor);
                if (tbMerkSparepart.Text.ToString().Trim() != "" && tbNameSparepart.Text.ToString().Trim() != "" && tbKodeSparepart.Text.ToString().Trim() != "" && tbMinStock.Text.ToString().Trim() != "" && tbStock.Text.ToString().Trim() != "" && tbBeli.Text.ToString().Trim() != "" && tbJual.Text.ToString().Trim() != "" && tbNomor.Text.ToString().Trim() != "")
                {
                    if (tbBeli.Text.ToString() == tbJual.Text.ToString())
                    {
                        MessageBox.Show("Harga Jual tidak boleh sama dengan harga beli");
                    }
                    else if (Double.Parse(tbBeli.Text.ToString()) > Double.Parse(tbJual.Text.ToString()))
                    {
                        MessageBox.Show("Harga Jual tidak boleh lebih kecil  harga beli");
                    }
                    else
                    {
                        string placement;
                        if (check.Equals("simpan"))
                        {
                            Debug.WriteLine("masuk simpan");
                            Debug.WriteLine(tbKodeSparepart.Text);
                            Debug.WriteLine(motor);
                            placement = comboPosition.SelectedValue.ToString() + "-" + comboTempat.SelectedValue.ToString() + "-" + tbNomor.Text.ToString();
                            MultipartFormDataContent form = new MultipartFormDataContent();
                            form.Add(new StringContent(tbKodeSparepart.Text), "id_sparepart");
                            form.Add(new StringContent(tbNameSparepart.Text), "sparepart_name");
                            form.Add(new StringContent(tbMerkSparepart.Text), "merk");
                            form.Add(new StringContent(tbStock.Text), "stock");
                            form.Add(new StringContent(tbMinStock.Text), "min_stock");
                            form.Add(new StringContent(tbBeli.Text), "purchase_price");
                            form.Add(new StringContent(tbJual.Text), "sell_price");
                            form.Add(new StringContent(comboSparepartType.SelectedValue.ToString()), "id_sparepart_type");
                            form.Add(new StringContent(placement), "placement");
                            form.Add(new StringContent(motor.ToString()), "motorcycleTypes");
                            form.Add(new StringContent("true"), "desktop");

                            if (upload == true)
                            {
                                MemoryStream ms = new MemoryStream();

                                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                byte[] buff = ms.GetBuffer();
                                form.Add(new ByteArrayContent(buff, 0, buff.Length), "image", open.SafeFileName);
                            }

                            Debug.WriteLine(form);

                            var response = client.PostAsync("api/spareparts", form).Result;

                            var a = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(a);
                            DataTable t = await GetSparepart();
                            dataSparepart.DataSource = t;
                            dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            MessageBox.Show("Berhasil Input Data Sparepart");

                        }
                        else if (check.Equals("edit"))
                        {
                            Debug.WriteLine("masuk edit");
                            placement = comboPosition.SelectedValue.ToString() + "-" + comboTempat.SelectedValue.ToString() + "-" + tbNomor.Text.ToString();
                            MultipartFormDataContent form = new MultipartFormDataContent();
                            form.Add(new StringContent(tbKodeSparepart.Text), "id_sparepart");
                            form.Add(new StringContent(tbNameSparepart.Text), "sparepart_name");
                            form.Add(new StringContent(tbMerkSparepart.Text), "merk");
                            form.Add(new StringContent(tbStock.Text), "stock");
                            form.Add(new StringContent(tbMinStock.Text), "min_stock");
                            form.Add(new StringContent(tbBeli.Text), "purchase_price");
                            form.Add(new StringContent(tbJual.Text), "sell_price");
                            form.Add(new StringContent(comboSparepartType.SelectedValue.ToString()), "id_sparepart_type");
                            form.Add(new StringContent(placement), "placement");
                            form.Add(new StringContent(motor), "motorcycleTypes");


                            Debug.WriteLine("cek mana");
                            if (upload == true)
                            {
                                MemoryStream ms = new MemoryStream();

                                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                byte[] buff = ms.GetBuffer();
                                form.Add(new ByteArrayContent(buff, 0, buff.Length), "image", open.SafeFileName);
                            }

                            var response = client.PostAsync($"api/updatesparepart/{tbKodeSparepart.Text.ToString()}", form).Result;

                            var a = await response.Content.ReadAsStringAsync();
                            Debug.WriteLine(a);

                            DataTable t = await GetSparepart();
                            dataSparepart.DataSource = t;
                            dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                            MessageBox.Show("Berhasil Ubah Data Sparepart");


                        }
                        clearInput();
                        disableInput();
                    }

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tbMerkSparepart.Text.ToString().Trim() != "" && tbNameSparepart.Text.ToString().Trim() != "" && tbKodeSparepart.Text.ToString().Trim() != "" && tbMinStock.Text.ToString().Trim() != "" && tbStock.Text.ToString().Trim() != "" && tbBeli.Text.ToString().Trim() != "" && tbJual.Text.ToString().Trim() != "" && tbNomor.Text.ToString().Trim() != "")
            {
                clearInput();
            }
            else
            {
                MessageBox.Show(" Anda harus memilih menu input atau edit terlebih dahulu");
            }
        }

        private DataTable dataPosisi()
        {
            DataTable Table = new DataTable("Position");
            DataColumn dtColumn;
            DataRow myDataRow;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "id";
            Table.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "text";
            Table.Columns.Add(dtColumn);

            DataSet dtSet = new DataSet();

            dtSet.Tables.Add(Table);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "DPN";
            myDataRow["text"] = "Depan";
            Table.Rows.Add(myDataRow);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "TGH";
            myDataRow["text"] = "Tengah";
            Table.Rows.Add(myDataRow);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "BLK";
            myDataRow["text"] = "Belakang";
            Table.Rows.Add(myDataRow);

            return Table;
        }

        private DataTable dataTempat()
        {
            DataTable Table = new DataTable("Placement");
            DataColumn dtColumn;
            DataRow myDataRow;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "id";
            Table.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "text";
            Table.Columns.Add(dtColumn);

            DataSet dtSet = new DataSet();

            dtSet.Tables.Add(Table);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "KACA";
            myDataRow["text"] = "Rak Kaca";
            Table.Rows.Add(myDataRow);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "DUS";
            myDataRow["text"] = "Tumpukan Dus";
            Table.Rows.Add(myDataRow);

            myDataRow = Table.NewRow();
            myDataRow["id"] = "KAYU";
            myDataRow["text"] = "Lemari Kayu";
            Table.Rows.Add(myDataRow);

            return Table;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                upload = true;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            check = "simpan";
            clearInput();
            enableInput();

        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            check = "edit";
            enableInput();
            foreach (DataGridViewRow row in dataSparepart.Rows)
            {
                if (row.Selected == true)
                {
                    {

                        id = Convert.ToString(row.Cells[0].Value);
                        tbNameSparepart.Text = Convert.ToString(row.Cells["sparepart_name"].Value);
                        tbKodeSparepart.Text = Convert.ToString(row.Cells["id_sparepart"].Value);
                        tbMerkSparepart.Text = Convert.ToString(row.Cells["merk"].Value);
                        tbStock.Text = Convert.ToString(row.Cells["stock"].Value);
                        tbMinStock.Text = Convert.ToString(row.Cells["min_stock"].Value);
                        tbBeli.Text = Convert.ToString(row.Cells["purchase_price"].Value);
                        tbJual.Text = Convert.ToString(row.Cells["sell_price"].Value);
                        string[] placement = Convert.ToString(row.Cells["placement"].Value).Split('-');
                        tbNomor.Text = placement[2];
                        comboPosition.SelectedValue = placement[0];
                        comboTempat.SelectedValue = placement[1];
                        comboSparepartType.SelectedIndex = comboSparepartType.FindStringExact(Convert.ToString(row.Cells["sparepart_type_name"].Value));
                        if (!Convert.ToString(row.Cells["image"].Value).Equals(""))
                        {
                            pictureBox1.Load("http://p3l.yafetrakan.com/images/" + Convert.ToString(row.Cells["image"].Value));
                        }

                        t2 = await GetCompatibility(id);
                        //t.Columns.Remove("id_branch");
                        //t.Columns.Remove("id_role");
                        dataCompatibility.DataSource = t2;
                        //tbNamaPegawai.Text = Convert.ToString(row.Cells["name"].Value);
                        //tbAlamatPegawai.Text = row.Cells[2].Value.ToString();
                        //tbNomorTeleponPegawai.Text = row.Cells[3].Value.ToString();
                        //tbGajiPegawai.Text = row.Cells[4].Value.ToString();
                    }
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            dataSparepart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataSparepart.SelectedRows)
            {
                if (row.Selected == true)
                {
                    try
                    {
                        DialogResult res = MessageBox.Show("Anda yakin akan menghapus data?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {

                            HttpResponseMessage response = await client.DeleteAsync(
                            $"api/spareparts/{Convert.ToString(row.Cells["id_sparepart"].Value)}");
                            response.EnsureSuccessStatusCode();
                            DataTable t = await GetSparepart();
                            dataSparepart.DataSource = t;
                            dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataSparepart.DataBindingComplete += (o, _) =>
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

        private async void btnCari_Click(object sender, EventArgs e)
        {
            disableInput();
            string searchValue = tbCari.Text;

            dataSparepart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                if (tbCari.Text.Trim() != "")
                {
                    foreach (DataGridViewRow row in dataSparepart.Rows)
                    {
                        Debug.WriteLine(searchValue);
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
                        {
                            id = Convert.ToString(row.Cells[0].Value);
                            row.Selected = true;
                            ((DataTable)dataSparepart.DataSource).DefaultView.RowFilter = string.Format("sparepart_name like '%{0}%'", tbCari.Text.Trim().Replace("'", "''"));

                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Anda Belum Memasukkan Data");
                    DataTable t = await GetSparepart();
                    dataSparepart.DataSource = t;
                    dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataSparepart.DataBindingComplete += (o, _) =>
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
                DataTable t = await GetSparepart();
                dataSparepart.DataSource = t;
                dataSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataSparepart.DataBindingComplete += (o, _) =>
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

        private async void comboMotorBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv1 = new DataView(await GetMotorType());
            dv1.RowFilter = "id_motorcycle_brand = " + comboMotorBrand.SelectedValue.ToString() + "";
            comboMotorType.DataSource = dv1;
            comboMotorType.ValueMember = "id_motorcycle_type";
            comboMotorType.DisplayMember = "motorcycle_type_name";
        }

        private void btnCompatibility_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(comboMotorType.SelectedText.ToString());
            if (t2 == null)
            {
                t2 = new DataTable();
                t2.Columns.Add("id_motorcycle_type");
                t2.Columns.Add("motorcycle_type_name");
                t2.Columns.Add("id_motorcycle_brand");
                t2.Columns.Add("motorcycle_brand");
                DataRow row = t2.NewRow();
                row["id_motorcycle_type"] = Convert.ToInt16(comboMotorType.SelectedValue.ToString());
                row["motorcycle_type_name"] = comboMotorType.GetItemText(comboMotorType.SelectedItem);
                row["id_motorcycle_brand"] = Convert.ToInt16(comboMotorBrand.SelectedValue.ToString());
                row["motorcycle_brand"] = comboMotorBrand.GetItemText(comboMotorBrand.SelectedItem);
                t2.Rows.Add(row);
            }
            else if (t2 != null)
            {
                DataRow row = t2.NewRow();
                row["id_motorcycle_type"] = Convert.ToInt16(comboMotorType.SelectedValue.ToString());
                row["motorcycle_type_name"] = comboMotorType.GetItemText(comboMotorType.SelectedItem);
                row["id_motorcycle_brand"] = Convert.ToInt16(comboMotorBrand.SelectedValue.ToString());
                row["motorcycle_brand"] = comboMotorBrand.GetItemText(comboMotorBrand.SelectedItem);
                t2.Rows.Add(row);
            }

            dataCompatibility.DataSource = t2;
        }

        private void tbKodeSparepart_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbNameSparepart.Focus();
            }
        }

        private void tbNameSparepart_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbMerkSparepart.Focus();
            }
        }

        private void tbMerkSparepart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboSparepartType.Focus();
            }
        }

        private void tbStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbMinStock.Focus();
            }
        }

        private void comboSparepartType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbStock.Focus();
            }
        }

        private void tbMinStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbBeli.Focus();
            }
        }

        private void tbJual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboPosition.Focus();
            }
        }

        private void tbBeli_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                tbJual.Focus();
            }
           

        }

        private void comboPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboTempat.Focus();
            }

        }

        private void comboTempat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbNomor.Focus();
            }
        }


    }
}
