using System;
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

            //Print of Unicode
            char copyrightSymbol = '\u00A9';

            Console.WriteLine(str);
            Console.WriteLine(copyrightSymbol);
        }
    }
}
