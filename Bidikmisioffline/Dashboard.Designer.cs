namespace Bidikmisioffline
{
    partial class Dashboard
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_unas = new System.Windows.Forms.Button();
            this.btn_prestasi = new System.Windows.Forms.Button();
            this.btn_datasiswa = new System.Windows.Forms.Button();
            this.btn_datasekolah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSekolahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataUNASSekolahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPrestasiSekolahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tutupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(531, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 413);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btn_unas
            // 
            this.btn_unas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unas.Location = new System.Drawing.Point(147, 36);
            this.btn_unas.Name = "btn_unas";
            this.btn_unas.Size = new System.Drawing.Size(100, 100);
            this.btn_unas.TabIndex = 2;
            this.btn_unas.Text = "UNAS Sekolah";
            this.btn_unas.UseVisualStyleBackColor = true;
            this.btn_unas.Click += new System.EventHandler(this.btn_unas_Click);
            // 
            // btn_prestasi
            // 
            this.btn_prestasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prestasi.Location = new System.Drawing.Point(272, 36);
            this.btn_prestasi.Name = "btn_prestasi";
            this.btn_prestasi.Size = new System.Drawing.Size(100, 100);
            this.btn_prestasi.TabIndex = 3;
            this.btn_prestasi.Text = "Prestasi Sekolah";
            this.btn_prestasi.UseVisualStyleBackColor = true;
            this.btn_prestasi.Click += new System.EventHandler(this.btn_prestasi_Click);
            // 
            // btn_datasiswa
            // 
            this.btn_datasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datasiswa.Location = new System.Drawing.Point(399, 36);
            this.btn_datasiswa.Name = "btn_datasiswa";
            this.btn_datasiswa.Size = new System.Drawing.Size(100, 100);
            this.btn_datasiswa.TabIndex = 4;
            this.btn_datasiswa.Text = "Data Siswa";
            this.btn_datasiswa.UseVisualStyleBackColor = true;
            this.btn_datasiswa.Click += new System.EventHandler(this.btn_datasiswa_Click);
            // 
            // btn_datasekolah
            // 
            this.btn_datasekolah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datasekolah.Location = new System.Drawing.Point(24, 36);
            this.btn_datasekolah.Name = "btn_datasekolah";
            this.btn_datasekolah.Size = new System.Drawing.Size(100, 100);
            this.btn_datasekolah.TabIndex = 1;
            this.btn_datasekolah.Text = "Data Sekolah";
            this.btn_datasekolah.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_datasekolah);
            this.groupBox1.Controls.Add(this.btn_datasiswa);
            this.groupBox1.Controls.Add(this.btn_prestasi);
            this.groupBox1.Controls.Add(this.btn_unas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 438);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard Sekolah";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikasiToolStripMenuItem
            // 
            this.aplikasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSekolahToolStripMenuItem,
            this.dataUNASSekolahToolStripMenuItem,
            this.dataPrestasiSekolahToolStripMenuItem,
            this.dataSiswaToolStripMenuItem,
            this.toolStripSeparator1,
            this.tutupToolStripMenuItem});
            this.aplikasiToolStripMenuItem.Name = "aplikasiToolStripMenuItem";
            this.aplikasiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aplikasiToolStripMenuItem.Text = "Aplikasi";
            // 
            // dataSekolahToolStripMenuItem
            // 
            this.dataSekolahToolStripMenuItem.Name = "dataSekolahToolStripMenuItem";
            this.dataSekolahToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dataSekolahToolStripMenuItem.Text = "Data Sekolah";
            // 
            // dataUNASSekolahToolStripMenuItem
            // 
            this.dataUNASSekolahToolStripMenuItem.Name = "dataUNASSekolahToolStripMenuItem";
            this.dataUNASSekolahToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dataUNASSekolahToolStripMenuItem.Text = "Data UNAS Sekolah";
            // 
            // dataPrestasiSekolahToolStripMenuItem
            // 
            this.dataPrestasiSekolahToolStripMenuItem.Name = "dataPrestasiSekolahToolStripMenuItem";
            this.dataPrestasiSekolahToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dataPrestasiSekolahToolStripMenuItem.Text = "Data Prestasi Sekolah";
            // 
            // dataSiswaToolStripMenuItem
            // 
            this.dataSiswaToolStripMenuItem.Name = "dataSiswaToolStripMenuItem";
            this.dataSiswaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.dataSiswaToolStripMenuItem.Text = "Data Siswa";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // tutupToolStripMenuItem
            // 
            this.tutupToolStripMenuItem.Name = "tutupToolStripMenuItem";
            this.tutupToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tutupToolStripMenuItem.Text = "Tutup";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_unas;
        private System.Windows.Forms.Button btn_prestasi;
        private System.Windows.Forms.Button btn_datasiswa;
        private System.Windows.Forms.Button btn_datasekolah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSekolahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataUNASSekolahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPrestasiSekolahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tutupToolStripMenuItem;

    }
}