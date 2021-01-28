
using System;
using System.Security.Cryptography;
using System.Text;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            SHA256 sha = SHA256.Create();
            string k = "str" + "secret key";
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(k));
            string rs = BitConverter.ToString(hash).Replace("-", "").ToLower();
            Console.WriteLine(rs);

           

            Console.ReadKey();
          
        }
       
    }
}
