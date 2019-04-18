/*
 * C# Program to calculate the Area and Circumference of a Circle
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Circumference_circle
{
    public class Circle
    {
        public static void Main()
        {
            double Radius, Area, Diameter, Circumference;

            Console.WriteLine("Calculate the Area and Circumference of a Circle");
            Console.WriteLine("Enter Radius of Circle: ");
            Radius = double.Parse(Console.ReadLine());
            Area = Math.PI * Math.Pow(Radius, 2);
            Diameter = Radius * 2;
            Circumference = 2 * Math.PI * Radius;

                if (Radius >= 0)
                {
                    Console.WriteLine("Radius of Circle is: " + Radius);
                    Console.WriteLine("Diameter of Circle is: " + Diameter);
                    Console.WriteLine("Area of Circle is: " + Area);
                    Console.WriteLine("Circumference of Circle is: " + Circumference);
                    Console.Read();
                }               
        }
    }
}
/* Output:
  Radius, Diameter, Area, Circumference
  n of Circle is: x
*/
