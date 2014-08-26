using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bidikmisioffline
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_datasiswa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Data_Siswa ds = new Data_Siswa(this);
            ds.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataPrestasi dp = new DataPrestasi(this);
            dp.Show();
        }

        private void btn_unas_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataUnas du = new DataUnas(this);
            du.Show();
        }

    }
}
