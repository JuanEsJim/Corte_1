using System;

namespace problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            String genero, whilepool;
            int altura;
            do
            {
                //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
                //Creado por Juan Esteban Jimenez Cuestas
                //Grupo 239-2A DIA
                //Turno Diurno
                Console.WriteLine("Dijite su altura");
                altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Hombre(H) o Mujer (M)");
                genero = Console.ReadLine();
                if (genero == "h" || genero == "H")
                {
                    if (altura >= 165)
                    {
                        if (altura <= 185)
                        {
                            Console.WriteLine("Su altura esta el la altura promedio entra los hombres");
                        }
                    }
                    if (altura > 185)
                    {
                        Console.WriteLine("su altura es mayor a la altura promedio entre los hombres");
                    }
                    if (altura < 165)
                    {
                        Console.WriteLine("Su altura es menos a la altura promedio entre los hombres");
                    }
                }
                if (genero == "m" || genero == "M")
                {
                    if (altura >= 150)
                    {
                        if (altura <= 170)
                        {
                            Console.WriteLine("Su altura esta el la altura promedio entre las mujeres");
                        }
                    }
                    if (altura > 170)
                    {
                        Console.WriteLine("su altura es mayor a la altura promedio entre las mujeres");
                    }
                    if (altura < 150)
                    {
                        Console.WriteLine("Su altura es menos a la altura promedio entre las mujeres");
                    }
                }
                Console.WriteLine("¿Desea salir?:(S/N)");
                whilepool=Console.ReadLine();


            } while (whilepool == "n" || whilepool == "N");
        }
    }
}
