using System;

namespace problema1
{
    class Program
    //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
    //Creado por:Juan Esteban Jimenez Cuestas 
    //Actividad semana3
    //Turno: Diurno
    //Codigo: 239-2A DIA
    // Problema 9: piramide de numeros
    {
        static void Main(string[] args)
        { String whilepool,m;
            do
            {

                int i, j, n;
                
                Console.WriteLine("Coloque un numero para la piramide:");
                n = int.Parse(Console.ReadLine());
                for (i =1; i <= n; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                        
                    }
                    Console.WriteLine("");

                }
              
                Console.WriteLine("Desea salir:(S/N)");
                whilepool = Console.ReadLine();

               

              
            } while (whilepool=="n" || whilepool=="N");
          
        }
    }       
}
