using System;

namespace Actividad_5_Problema_1
{
    class Actividad_5_Problema_1
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez, 
        //Creado por Jonathan David Guerrero Gomez
        //Grupo: 239-2A DIA
        //Turno: Diurno

        int[,] Numeros = new int[4, 5];
        int[,] Suma = new int [6,5];
        int Total=0;
        int WhileLoop = 0;
        public void Pedir()
        {
            Console.WriteLine("Este programa se basa en hacer un hoja de excel que sume\nlas columnas y las filas y nos de un resultado Total");
            Console.WriteLine("-----------------------------------------------------");
            do
            {
                try
                {
                    Console.WriteLine("Ingrese 20 numeros enteros (Deben de ser enteros)");
                    for (int f = 0; f < 4; f++)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            Console.Write("- ");
                            Numeros[f, c] = int.Parse(Console.ReadLine());
                            Total =Total+Numeros[f,c];
                            WhileLoop = 0;
                        }
                    }
                }
                catch (System.FormatException ex)
                {
                    Console.WriteLine("------------------------------|");
                    Console.WriteLine("SOLO ES VALIDO NUMEROS ENTEROS|");
                    WhileLoop = 1;
                }
                Console.WriteLine("------------------------------|");
            } while (WhileLoop == 1);
        }

        public void Operacion()
        {
            for(int f=0;f<4;f++)
            {
                for(int c=0;c<5;c++)
                {
                    Suma[f,0] = Suma[f,0] + Numeros[f, c];
                    Suma[5, c] = Suma[5, c] + Numeros[f, c];                  
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los numeros y su suma son:");
            Console.WriteLine("-------------------------------");
            for (int f=0;f<4;f++)
            {                  
               Console.WriteLine($"| {Numeros[f,0]} | {Numeros[f, 1]} | {Numeros[f, 2]} | {Numeros[f, 3]} | {Numeros[f, 4]} | = {Suma[f,0]} |");   
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"| {Suma[5, 0]} | {Suma[5, 1]} | {Suma[5, 2]} | {Suma[5, 3]} | {Suma[5, 4]} | Total {Total} |");
            
            Console.WriteLine("------------------------------");
        }

        static void Main(string[] args)
        {
            string WhileLoop2 = "";

            do
            {
                Console.WriteLine("Problema 1 - Creado por Jonathan David Guerrero Gomez");
                Console.WriteLine("-----------------------------------------------------\n");

                Actividad_5_Problema_1 pv = new Actividad_5_Problema_1();
                pv.Pedir();
                pv.Operacion();
                pv.Imprimir();

                Console.WriteLine("¿Desea volver a repetirlo?(s/n)");
                WhileLoop2 = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------");

            } while (WhileLoop2 == "s" || WhileLoop2 == "S");
            Console.WriteLine("Fin del programa :D");

        }
    }
}
