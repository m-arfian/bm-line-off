using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Bidikmisioffline.classes
{
    class Validator
    {
        public static bool IsEmptyText(String text)
        {
            return String.IsNullOrWhiteSpace(text);
        }

        public static bool IsNotZero(String digit)
        {
            return digit != "0";
        }

        public static bool IsNotZero(Int32 digit)
        {
            return digit != 0;
        }

        public static bool IsMatchRegex(String text, String regex)
        {
            return Regex.IsMatch(text, @regex);
        }

        public static bool IsOnlyNumber(String text)
        {
            return Regex.IsMatch(text, @"[0-9]");
        }

        public static bool IsCertainLength(String text, Int32 length)
        {
            return text.Length == length;
        }
    }
}
