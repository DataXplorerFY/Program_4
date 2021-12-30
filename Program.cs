using System;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3 , b=4;
            //CONDITION 1
            int c = ++a;
            c *= b++;
            Console.WriteLine(c); 

            //CONDITION 2
            int c= ++a;
            c*= ++b;
            Console.WriteLine(c);

        }
    }
}
