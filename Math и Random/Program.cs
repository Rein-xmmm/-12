using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_и_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("K=3t^2 +3sinx^3 +9.2");
            Random rand = new Random();
            int t = rand.Next(0, 99);
            int x = rand.Next(0, 99);

            Double K = 3 * Math.Pow(t, 2) + 3 * Math.Sin( Math.Pow(x, 3)) + 9.2;
            Console.WriteLine($"t= {t}");
            Console.WriteLine($"x= {x} ");
            Console.WriteLine($"K={K}");
            Console.ReadLine();



        }
    }
}