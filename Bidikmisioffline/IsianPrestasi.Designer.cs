namespace Bidikmisioffline
{
    partial class IsianPrestasi
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
            this.pnl_form = new System.Windows.Forms.Panel();
            this.group_form = new System.Windows.Forms.GroupBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.pnl_pencapaian = new System.Windows.Forms.Panel();
            this.rd_juara3 = new System.Windows.Forms.RadioButton();
            this.rd_juara2 = new System.Windows.Forms.RadioButton();
            this.rd_juara1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_tingkat = new System.Windows.Forms.Panel();
            this.rd_internasional = new System.Windows.Forms.RadioButton();
            this.rd_nasional = new System.Windows.Forms.RadioButton();
            this.rd_propinsi = new System.Windows.Forms.RadioButton();
            this.rd_kabkota = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_jenis = new System.Windows.Forms.Panel();
            this.rd_lainnya = new System.Windows.Forms.RadioButton();
            this.rd_grup = new System.Windows.Forms.RadioButton();
            this.rd_individual = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tahun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kegiatan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.err_isianprestasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_form.SuspendLayout();
            this.group_form.SuspendLayout();
            this.pnl_pencapaian.SuspendLayout();
            this.pnl_tingkat.SuspendLayout();
            this.pnl_jenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_isianprestasi)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_form
            // 
            this.pnl_form.Controls.Add(this.group_form);
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_form.Location = new System.Drawing.Point(0, 76);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(734, 386);
            this.pnl_form.TabIndex = 16;
            // 
            // group_form
            // 
            this.group_form.Controls.Add(this.btn_simpan);
            this.group_form.Controls.Add(this.pnl_pencapaian);
            this.group_form.Controls.Add(this.pnl_tingkat);
            this.group_form.Controls.Add(this.pnl_jenis);
            this.group_form.Controls.Add(this.txt_tahun);
            this.group_form.Controls.Add(this.label2);
            this.group_form.Controls.Add(this.txt_kegiatan);
            this.group_form.Controls.Add(this.label1);
            this.group_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_form.Location = new System.Drawing.Point(0, 0);
            this.group_form.Name = "group_form";
            this.group_form.Size = new System.Drawing.Size(734, 386);
            this.group_form.TabIndex = 0;
            this.group_form.TabStop = false;
            this.group_form.Text = "Form Data Prestasi";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(289, 243);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_simpan.TabIndex = 8;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // pnl_pencapaian
            // 
            this.pnl_pencapaian.Controls.Add(this.rd_juara3);
            this.pnl_pencapaian.Controls.Add(this.rd_juara2);
            this.pnl_pencapaian.Controls.Add(this.rd_juara1);
            this.pnl_pencapaian.Controls.Add(this.label5);
            this.pnl_pencapaian.Location = new System.Drawing.Point(344, 127);
            this.pnl_pencapaian.Name = "pnl_pencapaian";
            this.pnl_pencapaian.Size = new System.Drawing.Size(291, 73);
            this.pnl_pencapaian.TabIndex = 7;
            // 
            // rd_juara3
            // 
            this.rd_juara3.AutoSize = true;
            this.rd_juara3.Location = new System.Drawing.Point(131, 50);
            this.rd_juara3.Name = "rd_juara3";
            this.rd_juara3.Size = new System.Drawing.Size(60, 17);
            this.rd_juara3.TabIndex = 3;
            this.rd_juara3.TabStop = true;
            this.rd_juara3.Text = "Juara 3";
            this.rd_juara3.UseVisualStyleBackColor = true;
            // 
            // rd_juara2
            // 
            this.rd_juara2.AutoSize = true;
            this.rd_juara2.Location = new System.Drawing.Point(131, 27);
            this.rd_juara2.Name = "rd_juara2";
            this.rd_juara2.Size = new System.Drawing.Size(60, 17);
            this.rd_juara2.TabIndex = 2;
            this.rd_juara2.TabStop = true;
            this.rd_juara2.Text = "Juara 2";
            this.rd_juara2.UseVisualStyleBackColor = true;
            // 
            // rd_juara1
            // 
            this.rd_juara1.AutoSize = true;
            this.rd_juara1.Location = new System.Drawing.Point(131, 4);
            this.rd_juara1.Name = "rd_juara1";
            this.rd_juara1.Size = new System.Drawing.Size(60, 17);
            this.rd_juara1.TabIndex = 1;
            this.rd_juara1.TabStop = true;
            this.rd_juara1.Text = "Juara 1";
            this.rd_juara1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pencapaian";
            // 
            // pnl_tingkat
            // 
            this.pnl_tingkat.Controls.Add(this.rd_internasional);
            this.pnl_tingkat.Controls.Add(this.rd_nasional);
            this.pnl_tingkat.Controls.Add(this.rd_propinsi);
            this.pnl_tingkat.Controls.Add(this.rd_kabkota);
            this.pnl_tingkat.Controls.Add(this.label4);
            this.pnl_tingkat.Location = new System.Drawing.Point(344, 20);
            this.pnl_tingkat.Name = "pnl_tingkat";
            this.pnl_tingkat.Size = new System.Drawing.Size(291, 100);
            this.pnl_tingkat.TabIndex = 6;
            // 
            // rd_internasional
            // 
            this.rd_internasional.AutoSize = true;
            this.rd_internasional.Location = new System.Drawing.Point(131, 79);
            this.rd_internasional.Name = "rd_internasional";
            this.rd_internasional.Size = new System.Drawing.Size(85, 17);
            this.rd_internasional.TabIndex = 7;
            this.rd_internasional.TabStop = true;
            this.rd_internasional.Text = "Internasional";
            this.rd_internasional.UseVisualStyleBackColor = true;
            // 
            // rd_nasional
            // 
            this.rd_nasional.AutoSize = true;
            this.rd_nasional.Location = new System.Drawing.Point(131, 56);
            this.rd_nasional.Name = "rd_nasional";
            this.rd_nasional.Size = new System.Drawing.Size(66, 17);
            this.rd_nasional.TabIndex = 3;
            this.rd_nasional.TabStop = true;
            this.rd_nasional.Text = "Nasional";
            this.rd_nasional.UseVisualStyleBackColor = true;
            // 
            // rd_propinsi
            // 
            this.rd_propinsi.AutoSize = true;
            this.rd_propinsi.Location = new System.Drawing.Point(131, 33);
            this.rd_propinsi.Name = "rd_propinsi";
            this.rd_propinsi.Size = new System.Drawing.Size(62, 17);
            this.rd_propinsi.TabIndex = 2;
            this.rd_propinsi.TabStop = true;
            this.rd_propinsi.Text = "Propinsi";
            this.rd_propinsi.UseVisualStyleBackColor = true;
            // 
            // rd_kabkota
            // 
            this.rd_kabkota.AutoSize = true;
            this.rd_kabkota.Location = new System.Drawing.Point(131, 10);
            this.rd_kabkota.Name = "rd_kabkota";
            this.rd_kabkota.Size = new System.Drawing.Size(71, 17);
            this.rd_kabkota.TabIndex = 1;
            this.rd_kabkota.TabStop = true;
            this.rd_kabkota.Text = "Kab/Kota";
            this.rd_kabkota.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tingkat";
            // 
            // pnl_jenis
            // 
            this.pnl_jenis.Controls.Add(this.rd_lainnya);
            this.pnl_jenis.Controls.Add(this.rd_grup);
            this.pnl_jenis.Controls.Add(this.rd_individual);
            this.pnl_jenis.Controls.Add(this.label3);
            this.pnl_jenis.Location = new System.Drawing.Point(13, 91);
            this.pnl_jenis.Name = "pnl_jenis";
            this.pnl_jenis.Size = new System.Drawing.Size(308, 76);
            this.pnl_jenis.TabIndex = 5;
            this.pnl_jenis.Validating += new System.ComponentModel.CancelEventHandler(this.pnl_jenis_Validating);
            // 
            // rd_lainnya
            // 
            this.rd_lainnya.AutoSize = true;
            this.rd_lainnya.Location = new System.Drawing.Point(131, 54);
            this.rd_lainnya.Name = "rd_lainnya";
            this.rd_lainnya.Size = new System.Drawing.Size(62, 17);
            this.rd_lainnya.TabIndex = 7;
            this.rd_lainnya.TabStop = true;
            this.rd_lainnya.Text = "Lainnya";
            this.rd_lainnya.UseVisualStyleBackColor = true;
            // 
            // rd_grup
            // 
            this.rd_grup.AutoSize = true;
            this.rd_grup.Location = new System.Drawing.Point(131, 30);
            this.rd_grup.Name = "rd_grup";
            this.rd_grup.Size = new System.Drawing.Size(48, 17);
            this.rd_grup.TabIndex = 6;
            this.rd_grup.TabStop = true;
            this.rd_grup.Text = "Grup";
            this.rd_grup.UseVisualStyleBackColor = true;
            // 
            // rd_individual
            // 
            this.rd_individual.AutoSize = true;
            this.rd_individual.Location = new System.Drawing.Point(131, 6);
            this.rd_individual.Name = "rd_individual";
            this.rd_individual.Size = new System.Drawing.Size(70, 17);
            this.rd_individual.TabIndex = 5;
            this.rd_individual.TabStop = true;
            this.rd_individual.Text = "Individual";
            this.rd_individual.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis";
            // 
            // txt_tahun
            // 
            this.txt_tahun.Location = new System.Drawing.Point(144, 65);
            this.txt_tahun.MaxLength = 4;
            this.txt_tahun.Name = "txt_tahun";
            this.txt_tahun.Size = new System.Drawing.Size(64, 20);
            this.txt_tahun.TabIndex = 3;
            this.txt_tahun.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tahun_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahun";
            // 
            // txt_kegiatan
            // 
            this.txt_kegiatan.Location = new System.Drawing.Point(144, 34);
            this.txt_kegiatan.Name = "txt_kegiatan";
            this.txt_kegiatan.Size = new System.Drawing.Size(166, 20);
            this.txt_kegiatan.TabIndex = 1;
            this.txt_kegiatan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_kegiatan_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kegiatan";
            // 
            // err_isianprestasi
            // 
            this.err_isianprestasi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_isianprestasi.ContainerControl = this;
            // 
            // pnl_header
            // 
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(734, 76);
            this.pnl_header.TabIndex = 15;
            // 
            // IsianPrestasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_header);
            this.Name = "IsianPrestasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IsianPrestasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IsianPrestasi_FormClosing);
            this.pnl_form.ResumeLayout(false);
            this.group_form.ResumeLayout(false);
            this.group_form.PerformLayout();
            this.pnl_pencapaian.ResumeLayout(false);
            this.pnl_pencapaian.PerformLayout();
            this.pnl_tingkat.ResumeLayout(false);
            this.pnl_tingkat.PerformLayout();
            this.pnl_jenis.ResumeLayout(false);
            this.pnl_jenis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_isianprestasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_form;
        private System.Windows.Forms.GroupBox group_form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tahun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kegiatan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_jenis;
        private System.Windows.Forms.RadioButton rd_lainnya;
        private System.Windows.Forms.RadioButton rd_grup;
        private System.Windows.Forms.RadioButton rd_individual;
        private System.Windows.Forms.Panel pnl_tingkat;
        private System.Windows.Forms.RadioButton rd_internasional;
        private System.Windows.Forms.RadioButton rd_nasional;
        private System.Windows.Forms.RadioButton rd_propinsi;
        private System.Windows.Forms.RadioButton rd_kabkota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_pencapaian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rd_juara3;
        private System.Windows.Forms.RadioButton rd_juara2;
        private System.Windows.Forms.RadioButton rd_juara1;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.ErrorProvider err_isianprestasi;
        private System.Windows.Forms.Panel pnl_header;
    }
}