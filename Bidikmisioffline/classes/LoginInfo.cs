using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bidikmisioffline.classes
{
    public static class LoginInfo
    {
        private static String NPSN;

        public static string getNPSN()
        {
            return LoginInfo.NPSN;
        }

        public static void setNPSN(string npsn)
        {
            LoginInfo.NPSN = npsn;
        }
    }
}
