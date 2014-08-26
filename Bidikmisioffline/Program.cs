using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using Bidikmisioffline.classes;

namespace Bidikmisioffline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if (Sekolah.cek_data_ada())
                    Application.Run(new IsianSekolah());
                else
                    Application.Run(new LoginSekolah());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
