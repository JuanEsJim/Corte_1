using System;
using System.Threading;
using System.Linq;

namespace Ejercicio_10
{
    class Program
    {
        //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
        //Creado por Juan Esteban Jimenez Cuestas
        //Grupo 239-2A DIA
        //Turno Diurno
        //Problema 10
        static void Main(string[] args)
        {
            int i, j, input = 0;
            int[,] a = new int[6, 10];
            
            int max = 0,min=0;




            for (i = 0; i <6 ; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    
                    Random rnd = new Random();
                    input = rnd.Next(0, 1000);
                    a[i, j] = input;
                     
                    
                         
                         
                          
                        





                }
                
            }
            min = a[0, 0];
            for (i = 0; i < 6; i++)
            {
                
                for (j = 0; j < 10; j++)
                {
                   

                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        

                    }
                    
                    if (a[i, j] < min)
                    {
                        min = a[i, j];

                    }

                }
            }
            Console.WriteLine("La Matriz es:\n");
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("el numero mayor es: {0}", +max);
            Console.WriteLine("El numero menor es: {0}", +min);
             
        }
    }
}

