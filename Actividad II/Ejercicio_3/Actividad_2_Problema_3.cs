using System;

namespace Actividad_2_Problema_3
{
    class Actividad_2_Problema_3
    {
        static void Main(string[] args)
        {
            //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            double Numero1 = 0f, Numero2 = 0f;
            int Opcion = 0;

            Console.WriteLine("Problema No. 3");
            Console.WriteLine("Menu con operaciones de suma, resta, division y multiplicacion");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese dos numeros enteros mayores a 100");

            Console.WriteLine("Numero 1");
            Numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Que operacion quiere hacer con los numeros");
            Console.WriteLine("                    Menu");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Division");
            Console.WriteLine("4. Multiplicacion");
            Console.WriteLine("5. Salir");

            Console.WriteLine("¿Que opcion escogue?");
            Opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            if (Numero1 >= 100 && Numero2>=100)
            {
                switch (Opcion)
                {
                    case 1:
                        {
                            double Resultado = 0;
                            Console.WriteLine("                    SUMA  ");
                            Resultado = Numero1 + Numero2;
                            Console.WriteLine($"La suma entre {Numero1} + {Numero2} es {Resultado}");
                            Console.WriteLine("------------------------------------");
                            break;
                        }

                    case 2:
                        {
                            double Resultado = 0;

                            Console.WriteLine("                    RESTA");
                            Resultado = Numero1 - Numero2;
                            Console.WriteLine($"La resta entre {Numero1} - {Numero2} es {Resultado}");
                            Console.WriteLine("------------------------------------");
                            break;
                        }
                    case 3:
                        {
                            double Resultado = 0f;

                            Console.WriteLine("                    DIVISION");
                            Resultado = Numero1 / Numero2;
                            Resultado = Math.Round(Resultado, 3);
                            Console.WriteLine($"La division entre {Numero1} / {Numero2} es {Resultado}");
                            Console.WriteLine("------------------------------------");
                            break;
                        }
                    case 4:
                        {
                            double Resultado = 0;

                            Console.WriteLine("                    MULTIPLICACION");
                            Resultado = Numero1 * Numero2;
                            Console.WriteLine($"La multiplicacion entre {Numero1} * {Numero2} es {Resultado}");
                            Console.WriteLine("------------------------------------");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Hasta la proxima.");
                            break;
                        }
                }
            }
            else if (Numero2 == 0)
            {
                Console.WriteLine("El numero 2 es 0 no es valido");
            }
            else if (Numero1 == 0)
            {
                Console.WriteLine("El numero 1 es 0 no es valido");
            }
            else if (Numero1 < 100)
            {
                Console.WriteLine("Numero 1 no valido debe ser mayor que 100");
            }
            else if (Numero2 < 100)
            {
                Console.WriteLine("Numero 2 no valido debe ser mayor que 100");
            }            
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}
