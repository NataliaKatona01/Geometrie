using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_03._03
{
    class Program
    {
        static void Main(string[] args)
        {

            double v1, marime1, marime2;
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            double z1 = double.Parse(Console.ReadLine());

            if (y1 < 0)
            {
               
                if(z1 < 0)
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
            /*            marime1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
                        Console.WriteLine($"Marimea vectorului: {marime1}");
            */

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
            /*           marime2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);
                       Console.WriteLine($"Marimea vectorului: {marime2}");

                       double p = 0;
                       p = (x1 * x2) + (y1 * y2) + (z1 * z2);
                       Console.WriteLine($"Produsul scalar: {p}");
                       if (p == 0)
                           Console.WriteLine("Vectorii sunt perpendiculari");
                       else
                           Console.WriteLine("Vectorii NU sunt perpendiculari");
           */
            Console.WriteLine();
            Console.WriteLine("PROBLEMA 2");

            double a, b, c;

            a = (y1 * z2) - (y2 * z1);
            b = (x2 * z1) - (x1 * z2);
            c = (x1 * y2) - (x2 * y1);
            if (b < 0 && c < 0)
                Console.WriteLine($"Produs vectorial= {a}i {b}j {c}k");
            else
            {
                if (b < 0)
                    Console.WriteLine($"Produs vectorial= {a}i {b}j + {c}k");
                if (c < 0)
                    Console.WriteLine($"Produs vectorial= {a}i + {b}j {c}k");
                if (b > 0 && c > 0)
                    Console.WriteLine($"Produs vectorial= {a}i + {b}j + {c}k");
            }
            if ((a == 0) && (b == 0) && (c == 0))
            {
                Console.WriteLine("Produs vectorial = 0");
                Console.WriteLine("Vectorii sunt coliniari");
            }
            else
                Console.WriteLine("Vectorii NU sunt coliniari");

            double prod;
            prod = Math.Sqrt(a * a + b * b + c * c);
            Console.WriteLine($"Aria paralelogramului este : {prod}");
            Console.WriteLine();
        }
    }
}
