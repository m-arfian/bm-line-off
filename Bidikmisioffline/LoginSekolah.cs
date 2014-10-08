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
    public partial class LoginSekolah : Form
    {
        public LoginSekolah()
        {
            InitializeComponent();
        }

        private void text_npsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Sekolah.login_sekolah(text_npsn.Text, text_kodeakses.Text))
            {
                this.Hide();

                Dashboard d = new Dashboard(text_npsn.Text);
                d.Show();
            }

            else
            {
                List<TextBox> lt = new List<TextBox>();
                lt.Add(text_npsn);
                lt.Add(text_kodeakses);

                Formatter.SetTextError(lt);
            }
                
        }
    }
}
