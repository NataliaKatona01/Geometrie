using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            double z1 = double.Parse(Console.ReadLine());

            if (y1 < 0)
            {

                if (z1 < 0)
                    Console.WriteLine($"v1 = {x1}i {y1}j {z1}k;");
                else
                    Console.WriteLine($"v1 = {x1}i {y1}j + {z1}k;");
            }
            if (y1 == 0)
                Console.WriteLine($"v1 = {x1}i + {z1}k;");
            if (z1 < 0)
            {
                Console.WriteLine($"v1 = {x1}i + {y1}j  {z1}k;");

            }
            if (z1 == 0)
                Console.WriteLine($"v1 = {x1}i + {y1}j ");
            if (y1 > 0 && z1 > 0)
                Console.WriteLine($"v1 = {x1}i + {y1}j + {z1}k;");
            

            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            double z2 = double.Parse(Console.ReadLine());
            if (y2 < 0 && z2 < 0)
                Console.WriteLine($"v2 = {x2}i {y2}j {z2}k;");
            else
            {
                if (y2 < 0)
                    Console.WriteLine($"v2 = {x2}i {y2}j + {z2}k;");
                if (y2 == 0)
                    Console.WriteLine($"v2 = {x2}i + {z2}k;");
                if (z2 < 0)
                    Console.WriteLine($"v2 = {x2}i + {y2}j  {z2}k;");
                if (z2 == 0)
                    Console.WriteLine($"v2 = {x2}i + {y2}j ");

                if (y2 > 0 && z2 > 0)
                    Console.WriteLine($"v2 = {x2}i + {y2}j + {z2}k;");
            }
            Console.Write("x3 = ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("y3 = ");
            double y3 = double.Parse(Console.ReadLine());
            Console.Write("z3 = ");
            double z3 = double.Parse(Console.ReadLine());

            if (y3 < 0)
            {

                if (z3 < 0)
                    Console.WriteLine($"v3 = {x3}i {y3}j {z3}k;");
                else
                    Console.WriteLine($"v3 = {x3}i {y3}j + {z3}k;");
            }
            if (y3 == 0)
                Console.WriteLine($"v3 = {x3}i + {z3}k;");
            if (z3 < 0)
            {
                Console.WriteLine($"v3 = {x3}i + {y3}j  {z3}k;");

            }
            if (z3 == 0)
                Console.WriteLine($"v3 = {x3}i + {y3}j ");
            if (y3 > 0 && z3 > 0)
                Console.WriteLine($"v3 = {x3}i + {y3}j + {z3}k;");

            double e1, e2, e3, e4, e5, e6, mixt;
            mixt = x1 * y2 * z3 + x2 * y3 * z1 + x3 * y1 * z2 - x3 * y2 * z1 - x2 * y1 * z3 - x1 * y3 * z2;
            Console.WriteLine($"Produsul mixt = {mixt}");
            if(mixt == 0)
                Console.WriteLine("Vectorii sunt coplanari");
            else
                Console.WriteLine("Vectorii NU sunt coplanari");
            if(mixt < 0)
                Console.WriteLine($"Volumul paralelogramului = {-mixt}");
            else
                Console.WriteLine($"Volumul paralelogramului = {mixt}");
        }
    }
}
