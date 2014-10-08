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
    public partial class DataUnas : Form
    {
        public DataUnas()
        {
            InitializeComponent();
            FillListView();
        }

        private void FillListView()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable dt = db.GetDataTable("select * from nilai_unas_slta");

            list_unas.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["TAHUN_AJARAN"].ToString());
                listitem.SubItems.Add(dr["NILAI_IPA"].ToString());
                listitem.SubItems.Add(dr["JUMLAH_MAPEL_IPA"].ToString());
                listitem.SubItems.Add(dr["NILAI_IPS"].ToString());
                listitem.SubItems.Add(dr["JUMLAH_MAPEL_IPS"].ToString());
                listitem.SubItems.Add(dr["NILAI_BAHASA"].ToString());
                listitem.SubItems.Add(dr["JUMLAH_MAPEL_BAHASA"].ToString());
                listitem.SubItems.Add(dr["NILAI_SMK"].ToString());
                listitem.SubItems.Add(dr["JUMLAH_MAPEL_SMK"].ToString());
                list_unas.Items.Add(listitem);
            }
        }

        private void btn_newunas_Click(object sender, EventArgs e)
        {
            IsianUnas isun = new IsianUnas();
            DialogResult dr = isun.ShowDialog();
            if (dr == DialogResult.OK)
                FillListView();
        }
    }
}
