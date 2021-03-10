using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs_24._02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Coordonatele punctului A : ");
            int xa = int.Parse(Console.ReadLine());
            int ya = int.Parse(Console.ReadLine());

            Console.WriteLine("Coordonatele punctului B : ");
            int xb = int.Parse(Console.ReadLine());
            int yb = int.Parse(Console.ReadLine());

            Console.WriteLine("Coordonatele punctului C : ");
            int xc = int.Parse(Console.ReadLine());
            int yc = int.Parse(Console.ReadLine());
           
            // ecuatiaDreptei(xa, xb, ya, yb);

            // lungime(xa, xb, ya, yb);

             coliniaritate(xa, xb, ya, yb, xc, yc);
            

           // conditiaDeConcurenta();
        }

        private static void conditiaDeConcurenta()
        {
            double d1 = 1, d2 = 2, d3 = 3, ec;
            Console.Write("a1 =");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("b1 =");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("c1 =");
            double c1 = double.Parse(Console.ReadLine());

            ecDreptei(a1, b1, c1, d1);
            Console.Write("a2 =");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("b2 =");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("c2 =");
            double c2 = double.Parse(Console.ReadLine());

            ecDreptei(a2, b2, c2, d2);
            Console.Write("a3 =");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("b3 =");
            double b3 = double.Parse(Console.ReadLine());
            Console.Write("c3 =");
            double c3 = double.Parse(Console.ReadLine());

            ecDreptei(a3, b3, c3, d3);

            ec = (a1 * b2 * c3) + (a2 * b3 * c1) + (b1 * c2 * a3) - (a3 * b2 * c1) - (a2 * b1 * c3) - (a1 * b3 * c2);
            if(ec == 0)
                Console.WriteLine("Dreptele sunt concurente");
            else
                Console.WriteLine("Dreptele NU sunt concurente");
        }
        private static void ecDreptei(double a, double b, double c, double d)
        {
            if (b < 0)
            {
                if (c < 0)
                    Console.WriteLine($"d{d} : {a}x  {b}y  {c} = 0");
                else
                    Console.WriteLine($"d{d} : {a}x  {b}y + {c} = 0");
            }
            else
            {
                if(c < 0)
                    Console.WriteLine($"d{d} : {a}x + {b}y  {c} = 0");
                else
                    Console.WriteLine($"d{d} : {a}x + {b}y + {c} = 0");
            }
            
        }

        private static void coliniaritate(int xa, int xb, int ya, int yb, int xc, int yc)
        {
            int ec;
           
            ec = (xa * yb) + (xb * yc) + (xc * ya) - (xc * yb) - (xa * yc) - (xb * ya);
            //Console.WriteLine($"{ec}");
            if (ec == 0)
                Console.WriteLine("Coliniare");
            else
                Console.WriteLine("Nu sunt coliniare");
        }

        private static void lungime(int xa, int xb, int ya, int yb)
        {
            double ec1, ec2, ec3, l;
            ec1 = Math.Pow((xb - xa), 2);
            ec2 = Math.Pow((yb - ya), 2);
            ec3 = ec1 + ec2;
            l = Math.Sqrt(ec3);
      
            Console.WriteLine($"|AB| = {l}");
        }

        private static void ecuatiaDreptei(int xa, int xb, int ya, int yb)
        {
            int a, b, c;
           
            a = (ya - yb);
            b = (xa - xb);
            c = (xa * yb) - (xb * ya);
            if(b > 0 && c > 0)
                
            Console.WriteLine($" AB : {a}x - {b}y + {c} = 0");
            if(b > 0 && c < 0)
                Console.WriteLine($" AB : {a}x - {b}y  {c} = 0");
            if(b < 0)
                if(c > 0)
                    Console.WriteLine($" AB : {a}x + {-b}y + {c} = 0");
                else
                    Console.WriteLine($" AB : {a}x + {-b}y  {c} = 0");
            if(b == 0)
                Console.WriteLine($" AB : {a}x + {c} = 0");
        }
    }
}
