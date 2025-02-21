using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Insert whole number: ");
            string str = Console.ReadLine();//Asks for an input from user

            //Converts string to integer 
            int i = int.Parse(str ); 

            
            //Console.WriteLine(str);
            //Console.WriteLine(i);



            Console.WriteLine("Insert real number: ");
            string str2 = Console.ReadLine();//Asks for an input from user

            float f =float.Parse(str2);

            //Console.WriteLine(f);


            string s = $"{i} mais {f} e' igual a {i + f}";

            Console.WriteLine(s);
        }
    }
}
