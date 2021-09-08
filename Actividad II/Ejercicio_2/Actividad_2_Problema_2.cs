using System;

namespace Actividad_2_Problema_2
{
    class Actividad_2_Problema_2
    {
        static void Main(string[] args)
        {
            //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Double Numero =0,Pares=0,Impares=0,Sumap=0,Sumai=0;
            double Promediop = 0f, Promedioi = 0f;
            String Whileloop = "";

            Console.WriteLine("Problema No 2.");
            Console.WriteLine("Calcula la cantidad de numeros pares y impares");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese 10 numeros (Pueden ser positivos o negativos)");

            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Numero {i + 1}");
                    Numero = int.Parse(Console.ReadLine());

                    if (Numero % 2 == 0)
                    {
                        Pares = Pares + 1;
                        Sumap = Sumap + Numero;
                    }
                    else
                    {
                        Impares = Impares + 1;
                        Sumai = Sumai + Numero;
                    }                   
                }
                Promediop =Sumap / Pares;
                Promedioi = Sumai / Impares;

                Promediop= Math.Round(Promediop, 2);
                Promedioi = Math.Round(Promedioi, 2);

                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Hay {Pares} de numeros pares");
                Console.WriteLine($"Su sumatoria da {Sumap}");
                Console.WriteLine($"Su promedio es {Promediop}");
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Hay {Impares} de numeros impares");
                Console.WriteLine($"Su sumatoria da {Sumai}");
                Console.WriteLine($"Su promedio es {Promedioi}");

                Console.WriteLine("------------------------------------");
                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                Whileloop = Console.ReadLine();

                Pares = 0;
                Impares = 0;
                Sumap = 0;
                Sumai = 0;
                Promediop = 0;
                Promedioi = 0;

            } while ((Whileloop == "s") || (Whileloop == "S"));

            Console.WriteLine("Fin del programa.");
        }
    }
}
