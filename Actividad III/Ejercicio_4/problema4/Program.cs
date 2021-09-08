using System;

namespace problema4
{
    class Program
    //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
    //Creado por:Juan Esteban Jimenez Cuestas 
    //Actividad semana3
    //Turno: Diurno
    //Codigo: 239-2A DIA
    // Problema 9: forumula ramplazada por n.
    {
        static void Main(string[] args)
        {
            String whilepool;
            do
            {
                double num1 = 0, res = 0, num3 = 0, num2,num6=0;
                double cont = 0, num5 = 1, num7 = 6;
                Console.WriteLine("escriba el nuemero que va hacer remplazado por (n)");
                Console.WriteLine("1 + 1/2!+ 1/3!+ 1/n!");
                num1=double.Parse(Console.ReadLine());
                for (cont = 1; cont <= num1; cont++)
                {
                    num5 = num5 * cont;
                }
               
              

                num2 = 0.5;
                num3 = 1 / num7;
                num6 = 1 / num5;
                res = 1+num2+num3+num6;
              
               
                

                Console.WriteLine("el resultado es:{0}", res);




                Console.WriteLine("¿desea salir?(S/N):");
                whilepool=Console.ReadLine();
            } while (whilepool == "n" || whilepool=="N");
            
        }
    }
}
