using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjekAkhir_Kel05
{
    public partial class CRUDPakaian : Form
    {
        SqlConnection con = new SqlConnection("integrated security=true; data source=.;initial catalog=PRG2_KEL05");
        DataClasses1DataContext db = new DataClasses1DataContext();

        public CRUDPakaian()
        {
            InitializeComponent();
        }

        private void simpanbutton_Click(object sender, EventArgs e)
        {

            try
            {
                string id = txtid.Text;
                string jenis = cbjenis.SelectedItem.ToString();
                string supplier = cbsupplier.SelectedItem.ToString();
                string nama = txtnama.Text;
                int stock = int.Parse(txtstock.Text);
                decimal hargabeli = decimal.Parse(txthargabeli.Text);
                decimal hargajual = decimal.Parse(txthargajual.Text);
                string keterangan = txtketerangan.Text;
                if (jenis == "" || supplier == "" || nama == "" || keterangan == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var data = new tblPakaian
                    {
                        id_pakaian = id,
                        id_jenis = jenis,
                        id_supplier = supplier,
                        nama_pakaian = nama,
                        stock = stock,
                        harga_beli = hargabeli,
                        harga_jual = hargajual,
                        keterangan = keterangan
                    };
                    db.tblPakaians.InsertOnSubmit(data);
                    db.SubmitChanges();
                    MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void LoadData()
        {
            try
            {
                cbjenis.SelectedIndex = -1;
                cbsupplier.SelectedIndex = -1;
                txtnama.Clear();
                txtstock.Clear();
                txthargajual.Clear();
                txthargabeli.Clear();
                txtketerangan.Clear();
                txtid.Enabled = false;
                editbutton.Enabled = false;
                hapusbutton.Enabled = false;
                simpanbutton.Enabled = true;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (id_pakaian)+1 FROM tblPakaian", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtid.Text = "PK" + dt.Rows[0][0].ToString();
                var st = from tb in db.tblPakaians select tb;
                dataGridView1.DataSource = st;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void CRUDPakaian_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}

