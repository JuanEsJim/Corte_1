using System;

namespace Actividad_2_Problema_4
{
    class Actividad_2_Problema_4
    {
        static void Main(string[] args)
        {
            //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int[] Numero = new int[10];
            int lim=10;
            String Orden = "";

            Console.WriteLine("Problema No. 4");
            Console.WriteLine("Ordena 10 numeros de mayor a menor y viceversa");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese 10 numeros, despues podra organizarlos");

            for (int i = 0; i < lim; i++)
            {
                Console.WriteLine($"Ingrese el numero {i+1}");
                Numero[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Como deseas organizarlo, orden de mayor o menor \n(Introduzca la opcion = mayor o menor)");
            Orden = Console.ReadLine();

            if (Orden == "Menor" || Orden == "MENOR" || Orden == "menor")
            {
                Array.Sort(Numero);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Los numero de menor a mayor son:");

                for (int i = 0; i < lim; i++)
                {
                    Console.WriteLine(Numero[i]);
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Fin del programa");
            }
            else if (Orden == "Mayor" || Orden == "MAYOR" || Orden == "mayor")
            {
                Array.Sort(Numero);
                Array.Reverse(Numero);
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Los numero de mayor a menor son:");

                for (int i = 0; i < lim; i++)
                {
                    Console.WriteLine(Numero[i]);
                }
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Fin del programa");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}
