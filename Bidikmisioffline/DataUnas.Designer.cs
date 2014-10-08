namespace Bidikmisioffline
{
    partial class DataUnas
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
            this.ts_datasiswa = new System.Windows.Forms.ToolStrip();
            this.btn_newunas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_search = new System.Windows.Forms.ToolStripLabel();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.btn_search = new System.Windows.Forms.ToolStripButton();
            this.list_unas = new System.Windows.Forms.ListView();
            this.col_tahunajaran = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nilaiipa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pelajaranipa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nilaiips = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pelajaranips = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nilaibahasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pelajaranbahasa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_nilaismk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_pelajaransmk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ts_datasiswa.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_datasiswa
            // 
            this.ts_datasiswa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_newunas,
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
            // btn_newunas
            // 
            this.btn_newunas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_newunas.Image = global::Bidikmisioffline.Properties.Resources._new;
            this.btn_newunas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_newunas.Name = "btn_newunas";
            this.btn_newunas.Size = new System.Drawing.Size(23, 22);
            this.btn_newunas.Text = "Input Siswa Baru";
            this.btn_newunas.Click += new System.EventHandler(this.btn_newunas_Click);
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
            // list_unas
            // 
            this.list_unas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_tahunajaran,
            this.col_nilaiipa,
            this.col_pelajaranipa,
            this.col_nilaiips,
            this.col_pelajaranips,
            this.col_nilaibahasa,
            this.col_pelajaranbahasa,
            this.col_nilaismk,
            this.col_pelajaransmk});
            this.list_unas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_unas.FullRowSelect = true;
            this.list_unas.GridLines = true;
            this.list_unas.Location = new System.Drawing.Point(0, 28);
            this.list_unas.Name = "list_unas";
            this.list_unas.Size = new System.Drawing.Size(734, 434);
            this.list_unas.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.list_unas.TabIndex = 3;
            this.list_unas.UseCompatibleStateImageBehavior = false;
            this.list_unas.View = System.Windows.Forms.View.Details;
            // 
            // col_tahunajaran
            // 
            this.col_tahunajaran.Text = "Tahun ajaran";
            this.col_tahunajaran.Width = 98;
            // 
            // col_nilaiipa
            // 
            this.col_nilaiipa.Text = "Nilai IPA";
            this.col_nilaiipa.Width = 61;
            // 
            // col_pelajaranipa
            // 
            this.col_pelajaranipa.Text = "Mapel IPA";
            this.col_pelajaranipa.Width = 73;
            // 
            // col_nilaiips
            // 
            this.col_nilaiips.Text = "Nilai IPS";
            this.col_nilaiips.Width = 65;
            // 
            // col_pelajaranips
            // 
            this.col_pelajaranips.Text = "Mapel IPS";
            this.col_pelajaranips.Width = 76;
            // 
            // col_nilaibahasa
            // 
            this.col_nilaibahasa.Text = "Nilai BAHASA";
            this.col_nilaibahasa.Width = 89;
            // 
            // col_pelajaranbahasa
            // 
            this.col_pelajaranbahasa.Text = "Mapel BAHASA";
            this.col_pelajaranbahasa.Width = 95;
            // 
            // col_nilaismk
            // 
            this.col_nilaismk.Text = "Nilai SMK";
            this.col_nilaismk.Width = 71;
            // 
            // col_pelajaransmk
            // 
            this.col_pelajaransmk.Text = "Mapel SMK";
            this.col_pelajaransmk.Width = 85;
            // 
            // DataUnas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.ControlBox = false;
            this.Controls.Add(this.ts_datasiswa);
            this.Controls.Add(this.list_unas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataUnas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataUnas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ts_datasiswa.ResumeLayout(false);
            this.ts_datasiswa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_datasiswa;
        private System.Windows.Forms.ToolStripButton btn_newunas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbl_search;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripButton btn_search;
        private System.Windows.Forms.ListView list_unas;
        private System.Windows.Forms.ColumnHeader col_tahunajaran;
        private System.Windows.Forms.ColumnHeader col_nilaiipa;
        private System.Windows.Forms.ColumnHeader col_pelajaranipa;
        private System.Windows.Forms.ColumnHeader col_nilaiips;
        private System.Windows.Forms.ColumnHeader col_pelajaranips;
        private System.Windows.Forms.ColumnHeader col_nilaibahasa;
        private System.Windows.Forms.ColumnHeader col_pelajaranbahasa;
        private System.Windows.Forms.ColumnHeader col_nilaismk;
        private System.Windows.Forms.ColumnHeader col_pelajaransmk;

    }
}