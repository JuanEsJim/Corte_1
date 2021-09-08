using System;

namespace Actividad_3_Problema_6
{
    class Actividad_3_Problema_6
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int Num = 0,Contador=0;
            String Whileloop = "";

            Console.WriteLine("Problema No. 6 --- Jonathan David Guerrero Gomez");
            Console.WriteLine("Bucle de nuemeros de 100 a 200");


            do
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Ingrese un numero entre 100 y 200");
                Num = int.Parse(Console.ReadLine());

                if (Num >= 100 && Num <= 200)
                {
                    Console.WriteLine($"Usted ingreso el {Num} la cadena es la siguiente");
                    for (int i = Num; i <= 200; i = i + 2)
                    {
                        Console.WriteLine($"- {i}");
                        Contador = Contador + 1;
                    }
                    Console.WriteLine($"Hay un total de {Contador} numeros pares");
                }
                else
                {
                    Console.WriteLine("El numero ingresado debe estar entre 100 y 200");
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("¿Desea salir del programa?(S/N)");
                Whileloop = Console.ReadLine();
                Contador = 0;

            } while (Whileloop == "n" | Whileloop == "N");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Fin del programa :)");

        }
    }
}
