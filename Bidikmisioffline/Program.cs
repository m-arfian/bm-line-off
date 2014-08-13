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

            try {
                SQLiteDatabase sqldb = new SQLiteDatabase();

                SQLiteCommand cmd = new SQLiteCommand();
                SQLiteDataReader dr;

                Application.Run(new Data_Siswa());
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Connection Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
