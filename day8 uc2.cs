// See https://aka.ms/new-console-template for more information
using System;
namespace Linecomparisionproblems
{
    class program
    {
        //variable declaration
        public static int x1, x2, y1, y2, length1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for coordinate x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for coordinate y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for coordinate y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            //formula for question
            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + (y2 - y1) * (y2 - y1)));

            double a1, b1, a2, b2, length2;
            Console.WriteLine("Enter value for coordinate x1");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for coordinate y1");
            b1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate x2");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for coordinate y2");
            b2 = Convert.ToInt32(Console.ReadLine());

            //formula for question
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + (b2 - b1) * (b2 - b1)));


            //compare to method is used to compare
            if (length1.CompareTo(length2) == 0)
            {
                Console.WriteLine("line is equal to length");

            }
            else if (length1.CompareTo(length2) > 0) ;
            {
                Console.WriteLine("Line1 is bigger than Line2");

            }
            else
            {

                Console.WriteLine("Line2 is bigger than Line1");

            }

            Console.ReadLine();
        }
    }

}

