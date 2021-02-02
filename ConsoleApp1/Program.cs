using System;
using System.Security.Cryptography;
using System.Text;
using ConsoleApp1.Function;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // ExcelFun.readExcel();
            // HashCodeFun.HashSHA256();
            #endregion

            string rs = HashPassword("abc1A@a");
            Console.WriteLine(rs);

            Console.ReadKey();
           
        }
        public static string HashPassword(string password)
        {
            password = password + "WZ5WLTPTEYFX6WU47GWD7TPEXJPHRXZD";
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    }
}
