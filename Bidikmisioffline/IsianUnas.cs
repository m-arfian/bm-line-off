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
    public partial class IsianUnas : Form
    {
        public IsianUnas()
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
                data.Add("TAHUN_AJARAN", cmb_tahunajaran.SelectedValue.ToString());
                data.Add("NILAI_IPA", txt_nilaiipa.Text);
                data.Add("JUMLAH_MAPEL_IPA", txt_mapelipa.Text);
                data.Add("NILAI_IPS", txt_nilaiips.Text);
                data.Add("JUMLAH_MAPEL_IPS", txt_mapelips.Text);
                data.Add("NILAI_BAHASA", txt_nilaibahasa.Text);
                data.Add("JUMLAH_MAPEL_BAHASA", txt_mapelbahasa.Text);
                data.Add("NILAI_SMK", txt_nilaismk.Text);
                data.Add("JUMLAH_MAPEL_SMK", txt_mapelsmk.Text);

                try
                {
                    db.Insert("nilai_unas_slta", data);
                    MessageBox.Show("Data unas berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception crap)
                {
                    MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void IsianUnas_Load(object sender, EventArgs e)
        {
            cmb_tahunajaran.DataSource = SimpleQuery.get_listtahunajaran();
            cmb_tahunajaran.DisplayMember = "TAHUN";
            cmb_tahunajaran.ValueMember = "TAHUN";
        }

        private void cmb_tahunajaran_Validating(object sender, CancelEventArgs e)
        {
            if (!Validator.IsNotZero(((ComboBox)sender).SelectedValue.ToString()))
            {
                e.Cancel = true;
                err_isianunas.SetError((ComboBox)sender, "Wajib diisi");
            }
        }

        private void IsianUnas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
