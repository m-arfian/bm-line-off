﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Drawing;

namespace Bidikmisioffline.classes
{
    class Formatter
    {
        protected static Color ERR_COLOR = Color.Pink;

        public static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes 
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data  
            // and format each one as a hexadecimal string. 
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }

        public static void SetTextError(System.Windows.Forms.TextBox txt)
        {
            txt.BackColor = ERR_COLOR;
        }

        public static void SetTextError(List<System.Windows.Forms.TextBox> txt)
        {
            foreach (System.Windows.Forms.TextBox item in txt)
            {
                item.BackColor = ERR_COLOR;
            }
        }
    }
}
