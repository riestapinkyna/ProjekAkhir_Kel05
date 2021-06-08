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
    public partial class CRUDJenisBaju : Form
    {
        SqlConnection con = new SqlConnection("integrated security=true; data source=.;initial catalog=PRG2_KEL05");
        DataClasses1DataContext db = new DataClasses1DataContext();
        public CRUDJenisBaju()
        {
            InitializeComponent();
        }

        private void simpanbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;
                string deskripsi = txtdeskripsi.Text;
                if (deskripsi == "")
                {
                    MessageBox.Show("Harap isikan data dengan benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var data = new tblJenis_Pakaian
                    {
                        id_jenis = id,
                        deskripsi_jenis = deskripsi
                    };
                    db.tblJenis_Pakaians.InsertOnSubmit(data);
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

        private void CRUDJenisBaju_Load(object sender, EventArgs e)
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
                txtdeskripsi.Clear();
                txtid.Enabled = false;
                editbutton.Enabled = false;
                hapusbutton.Enabled = false;
                simpanbutton.Enabled = true;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (id_jenis)+1 FROM tblJenis_Pakaian", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                txtid.Text = "JNS" + dt.Rows[0][0].ToString();
                var st = from tb in db.tblJenis_Pakaians select tb;
                dataGridView1.DataSource = st;
                dataGridView1.Columns[0].HeaderCell.Value = "ID Pakaian";
                dataGridView1.Columns[1].HeaderCell.Value = "Deskripsi";
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
                txtdeskripsi.Text = row.Cells[1].Value.ToString();
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
                string deskripsi = txtdeskripsi.Text;
                var st = (from s in db.tblJenis_Pakaians where s.id_jenis== id select s).First();
                st.deskripsi_jenis = deskripsi;
                db.SubmitChanges();
                MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
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
                var delete = from s in db.tblJenis_Pakaians where s.id_jenis == txtid.Text select s;
                foreach (var t in delete)
                {
                    db.tblJenis_Pakaians.DeleteOnSubmit(t);
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
