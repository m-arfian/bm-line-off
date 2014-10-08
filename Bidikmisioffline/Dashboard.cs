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
    public partial class Dashboard : Form
    {
        public Dashboard(string NPSN)
        {
            InitializeComponent();
            LoginInfo.setNPSN(NPSN);
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_datasiswa_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Data_Siswa ds = new Data_Siswa(this);
            //ds.Show();

            DataSiswa ds = new DataSiswa();
            ds.TopLevel = false;
            gb_datalist.Controls.Add(ds);
            ds.Dock = DockStyle.Fill;
            ds.Show();
        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //DataPrestasi dp = new DataPrestasi(this);
            //dp.Show();

            DataPrestasi dp = new DataPrestasi();
            dp.TopLevel = false;
            gb_datalist.Controls.Add(dp);
            dp.Dock = DockStyle.Fill;
            dp.Show();
        }

        private void btn_unas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //DataUnas du = new DataUnas(this);
            //du.Show();

            DataUnas du = new DataUnas();
            du.TopLevel = false;
            gb_datalist.Controls.Add(du);
            du.Dock = DockStyle.Fill;
            du.Show();
        }

    }
}
