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
    public partial class DataPrestasi : Form
    {
        Dashboard dash;

        public DataPrestasi()
        {
            InitializeComponent();
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
        }

        private void DataPrestasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dash.Show();
        }
    }
}
