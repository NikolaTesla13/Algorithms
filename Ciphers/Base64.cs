using System;

namespace Base64
{
    internal class Base64
    {
        public static string Decrypt(string msg)
        {
            byte[] b;
            string decypted;

            try
            {
                b = Convert.FromBase64String(msg);
                decypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                decypted = "error";
            }

            return decypted;
        }

        public static string Encrypt(string msg)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(msg);
            string encrypted = Convert.ToBase64String(b);
            return encrypted;
        }
    }
}
