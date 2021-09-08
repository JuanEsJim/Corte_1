using System;

namespace problema10
{
    class Problema10
    {
        static void Main(string[] args)
        {//Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
         //Creado por: Juan Esteban Jimenez Cuestas
         //Actividad semana2
         //Turno: Diurno
         //Codigo: 239-2A DIA
            String Whilepool;
            do
            {
                double M = 0, Mterreno = 0, Desterreno = 0, TotalT = 0,multerreno=0;
                Console.WriteLine("Escriba el valor del Metro:");
                M = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba cuanto mide el terreno");
                Mterreno = int.Parse(Console.ReadLine());
                if (Mterreno >= 400)
                {
                    if (Mterreno < 500)
                    {
                        multerreno = M * Mterreno;
                        Desterreno = multerreno * 0.1;
                        TotalT = Desterreno - M;
                        Console.WriteLine("El total con descuento del 10% da:{0}", TotalT);
                    }
                    
                }
                if (Mterreno >= 500)
                {
                    if (Mterreno < 1000)
                    {
                        multerreno = M * Mterreno;
                        Desterreno = multerreno * 0.17;
                        TotalT = Desterreno - M;
                        Console.WriteLine("El total con descuento del 17% da:{0}", TotalT);
                    }

                }
                if (Mterreno >= 1000)
                {
                    multerreno = M * Mterreno;



                    Desterreno = multerreno * 0.25;
                   TotalT = Desterreno - M;
                   Console.WriteLine("El total con descuento del 25% da:{0}", TotalT);
                        

                    

                }
                if (Mterreno < 400)
                {
                    multerreno = M * Mterreno;
                    Console.WriteLine("Total:{0}",multerreno);
                }







                Console.WriteLine("Desea salir (S/N)");
                Whilepool = Console.ReadLine();



            } while (Whilepool == "n" || Whilepool == "N");
        }
    }
}
