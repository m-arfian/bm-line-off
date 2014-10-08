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
    public partial class DataPrestasi : Form
    {
        Dashboard dash;

        public DataPrestasi()
        {
            InitializeComponent();
            FillListView();
        }

        private void FillListView()
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

        public DataPrestasi(Dashboard dash)
        {
            InitializeComponent();
            this.dash = dash;
        }

        private void btn_newprestasi_Click(object sender, EventArgs e)
        {
            IsianPrestasi ispr = new IsianPrestasi();
            DialogResult dr = ispr.ShowDialog();
            if (dr == DialogResult.OK)
                FillListView();
        }

        private void DataPrestasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dash.Show();
        }
    }
}
