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
    public partial class Pralogin : Form
    {
        public Pralogin()
        {
            InitializeComponent();
        }

        public Pralogin(String kodeakses)
        {
            InitializeComponent();
            lbl_kodeakses.Text = kodeakses;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void chk_pernyataan_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
                btn_next.Enabled = true;
            else
                btn_next.Enabled = false;

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginSekolah ls = new LoginSekolah();
            ls.Show();

        }
    }
}
