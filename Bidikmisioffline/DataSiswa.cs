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
    public partial class DataSiswa : Form
    {
        private Dashboard dash;

        public DataSiswa()
        {
            InitializeComponent();
        }

        public DataSiswa(Dashboard d)
        {
            InitializeComponent();
            this.dash = d;
        }

        private void btn_newsiswa_Click(object sender, EventArgs e)
        {
            IsianSiswa isis = new IsianSiswa(Siswa.DATA_BARU);
            DialogResult dr = isis.ShowDialog();
        }

        private void Data_Siswa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dash.Show();
        }
    }
}
