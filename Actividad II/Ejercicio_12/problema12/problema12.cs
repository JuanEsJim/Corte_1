using System;

namespace problema12
{
    class Program
    {
        static void Main(string[] args)
        {//Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
         //Creado por: Juan Esteban Jimenez Cuestas
         //Actividad semana2
         //Turno: Diurno
         //Codigo: 239-2A DIA
            string whilepool;

            do
            {
                double cable = 0, metroca = 0, cable22=0, cable33=0,cablee=0;
                double cable1 = 17000, cable2 = 75000, cable3 = 9990;
                double cable11 = 0, rescable1=0,rescable2=0,rescable3=0;
                Console.WriteLine("==============================================================================");
                Console.WriteLine("1. Cable universal =$17.000");
                Console.WriteLine("2. Cable De Alimentacion Universal Tnp - Nema 5-15p A Iec320c1 = $75.000");
                Console.WriteLine("3. Cable De Alimentación Usb A Dc 2.0mm 2.5mm 3.5mm 4.0mm 5.5mm = 9.990");
                Console.WriteLine("==============================================================================");
                cable = double.Parse(Console.ReadLine());
                Console.WriteLine("metro Xcable:");
                metroca = double.Parse(Console.ReadLine());
                if (cable == 1)
                {
                    if (metroca >= 20)
                    {
                        if (metroca < 40)
                        {
                            cablee = cable1 * metroca;
                            cable11 = cablee * 0.05;
                            rescable1 = cablee - cable11;
                            Console.WriteLine("Total menos el 5% es:{0}", rescable1);

                        }
                    }
                    if (metroca >= 40)
                    {
                        cablee = cable1 * metroca;
                        cable11 = cablee * 0.12;
                        rescable1 = cablee - cable11;
                        Console.WriteLine("Total menos el 12% es:{0}", rescable1);

                    }
                    if (metroca < 20)
                    {
                        cable3 = cable1* metroca;
                        Console.WriteLine("Total es:{0}", cablee);



                    }
                }
                if (cable == 2)
                {
                    if (metroca >= 20)
                    {
                        if (metroca < 40)
                        {
                            cablee = cable2 * metroca;
                            cable22 = cablee * 0.05;
                            rescable2 = cablee - cable22;
                            Console.WriteLine("Total menos el 5% es:{0}", rescable2);

                        }
                    }
                    if (metroca >= 40)
                    {
                        cablee = cable2 * metroca;
                        cable22 = cablee * 0.12;
                        rescable2 = cablee - cable22;
                        Console.WriteLine("Total menos el 12% es:{0}", rescable2);

                    }
                    if (metroca < 20)
                    {
                        cablee = cable2 * metroca;
                        Console.WriteLine("Total es:{0}", cablee);



                    }
                }
                if (cable == 3)
                {
                    if (metroca >= 20)
                    {
                        if (metroca < 40)
                        {
                            cablee = cable3 * metroca;
                            cable33 = cablee * 0.05;
                            rescable3 = cablee - cable33;
                            Console.WriteLine("Total menos el 5% es:{0}", rescable3);

                        }
                    }
                    if (metroca >= 40)
                    {
                        cablee = cable3 * metroca;
                        cable33 = cablee * 0.12;
                        rescable1 = cablee - cable33;
                        Console.WriteLine("Total menos el 12% es:{0}", rescable3);

                    }
                    if (metroca < 20)
                    {
                        cablee = cable3 * metroca;
                        Console.WriteLine("Total es:{0}", cablee);



                    }
                }
                Console.WriteLine("desa salir(S/N):");
                whilepool = Console.ReadLine();



            } while(whilepool=="n" || whilepool == "N");
        }
    }
}
