using System;

namespace Actividad_3_Problema_7
{
    class Actividad_3_Problema_7
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int Num1 = 0, Num2 = 0,Contador=0;
            String Opcion = "",Whileloop="";

            Console.WriteLine("Problema No. 7 --- Jonathan David Guerrero Gomez");
            Console.WriteLine("Imprime numeros pares y impares");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Ingrese un numero");
                Num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero");
                Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione una opcion (i =Impares / p =Pares)");
                Opcion = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------");



                if (Opcion == "I" || Opcion == "i")
                {
                    Console.WriteLine("Escoguio la opcion de IMPARES");

                    if (Num1 < Num2)
                    {
                        for (int i = Num1; i <= Num2; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine($"- {i}");
                                Contador = Contador + 1;
                            }
                        }
                        Console.WriteLine($"Hay {Contador} numeros impares");
                    }

                    if (Num2 < Num1)
                    {
                        for (int i = Num2; Num1 >= i; i++)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine($"- {i}");
                                Contador = Contador + 1;
                            }
                        }
                        Console.WriteLine($"Hay {Contador} numeros impares");
                    }
                }
                else if (Opcion == "P" || Opcion == "p")
                {
                    Console.WriteLine("Ecogio la opcion de PARES");

                    if (Num1 < Num2)
                    {
                        for (int i = Num1; i <= Num2; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"- {i}");
                                Contador = Contador + 1;
                            }
                        }
                        Console.WriteLine($"Hay {Contador} numeros impares");
                    }

                    if (Num2 < Num1)
                    {
                        for (int i = Num2; Num1 >= i; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"- {i}");
                                Contador = Contador + 1;
                            }
                        }
                        Console.WriteLine($"Hay {Contador} numeros impares");
                    }
                }
                Console.WriteLine("¿Desea salir del programa? (S/N)");
                Whileloop = Console.ReadLine();
                Contador = 0;

            } while (Whileloop == "n" || Whileloop == "N");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Fin del programa.");
        }
    }
}