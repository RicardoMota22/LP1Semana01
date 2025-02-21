using System;


namespace ManyStrings
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            //This changed the question mark that was printed on the money 
            //script to a euro sign 
            Console.OutputEncoding = System.Text.Encoding.Unicode;

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

            //Exercise 6 
            double xx = 1.23456; //if you change 4 to 5 it rounds to 1.24
            int ii = 19;

            //only 2 decimal points 
            string xxk = $"xx={xx:f2}"; //Answer is 1.23

            //Percentage, only 1 decimal point
            
            //tests
            //string x2 = $".{10,4:x}. e .{11,-4:x}.";

            //string s3 = $"'{5,-6:f2}' e '{0.2:p1}'";

            string xx2 = $"'{xx:p1}'"; //Calculates percentage of double xx
            string ii2 = $"'{ii:x}'"; //Calculates Hexadecimal
             
            string ii3 = $"'{ii:C}'"; //Calculates Moeda

            
            Console.WriteLine("Hello LP1!");
            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(s);
            Console.WriteLine(f);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(sn);

            Console.WriteLine(xxk);
            //Console.WriteLine(x2);
            //Console.WriteLine(s3);
            Console.WriteLine(xx2);

            Console.WriteLine(ii2);
            Console.WriteLine(ii3);
        }
    }
}
