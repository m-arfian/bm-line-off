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
        public static int TAHUN = 2014;
        public static int INISIAL_NO_PEND = 12;

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
