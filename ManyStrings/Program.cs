using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //strings are types of references, not value like int,float,double
            string message = "Hello World";
            string message2 = "\u0027"; //Plica
            string s = "Um tab\t e um copyright\t\u00A9"; //copyright unicode 
            //with string
            
            
            Console.WriteLine("Hello LP1!");
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(s);
        }
    }
}
