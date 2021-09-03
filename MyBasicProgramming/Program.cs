using System;

namespace MyBasicProgramming
{
    class MainClass //class
    {
        public static void Main(string[] args) //method
        {
            /* Print String */
            Console.WriteLine("HELLO EMPLY!!!");  //Print String

            /* True False Check */
            Console.WriteLine(10==8); //True False Check

            /* print with bracket{} */
            Console.WriteLine("EMPLy!!! EMPLY01 = {0} EMPLY02 = {1}","EMPLY","IT'S EMPLY");
            Console.WriteLine("{0} + {1} = {2}",1,1,2);   //print with bracket{}

            /* Data Variable : Math logic */
            int x = 10, y = 20;
            float a = 1.1f;
            double b;
            b = x + y;
            bool status = false;
            char al = 'A';
            string name = "emply!";

            Console.WriteLine("integer: " + x + "+" + y + "=" + (x + y));
            Console.WriteLine("float: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("boolean: " + status);
            Console.WriteLine("char: " + al);
            Console.WriteLine("string: " + name);
            x = 11;
            y = 22;
            Console.WriteLine("change integer: " + x + "+" + y + "=" + (x + y));

            /* Constant */
            const float W = 3.14f; // constant must use Upper word for help to find
            Console.WriteLine("Constant: " + W);

            /* format string */
            int number = 1234567;
            Console.WriteLine("Number Exponential: = {0:E}", number); //E or e = Exponential
            Console.WriteLine("Number Floating Point: = {0:F}", number); //F or f = Floating Point
            Console.WriteLine("Number Short number: = {0:G}", number); // G or g = Short number
            Console.WriteLine("Number Comma Number : = {0:N}", number); // N or n = Comma Number like 1,000
            Console.WriteLine("Number percentage: = {0:P}", number); //P or p = percentage
            Console.WriteLine("Number Hexadecimal: = {0:X}", number); //X or x = Hexadecimal

            /* Input */
            Console.Write("Input = ");
            int result = Console.Read(); // Read ASCII
            Console.WriteLine("ASCII output: " + result);
            string sresult = Console.ReadLine(); //Read string
            Console.WriteLine("String Output: " + sresult);


            /* ###################################### */
            Console.ReadLine(); //enter for close command
        }
    }
}
