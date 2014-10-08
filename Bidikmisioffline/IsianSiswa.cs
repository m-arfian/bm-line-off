using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Bidikmisioffline.classes;

namespace Bidikmisioffline
{
    public partial class IsianSiswa : Form
    {
        private static int MODE_ISIAN;
        private static string NO_INDUK;
        private static string NO_PENDAFTARAN;

        public IsianSiswa(int mode)
        {
            InitializeComponent();

            IsianSiswa.MODE_ISIAN = mode;

            // FormSetting();
            FillListPrestasi();
        }

        public IsianSiswa(int mode, string noinduk, string nopend)
        {
            InitializeComponent();

            IsianSiswa.MODE_ISIAN = mode;
            IsianSiswa.NO_INDUK = noinduk;
            IsianSiswa.NO_PENDAFTARAN = nopend;

            FormSetting();
            FillListPrestasi();
        }

        private void EnabledTab(bool stats)
        {
            tp_akademik.Enabled = stats;
            tp_prestasi.Enabled = stats;
            tp_keluarga.Enabled = stats;
            tp_rumah.Enabled = stats;
            tp_aset.Enabled = stats;
            tp_ekonomi.Enabled = stats;
            tp_seleksi.Enabled = stats;
        }

        private void FormSetting()
        {
            if (MODE_ISIAN == Siswa.DATA_BARU)
            {
                // this.btn_next_biodata.DialogResult = System.Windows.Forms.DialogResult.OK;
                EnabledTab(false);
            }
            else
            {
                EnabledTab(true);
            }
        }

        private void FillListPrestasi()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable dt = db.GetDataTable("select * from prestasi_slta");

