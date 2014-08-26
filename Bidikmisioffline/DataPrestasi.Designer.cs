namespace Bidikmisioffline
{
    partial class DataPrestasi
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
            this.list_prestasi = new System.Windows.Forms.ListView();
            this.col_kegiatan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_jenis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tingkat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tahun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pencapaian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_newprestasi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_search = new System.Windows.Forms.ToolStripLabel();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.ts_datasiswa = new System.Windows.Forms.ToolStrip();
            this.ts_datasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_prestasi
            // 
            this.list_prestasi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_prestasi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_kegiatan,
            this.col_jenis,
            this.col_tingkat,
            this.col_tahun,
            this.col_pencapaian});
            this.list_prestasi.FullRowSelect = true;
            this.list_prestasi.GridLines = true;
            this.list_prestasi.Location = new System.Drawing.Point(0, 28);
            this.list_prestasi.Name = "list_prestasi";
            this.list_prestasi.Size = new System.Drawing.Size(734, 433);
            this.list_prestasi.TabIndex = 3;
            this.list_prestasi.UseCompatibleStateImageBehavior = false;
            this.list_prestasi.View = System.Windows.Forms.View.Details;
            // 
            // col_kegiatan
            // 
            this.col_kegiatan.Text = "Nama Kegiatan";
            this.col_kegiatan.Width = 98;
            // 
            // col_jenis
            // 
            this.col_jenis.Text = "Jenis Kegiatan";
            this.col_jenis.Width = 107;
            // 
            // col_tingkat
            // 
            this.col_tingkat.Text = "Tingkat";
            this.col_tingkat.Width = 77;
            // 
            // col_tahun
            // 
            this.col_tahun.Text = "Tahun";
            // 
            // col_pencapaian
            // 
            this.col_pencapaian.Text = "Pencapaian";
            this.col_pencapaian.Width = 90;
            // 
            // btn_newprestasi
            // 
            this.btn_newprestasi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newprestasi.Image = global::Bidikmisioffline.Properties.Resources._new;
            this.btn_newprestasi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newprestasi.Name = "btn_newprestasi";
            this.btn_newprestasi.Size = new System.Drawing.Size(23, 22);
            this.btn_newprestasi.Text = "Input Siswa Baru";
            this.btn_newprestasi.Click += new System.EventHandler(this.btn_newprestasi_Click);
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
            // ts_datasiswa
            // 
            this.ts_datasiswa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newprestasi,
            this.toolStripSeparator1,
            this.lbl_search,
            this.txt_search,
            this.btn_search});
            this.ts_datasiswa.Location = new System.Drawing.Point(0, 0);
            this.ts_datasiswa.Name = "ts_datasiswa";
            this.ts_datasiswa.Size = new System.Drawing.Size(734, 25);
            this.ts_datasiswa.TabIndex = 4;
            this.ts_datasiswa.Text = "toolStrip1";
            // 
            // DataPrestasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.ts_datasiswa);
            this.Controls.Add(this.list_prestasi);
            this.Name = "DataPrestasi";
            this.Text = "Data Prestasi Sekolah";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataPrestasi_FormClosing);
            this.ts_datasiswa.ResumeLayout(false);
            this.ts_datasiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list_prestasi;
        private System.Windows.Forms.ColumnHeader col_kegiatan;
        private System.Windows.Forms.ColumnHeader col_jenis;
        private System.Windows.Forms.ColumnHeader col_tingkat;
        private System.Windows.Forms.ColumnHeader col_tahun;
        private System.Windows.Forms.ColumnHeader col_pencapaian;
        private System.Windows.Forms.ToolStripButton btn_newprestasi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbl_search;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ToolStrip ts_datasiswa;
    }
}