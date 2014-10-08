using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bidikmisioffline.classes
{
    class Algoritma
    {
        public static string GenerateNoPendaftaran(string npsn)
        {
            string timestamp = Formatter.GetTimeStamp();
            string unique = timestamp.Substring(0, 2) + timestamp.Substring(8, 2) + new Random().Next(100, 999).ToString();
            string tahun = Program.TAHUN.ToString().Substring(2, 2);

            npsn = npsn.Trim().Substring(0, 8);
            string nopendaftaran = Program.INISIAL_NO_PEND.ToString() + tahun + npsn + unique;

            return nopendaftaran;
        }

        public static string GenerateKodeAksesSiswa(string nis, string npsn)
        {
            string kodeakses = Formatter.GetMd5Hash(nis + npsn + new Random().Next(0, 999).ToString());

            return kodeakses;
        }
    }
}
