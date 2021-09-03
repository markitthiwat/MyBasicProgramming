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

            /* Data Variable */
            int x = 10;
            int y = 20;
            float a = 1.1f;

            Console.WriteLine("integer: " + (x + y));
            Console.WriteLine("float: " + a);

            /* ###################################### */
            Console.ReadLine(); //enter for close command
        }
    }
}
