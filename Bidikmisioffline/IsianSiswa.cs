using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bidikmisioffline
{
    public partial class IsianSiswa : Form
    {
        public IsianSiswa()
        {
            InitializeComponent();
            disabled_alltab();
        }

        private void disabled_alltab()
        {
            tp_akademik.Enabled = false;
            tp_prestasi.Enabled = false;
            tp_keluarga.Enabled = false;
            tp_rumah.Enabled = false;
            tp_aset.Enabled = false;
            tp_ekonomi.Enabled = false;
            tp_seleksi.Enabled = false;
        }

        private void tc_siswa_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }
    }
}
