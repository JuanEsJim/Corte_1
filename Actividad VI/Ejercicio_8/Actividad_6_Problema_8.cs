using System;
using System.Collections;

namespace Actividad_6_Problema_8
{
    class Actividad_6_Problema_8
    {
        int Cantidad = 0,Datos=0;
        ArrayList Lista1 = new ArrayList();
        ArrayList Lista2 = new ArrayList();
        ArrayList Lista3 = new ArrayList();

        static void Imprimir(ArrayList Lista1)
        {
            foreach (int a in Lista1)
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
                Datos = int.Parse(Console.ReadLine());
                Lista1.Add(Datos);
            }
            Console.WriteLine("--------");
            Console.WriteLine("La lista 1 es esta");
            Imprimir(Lista1);
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
                Datos = int.Parse(Console.ReadLine());
                Lista2.Add(Datos);
            }
            Console.WriteLine("--------");
            Console.WriteLine("La lista 2 es esta");
            Imprimir(Lista2);
            Console.WriteLine("\n----------------------------------------");
        }

        public void Intercambiar()
        {
            Lista3.AddRange(Lista1);
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("| SE ACABAN DE INTERCAMBIAR LOS VALORES DE LAS FILAS |");
            Console.WriteLine("|----------------------------------------------------|");

            Lista1.Clear();
            Lista1.AddRange(Lista2);
            Console.WriteLine("La lista 1 ahora tiene valores de la 2");
            Imprimir(Lista1);

            Lista2.Clear();
            Lista2.AddRange(Lista3);
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("La lista 2 ahora tiene valores de la 1");
            Imprimir(Lista2);
        }

        static void Main(string[] args)
        {
            String WhileLoop = "";

            //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Creado por Jonathan David Guerrero Gomez :D
            //Grupo: 239-2A DIA
            //Turno: Diurno

            do
            {
                Console.WriteLine("Problema N° 8 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Este programa llenar las dos listas y intercambiar los valores en las listas");
                Console.WriteLine("----------------------------------------------------------------------------");
                Actividad_6_Problema_8 pv = new Actividad_6_Problema_8();
                pv.Rellenar1();
                pv.Rellenar2();
                pv.Intercambiar();

                Console.WriteLine("\n----------------------------------------");
                Console.WriteLine("¿Desea repetir el programa? (S/N)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("----------------------------------------");

            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
