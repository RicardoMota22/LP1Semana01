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



            //Mostrar Valor no ecra 
            Console.WriteLine(numero);

            Console.WriteLine(pi);

            Console.WriteLine(myletter);
            Console.WriteLine(copyrightSymbol);
            Console.WriteLine(newLine);
            Console.WriteLine(heart);
        
        
        
        }

    }
}
