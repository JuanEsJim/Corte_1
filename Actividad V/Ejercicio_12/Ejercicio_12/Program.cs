using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sw, n = 12,input=0;
            int[,] a = new int[12,12];
            int[,] b = new int[12,12];
            
            
               
            
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Random rnd = new Random();
                    input = rnd.Next(0, 100);
                    a[i, j] = input; 
                }
            }

            Console.WriteLine("La Matriz es:\n");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine(" maitriz al rotar hacia las manecillas del reloj\n");

            for (i = 0; i < n / 2; i++)
            {
                for (j = 0; j < n; j++)
                {

                    sw = a[j,i];
                    a[j,i] = a[j,n - 1 - i];
                    a[j,n - 1 - i] = sw;
                }
                Console.WriteLine("\n");
            }



            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i,j] + "\t");
                }
                Console.WriteLine("\n");
            }

            //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
            //Creado por Juan Esteban Jimenez Cuestas
            //Grupo 239-2A DIA
            //Turno Diurno
            //Problema 12




        }
    }
}
