using System;
using System.Collections;

namespace Actividad_6_Problema_6
{
    class Actividad_6_Problema_6
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por Jonathan David Guerrero Gomez :D
        //Grupo: 239-2A DIA
        //Turno: Diurno

        static void Imprimir(Stack pila)
        {
            foreach (int q in pila)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("-------------------------------");
        }

        static void ImprimirNueva(Stack Nuevapila)
        {
            foreach (int l in Nuevapila)
            {
                Console.WriteLine($"- {l}");
            }
            Console.WriteLine("-------------------------------");
        }

        static void ImprimirLista(ArrayList lista)
        {
            foreach (int q in lista)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("-------------------------------");
        }

        static void ImprimirNuevaLista(ArrayList Nuevalista)
        {
            foreach (int q in Nuevalista)
            {
                Console.WriteLine($"- {q}");
            }
            Console.WriteLine("-------------------------------");
        }

        static void Main(string[] args)
        {            
            String WhileLoop = "";

            do
            {
                Console.WriteLine("Problema N° 6 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Crear una PilaP con numeros enteros y despues pasarlos a una nueva pila pero imprimirlos invertidos");
                Console.WriteLine("----------------------------------------------------------------------------\n");

                int Opcion = 0;
                Console.WriteLine("       Menu");
                Console.WriteLine("1. Realizar el programa con un Stack");
                Console.WriteLine("2. Realizar el programa con un ArrayList");
                Opcion = int.Parse(Console.ReadLine());

                switch(Opcion)
                {
                    case 1:
                        {
                            int Cantidad = 0, Dato = 0;
                            Stack Pila = new Stack();
                            Stack PilaP = new Stack();
                            Stack NuevaPila = new Stack();

                            Console.WriteLine("Ingrese la cantidad de numeros que va ingresar");
                            Cantidad = int.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese los numeros para llenar la PilaP");
                            for (int a = 0; a < Cantidad; a++)
                            {
                                Console.Write("- ");
                                Dato = int.Parse(Console.ReadLine());
                                Pila.Push(Dato);
                            }

                            foreach (int a in Pila)
                            {
                                PilaP.Push(a);
                            }
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine($"Hay {Pila.Count} valores ingresados son estos:");
                            Imprimir(PilaP);

                            Console.WriteLine("Los valores se acaban de pasar a una nueva Pila");
                            foreach (int e in PilaP)
                            {
                                NuevaPila.Push(e);
                            }

                            Console.WriteLine("Estos son los valores, impresos invertidamente");
                            ImprimirNueva(NuevaPila);

                            break;
                        }

                    case 2:
                        {
                            int Cantidad2 = 0,Dato2=0;
                            ArrayList Lista = new ArrayList();
                            ArrayList ListaP = new ArrayList();
                            ArrayList NuevaLista = new ArrayList();

                            Console.WriteLine("Ingrese la cantidad de numeros que va ingresar");
                            Cantidad2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Ingrese los numeros para llenar la PilaP");
                            for (int a = 0; a < Cantidad2; a++)
                            {
                                Console.Write("- ");
                                Dato2 = int.Parse(Console.ReadLine());
                                Lista.Add(Dato2);
                            }

                            foreach (int a in Lista)
                            {
                                ListaP.Add(a);
                            }
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine($"Hay {Lista.Count} valores ingresados son estos:");
                            ImprimirLista(ListaP);

                            Console.WriteLine("Los valores se acaban de pasar a una nueva Pila");
                            foreach (int e in ListaP)
                            {
                                NuevaLista.Add(e);
                            }

                            NuevaLista.Reverse();
                            Console.WriteLine("Estos son los valores, impresos invertidamente");
                            ImprimirNuevaLista(NuevaLista);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("OPCION NO VALIDA");
                            break;
                        }

                }

                Console.WriteLine("¿Desea Repetir el programa? (S/N)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("-------------------------------");

            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
