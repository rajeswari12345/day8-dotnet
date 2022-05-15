// See https://aka.ms/new-console-template for more information
using  System;
namespace Linecomparisionproblems
{
    class program
    {
        //variable declaration
        public static int x1, x2, y1, y2;
        static void Main(string[] args)
        {
            console.writeline("Enter value for coordinate \"x1/" ");
            x1 = convert.ToInt > ReadLine());
            console.writeline("Enter value for coordinate \"y1/" ");
            y1 = convert.ToInt > ReadLine());

            console.writeline("Enter value for coordinate \"x2/" ");
            x2 = convert.ToInt > ReadLine());
            console.writeline("Enter value for coordinate \"y2/" ");
           y2 = convert.ToInt > ReadLine());
            //object for created for class FindingLength 
            FindingLength obj = new FindingLength();
            obj.LineLength(x1, y1, x2, y2);
        }
    }
