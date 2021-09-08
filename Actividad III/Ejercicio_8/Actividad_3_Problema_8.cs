using System;

namespace Actividad_3_Problema_8
{
    class Actividad_3_Problema_8
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            double Numero1 = 0.0f, Numero2 = 0.0f, C = 0.0f, B = 0.0, A = 1; ;
            double Nega = 0.0f, Elevado = 0.0f, Comple = 0.0f, Divi = 0.0f;
            double Suma = 0.0f, Raiz = 0.0f, Suma2 = 0.0f, Resta2 = 0.0f;
            string Whileloop = "";

            Console.WriteLine("Problema No. 8 --- Jonathan David Guerrero Gomez");
            Console.WriteLine("Ingresar dos numeros y hacer la operacion de segundi grado");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Ingrese el primer digito");
                Numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo digito");
                Numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------");

                B = (Numero1 + Numero2);
                C = Numero1 * Numero2;
                if (B > 0)
                {
                    if (C > 0)
                    {
                        Console.WriteLine($"La operacion es (x-({Numero1}))(x+({Numero2})) = x² + {B}x + {C}");
                        Console.WriteLine("Paso a paso");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"La operacion es (x-({Numero1}))(x+({Numero2})) = x² + {B}x {C}");
                        Console.WriteLine("Paso a paso");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    if (C > 0)
                    {
                        Console.WriteLine($"La operacion es (x-({Numero1}))(x+({Numero2})) = x² {B}x + {C}");
                        Console.WriteLine("Paso a paso");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"La operacion es (x-({Numero1}))(x+({Numero2})) = x² {B}x {C}");
                        Console.WriteLine("Paso a paso");
                        Console.WriteLine("");
                    }
                }

                Nega = -1 * (B);
                Elevado = Math.Pow(B, 2);
                Comple = -(4 * (A * C));
                Divi = 2 * A;

                if (Comple > 0)
                {
                    Console.WriteLine("      _________");
                    Console.WriteLine($" {Nega} ± √ {Elevado}  {Comple}\n -------------- \n       {Divi}");

                    Suma = Elevado + Comple;

                    Console.WriteLine("      ______");
                    Console.WriteLine($" {Nega} ± √ {Suma}\n ------------ \n     {Divi}");

                    Raiz = Math.Sqrt(Suma);
                    Raiz = Math.Round(Raiz, 2);

                    Console.WriteLine($" {Nega} ± {Raiz}\n ---------\n     {Divi}");


                    Console.WriteLine("\n- Ahora se procede a averiguar X1 y X2\n");

                    Console.WriteLine($" X1=  {Nega} + {Raiz}\n      ---------\n          {Divi}\n");

                    Suma2 = Nega + Raiz;
                    Suma2 = Math.Round(Suma2, 2);

                    Console.WriteLine($" X1= {Suma2}\n     -----\n       {Divi}\n");
                    Console.WriteLine("---------  ");
                    Console.WriteLine($"| X1= {Suma2 / Divi} |");
                    Console.WriteLine("---------  ");

                    Console.WriteLine("------------------------------------");

                    Console.WriteLine($"\n X2=  {Nega} - {Raiz}\n      ---------\n          {Divi}\n");

                    Resta2 = Nega - Raiz;
                    Resta2 = Math.Round(Resta2, 2);

                    Console.WriteLine($" X2= {Resta2}\n     -----\n       {Divi}");
                    Console.WriteLine("----------  ");
                    Console.WriteLine($"| X2= {Resta2 / Divi} |");
                    Console.WriteLine("----------  ");
                }
                else
                {
                    Console.WriteLine("      _________");
                    Console.WriteLine($" {Nega} ± √ {Elevado}  {Comple}\n -------------- \n       {Divi}");

                    Suma = Elevado - Comple;

                    Console.WriteLine("      ______");
                    Console.WriteLine($" {Nega} ± √ {Suma}\n ------------ \n     {Divi}");

                    Raiz = Math.Sqrt(Suma);
                    Raiz = Math.Round(Raiz, 2);

                    Console.WriteLine($" {Nega} ± {Raiz}\n ---------\n     {Divi}");


                    Console.WriteLine("\n- Ahora se procede a averiguar X1 y X2\n");

                    Console.WriteLine($" X1=  {Nega} + {Raiz}\n      ---------\n          {Divi}\n");

                    Suma2 = Nega + Raiz;
                    Suma2 = Math.Round(Suma2, 2);

                    Console.WriteLine($" X1= {Suma2}\n     -----\n       {Divi}\n");
                    Console.WriteLine("-------------  ");
                    Console.WriteLine($"| X1= {Suma2 / Divi} |");
                    Console.WriteLine("-------------  ");

                    Console.WriteLine("------------------------------------");

                    Console.WriteLine($"\n X2=  {Nega} - {Raiz}\n      ---------\n          {Divi}\n");

                    Resta2 = Nega - Raiz;
                    Resta2 = Math.Round(Resta2, 2);

                    Console.WriteLine($" X2= {Resta2}\n     -----\n       {Divi}");

                    Console.WriteLine("-------------  ");
                    Console.WriteLine($"| X2= {Resta2 / Divi} |");
                    Console.WriteLine("-------------  ");
                }

                Console.WriteLine("¿Desea salir del programa? (S/N)");
                Whileloop = Console.ReadLine();

            } while (Whileloop == "n" || Whileloop == "N");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Fin del programa :D");

        }
    }
}
