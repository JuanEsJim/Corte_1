using System;
using System.Collections;

namespace Actividad_6_Problema_7
{
    class Actividad_6_Problema_7
    {
        Double Datos = 0;
        int Cantidad = 0;
        ArrayList Lista1 = new ArrayList();
        ArrayList Lista2 = new ArrayList();
        ArrayList Lista3 = new ArrayList();

        static void Imprimir1(ArrayList Lista1)
        {
            foreach(double a in Lista1)
            {
                Console.Write($" {a}");
            }
        }

        public void Rellenar1()
        {
            Console.WriteLine("Cuantos datos va ingresar a la lista 1");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese los numeros para llenar la lista 1");
            Console.WriteLine("--------");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write(" - ");
                Datos = double.Parse(Console.ReadLine());
                Lista1.Add(Datos);
            }
            Console.WriteLine("--------");
            Console.WriteLine("La lista 1 es esta");
            Imprimir1(Lista1);
            Console.WriteLine("\n----------------------------------------");
        }

        public void Rellenar2()
        {
            Console.WriteLine("Cuantos datos va ingresar a la lista 2");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese los numeros para llenar la lista 2");
            Console.WriteLine("--------");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write(" - ");
                Datos = double.Parse(Console.ReadLine());
                Lista2.Add(Datos);
            }
            Console.WriteLine("--------");
            Console.WriteLine("La lista 2 es esta");
            Imprimir1(Lista2);
            Console.WriteLine("\n----------------------------------------");
        }

        public void Mezclar()
        {
            Lista3.AddRange(Lista1);
            Lista3.AddRange(Lista2);
            
            Console.WriteLine($"La lista mezclada tiene {Lista3.Count} datos y son estos:");
            Imprimir1(Lista3);
            Console.WriteLine("\n----------------------------------------");
        }

        static void Main(string[] args)
        {
            string WhileLoop = "";

            //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Creado por Jonathan David Guerrero Gomez :D
            //Grupo: 239-2A DIA
            //Turno: Diurno
            do
            {

                Console.WriteLine("Problema N° 7 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Este programa mezcla dos listas y se imprimen en una sola");
                Console.WriteLine("----------------------------------------------------------------------------\n");

                Actividad_6_Problema_7 pv = new Actividad_6_Problema_7();
                pv.Rellenar1();
                pv.Rellenar2();
                pv.Mezclar();

                Console.WriteLine("¿Desea repetir el programa? (S/N)");
                WhileLoop = Console.ReadLine();

            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
