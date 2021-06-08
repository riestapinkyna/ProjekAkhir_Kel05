namespace ProjekAkhir_Kel05
{
    partial class CRUD_Supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Supplier));
            this.txtnama = new PRG2_UserControl_KEL05.CharTextBoxt();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.kembalibutton = new ns1.BunifuFlatButton();
            this.batalbutton = new ns1.BunifuFlatButton();
            this.hapusbutton = new ns1.BunifuFlatButton();
            this.editbutton = new ns1.BunifuFlatButton();
            this.simpanbutton = new ns1.BunifuFlatButton();
            this.txtno = new PRG2_UserControl_KEL05.NumericTextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(10, 247);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(213, 20);
            this.txtnama.TabIndex = 54;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(536, 122);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(339, 51);
            this.bunifuCustomLabel10.TabIndex = 53;
            this.bunifuCustomLabel10.Text = "DATA SUPPLIER";
            this.bunifuCustomLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(490, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 446);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 374);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel6.TabIndex = 43;
            this.bunifuCustomLabel6.Text = "ALAMAT";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(13, 303);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel5.TabIndex = 42;
            this.bunifuCustomLabel5.Text = "NO TELEPON";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 231);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(99, 13);
            this.bunifuCustomLabel4.TabIndex = 41;
            this.bunifuCustomLabel4.Text = "NAMA SUPPLIER";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.DarkBlue;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 160);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(77, 13);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "ID SUPPLIER";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 176);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(214, 20);
            this.txtid.TabIndex = 36;
            // 
            // kembalibutton
            // 
            this.kembalibutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.kembalibutton.BackColor = System.Drawing.Color.Navy;
            this.kembalibutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kembalibutton.BorderRadius = 0;
            this.kembalibutton.ButtonText = "Kembali";
            this.kembalibutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kembalibutton.DisabledColor = System.Drawing.Color.Gray;
            this.kembalibutton.Iconcolor = System.Drawing.Color.Transparent;
            this.kembalibutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("kembalibutton.Iconimage")));
            this.kembalibutton.Iconimage_right = null;
            this.kembalibutton.Iconimage_right_Selected = null;
            this.kembalibutton.Iconimage_Selected = null;
            this.kembalibutton.IconMarginLeft = 0;
            this.kembalibutton.IconMarginRight = 0;
            this.kembalibutton.IconRightVisible = true;
            this.kembalibutton.IconRightZoom = 0D;
            this.kembalibutton.IconVisible = true;
            this.kembalibutton.IconZoom = 90D;
            this.kembalibutton.IsTab = false;
            this.kembalibutton.Location = new System.Drawing.Point(54, 587);
            this.kembalibutton.Name = "kembalibutton";
            this.kembalibutton.Normalcolor = System.Drawing.Color.Navy;
            this.kembalibutton.OnHovercolor = System.Drawing.Color.Navy;
            this.kembalibutton.OnHoverTextColor = System.Drawing.Color.White;
            this.kembalibutton.selected = false;
            this.kembalibutton.Size = new System.Drawing.Size(127, 35);
            this.kembalibutton.TabIndex = 51;
            this.kembalibutton.Text = "Kembali";
            this.kembalibutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kembalibutton.Textcolor = System.Drawing.Color.White;
            this.kembalibutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // batalbutton
            // 
            this.batalbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.batalbutton.BackColor = System.Drawing.Color.Navy;
            this.batalbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batalbutton.BorderRadius = 0;
            this.batalbutton.ButtonText = "Batal";
            this.batalbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batalbutton.DisabledColor = System.Drawing.Color.Gray;
            this.batalbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.batalbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("batalbutton.Iconimage")));
            this.batalbutton.Iconimage_right = null;
            this.batalbutton.Iconimage_right_Selected = null;
            this.batalbutton.Iconimage_Selected = null;
            this.batalbutton.IconMarginLeft = 0;
            this.batalbutton.IconMarginRight = 0;
            this.batalbutton.IconRightVisible = true;
            this.batalbutton.IconRightZoom = 0D;
            this.batalbutton.IconVisible = true;
            this.batalbutton.IconZoom = 90D;
            this.batalbutton.IsTab = false;
            this.batalbutton.Location = new System.Drawing.Point(125, 546);
            this.batalbutton.Name = "batalbutton";
            this.batalbutton.Normalcolor = System.Drawing.Color.Navy;
            this.batalbutton.OnHovercolor = System.Drawing.Color.Navy;
            this.batalbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.batalbutton.selected = false;
            this.batalbutton.Size = new System.Drawing.Size(99, 35);
            this.batalbutton.TabIndex = 50;
            this.batalbutton.Text = "Batal";
            this.batalbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.batalbutton.Textcolor = System.Drawing.Color.White;
            this.batalbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalbutton.Click += new System.EventHandler(this.batalbutton_Click);
            // 
            // hapusbutton
            // 
            this.hapusbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hapusbutton.BackColor = System.Drawing.Color.Navy;
            this.hapusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hapusbutton.BorderRadius = 0;
            this.hapusbutton.ButtonText = "Hapus";
            this.hapusbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hapusbutton.DisabledColor = System.Drawing.Color.Gray;
            this.hapusbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.hapusbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("hapusbutton.Iconimage")));
            this.hapusbutton.Iconimage_right = null;
            this.hapusbutton.Iconimage_right_Selected = null;
            this.hapusbutton.Iconimage_Selected = null;
            this.hapusbutton.IconMarginLeft = 0;
            this.hapusbutton.IconMarginRight = 0;
            this.hapusbutton.IconRightVisible = true;
            this.hapusbutton.IconRightZoom = 0D;
            this.hapusbutton.IconVisible = true;
            this.hapusbutton.IconZoom = 90D;
            this.hapusbutton.IsTab = false;
            this.hapusbutton.Location = new System.Drawing.Point(10, 546);
            this.hapusbutton.Name = "hapusbutton";
            this.hapusbutton.Normalcolor = System.Drawing.Color.Navy;
            this.hapusbutton.OnHovercolor = System.Drawing.Color.Navy;
            this.hapusbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.hapusbutton.selected = false;
            this.hapusbutton.Size = new System.Drawing.Size(99, 35);
            this.hapusbutton.TabIndex = 49;
            this.hapusbutton.Text = "Hapus";
            this.hapusbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapusbutton.Textcolor = System.Drawing.Color.White;
            this.hapusbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusbutton.Click += new System.EventHandler(this.hapusbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.editbutton.BackColor = System.Drawing.Color.Navy;
            this.editbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editbutton.BorderRadius = 0;
            this.editbutton.ButtonText = "Edit";
            this.editbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbutton.DisabledColor = System.Drawing.Color.Gray;
            this.editbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.editbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("editbutton.Iconimage")));
            this.editbutton.Iconimage_right = null;
            this.editbutton.Iconimage_right_Selected = null;
            this.editbutton.Iconimage_Selected = null;
            this.editbutton.IconMarginLeft = 0;
            this.editbutton.IconMarginRight = 0;
            this.editbutton.IconRightVisible = true;
            this.editbutton.IconRightZoom = 0D;
            this.editbutton.IconVisible = true;
            this.editbutton.IconZoom = 90D;
            this.editbutton.IsTab = false;
            this.editbutton.Location = new System.Drawing.Point(125, 505);
            this.editbutton.Name = "editbutton";
            this.editbutton.Normalcolor = System.Drawing.Color.Navy;
            this.editbutton.OnHovercolor = System.Drawing.Color.Navy;
            this.editbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.editbutton.selected = false;
            this.editbutton.Size = new System.Drawing.Size(99, 35);
            this.editbutton.TabIndex = 48;
            this.editbutton.Text = "Edit";
            this.editbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editbutton.Textcolor = System.Drawing.Color.White;
            this.editbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // simpanbutton
            // 
            this.simpanbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.simpanbutton.BackColor = System.Drawing.Color.Navy;
            this.simpanbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpanbutton.BorderRadius = 0;
            this.simpanbutton.ButtonText = "Simpan";
            this.simpanbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpanbutton.DisabledColor = System.Drawing.Color.Gray;
            this.simpanbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.simpanbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("simpanbutton.Iconimage")));
            this.simpanbutton.Iconimage_right = null;
            this.simpanbutton.Iconimage_right_Selected = null;
            this.simpanbutton.Iconimage_Selected = null;
            this.simpanbutton.IconMarginLeft = 0;
            this.simpanbutton.IconMarginRight = 0;
            this.simpanbutton.IconRightVisible = true;
            this.simpanbutton.IconRightZoom = 0D;
            this.simpanbutton.IconVisible = true;
            this.simpanbutton.IconZoom = 90D;
            this.simpanbutton.IsTab = false;
            this.simpanbutton.Location = new System.Drawing.Point(10, 505);
            this.simpanbutton.Name = "simpanbutton";
            this.simpanbutton.Normalcolor = System.Drawing.Color.Navy;
            this.simpanbutton.OnHovercolor = System.Drawing.Color.Navy;
            this.simpanbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.simpanbutton.selected = false;
            this.simpanbutton.Size = new System.Drawing.Size(99, 35);
            this.simpanbutton.TabIndex = 47;
            this.simpanbutton.Text = "Simpan";
            this.simpanbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.simpanbutton.Textcolor = System.Drawing.Color.White;
            this.simpanbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanbutton.Click += new System.EventHandler(this.simpanbutton_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(10, 319);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(211, 20);
            this.txtno.TabIndex = 56;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(12, 391);
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(209, 83);
            this.txtalamat.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjekAkhir_Kel05.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // CRUD_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kembalibutton);
            this.Controls.Add(this.batalbutton);
            this.Controls.Add(this.hapusbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.simpanbutton);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CRUD_Supplier";
            this.Text = "Form Supplier";
            this.Load += new System.EventHandler(this.CRUD_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PRG2_UserControl_KEL05.CharTextBoxt txtnama;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ns1.BunifuFlatButton kembalibutton;
        private ns1.BunifuFlatButton batalbutton;
        private ns1.BunifuFlatButton hapusbutton;
        private ns1.BunifuFlatButton editbutton;
        private ns1.BunifuFlatButton simpanbutton;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtid;
        private PRG2_UserControl_KEL05.NumericTextBox txtno;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}