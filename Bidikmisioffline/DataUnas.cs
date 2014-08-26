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
    public partial class DataUnas : Form
    {
        Dashboard dash;

        public DataUnas()
        {
            InitializeComponent();
        }

        public DataUnas(Dashboard dash)
        {
            InitializeComponent();
            this.dash = dash;
        }

        private void btn_newunas_Click(object sender, EventArgs e)
        {
            IsianUnas isun = new IsianUnas();
            DialogResult dr = isun.ShowDialog();
        }
    }
}
