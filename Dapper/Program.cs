using Microsoft.AspNet.Identity;
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
            string k = "Nhat@041089XKJSOTNFJGFCJGOMSYST2PXBQZLI2SWR";
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(k));
            string rs = BitConverter.ToString(hash).Replace("-", "").ToLower();
            Console.WriteLine(rs);

           

            Console.ReadKey();
          
        }
       
    }
}
