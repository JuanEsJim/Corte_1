using System;

namespace Actividad_4_Problema_11
{
    class Actividad_4_Problema_11
    {
        public String[,] Paises;

        public void PaisyCiudades()
        {
            Paises = new string[4, 4];
            int a = 4;

            for (int i=0;i<4;i++)
            {
                Console.WriteLine($"Ingrese el nombre del pais {i+1}");
                Paises[i,0] = Console.ReadLine();

                for(int j=1;j<4;j++)
                {
                    Console.WriteLine($"Ingrese las 3 ciudades de {Paises[i,0]}  (Faltan {a-j} ciudades)");
                    Paises[i, j] = Console.ReadLine();
                }
                Console.WriteLine("-----------------------------------------------------------");
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Pais: {Paises[i, 0]} ");

                for (int j = 0; j < 1; j++)
                {
                    Console.Write($"| Ciudades : {Paises[i, j + 1]}, {Paises[i, j + 2]}, {Paises[i, j + 3]} | \n");
                }
            }
        }

        public void Inicio()
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            Console.WriteLine("Problema No. 11 --- Jonathan David Guerrero Gomez");
            Console.WriteLine("Este programa usa un array multidimensional para imprimir paises y ciudades");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            Actividad_4_Problema_11 pv = new Actividad_4_Problema_11();
            string Whileloop = "";
            do
            {
                pv.Inicio();
                pv.PaisyCiudades();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("¿Desea repetir el programa?");
                Whileloop = Console.ReadLine();
                Console.Clear();
            } while (Whileloop != "n" && Whileloop != "N");

            Console.WriteLine("Fin del programa ;)");
        }
    }
}
