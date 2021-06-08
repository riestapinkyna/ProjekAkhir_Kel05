using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir_Kel05
{
    public partial class CRUD_Supplier : Form
    {
        SqlConnection con = new SqlConnection("integrated security=true; data source=.;initial catalog=PRG2_KEL05");
        DataClasses1DataContext db = new DataClasses1DataContext();
        public CRUD_Supplier()
        {
            InitializeComponent();
        }

        private void simpanbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;
                string nama = txtnama.Text;
                string no = txtno.Text;
                string alamatsup = txtalamat.Text;
                if (no.Length > 13 || nama == "" || no == "" || alamatsup == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var data = new tblSupplier
                    {
                        id_supplier = id,
                        nama_supplier = nama,
                        no_telepon = no,
                        alamat = alamatsup
                    };
                    db.tblSuppliers.InsertOnSubmit(data);
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

        private void CRUD_Supplier_Load(object sender, EventArgs e)
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
        void LoadData()
        {
            try
            {
                txtnama.Clear();
                txtalamat.Clear();
                txtno.Clear();
                txtid.Enabled = false;
                editbutton.Enabled = false;
                hapusbutton.Enabled = false;
                simpanbutton.Enabled = true;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (id_supplier)+1 FROM tblSupplier", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtid.Text = "SP" + dt.Rows[0][0].ToString();
                var st = from tb in db.tblSuppliers select tb;
                dataGridView1.DataSource = st;
                dataGridView1.Columns[0].HeaderCell.Value = "ID Supplier";
                dataGridView1.Columns[1].HeaderCell.Value = "Nama Supplier";
                dataGridView1.Columns[2].HeaderCell.Value = "No Telepon";
                dataGridView1.Columns[3].HeaderCell.Value = "Alamat";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            simpanbutton.Enabled = false;
            editbutton.Enabled = true;
            hapusbutton.Enabled = true;
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtid.Text = row.Cells[0].Value.ToString();
                txtnama.Text = row.Cells[1].Value.ToString();
                txtno.Text = row.Cells[2].Value.ToString();
                txtalamat.Text = row.Cells[3].Value.ToString();
            }
        }

        private void batalbutton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;
                string nama = txtnama.Text;
                string no = txtno.Text;
                string alamatsup = txtalamat.Text;
                if (no.Length > 13 || nama == "" || no == "" || alamatsup == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var st = (from s in db.tblSuppliers where s.id_supplier == id select s).First();
                    st.nama_supplier = nama;
                    st.nama_supplier = no;
                    st.alamat = alamatsup;
                    db.SubmitChanges();
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void hapusbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = from s in db.tblSuppliers where s.id_supplier == txtid.Text select s;
                foreach (var t in delete)
                {
                    db.tblSuppliers.DeleteOnSubmit(t);
                }
                db.SubmitChanges();
                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }
    }
}
