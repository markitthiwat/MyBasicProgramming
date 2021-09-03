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

            const float w = 3.14f;
            Console.WriteLine("Constant: " + w);


            /* ###################################### */
            Console.ReadLine(); //enter for close command
        }
    }
}
