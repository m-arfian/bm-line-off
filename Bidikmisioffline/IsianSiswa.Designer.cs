namespace Bidikmisioffline
{
    partial class IsianSiswa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsianSiswa));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabicon_list = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tc_siswa = new System.Windows.Forms.TabControl();
            this.tp_biodata = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_akademik = new System.Windows.Forms.TabPage();
            this.tp_prestasi = new System.Windows.Forms.TabPage();
            this.tp_keluarga = new System.Windows.Forms.TabPage();
            this.tp_rumah = new System.Windows.Forms.TabPage();
            this.tp_aset = new System.Windows.Forms.TabPage();
            this.tp_ekonomi = new System.Windows.Forms.TabPage();
            this.tp_seleksi = new System.Windows.Forms.TabPage();
            this.tc_siswa.SuspendLayout();
            this.tp_biodata.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabicon_list
            // 
            this.tabicon_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabicon_list.ImageStream")));
            this.tabicon_list.TransparentColor = System.Drawing.Color.Transparent;
            this.tabicon_list.Images.SetKeyName(0, "cup.png");
            this.tabicon_list.Images.SetKeyName(1, "family.png");
            this.tabicon_list.Images.SetKeyName(2, "house.png");
            this.tabicon_list.Images.SetKeyName(3, "license.png");
            this.tabicon_list.Images.SetKeyName(4, "money.png");
            this.tabicon_list.Images.SetKeyName(5, "money_bag.png");
            this.tabicon_list.Images.SetKeyName(6, "plan.png");
            this.tabicon_list.Images.SetKeyName(7, "tick.png");
            this.tabicon_list.Images.SetKeyName(8, "user.png");
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 76);
            this.panel1.TabIndex = 13;
            // 
            // tc_siswa
            // 
            this.tc_siswa.Controls.Add(this.tp_biodata);
            this.tc_siswa.Controls.Add(this.tp_akademik);
            this.tc_siswa.Controls.Add(this.tp_prestasi);
            this.tc_siswa.Controls.Add(this.tp_keluarga);
            this.tc_siswa.Controls.Add(this.tp_rumah);
            this.tc_siswa.Controls.Add(this.tp_aset);
            this.tc_siswa.Controls.Add(this.tp_ekonomi);
            this.tc_siswa.Controls.Add(this.tp_seleksi);
            this.tc_siswa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_siswa.ImageList = this.tabicon_list;
            this.tc_siswa.Location = new System.Drawing.Point(0, 76);
            this.tc_siswa.Name = "tc_siswa";
            this.tc_siswa.SelectedIndex = 0;
            this.tc_siswa.Size = new System.Drawing.Size(734, 364);
            this.tc_siswa.TabIndex = 16;
            this.tc_siswa.TabStop = false;
            // 
            // tp_biodata
            // 
            this.tp_biodata.Controls.Add(this.comboBox1);
            this.tp_biodata.Controls.Add(this.textBox3);
            this.tp_biodata.Controls.Add(this.dateTimePicker1);
            this.tp_biodata.Controls.Add(this.textBox2);
            this.tp_biodata.Controls.Add(this.textBox1);
            this.tp_biodata.Controls.Add(this.label5);
            this.tp_biodata.Controls.Add(this.label4);
            this.tp_biodata.Controls.Add(this.label3);
            this.tp_biodata.Controls.Add(this.label2);
            this.tp_biodata.Controls.Add(this.label1);
            this.tp_biodata.ImageKey = "user.png";
            this.tp_biodata.Location = new System.Drawing.Point(4, 23);
            this.tp_biodata.Name = "tp_biodata";
            this.tp_biodata.Padding = new System.Windows.Forms.Padding(3);
            this.tp_biodata.Size = new System.Drawing.Size(726, 337);
            this.tp_biodata.TabIndex = 0;
            this.tp_biodata.Text = "Biodata";
            this.tp_biodata.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(501, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(501, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tahun Lulus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nama Gadis Ibu/Ayah/Wali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Siswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "No Induk";
            // 
            // tp_akademik
            // 
            this.tp_akademik.ImageIndex = 3;
            this.tp_akademik.Location = new System.Drawing.Point(4, 23);
            this.tp_akademik.Name = "tp_akademik";
            this.tp_akademik.Padding = new System.Windows.Forms.Padding(3);
            this.tp_akademik.Size = new System.Drawing.Size(726, 413);
            this.tp_akademik.TabIndex = 1;
            this.tp_akademik.Text = "Akademik";
            this.tp_akademik.UseVisualStyleBackColor = true;
            // 
            // tp_prestasi
            // 
            this.tp_prestasi.ImageIndex = 0;
            this.tp_prestasi.Location = new System.Drawing.Point(4, 23);
            this.tp_prestasi.Name = "tp_prestasi";
            this.tp_prestasi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_prestasi.Size = new System.Drawing.Size(726, 413);
            this.tp_prestasi.TabIndex = 2;
            this.tp_prestasi.Text = "Prestasi";
            this.tp_prestasi.UseVisualStyleBackColor = true;
            // 
            // tp_keluarga
            // 
            this.tp_keluarga.ImageIndex = 1;
            this.tp_keluarga.Location = new System.Drawing.Point(4, 23);
            this.tp_keluarga.Name = "tp_keluarga";
            this.tp_keluarga.Padding = new System.Windows.Forms.Padding(3);
            this.tp_keluarga.Size = new System.Drawing.Size(726, 413);
            this.tp_keluarga.TabIndex = 3;
            this.tp_keluarga.Text = "Keluarga";
            this.tp_keluarga.UseVisualStyleBackColor = true;
            // 
            // tp_rumah
            // 
            this.tp_rumah.ImageIndex = 2;
            this.tp_rumah.Location = new System.Drawing.Point(4, 23);
            this.tp_rumah.Name = "tp_rumah";
            this.tp_rumah.Padding = new System.Windows.Forms.Padding(3);
            this.tp_rumah.Size = new System.Drawing.Size(726, 413);
            this.tp_rumah.TabIndex = 4;
            this.tp_rumah.Text = "Rumah";
            this.tp_rumah.UseVisualStyleBackColor = true;
            // 
            // tp_aset
            // 
            this.tp_aset.ImageIndex = 5;
            this.tp_aset.Location = new System.Drawing.Point(4, 23);
            this.tp_aset.Name = "tp_aset";
            this.tp_aset.Padding = new System.Windows.Forms.Padding(3);
            this.tp_aset.Size = new System.Drawing.Size(726, 413);
            this.tp_aset.TabIndex = 5;
            this.tp_aset.Text = "Aset";
            this.tp_aset.UseVisualStyleBackColor = true;
            // 
            // tp_ekonomi
            // 
            this.tp_ekonomi.ImageIndex = 4;
            this.tp_ekonomi.Location = new System.Drawing.Point(4, 23);
            this.tp_ekonomi.Name = "tp_ekonomi";
            this.tp_ekonomi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_ekonomi.Size = new System.Drawing.Size(726, 413);
            this.tp_ekonomi.TabIndex = 6;
            this.tp_ekonomi.Text = "Ekonomi";
            this.tp_ekonomi.UseVisualStyleBackColor = true;
            // 
            // tp_seleksi
            // 
            this.tp_seleksi.ImageIndex = 7;
            this.tp_seleksi.Location = new System.Drawing.Point(4, 23);
            this.tp_seleksi.Name = "tp_seleksi";
            this.tp_seleksi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_seleksi.Size = new System.Drawing.Size(726, 413);
            this.tp_seleksi.TabIndex = 7;
            this.tp_seleksi.Text = "Seleksi";
            this.tp_seleksi.UseVisualStyleBackColor = true;
            // 
            // IsianSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.tc_siswa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "IsianSiswa";
            this.Text = "Form Siswa";
            this.tc_siswa.ResumeLayout(false);
            this.tp_biodata.ResumeLayout(false);
            this.tp_biodata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList tabicon_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tc_siswa;
        private System.Windows.Forms.TabPage tp_biodata;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_akademik;
        private System.Windows.Forms.TabPage tp_prestasi;
        private System.Windows.Forms.TabPage tp_keluarga;
        private System.Windows.Forms.TabPage tp_rumah;
        private System.Windows.Forms.TabPage tp_aset;
        private System.Windows.Forms.TabPage tp_ekonomi;
        private System.Windows.Forms.TabPage tp_seleksi;

    }
}