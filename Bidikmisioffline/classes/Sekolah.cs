using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Bidikmisioffline.classes
{
    abstract class Sekolah
    {
        public static String ROLE = "2";
        public static String NPSN = "99999999";

        public static bool cek_data_ada()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = "select count(NPSN) from slta";
            String row = db.ExecuteScalar(query);
            if (!Validator.IsNotZero(row))
                return true;

            return false;
        }

        public static int jumlah_siswa()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = "select count(NO_PENDAFTARAN) from siswa";
            String row = db.ExecuteScalar(query);
            if (!String.IsNullOrWhiteSpace(row))
                return 0;
            else
                return Int32.Parse(row);
        }

        public static bool login_sekolah(string npsn, string kodeakses)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = "select NPSN, KODE_AKSES from slta where NPSN = '"+npsn+"' and KODE_AKSES = '"+kodeakses+"'";
            DataTable dt = db.GetDataTable(query);
            if (Validator.IsNotZero(dt.Rows.Count))
                return true;

            return false;
        }


        /* BEFORE SAVE */
        public static string _akreditasi(string value)
        {
            switch (value)
            {
                case "A":
                case "B":
                case "C":
                    return value;
                default:
                    return "0";
            }
        }

        public static string _jenissekolah(string value)
        {
            switch (value)
            {
                case "SMA":
                case "SMK":
                case "MA":
                case "MAK":
                    return value;
                default:
                    return "0";

            }
        }

    }
}
