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


            //Exercise 5 
            int z = 5;
            float y = 5.1f;

            //Concatenation
            string f = "Connected"+ " String";
            string a = "String " + 2;
            string b = "String " + z;

            //Interpolation

            string sn = $"{z} mais {y} e' igual a {z + y}";
            
            Console.WriteLine("Hello LP1!");
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(s);
            Console.WriteLine(f);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(sn);
        }
    }
}
