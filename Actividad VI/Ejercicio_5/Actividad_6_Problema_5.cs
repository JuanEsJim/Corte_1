using System;
using System.Collections;

namespace Actividad_6_Problema_5
{
    class Actividad_6_Problema_5
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por Jonathan David Guerrero Gomez :D
        //Grupo: 239-2A DIA
        //Turno: Diurno

        static void ImprimirPilaP(ArrayList Pila)
        {
            foreach (int q in Pila)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void ImprimirNuevaPila(ArrayList NPila)
        {
            foreach (int q in NPila)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void Main(string[] args)
        {
            String WhileLoop = "";
            do
            {

                int Numero = 0, Cantidad = 0;

                ArrayList PilaP = new ArrayList();
                ArrayList NuevaPila = new ArrayList();

                Console.WriteLine("Problema N° 5 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Crear una PilaP con numeros enteros y despues pasarlos a una nueva pila");
                Console.WriteLine("----------------------------------------------------------------------------\n");

                Console.WriteLine("¿Cuantos datos desea ingresar para la PilaP?");
                Cantidad = int.Parse(Console.ReadLine());

                for (int i = 0; i < Cantidad; i++)
                {
                    Console.Write("- ");
                    Numero = int.Parse(Console.ReadLine());
                    PilaP.Add(Numero);
                }

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Los valores ingresados a la PilaP son:");

                ImprimirPilaP(PilaP);

                Console.WriteLine("Los valores de la PilaP seran transpasado a una Nueva Pila");
                Console.WriteLine("-----------------------------");

                foreach (int s in PilaP)
                {
                    NuevaPila.Add(s);
                }

                Console.WriteLine($"La Nueva Pila tiene {NuevaPila.Count} datos y estos son sus valores");
                ImprimirNuevaPila(NuevaPila);

                PilaP.Clear();
                Console.WriteLine($"Ahora la PilaP quedo con {PilaP.Count} datos");

                Console.WriteLine("-----------------------------");
                Console.WriteLine("¿Desea Repetir el programa? (S/N)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("-----------------------------");

            } while (WhileLoop == "s" || WhileLoop == "S");
            Console.WriteLine("Fin del programa :D");

        }
    }
}
