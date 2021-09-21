using System;

namespace Actividad_5_Problema_2
{
    class Actividad_5_Problema_2
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez, 
        //Creado por Jonathan David Guerrero Gomez
        //Grupo: 239-2A DIA
        //Turno: Diurno

        int[,] Numeros = new int[4, 5];
        int[,] Suma = new int[6, 5];
        int Total = 0;
        int WhileLoop = 0, Opcion = 0;

        Random random = new Random();

        public void Pedir()
        {
            Console.WriteLine("Este programa se basa en hacer un hoja de excel que sume\nlas columnas y las filas y nos de un resultado Total");
            do
            {
                try
                {
                    Console.WriteLine("\n------------------------------|");
                    Console.WriteLine("             MENU");
                    Console.WriteLine("------------------------------|");
                    Console.WriteLine("1. Ingresa los numeros usted");
                    Console.WriteLine("2. Generar los numeros de forma aleatoria (100 - 999)");
                    Console.WriteLine("¿Que opcion va escoguer?");
                    Opcion = int.Parse(Console.ReadLine());
                    Console.WriteLine("------------------------------|");
                }
                catch(System.FormatException ex)
                {
                    Console.WriteLine("------------------------------|");
                    Console.WriteLine("ESCOGA UNA OPCION VALIDA      |");
                    Console.WriteLine("------------------------------|");
                }


                switch (Opcion)
                {
                    case 1:
                        {
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
                                            Total = Total + Numeros[f, c];
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

                            break;
                        }


                    case 2:
                        {
                            Console.WriteLine("Se van a generar 20 numeros de forma aleatoria en un rango de 100 hasta 999");

                            for (int f = 0; f < 4; f++)
                            {
                                for (int c = 0; c < 5; c++)
                                {
                                    Numeros[f, c] = random.Next(100, 1000);
                                    Console.Write($"- {Numeros[f, c]} \n");
                                    Total = Total + Numeros[f, c];
                                }
                            }
                            Console.WriteLine("-------------------------------");
                            break;
                        }


                    default:
                        {
                            Console.WriteLine("OPCION NO VALIDA");
                            Console.WriteLine("-------------------------------");
                            Opcion = 0;
                            break;
                        }
                }

            } while (Opcion == 0);
        }

        public void Operacion()
        {
            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Suma[f, 0] = Suma[f, 0] + Numeros[f, c];
                    Suma[5, c] = Suma[5, c] + Numeros[f, c];
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los numeros y su suma son:");
            Console.WriteLine("-------------------------------");
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine($"| {Numeros[f, 0]} | {Numeros[f, 1]} | {Numeros[f, 2]} | {Numeros[f, 3]} | {Numeros[f, 4]} | = {Suma[f, 0]} |");
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
                Console.WriteLine("Problema 2 - Creado por Jonathan David Guerrero Gomez");
                Console.WriteLine("-----------------------------------------------------\n");

                Actividad_5_Problema_2 pv = new Actividad_5_Problema_2();
                pv.Pedir();
                pv.Operacion();
                pv.Imprimir();

                Console.WriteLine("¿Desea volver a repetirlo? (S/N)");
                WhileLoop2 = Console.ReadLine();
                Console.WriteLine("------------------------------");

            } while (WhileLoop2 == "s" || WhileLoop2 == "S");
            Console.WriteLine("Fin del programa :D");

        }
    }
}
