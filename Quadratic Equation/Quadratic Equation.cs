/*
 *  C# Program to Solve a Quadratic Equation
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    public class Program
    {
        public double a, b, c;

        public static void Main()
        {
            double a, b, c;

            Console.WriteLine("To solve a quadratic equation of " + "the form x = ax^2+bx+C=0-b+-sqrt(b^2-4ac) / 2a");
            Console.Write("Enter value for a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            c = double.Parse(Console.ReadLine());

            int m;
            double r1, r2, d1;
            d1 = b * b - 4 * a * c;
            if (a == 0)
                m = 1;
            else if (d1 > 0)
                m = 2;
            else if (d1 == 0)
                m = 3;
            else
                m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine(@"Not a Quadratic equation, Linear equation");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Roots are Real and Distinct");
                    r1 = (-b + Math.Sqrt(d1)) / (2 * a);
                    r2 = (-b - Math.Sqrt(d1)) / (2 * a);
                    Console.WriteLine("First root is {0:#.##}", r1);
                    Console.WriteLine("Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Roots are Real and Equal");
                    r1 = r2 = (-b) / (2 * a);
                    Console.WriteLine("First root is {0:#.##}", r1);
                    Console.WriteLine("Second root is {0:#.##}", r2);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("\n Roots are Imaginary");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-d1) / (2 * a);
                    Console.WriteLine("\n First root is {0:#.##} + i {1:#.##}",
                                       r1, r2);
                    Console.WriteLine("\n Second root is {0:#.##} - i {1:#.##}",
                                      r1, r2);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
/* Output:
  Root 1
  Root 2
  The solutions are: n
*/
