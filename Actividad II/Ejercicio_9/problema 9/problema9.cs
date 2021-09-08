using System;

namespace Areas_del_Circulo_y_triangulo
{
    class Problema9
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
                double Circulo = 0.0, triangulo = 0, AlturaT, areatriancir=0.0,BaseT=0, AreaO = 0, Areacir = 0,tri=0;
                double PI = 3.1416;
                Console.WriteLine("1.Area del circulo");
                Console.WriteLine("2.Area del triangulo");
                areatriancir = int.Parse(Console.ReadLine());
                if (areatriancir == 1)
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("Dijite el Radio");
                    Console.WriteLine("====================");
                    Console.WriteLine("");
                    Areacir = double.Parse(Console.ReadLine());
                    AreaO = Areacir * Areacir;
                    Circulo = AreaO * PI;
                    Console.WriteLine("El resultado es:{0}",Circulo);

                }
                if(areatriancir==2)
                {
                    
                    Console.WriteLine("Dijite la base");
                    BaseT = int.Parse(Console.ReadLine());
                    Console.WriteLine("Dijite la altura");
                    AlturaT = int.Parse(Console.ReadLine());
                    tri = BaseT * AlturaT;
                    triangulo = tri / 2;
                    Console.WriteLine("El area del triangulo es:{0}", triangulo);
                    
                        



                }
                Console.WriteLine("Desea salir (S/N)");
                Whilepool = Console.ReadLine();



            } while (Whilepool == "n" || Whilepool=="N");
        }
    }
}
