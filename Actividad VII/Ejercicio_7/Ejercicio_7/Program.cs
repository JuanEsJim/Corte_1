using System;
using System.Collections;

namespace Ejercicio_7
{
    class Program
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por Juan Esteban Jimenez Cuestas
        //Grupo: 239-2A DIA
        //Turno: Diurno

      

  

        static void Main(string[] args)
        {
            Double Datos = 0;
            int Cantidad = 0;
            Queue Lista1 = new Queue();
            Queue Lista2 = new Queue();
            ArrayList Lista3 = new ArrayList();
            Console.WriteLine("Cuantos datos va ingresar a la cola 1:");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese los numeros para la cola 1");
            Console.WriteLine("--------");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write(" * ");
                Datos = double.Parse(Console.ReadLine());
                Lista1.Enqueue(Datos);
            }

            Console.WriteLine("Cuantos datos va ingresar a la cola 2");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese los numeros para la cola 2");
            Console.WriteLine("--------");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write(" * ");
                Datos = double.Parse(Console.ReadLine());
                Lista2.Enqueue(Datos);
            }

           


            Lista3.AddRange(Lista1);
            Lista3.AddRange(Lista2);
            Queue Listanew3 = new Queue(Lista3);

            Console.WriteLine($"La lista mezclada tiene {Listanew3.Count} datos y son estos:");
           
            foreach(Double q in Listanew3)
            {
                Console.WriteLine($"*{q}");
            }
            
          

        }
    }
}
