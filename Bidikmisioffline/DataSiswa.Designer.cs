namespace Bidikmisioffline
{
    partial class DataSiswa
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
            this.list_siswa = new System.Windows.Forms.ListView();
            this.col_nopendaftaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_noinduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_namasiswa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nisn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tgllahir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ts_datasiswa = new System.Windows.Forms.ToolStrip();
            this.btn_newsiswa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_search = new System.Windows.Forms.ToolStripLabel();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.ts_datasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_siswa
            // 
            this.list_siswa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_nopendaftaran,
            this.col_noinduk,
            this.col_namasiswa,
            this.col_nisn,
            this.col_tgllahir});
            this.list_siswa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_siswa.FullRowSelect = true;
            this.list_siswa.GridLines = true;
            this.list_siswa.Location = new System.Drawing.Point(0, 28);
            this.list_siswa.Name = "list_siswa";
            this.list_siswa.Size = new System.Drawing.Size(734, 434);
            this.list_siswa.TabIndex = 1;
            this.list_siswa.UseCompatibleStateImageBehavior = false;
            this.list_siswa.View = System.Windows.Forms.View.Details;
            // 
            // col_nopendaftaran
            // 
            this.col_nopendaftaran.Text = "No Pendaftaran";
            this.col_nopendaftaran.Width = 98;
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
            this.ts_datasiswa.Location = new System.Drawing.Point(0, 0);
            this.ts_datasiswa.Name = "ts_datasiswa";
            this.ts_datasiswa.Size = new System.Drawing.Size(734, 25);
            this.ts_datasiswa.TabIndex = 2;
            this.ts_datasiswa.Text = "toolStrip1";
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
            // btn_search
            // 
            this.btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_search.Image = global::Bidikmisioffline.Properties.Resources.search;
            this.btn_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 22);
            this.btn_search.Text = "toolStripButton2";
            // 
            // DataSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.ControlBox = false;
            this.Controls.Add(this.ts_datasiswa);
            this.Controls.Add(this.list_siswa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataSiswa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Siswa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Data_Siswa_FormClosing);
            this.ts_datasiswa.ResumeLayout(false);
            this.ts_datasiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_siswa;
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