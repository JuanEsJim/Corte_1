using System;
using System.Collections;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList NUM = new ArrayList();
            ArrayList NUM2 = new ArrayList();
            ArrayList NUM3 = new ArrayList();
            Console.WriteLine("Coloque numero conjunto 1");
            for(int cont = 0; cont < 5; cont++)
            {
                int num = int.Parse(Console.ReadLine());
                NUM.Add(num);
                NUM3.Add(num);
            }
            Console.WriteLine("Coloque numero conjunto 2");
            for (int cont = 0; cont < 5; cont++)
            {
                int num1 = int.Parse(Console.ReadLine());
                NUM2.Add(num1);
                NUM3.Add(num1);
            }
            Console.WriteLine("Sin concatenar:");
            foreach (int value in NUM3)
            {
                Console.Write(value + " ");
               
            }
            Console.WriteLine("");

            NUM3.Sort();
            Console.WriteLine("Concatenacion:\n");
            foreach (int value in NUM3)
            {
                Console.Write(value + " ");
            }

        }
    }
}
