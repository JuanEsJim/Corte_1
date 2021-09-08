using System;

namespace problema2
{
    class Program
    //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
    //Creado por:Juan Esteban Jimenez Cuestas 
    //Actividad semana3
    //Turno: Diurno
    //Codigo: 239-2A DIA
    // Problema 9: piramide de *
    {
        static void Main(string[] args)
        {
            String whilepool;
            int  n,l,m;
            do { 
                Console.WriteLine(":");
                 n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine();

                    for (int j = 0; j < n - i - 1; ++j)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < 2 * i + 1; ++j)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");

                Console.WriteLine("desea salir(S/N)");
                whilepool=Console.ReadLine();
            } while (whilepool == "n" || whilepool == "N");
        
             
        }
    }
}
