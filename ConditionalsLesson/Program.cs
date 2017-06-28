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
        {       Console.WriteLine("What Is the total bill?");
            int totalBill = int.Parse(Console.ReadLine());
                if (totalBill >= 50)
                Console.WriteLine("You Get A 10% Discount!");

            if (totalBill < 50)
                Console.WriteLine("You Get A 5% Discount!");
        }
    }
}
