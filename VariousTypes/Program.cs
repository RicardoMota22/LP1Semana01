using System;
using System.Text; // Start of the program
using System.ComponentModel;

namespace VariousTypes
{
    public class Program
    {
        //Output encoding did not work here
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            Console.OutputEncoding = Encoding.UTF8;//

            // Declarar variavel
            //int numero;
            
            //Atribuir valor a variavel
            //numero = 8;
            
            // Declarar e attribuir valor na mesma linha 
            int numero = 8;

            // Declarar e attribuir valor na mesma linha 
            float pi = 3.1415f;



            //char = stores single characters, such as 'a' or 'B'. Char values
            // are surrounded by single quotes
            //More complex symbols need unicodes
            char myletter = 'D';

            char copyrightSymbol = '\u00A9';
            char newLine = '\u000A';
            char heart = '\u2764';

            //Real Variables
            //Float, decimal, double 

            double x = 3.145;
            float y = 3.145f; //requer f or F ao fim
            decimal z = 3.145m; //requer m or M ao fim

            //Boolean 
            //2 possible values, either true or false 
            
            bool condition = 5 > 3; //Answer is True
            bool condition2 = 3 > 5;




            //Mostrar Valor no ecra 
            Console.WriteLine(numero);

            Console.WriteLine(pi);

            Console.WriteLine(myletter);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);
            Console.WriteLine(heart);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(condition);
            Console.WriteLine(condition2);

        
        
        
        }

    }
}
