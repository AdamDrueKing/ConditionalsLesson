using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsLesson
{
    class Program
    {
        static void Main(string[] args)
        //{ Console.WriteLine("What Is the total bill?");
        //    float totalBill = float.Parse(Console.ReadLine());
        //    if (totalBill >= 50)
        //        Console.WriteLine("You Get A 10% Discount!");

        //    if (totalBill < 50)
        //        Console.WriteLine("You Get A 5% Discount!");



        {
            Console.WriteLine("Please type a whole number from zero to ten");
            string number = (Console.ReadLine());
            switch (number)
            {
                case "zero":
                    Console.WriteLine("0");
                    break;
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "five":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("<0 or >10");
                    break;
            }
        }
    }
}