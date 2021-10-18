using System;
using System.Collections;

namespace Ejercicio_8
{
    class Program
    {
        static void Imprimircolas(ArrayList colafin)
        {
            foreach (int a in colafin)
            {
                Console.WriteLine($"* {a}");
            }
        }
        static void Main(string[] args)
        {
            Queue cola1 = new Queue();
            Queue cola2 = new Queue();
            
            Console.WriteLine("¿Cuantos numero quiere que coloque en la cola 1:?");
            int Col1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque numeros para la cola 1:");
            for (int cont = 0; cont < Col1; cont++)
            {
                Console.Write("*");
                int a = int.Parse(Console.ReadLine());
                cola1.Enqueue(a);
            }
            Console.WriteLine("¿Cuantos numero quiere que coloque en la cola 2:?");
            int col2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque numeros para la cola 2:");
            for (int cont = 0; cont < col2; cont++)
            {
                Console.Write("*");
                int b = int.Parse(Console.ReadLine());
                cola2.Enqueue(b);
            }
            ArrayList colnew1 = new ArrayList(cola1);
            ArrayList colnew2 = new ArrayList(cola2);
            ArrayList colnew3 = new ArrayList();
            colnew3.AddRange(colnew1);
            colnew1.Clear();
            colnew1.AddRange(colnew2);

            Console.WriteLine("las colas hicieron intercambio de datos.");
            Console.WriteLine("la cola 1 quedo con los datos de la cola 2:");
            Imprimircolas(colnew1);
            colnew2.Clear();
            colnew2.AddRange(colnew3);
            Console.WriteLine("la cola 2 quedo con los datos de la cola 1:");
            Imprimircolas(colnew2);
             
         

            


        }
    }
}
