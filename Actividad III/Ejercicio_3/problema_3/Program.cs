using System;

namespace problema_1
{
    class Program
    //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
    //Creado por:Juan Esteban Jimenez Cuestas 
    //Actividad semana3
    //Turno: Diurno
    //Codigo: 239-2A DIA
    // Problema 9: numero con * 
    {
        static void Main(string[] args)
        {
            String whilepool;
            do
            {
                int Num, cont;
                Console.WriteLine("=========================");
                Console.WriteLine("Escriba un numero:");
                Console.WriteLine("=========================");
                Num = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");
                Console.Write("{0}:", Num);
                for(cont=1;cont<=Num;++cont)
                {
                    
                    Console.Write("*");
                    
                }
                Console.WriteLine("");
                Console.WriteLine("=========================");
                Console.WriteLine("desea salir(S/N):");
                whilepool = Console.ReadLine();
            } while (whilepool == "N" || whilepool=="n");
        }
    }
}
