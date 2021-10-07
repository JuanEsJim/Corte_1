using System;
using System.Collections;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatoria,sumatoria2,sumatoria3,total,fulltotal;
            ArrayList num = new ArrayList();
            Console.WriteLine("escriba la sumatoria");
            sumatoria=int.Parse(Console.ReadLine());
            sumatoria2 = sumatoria + 1;
            sumatoria3 = sumatoria + sumatoria2;
            total = sumatoria * sumatoria2 * sumatoria3;
            fulltotal = total / 6;
            Console.WriteLine("TOTAL:{0}",fulltotal);

        }
    }
}
