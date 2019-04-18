/*
 * C# Program to calculate the Area of a Triangle given the Length of the sides.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Triangle
{
    public class Hemisphere
    {
        public static void Main()
        {
            int A, B, C, P, Area;

            Console.WriteLine("Enter Length of Triangle's three sides: ");
            Console.WriteLine("Enter Side A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Side B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Side C");
            C = Convert.ToInt32(Console.ReadLine());

            P = (A + B + C) / 2;
            Area = (int)Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            if (A >= 0)
            {
                Console.WriteLine("Area of Triangle is : " + Area);
                Console.Read();
            }
        }
    }
}
/* Output:
  Area
  Area of Triangle is: n
*/
