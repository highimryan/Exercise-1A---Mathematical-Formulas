/*
 * C# Program to calculate the Volume of a Hemisphere.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_of_Hemisphere
{
    public class Hemisphere
    {
        public static void Main()
        {
            Console.WriteLine("Calculate the Volume of a Hemisphere");

            Double Radius, Volume, PI = Math.PI;

            Console.WriteLine("Enter Radius of Sphere: ");
            Radius = double.Parse(Console.ReadLine());
            Volume = (4.0 / 3) * PI * Math.Pow(Radius, 3) / 2;

                if (Radius >= 0)
                {
                        Console.WriteLine("Volume of Sphere is: " + Volume);
                        Console.Read();
                }

        }
    }
}
/* Output:
  Volume
  Volume of Sphere is: n
*/
