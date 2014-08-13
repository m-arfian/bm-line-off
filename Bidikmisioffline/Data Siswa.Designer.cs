namespace Bidikmisioffline
{
    partial class Data_Siswa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.col_noinduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_namasiswa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nisn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nopendaftaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tgllahir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ts_datasiswa = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_search = new System.Windows.Forms.ToolStripLabel();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.btn_newsiswa = new System.Windows.Forms.ToolStripButton();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.ts_datasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nopendaftaran,
            this.col_noinduk,
            this.col_namasiswa,
            this.col_nisn,
            this.col_tgllahir});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(734, 398);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // col_noinduk
            // 
            this.col_noinduk.Text = "No Induk";
            // 
            // col_namasiswa
            // 
            this.col_namasiswa.Text = "Nama Siswa";
            this.col_namasiswa.Width = 77;
            // 
            // col_nisn
            // 
            this.col_nisn.Text = "NISN";
            // 
            // col_nopendaftaran
            // 
            this.col_nopendaftaran.Text = "No Pendaftaran";
            this.col_nopendaftaran.Width = 98;
            // 
            // col_tgllahir
            // 
            this.col_tgllahir.Text = "Tanggal Lahir";
            this.col_tgllahir.Width = 90;
            // 
            // ts_datasiswa
            // 
            this.ts_datasiswa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newsiswa,
            this.toolStripSeparator1,
            this.lbl_search,
            this.txt_search,
            this.btn_search});
            this.ts_datasiswa.Location = new System.Drawing.Point(0, 24);
            this.ts_datasiswa.Name = "ts_datasiswa";
            this.ts_datasiswa.Size = new System.Drawing.Size(734, 25);
            this.ts_datasiswa.TabIndex = 2;
            this.ts_datasiswa.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbl_search
            // 
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(59, 22);
            this.lbl_search.Text = "Pencarian";
            // 
            // txt_search
            // 
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 25);
            // 
            // btn_newsiswa
            // 
            this.btn_newsiswa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newsiswa.Image = global::Bidikmisioffline.Properties.Resources._new;
            this.btn_newsiswa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newsiswa.Name = "btn_newsiswa";
            this.btn_newsiswa.Size = new System.Drawing.Size(23, 22);
            this.btn_newsiswa.Text = "Input Siswa Baru";
            this.btn_newsiswa.Click += new System.EventHandler(this.btn_newsiswa_Click);
            // 
            // btn_search
            // 
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_search.Image = global::Bidikmisioffline.Properties.Resources.search;
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 22);
            this.btn_search.Text = "toolStripButton2";
            // 
            // Data_Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.ts_datasiswa);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Data_Siswa";
            this.Text = "Data_Siswa";
            this.ts_datasiswa.ResumeLayout(false);
            this.ts_datasiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader col_noinduk;
        private System.Windows.Forms.ColumnHeader col_namasiswa;
        private System.Windows.Forms.ColumnHeader col_nisn;
        private System.Windows.Forms.ColumnHeader col_nopendaftaran;
        private System.Windows.Forms.ColumnHeader col_tgllahir;
        private System.Windows.Forms.ToolStrip ts_datasiswa;
        private System.Windows.Forms.ToolStripButton btn_newsiswa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbl_search;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripButton btn_search;
    }
}