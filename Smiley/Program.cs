using System;
using System.Globalization;
using System.Text;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Insere codigo  : ");
            string str = Console.ReadLine();//Asks for an input from user

            //From string to int
            int str2= int.Parse(str );

            //Print of Unicode

            string str3 = $"'{str2:x}'"; //Calculates Hexadecimal

            

            byte[] bytes = Encoding.UTF8.GetBytes(str);

            string hexString = BitConverter.ToString(bytes).Replace("-", "");

            //Console.WriteLine("Original String: " + str);
            Console.WriteLine("Caráter Unicode : " + hexString);
            Console.WriteLine(str3);
             
            
            
        }
    }
}
