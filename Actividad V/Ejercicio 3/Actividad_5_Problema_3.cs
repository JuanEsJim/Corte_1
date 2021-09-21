using System;

namespace Actividad_5_Problema_3
{
    class Actividad_5_Problema_3
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez, 
        //Creado por Jonathan David Guerrero Gomez :D
        //Grupo: 239-2A DIA
        //Turno: Diurno

        int[,] Num = new int[3, 6];
        int Contador = 0, WhileLoop = 0;

        public void Pedir()
        {
            do
            {
                try
                {
                    Console.WriteLine("Ingrese los numeros para crear la tabla de numeros, son 18 numeros");
                    Console.WriteLine("-------------------------------------------");
                    for (int f = 0; f < 3; f++)
                    {
                        Console.WriteLine($"Cuales van a ser los valores para la fila {f + 1}");
                        for (int c = 0; c < 6; c++)
                        {
                            Console.Write($"{c + 1}. ");
                            Num[f, c] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("--------------------------------------");
                        WhileLoop = 0;
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("SOLO ES VALIDO NUMEROS ENTEROS |");
                    Console.WriteLine("--------------------------------");
                    WhileLoop = 1;
                }
            } while (WhileLoop == 1);
        }

        public void Imprimir()
        {
            Console.WriteLine("La tabla es la siguiente:        ->FILAS   ↓ COLUMNAS");
            Console.WriteLine("\n--------------------------------------------------------------------------------------");
            Console.WriteLine("| No. ||     A      |     B      |     C      |     D      |     E      |     F      |");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 1; c++)
                {
                    Console.Write($"|  {f+1}  ||     { Num[f, c]}     |     { Num[f, c+1]}     |     { Num[f, c+2]}     |     { Num[f, c+3]}     |     { Num[f, c+4]}     |     { Num[f, c+5]}     | ");
                    Contador = Contador + 1;

                    if (Contador == 1)
                    {
                        Console.WriteLine("");
                        Contador = 0;
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        static void Main(string[] args)
        {
            string Repetir = "";
            do
            {
                Console.WriteLine("Problema 3 - Creado por Jonathan David Guerrero Gomez");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Este programa se basa en crear una tabla con \n3 filas y 6 columnas con los datos introducidos\n");

                Actividad_5_Problema_3 pv = new Actividad_5_Problema_3();
                pv.Pedir();
                pv.Imprimir();

                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                Repetir = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------");

            } while (Repetir == "s" || Repetir == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
