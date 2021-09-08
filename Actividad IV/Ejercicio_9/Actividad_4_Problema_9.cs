using System;

namespace Actividad_4_Problema_9
{
    class Actividad_4_Problema_9
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int Contador = 1;
            int[] Ganador = new int[5];
            int[] Numero = new int[5];

            Console.WriteLine("Problema No. 9 --- Jonathan David Guerrero Gomez");
            Console.WriteLine("Numero de apuestas necesarias para que acierte en la loteria");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("¿Cual quiere que sea el numero ganador de la loteria? (Ingrese de a solo un digito)");
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine($"Digito {a+1}");
                Ganador[a] = int.Parse(Console.ReadLine());                
            }
            Console.WriteLine("-----------------------------------------------------------");

           // Array.Sort(Ganador);

            for (int i=0;i<10;i++)
            {
                for(int j=0;j<10;j++)
                {
                    for(int k = 0; k < 10; k++)
                    {
                        for(int m=0;m<10;m++)
                        {
                            for(int n=0;n<10;n++)
                            {
                                Console.WriteLine($"{Contador} = [ {i} {j} {k} {m} {n} ]");
                                Contador = Contador+ 1;

                                Numero[0] = i;
                                Numero[1] = j;
                                Numero[2] = k;
                                Numero[3] = m;
                                Numero[4] = n;

                                Array.Reverse(Numero);

                                if (Ganador[4] == Numero[0] && Ganador[3] == Numero[1] && Ganador[2] == Numero[2] && Ganador[1] == Numero[3] && Ganador[0] == Numero[4])
                                {
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine($"El numero ganador de la loteria es | {Ganador[0]} {Ganador[1]} {Ganador[2]} {Ganador[3]} {Ganador[4]} | \nTomo {Contador-1} intentos para poder acertar el numero de la loteria");
                                    i = 9;
                                    j = 9;
                                    k = 9;
                                    m = 9;
                                    n = 9;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Fin del programa.");


        }
    }
}
