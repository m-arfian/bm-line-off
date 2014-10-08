using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Bidikmisioffline.classes
{
    abstract class Siswa
    {
        public static int DATA_BARU = 1;
        public static int EDIT_DATA = 2;

        public static String ROLE = "3";

        public static String DIREKOMENDASI = "1";

        public static bool cek_siswa_ada(string nopendaftaran)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            String query = "select count(NO_PENDAFTARAN) from siswa where NO_PENDAFTARAN = '"+nopendaftaran+"'";
            String row = db.ExecuteScalar(query);
            if (!Validator.IsNotZero(row))
                return true;

            return false;
        }

        public static Int32[] get_tahun_lulus()
        {
            return new Int32[] {Program.TAHUN, Program.TAHUN - 1};
        }

        /* -- KELUARGA -- */
        public static ListModel[] get_status_ayah()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Status --", "0"),
                new ListModel("Masih Hidup", "hidup"),
                new ListModel("Wafat", "wafat"),
                new ListModel("Bercerai", "bercerai"),
            };
        }

        public static ListModel[] get_status_ibu()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Status --", "0"),
                new ListModel("Masih Hidup", "hidup"),
                new ListModel("Wafat", "wafat"),
            };
        }

        public static String[] get_status_hubungan()
        {
            return new String[] { "-- Pilih Hubungan --", "Ayah Kandung", "Ayah Tiri", "Wali" };
        }

        public static String[] get_hubungan_wali()
        {
            return new String[] { "-- Pilih Hubungan --", "Keluarga Ayah/Ibu", "Kerabat Jauh", "Lainnya" };
        }

        /* -- RUMAH -- */
        public static List<ListModel> get_tahun_kepemilikan()
        {
            List<ListModel> tahun = new List<ListModel>();
            tahun.Add(new ListModel("-- Pilih Tahun --", "0"));

            for (int i = 1900; i <= Int32.Parse(DateTime.Now.ToString("yyyy")); i++)
            {
                tahun.Add(new ListModel(i.ToString()));
            }

            return tahun;
        }

        public static ListModel[] get_daya_listrik()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Daya --", "0"),
                new ListModel("450 Watt", "450"),
                new ListModel("900 Watt", "900"),
                new ListModel("1300 Watt", "1300"),
                new ListModel("2200 Watt", "2200"),
                new ListModel("3500 Watt", "3500"),
                new ListModel("5500 Watt", "5500"),
                new ListModel(">5500 Watt", ">5500"),
            };
        }

        public static ListModel[] get_bahan_atap()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Bahan --", "0"),
                new ListModel("Genting Glazur"),
                new ListModel("Genting"),
                new ListModel("Cor-Coran"),
                new ListModel("Asbes/Seng"),
                new ListModel("Kayu"),
                new ListModel("Rumbai/Tanaman"),
                new ListModel("Tanpa Atap"),
                new ListModel("Lainnya"),
            };
        }

        public static ListModel[] get_bahan_lantai()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Bahan --", "0"),
                new ListModel("Tanah"),
                new ListModel("Kayu"),
                new ListModel("Semen Plester"),
                new ListModel("Ubin"),
                new ListModel("Keramik"),
            };
        }

        public static ListModel[] get_bahan_tembok()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Bahan --", "0"),
                new ListModel("Kayu"),
                new ListModel("Seng"),
                new ListModel("Batu Gamping"),
                new ListModel("Semen/Beton"),
                new ListModel("Lainnya"),
            };
        }

        public static ListModel[] get_sumber_air()
        {
            return new ListModel[] {
                new ListModel("-- Pilih Sumber --", "0"),
                new ListModel("Kemasan", "kemasan"),
                new ListModel("PDAM", "PDAM"),
                new ListModel("Sumur", "sumur"),
                new ListModel("Sungai / Mata air", "sungai / mata air"),
            };
        }

        /* =============================================================================================== */
        /* BEFORE SAVE */
        public static string _kelamin(string value)
        {
            switch (value)
            {
                case "Laki-laki":
                    return "L";
                case "Perempuan":
                    return "P";
                default:
                    return "";
            }
        }
    }
}
