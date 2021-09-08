using System;

namespace problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            string whileloop;
            do
            {
                double a;
                double c;
                double d = 0;
                string f = null;
                double n;
                string s = null;

                Console.WriteLine("ingrese un numero");
                n = double.Parse(Console.ReadLine());

                a = Math.Truncate(n / 10);
                switch (a)
                {
                    case 2:
                        s = "v";
                        break;
                    case 3:
                        s = "treinta";
                        break;
                    case 4:
                        s = "cuarenta";
                        break;
                    case 5:
                        s = "cincuenta";
                        break;
                    case 6:
                        s = "sesenta";
                        break;
                    case 7:
                        s = "setenta";
                        break;
                    case 8:
                        s = "ochenta";
                        break;
                    case 9:
                        s = "noventa";
                        break;

                }

                 

 

                 
                whileloop = Console.ReadLine();


            } while (whileloop == "n" || whileloop == "N");





            //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
            //Creado por Juan Esteban Jimenez Cuestas
            //Grupo 239-2A DIA
            //Turno Diurno









        }
    }
}
