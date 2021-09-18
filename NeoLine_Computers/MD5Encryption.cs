using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NeoLine_Computers
{
    class MD5Encryption
    {
        public string getMD5(string encryptionText)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] array = Encoding.UTF8.GetBytes(encryptionText);
            array = md5.ComputeHash(array);
            StringBuilder sb = new StringBuilder();

            foreach (byte ba in array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

    }
}

