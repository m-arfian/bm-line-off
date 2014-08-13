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
    public partial class Data_Siswa : Form
    {
        public Data_Siswa()
        {
            InitializeComponent();
        }

        private void btn_newsiswa_Click(object sender, EventArgs e)
        {
            IsianSiswa isis = new IsianSiswa();
            isis.ShowDialog();
        }
    }
}
