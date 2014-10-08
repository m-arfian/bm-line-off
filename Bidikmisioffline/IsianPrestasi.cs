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
    public partial class IsianPrestasi : Form
    {
        public IsianPrestasi()
        {
            InitializeComponent();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                SQLiteDatabase db = new SQLiteDatabase();
                Dictionary<String, String> data = new Dictionary<String, String>();
                data.Add("NPSN", LoginInfo.getNPSN());
                data.Add("NAMA_KEGIATAN", txt_kegiatan.Text);
                data.Add("TAHUN", txt_tahun.Text);
                data.Add("JENIS", pnl_jenis.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToLower());
                data.Add("TINGKAT", pnl_tingkat.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToLower());
                data.Add("PENCAPAIAN", pnl_pencapaian.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text.ToLower());

                try
                {
                    db.Insert("prestasi_slta", data);
                    MessageBox.Show("Data prestasi berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txt_kegiatan_Validating(object sender, CancelEventArgs e)
        {
            String teks = ((TextBox)sender).Text;
            e.Cancel = true;

            if (Validator.IsEmptyText(teks))
                err_isianprestasi.SetError((TextBox)sender, "Nama Kegiatan wajib diisi");
            else
            {
                e.Cancel = false;
                err_isianprestasi.SetError((TextBox)sender, "");
            }
        }

        private void txt_tahun_Validating(object sender, CancelEventArgs e)
        {
            String teks = ((TextBox)sender).Text;
            e.Cancel = true;

            if (Validator.IsEmptyText(teks))
                err_isianprestasi.SetError((TextBox)sender, "Tahun wajib diisi");
            else
            {
                e.Cancel = false;
                err_isianprestasi.SetError((TextBox)sender, "");
            }
        }

        private void pnl_jenis_Validating(object sender, CancelEventArgs e)
        {
            String teks = ((Panel)sender).Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            e.Cancel = true;

            if (Validator.IsEmptyText(teks))
                err_isianprestasi.SetError((Panel)sender, "Jenis Prestasi wajib diisi");
            else
            {
                e.Cancel = false;
                err_isianprestasi.SetError((Panel)sender, "");
            }
        }

        private void IsianPrestasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}