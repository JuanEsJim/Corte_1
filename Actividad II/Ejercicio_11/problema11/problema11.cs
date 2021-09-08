using System;

namespace problema11
{
    class Program
    {
        static void Main(string[] args)
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Esteban Jimenez Cuestas
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA
        {
            String Whilepool;
            do
            {
                double Totalagua = 0, Totalluz = 0,Desagua=0,Desluz=0,Desgas=0;
                double Totalgas = 0, recibo1 = 0,recibo2=0,recibo3=0;
                int estrato = 0;
                Console.WriteLine("Escriba el valor del recibo del agua:");
                recibo1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el valor del recibo del gas:");
                recibo2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el valor del recibo de la luz:");
                recibo3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el su estrato:");
                estrato = int.Parse(Console.ReadLine());
                if (estrato == 1)
                {
                    
                    Desagua = recibo1 * 0.2;
                    Totalagua = recibo1 - Desagua;
                    Console.WriteLine("El total del recibo del agua con descuento del 20% da:{0}", Totalagua);
                    
                    Desgas = recibo2 * 0.2;
                    Totalgas = recibo2 - Desagua;
                    Console.WriteLine("El total del recibo del gas con descuento del 20% da:{0}", Totalgas);
                    
                    Desluz = recibo3 * 0.2;
                    Totalluz = recibo3 - Desagua;
                    Console.WriteLine("El total del recibo de la luz con descuento del 20% da:{0}", Totalluz);

                }
                if (estrato == 2)
                {
                    Desagua = recibo1 * 0.15;
                    Totalagua = recibo1 - Desagua;
                    Console.WriteLine("El total del recibo del agua con descuento del 15% da:{0}", Totalagua);

                    Desgas = recibo2 * 0.15;
                    Totalgas = recibo2 - Desagua;
                    Console.WriteLine("El total del recibo del gas con descuento del 15% da:{0}", Totalgas);

                    Desluz = recibo3 * 0.15;
                    Totalluz = recibo3 - Desagua;
                    Console.WriteLine("El total del recibo de la luz con descuento del 15% da:{0}", Totalluz);

                }
                if (estrato > 3)
                {
                    Desagua = recibo1 * 0.09;
                    Totalagua = recibo1 - Desagua;
                    Console.WriteLine("El total del recibo del agua con descuento del 9% da:{0}", Totalagua);

                    Desgas = recibo2 * 0.09;
                    Totalgas = recibo2 - Desagua;
                    Console.WriteLine("El total del recibo del gas con descuento del 9% da:{0}", Totalgas);

                    Desluz = recibo3 * 0.09;
                    Totalluz = recibo3 - Desagua;
                    Console.WriteLine("El total del recibo de la luz con descuento del 9% da:{0}", Totalluz);




                }
             






                Console.WriteLine("Desea salir (S/N)");
                Whilepool = Console.ReadLine();



            } while (Whilepool == "n" || Whilepool == "N");
        }
    }
}
