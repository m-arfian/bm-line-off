namespace Bidikmisioffline
{
    partial class IsianSekolah
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_npsn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_namasekolah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_alamatsekolah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_provinsi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_kota = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telpsekolah = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_namakepsek = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailkepsek = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_telpkepsek = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nilaiakreditasi = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.pnl_akreditasi = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rd_akreditasi_x = new System.Windows.Forms.RadioButton();
            this.rd_akreditasi_b = new System.Windows.Forms.RadioButton();
            this.rd_akreditasi_c = new System.Windows.Forms.RadioButton();
            this.rd_akreditasi_a = new System.Windows.Forms.RadioButton();
            this.pnl_jenis = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rd_sekolah_pkbm = new System.Windows.Forms.RadioButton();
            this.rd_sekolah_mak = new System.Windows.Forms.RadioButton();
            this.rd_sekolah_ma = new System.Windows.Forms.RadioButton();
            this.rd_sekolah_smk = new System.Windows.Forms.RadioButton();
            this.rd_sekolah_sma = new System.Windows.Forms.RadioButton();
            this.err_isiansekolah = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_status = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.rd_pemerintah = new System.Windows.Forms.RadioButton();
            this.rd_masyarakat = new System.Windows.Forms.RadioButton();
            this.pnl_akreditasi.SuspendLayout();
            this.pnl_jenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_isiansekolah)).BeginInit();
            this.pnl_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPSN";
            // 
            // txt_npsn
            // 
            this.txt_npsn.Location = new System.Drawing.Point(160, 28);
            this.txt_npsn.MaxLength = 8;
            this.txt_npsn.Name = "txt_npsn";
            this.txt_npsn.Size = new System.Drawing.Size(100, 20);
            this.txt_npsn.TabIndex = 1;
            this.txt_npsn.Validating += new System.ComponentModel.CancelEventHandler(this.txt_npsn_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Sekolah";
            // 
            // txt_namasekolah
            // 
            this.txt_namasekolah.Location = new System.Drawing.Point(160, 59);
            this.txt_namasekolah.MaxLength = 50;
            this.txt_namasekolah.Name = "txt_namasekolah";
            this.txt_namasekolah.Size = new System.Drawing.Size(185, 20);
            this.txt_namasekolah.TabIndex = 3;
            this.txt_namasekolah.Validating += new System.ComponentModel.CancelEventHandler(this.txt_namasekolah_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alamat Sekolah";
            // 
            // txt_alamatsekolah
            // 
            this.txt_alamatsekolah.Location = new System.Drawing.Point(160, 95);
            this.txt_alamatsekolah.Multiline = true;
            this.txt_alamatsekolah.Name = "txt_alamatsekolah";
            this.txt_alamatsekolah.Size = new System.Drawing.Size(185, 62);
            this.txt_alamatsekolah.TabIndex = 5;
            this.txt_alamatsekolah.Validating += new System.ComponentModel.CancelEventHandler(this.txt_alamatsekolah_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Provinsi";
            // 
            // cmb_provinsi
            // 
            this.cmb_provinsi.FormattingEnabled = true;
            this.cmb_provinsi.Location = new System.Drawing.Point(160, 169);
            this.cmb_provinsi.Name = "cmb_provinsi";
            this.cmb_provinsi.Size = new System.Drawing.Size(165, 21);
            this.cmb_provinsi.TabIndex = 7;
            this.cmb_provinsi.SelectionChangeCommitted += new System.EventHandler(this.cmb_provinsi_SelectionChangeCommitted);
            this.cmb_provinsi.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_provinsi_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kota";
            // 
            // cmb_kota
            // 
            this.cmb_kota.Enabled = false;
            this.cmb_kota.FormattingEnabled = true;
            this.cmb_kota.Location = new System.Drawing.Point(160, 205);
            this.cmb_kota.Name = "cmb_kota";
            this.cmb_kota.Size = new System.Drawing.Size(149, 21);
            this.cmb_kota.TabIndex = 9;
            this.cmb_kota.Validating += new System.ComponentModel.CancelEventHandler(this.cmb_kota_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email Sekolah";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(160, 241);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(165, 20);
            this.txt_email.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "No Telp Sekolah";
            // 
            // txt_telpsekolah
            // 
            this.txt_telpsekolah.Location = new System.Drawing.Point(160, 282);
            this.txt_telpsekolah.MaxLength = 20;
            this.txt_telpsekolah.Name = "txt_telpsekolah";
            this.txt_telpsekolah.Size = new System.Drawing.Size(115, 20);
            this.txt_telpsekolah.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nama Kepala Sekolah";
            // 
            // txt_namakepsek
            // 
            this.txt_namakepsek.Location = new System.Drawing.Point(160, 325);
            this.txt_namakepsek.MaxLength = 30;
            this.txt_namakepsek.Name = "txt_namakepsek";
            this.txt_namakepsek.Size = new System.Drawing.Size(149, 20);
            this.txt_namakepsek.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Email Kepala Sekolah";
            // 
            // txt_emailkepsek
            // 
            this.txt_emailkepsek.Location = new System.Drawing.Point(160, 365);
            this.txt_emailkepsek.MaxLength = 50;
            this.txt_emailkepsek.Name = "txt_emailkepsek";
            this.txt_emailkepsek.Size = new System.Drawing.Size(165, 20);
            this.txt_emailkepsek.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "No Telp Kepala Sekolah";
            // 
            // txt_telpkepsek
            // 
            this.txt_telpkepsek.Location = new System.Drawing.Point(160, 406);
            this.txt_telpkepsek.MaxLength = 12;
            this.txt_telpkepsek.Name = "txt_telpkepsek";
            this.txt_telpkepsek.Size = new System.Drawing.Size(115, 20);
            this.txt_telpkepsek.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Nilai Akreditasi";
            // 
            // txt_nilaiakreditasi
            // 
            this.txt_nilaiakreditasi.Location = new System.Drawing.Point(519, 142);
            this.txt_nilaiakreditasi.MaxLength = 10;
            this.txt_nilaiakreditasi.Name = "txt_nilaiakreditasi";
            this.txt_nilaiakreditasi.Size = new System.Drawing.Size(69, 20);
            this.txt_nilaiakreditasi.TabIndex = 26;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(604, 406);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(91, 34);
            this.btn_simpan.TabIndex = 33;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // pnl_akreditasi
            // 
            this.pnl_akreditasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_akreditasi.Controls.Add(this.label11);
            this.pnl_akreditasi.Controls.Add(this.rd_akreditasi_x);
            this.pnl_akreditasi.Controls.Add(this.rd_akreditasi_b);
            this.pnl_akreditasi.Controls.Add(this.rd_akreditasi_c);
            this.pnl_akreditasi.Controls.Add(this.rd_akreditasi_a);
            this.pnl_akreditasi.Location = new System.Drawing.Point(381, 28);
            this.pnl_akreditasi.Name = "pnl_akreditasi";
            this.pnl_akreditasi.Size = new System.Drawing.Size(314, 107);
            this.pnl_akreditasi.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Akreditasi";
            // 
            // rd_akreditasi_x
            // 
            this.rd_akreditasi_x.AutoSize = true;
            this.rd_akreditasi_x.Checked = true;
            this.rd_akreditasi_x.Location = new System.Drawing.Point(138, 78);
            this.rd_akreditasi_x.Name = "rd_akreditasi_x";
            this.rd_akreditasi_x.Size = new System.Drawing.Size(102, 17);
            this.rd_akreditasi_x.TabIndex = 38;
            this.rd_akreditasi_x.TabStop = true;
            this.rd_akreditasi_x.Text = "Belum akreditasi";
            this.rd_akreditasi_x.UseVisualStyleBackColor = true;
            // 
            // rd_akreditasi_b
            // 
            this.rd_akreditasi_b.AutoSize = true;
            this.rd_akreditasi_b.Location = new System.Drawing.Point(138, 31);
            this.rd_akreditasi_b.Name = "rd_akreditasi_b";
            this.rd_akreditasi_b.Size = new System.Drawing.Size(32, 17);
            this.rd_akreditasi_b.TabIndex = 36;
            this.rd_akreditasi_b.TabStop = true;
            this.rd_akreditasi_b.Text = "B";
            this.rd_akreditasi_b.UseVisualStyleBackColor = true;
            // 
            // rd_akreditasi_c
            // 
            this.rd_akreditasi_c.AutoSize = true;
            this.rd_akreditasi_c.Location = new System.Drawing.Point(138, 54);
            this.rd_akreditasi_c.Name = "rd_akreditasi_c";
            this.rd_akreditasi_c.Size = new System.Drawing.Size(32, 17);
            this.rd_akreditasi_c.TabIndex = 37;
            this.rd_akreditasi_c.TabStop = true;
            this.rd_akreditasi_c.Text = "C";
            this.rd_akreditasi_c.UseVisualStyleBackColor = true;
            // 
            // rd_akreditasi_a
            // 
            this.rd_akreditasi_a.AutoSize = true;
            this.rd_akreditasi_a.Location = new System.Drawing.Point(138, 7);
            this.rd_akreditasi_a.Name = "rd_akreditasi_a";
            this.rd_akreditasi_a.Size = new System.Drawing.Size(32, 17);
            this.rd_akreditasi_a.TabIndex = 35;
            this.rd_akreditasi_a.TabStop = true;
            this.rd_akreditasi_a.Text = "A";
            this.rd_akreditasi_a.UseVisualStyleBackColor = true;
            // 
            // pnl_jenis
            // 
            this.pnl_jenis.Controls.Add(this.label13);
            this.pnl_jenis.Controls.Add(this.rd_sekolah_pkbm);
            this.pnl_jenis.Controls.Add(this.rd_sekolah_mak);
            this.pnl_jenis.Controls.Add(this.rd_sekolah_ma);
            this.pnl_jenis.Controls.Add(this.rd_sekolah_smk);
            this.pnl_jenis.Controls.Add(this.rd_sekolah_sma);
            this.pnl_jenis.Location = new System.Drawing.Point(381, 168);
            this.pnl_jenis.Name = "pnl_jenis";
            this.pnl_jenis.Size = new System.Drawing.Size(314, 134);
            this.pnl_jenis.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Jenis Sekolah";
            // 
            // rd_sekolah_pkbm
            // 
            this.rd_sekolah_pkbm.AutoSize = true;
            this.rd_sekolah_pkbm.Checked = true;
            this.rd_sekolah_pkbm.Location = new System.Drawing.Point(138, 107);
            this.rd_sekolah_pkbm.Name = "rd_sekolah_pkbm";
            this.rd_sekolah_pkbm.Size = new System.Drawing.Size(162, 17);
            this.rd_sekolah_pkbm.TabIndex = 37;
            this.rd_sekolah_pkbm.TabStop = true;
            this.rd_sekolah_pkbm.Text = "Unit Pendidikan Lain (PKBM)";
            this.rd_sekolah_pkbm.UseVisualStyleBackColor = true;
            // 
            // rd_sekolah_mak
            // 
            this.rd_sekolah_mak.AutoSize = true;
            this.rd_sekolah_mak.Location = new System.Drawing.Point(138, 83);
            this.rd_sekolah_mak.Name = "rd_sekolah_mak";
            this.rd_sekolah_mak.Size = new System.Drawing.Size(48, 17);
            this.rd_sekolah_mak.TabIndex = 36;
            this.rd_sekolah_mak.Text = "MAK";
            this.rd_sekolah_mak.UseVisualStyleBackColor = true;
            // 
            // rd_sekolah_ma
            // 
            this.rd_sekolah_ma.AutoSize = true;
            this.rd_sekolah_ma.Location = new System.Drawing.Point(138, 59);
            this.rd_sekolah_ma.Name = "rd_sekolah_ma";
            this.rd_sekolah_ma.Size = new System.Drawing.Size(41, 17);
            this.rd_sekolah_ma.TabIndex = 35;
            this.rd_sekolah_ma.Text = "MA";
            this.rd_sekolah_ma.UseVisualStyleBackColor = true;
            // 
            // rd_sekolah_smk
            // 
            this.rd_sekolah_smk.AutoSize = true;
            this.rd_sekolah_smk.Location = new System.Drawing.Point(138, 35);
            this.rd_sekolah_smk.Name = "rd_sekolah_smk";
            this.rd_sekolah_smk.Size = new System.Drawing.Size(48, 17);
            this.rd_sekolah_smk.TabIndex = 34;
            this.rd_sekolah_smk.Text = "SMK";
            this.rd_sekolah_smk.UseVisualStyleBackColor = true;
            // 
            // rd_sekolah_sma
            // 
            this.rd_sekolah_sma.AutoSize = true;
            this.rd_sekolah_sma.Location = new System.Drawing.Point(138, 11);
            this.rd_sekolah_sma.Name = "rd_sekolah_sma";
            this.rd_sekolah_sma.Size = new System.Drawing.Size(48, 17);
            this.rd_sekolah_sma.TabIndex = 33;
            this.rd_sekolah_sma.Text = "SMA";
            this.rd_sekolah_sma.UseVisualStyleBackColor = true;
            // 
            // err_isiansekolah
            // 
            this.err_isiansekolah.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_isiansekolah.ContainerControl = this;
            // 
            // pnl_status
            // 
            this.pnl_status.Controls.Add(this.rd_masyarakat);
            this.pnl_status.Controls.Add(this.rd_pemerintah);
            this.pnl_status.Controls.Add(this.label14);
            this.pnl_status.Location = new System.Drawing.Point(381, 308);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(314, 60);
            this.pnl_status.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Status Sekolah";
            // 
            // rd_pemerintah
            // 
            this.rd_pemerintah.AutoSize = true;
            this.rd_pemerintah.Location = new System.Drawing.Point(138, 10);
            this.rd_pemerintah.Name = "rd_pemerintah";
            this.rd_pemerintah.Size = new System.Drawing.Size(78, 17);
            this.rd_pemerintah.TabIndex = 1;
            this.rd_pemerintah.TabStop = true;
            this.rd_pemerintah.Text = "Pemerintah";
            this.rd_pemerintah.UseVisualStyleBackColor = true;
            // 
            // rd_masyarakat
            // 
            this.rd_masyarakat.AutoSize = true;
            this.rd_masyarakat.Location = new System.Drawing.Point(138, 33);
            this.rd_masyarakat.Name = "rd_masyarakat";
            this.rd_masyarakat.Size = new System.Drawing.Size(80, 17);
            this.rd_masyarakat.TabIndex = 2;
            this.rd_masyarakat.TabStop = true;
            this.rd_masyarakat.Text = "Masyarakat";
            this.rd_masyarakat.UseVisualStyleBackColor = true;
            // 
            // IsianSekolah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.pnl_jenis);
            this.Controls.Add(this.pnl_akreditasi);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_nilaiakreditasi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_telpkepsek);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_emailkepsek);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_namakepsek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_telpsekolah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_kota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_provinsi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_alamatsekolah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_namasekolah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_npsn);
            this.Controls.Add(this.label1);
            this.Name = "IsianSekolah";
            this.Text = "IsianSekolah";
            this.Load += new System.EventHandler(this.IsianSekolah_Load);
            this.pnl_akreditasi.ResumeLayout(false);
            this.pnl_akreditasi.PerformLayout();
            this.pnl_jenis.ResumeLayout(false);
            this.pnl_jenis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_isiansekolah)).EndInit();
            this.pnl_status.ResumeLayout(false);
            this.pnl_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_npsn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_namasekolah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_alamatsekolah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_provinsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_kota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telpsekolah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_namakepsek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_emailkepsek;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_telpkepsek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nilaiakreditasi;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Panel pnl_akreditasi;
        private System.Windows.Forms.RadioButton rd_akreditasi_x;
        private System.Windows.Forms.RadioButton rd_akreditasi_b;
        private System.Windows.Forms.RadioButton rd_akreditasi_c;
        private System.Windows.Forms.RadioButton rd_akreditasi_a;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnl_jenis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rd_sekolah_pkbm;
        private System.Windows.Forms.RadioButton rd_sekolah_mak;
        private System.Windows.Forms.RadioButton rd_sekolah_ma;
        private System.Windows.Forms.RadioButton rd_sekolah_smk;
        private System.Windows.Forms.RadioButton rd_sekolah_sma;
        private System.Windows.Forms.ErrorProvider err_isiansekolah;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.RadioButton rd_masyarakat;
        private System.Windows.Forms.RadioButton rd_pemerintah;
        private System.Windows.Forms.Label label14;
    }
}