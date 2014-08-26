using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bidikmisioffline.classes;

namespace Bidikmisioffline
{
    public partial class IsianSekolah : Form
    {
        public IsianSekolah()
        {
            InitializeComponent();
        }

        private void IsianSekolah_Load(object sender, EventArgs e)
        {   
            cmb_provinsi.DataSource = SimpleQuery.get_provinsi();
            cmb_provinsi.DisplayMember = "NAMA_PROVINSI";
            cmb_provinsi.ValueMember = "KODE_PROVINSI";


        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                String kodeakses = Formatter.GetMd5Hash(txt_namasekolah.Text).Substring(0, 6);
                SQLiteDatabase db = new SQLiteDatabase();
                Dictionary<String, String> data = new Dictionary<String, String>();
                data.Add("NPSN", txt_npsn.Text);
                data.Add("KODE_AKSES", kodeakses);
                data.Add("KODE_ROLE", Sekolah.ROLE);
                data.Add("KODE_KOTA", cmb_kota.SelectedValue.ToString());
                data.Add("NAMA_SEKOLAH", txt_namasekolah.Text);
                data.Add("ALAMAT", txt_alamatsekolah.Text);
                data.Add("NOMOR_TELEPON", txt_telpsekolah.Text);
                data.Add("EMAIL", txt_email.Text);
                data.Add("KEPALA_SEKOLAH", txt_namakepsek.Text);
                data.Add("NOTELP_KEPSEK", txt_telpkepsek.Text);
                data.Add("EMAIL_KEPSEK", txt_emailkepsek.Text);
                data.Add("JENIS", Sekolah._jenissekolah(pnl_jenis.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text));
                data.Add("AKREDITASI", Sekolah._akreditasi(pnl_akreditasi.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text));
                data.Add("NILAI_AKREDITASI", txt_nilaiakreditasi.Text);
                data.Add("STATUS", pnl_status.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToLower());

                try
                {
                    db.Insert("slta", data);
                    MessageBox.Show("Data sekolah berhasil disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    Pralogin pl = new Pralogin(kodeakses);
                    pl.Show();
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmb_provinsi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb_prov_temp = (ComboBox)sender;
            cmb_kota.Enabled = true;

            cmb_kota.DataSource = SimpleQuery.get_kota(cmb_prov_temp.SelectedValue.ToString());
            cmb_kota.DisplayMember = "NAMA_KOTA";
            cmb_kota.ValueMember = "KODE_KOTA";
        }

        private void txt_npsn_Validating(object sender, CancelEventArgs e)
        {
            String teks = ((TextBox)sender).Text;
            e.Cancel = true;

            if (Validator.IsEmptyText(teks))
                err_isiansekolah.SetError((TextBox)sender, "NPSN wajib diisi");
            else if (!Validator.IsCertainLength(teks, Sekolah.NPSN.Length))
                err_isiansekolah.SetError((TextBox)sender, "Panjang NPSN adalah 8 digit");
            else if (!Validator.IsOnlyNumber(teks))
                err_isiansekolah.SetError((TextBox)sender, "NPSN hanya boleh diisi angka");
            else
            {
                e.Cancel = false;
                err_isiansekolah.SetError((TextBox)sender, "");
            }
        }

        private void txt_namasekolah_Validating(object sender, CancelEventArgs e)
        {
            if (Validator.IsEmptyText(((TextBox)sender).Text))
            {
                e.Cancel = true;
                err_isiansekolah.SetError((TextBox)sender, "Wajib diisi");
            }
        }

        private void txt_alamatsekolah_Validating(object sender, CancelEventArgs e)
        {
            if (Validator.IsEmptyText(((TextBox)sender).Text))
            {
                e.Cancel = true;
                err_isiansekolah.SetError((TextBox)sender, "Wajib diisi");
            }
        }

        private void cmb_provinsi_Validating(object sender, CancelEventArgs e)
        {
            if (!Validator.IsNotZero(((ComboBox)sender).SelectedValue.ToString()))
            {
                e.Cancel = true;
                err_isiansekolah.SetError((ComboBox)sender, "Wajib diisi");
            }
        }

        private void cmb_kota_Validating(object sender, CancelEventArgs e)
        {
            if (!Validator.IsNotZero(((ComboBox)sender).SelectedValue.ToString()))
            {
                e.Cancel = true;
                err_isiansekolah.SetError((ComboBox)sender, "Wajib diisi");
            }
        }

    }
}