            list_prestasi.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["NAMA_KEGIATAN"].ToString());
                listitem.SubItems.Add(dr["JENIS"].ToString());
                listitem.SubItems.Add(dr["TINGKAT"].ToString());
                listitem.SubItems.Add(dr["TAHUN"].ToString());
                listitem.SubItems.Add(dr["PENCAPAIAN"].ToString());
                list_prestasi.Items.Add(listitem);
            }
        }

        private void KeluargaDependencies()
        {
            /* Status ortu */
            cmb_status_ayah.DataSource = Siswa.get_status_ayah();
            cmb_status_ayah.DisplayMember = "Text";
            cmb_status_ayah.ValueMember = "Value";

            cmb_status_ibu.DataSource = Siswa.get_status_ibu();
            cmb_status_ibu.DisplayMember = "Text";
            cmb_status_ibu.ValueMember = "Value";

            /* Status hubungan */
            cmb_status_hubungan.DataSource = Siswa.get_status_hubungan();

            /* Status Wali */
            cmb_hubungan_wali.DataSource = Siswa.get_hubungan_wali();

            /* Pekerjaan ortu */
            cmb_pekerjaan_ayah.DataSource = SimpleQuery.get_list_pekerjaan();
            cmb_pekerjaan_ayah.DisplayMember = "NAMA_PEKERJAAN";
            cmb_pekerjaan_ayah.ValueMember = "KODE_PEKERJAAN";

            cmb_pekerjaan_ibu.DataSource = SimpleQuery.get_list_pekerjaan();
            cmb_pekerjaan_ibu.DisplayMember = "NAMA_PEKERJAAN";
            cmb_pekerjaan_ibu.ValueMember = "KODE_PEKERJAAN";

            /* Pendidikan ortu */
            cmb_pendidikan_ayah.DataSource = SimpleQuery.get_list_pendidikan();
            cmb_pendidikan_ayah.DisplayMember = "NAMA_PENDIDIKAN";
            cmb_pendidikan_ayah.ValueMember = "KODE_PENDIDIKAN";

            cmb_pendidikan_ibu.DataSource = SimpleQuery.get_list_pendidikan();
            cmb_pendidikan_ibu.DisplayMember = "NAMA_PENDIDIKAN";
            cmb_pendidikan_ibu.ValueMember = "KODE_PENDIDIKAN";
        }

        private void RumahDependencies()
        {
            /* Kepemilikan */
            cmb_kepemilikan.DataSource = SimpleQuery.get_list_kepemilikan();
            cmb_kepemilikan.DisplayMember = "KEPEMILIKAN";
            cmb_kepemilikan.ValueMember = "KODE_KEPEMILIKAN";

            /* Tahun perolehan */
            cmb_tahun_perolehan.DataSource = Siswa.get_tahun_kepemilikan();
            cmb_tahun_perolehan.DisplayMember = "Text";
            cmb_tahun_perolehan.ValueMember = "Value";

            cmb_sumber_listrik.DataSource = SimpleQuery.get_list_listrik();
            cmb_sumber_listrik.DisplayMember = "SUMBER";
            cmb_sumber_listrik.ValueMember = "KODE_LISTRIK";

            cmb_daya_listrik.DataSource = Siswa.get_daya_listrik();
            cmb_daya_listrik.DisplayMember = "Text";
            cmb_daya_listrik.ValueMember = "Value";

            cmb_luas_bangunan.DataSource = SimpleQuery.get_list_luas();
            cmb_luas_bangunan.DisplayMember = "LUAS";
            cmb_luas_bangunan.ValueMember = "KODE_LUAS";

            cmb_luas_tanah.DataSource = SimpleQuery.get_list_luas();
            cmb_luas_tanah.DisplayMember = "LUAS";
            cmb_luas_tanah.ValueMember = "KODE_LUAS";

            cmb_bahan_atap.DataSource = Siswa.get_bahan_atap();
            cmb_bahan_atap.DisplayMember = "Text";
            cmb_bahan_atap.ValueMember = "Value";

            cmb_bahan_lantai.DataSource = Siswa.get_bahan_lantai();
            cmb_bahan_lantai.DisplayMember = "Text";
            cmb_bahan_lantai.ValueMember = "Value";

            cmb_bahan_tembok.DataSource = Siswa.get_bahan_tembok();
            cmb_bahan_tembok.DisplayMember = "Text";
            cmb_bahan_tembok.ValueMember = "Value";

            cmb_sumber_air.DataSource = Siswa.get_sumber_air();
            cmb_sumber_air.DisplayMember = "Text";
            cmb_sumber_air.ValueMember = "Value";

            cmb_mck.DataSource = SimpleQuery.get_list_mck();
            cmb_mck.DisplayMember = "MCK";
            cmb_mck.ValueMember = "KODE_MCK";
        }

        private void IsianSiswa_Load(object sender, EventArgs e)
        {
            /* Provinsi */
            cmb_provinsi.DataSource = SimpleQuery.get_provinsi();
            cmb_provinsi.DisplayMember = "NAMA_PROVINSI";
            cmb_provinsi.ValueMember = "KODE_PROVINSI";

            /* Tahun lulus */
            cmb_tahunlulus.DataSource = Siswa.get_tahun_lulus();

            KeluargaDependencies();
            RumahDependencies();
        }

        private void tc_siswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*   SAVE PROCESS   */
            // btn_next_akademik.Text = ((TabControl)sender).TabPages.;
        }

        private void btn_next_biodata_Click(object sender, EventArgs e)
        {
            string nopendaftaran = Algoritma.GenerateNoPendaftaran(LoginInfo.getNPSN());
            string kodeakses = Algoritma.GenerateKodeAksesSiswa(txt_noinduk.Text, LoginInfo.getNPSN());

            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> siswa = new Dictionary<String, String>();
            siswa.Add("NO_INDUK", LoginInfo.getNPSN() + txt_noinduk.Text);
            siswa.Add("NISN", txt_nisn.Text);
            siswa.Add("NPSN", LoginInfo.getNPSN());
            siswa.Add("NAMA_SISWA", txt_namasiswa.Text);
            siswa.Add("TEMPAT_LAHIR", txt_tempatlahir.Text);
            siswa.Add("TANGGAL_LAHIR", DateTime.ParseExact("10/03/2014", "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"));
            siswa.Add("JENIS_KELAMIN", Siswa._kelamin(pnl_kelamin.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text));
            siswa.Add("NAMA_IBU", txt_namagadis.Text);
            siswa.Add("ANGKATAN_LULUS", cmb_tahunlulus.SelectedValue.ToString());
            siswa.Add("STATUS_REKOMENDASI", Siswa.DIREKOMENDASI);

            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("NO_PENDAFTARAN", nopendaftaran);
            data.Add("NO_INDUK", LoginInfo.getNPSN() + txt_noinduk.Text);
            data.Add("KODE_AKSES", kodeakses);
            data.Add("KODE_ROLE", Siswa.ROLE);
            data.Add("TAHUN_BEASISWA", Program.TAHUN.ToString());
            data.Add("ALAMAT", txt_alamat.Text);
            data.Add("KOTA", cmb_kota.SelectedValue.ToString());
            data.Add("KODE_POS", txt_kodepos.Text);
            data.Add("NO_TELEPON", txt_notelp.Text);
            data.Add("NO_HANDPHONE", txt_nohp.Text);
            data.Add("EMAIL", txt_email.Text);

            try
            {
                db.Insert("siswa", siswa);
                db.Insert("berkas", data);
                MessageBox.Show("Data siswa baru tersimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tc_siswa.SelectedTab = tp_akademik;
                if (MODE_ISIAN == Siswa.DATA_BARU)
                {
                    EnabledTab(true);
                    IsianSiswa.MODE_ISIAN = Siswa.EDIT_DATA;
                    IsianSiswa.NO_INDUK = LoginInfo.getNPSN() + txt_noinduk.Text;
                    IsianSiswa.NO_PENDAFTARAN = nopendaftaran;
                }
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_next_akademik_Click(object sender, EventArgs e)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> siswa = new Dictionary<String, String>();
            siswa.Add("NILAI_SMT_4", txt_ntotal_4.Text);
            siswa.Add("NILAI_SMT_5", txt_ntotal_5.Text);
            siswa.Add("NILAI_SMT_6", txt_ntotal_6.Text);
            siswa.Add("JUMLAH_MAPEL_SMT_4", txt_jmapel_4.Text);
            siswa.Add("JUMLAH_MAPEL_SMT_5", txt_jmapel_5.Text);
            siswa.Add("JUMLAH_MAPEL_SMT_6", txt_jmapel_6.Text);
            siswa.Add("RANKING_SMT_4", txt_ranking_4.Text);
            siswa.Add("RANKING_SMT_5", txt_ranking_5.Text);
            siswa.Add("RANKING_SMT_6", txt_ranking_6.Text);
            siswa.Add("JURUSAN", cmb_jurusan_sekolah.SelectedValue.ToString());
            siswa.Add("NILAI_UNAS", txt_nunas.Text);
            siswa.Add("JUMLAH_MAPEL_UNAS", txt_jmapel_unas.Text);

            try
            {
                db.Update("siswa", siswa, String.Format("NO_INDUK = {0}", IsianSiswa.NO_INDUK));
                MessageBox.Show("Data berhasil tersimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tc_siswa.SelectedTab = tp_prestasi;
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_next_prestasi_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection checkedItems =
                list_prestasi.CheckedItems;
            SQLiteDatabase db = new SQLiteDatabase();

            try
            {
                foreach (ListViewItem item in checkedItems)
                {

                    Dictionary<String, String> prestasi = new Dictionary<String, String>();
                    prestasi.Add("NO_INDUK", IsianSiswa.NO_INDUK);
                    prestasi.Add("KODE_PRESTASI_SEKOLAH", item.SubItems[0].Text);
                    db.Insert("prestasi_ekstra_siswa", prestasi);
                }

                MessageBox.Show("Data prestasi siswa tersimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tc_siswa.SelectedTab = tp_prestasi;
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_next_keluarga_Click(object sender, EventArgs e)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            Dictionary<String, String> berkas = new Dictionary<String, String>();
            berkas.Add("NILAI_SMT_4", txt_ntotal_4.Text);
            berkas.Add("NILAI_SMT_5", txt_ntotal_5.Text);
            berkas.Add("NILAI_SMT_6", txt_ntotal_6.Text);
            berkas.Add("JUMLAH_MAPEL_SMT_4", txt_jmapel_4.Text);
            berkas.Add("JUMLAH_MAPEL_SMT_5", txt_jmapel_5.Text);
            berkas.Add("JUMLAH_MAPEL_SMT_6", txt_jmapel_6.Text);
            berkas.Add("RANKING_SMT_4", txt_ranking_4.Text);
            berkas.Add("RANKING_SMT_5", txt_ranking_5.Text);
            berkas.Add("RANKING_SMT_6", txt_ranking_6.Text);
            berkas.Add("JURUSAN", cmb_jurusan_sekolah.SelectedValue.ToString());
            berkas.Add("NILAI_UNAS", txt_nunas.Text);
            berkas.Add("JUMLAH_MAPEL_UNAS", txt_jmapel_unas.Text);

            try
            {
                db.Update("berkas", berkas, String.Format("NO_INDUK = {0}", IsianSiswa.NO_INDUK));
                MessageBox.Show("Data berhasil tersimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tc_siswa.SelectedTab = tp_prestasi;
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_next_rumah_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_aset_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_ekonomi_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_seleksi_Click(object sender, EventArgs e)
        {

        }

        private void tc_siswa_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void cmb_provinsi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb_prov_temp = (ComboBox)sender;
            cmb_kota.Enabled = true;

            cmb_kota.DataSource = SimpleQuery.get_kota(cmb_prov_temp.SelectedValue.ToString());
            cmb_kota.DisplayMember = "NAMA_KOTA";
            cmb_kota.ValueMember = "KODE_KOTA";
        }

    }
}
