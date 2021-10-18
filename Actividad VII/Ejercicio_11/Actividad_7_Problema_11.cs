using System;
using System.Collections;

namespace Actividad_7_Problema_11
{
    class Actividad_7_Problema_11
    {
        int Cantidad = 0;
        float Valor = 0f;

        Queue ColaP = new Queue();
        ArrayList List1 = new ArrayList();
        Queue ColaNueva = new Queue();

        public void Llenar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros flotantes que va a ingresar para llenar la cola");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los numeros flotantes");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write("- ");
                Valor = float.Parse(Console.ReadLine());
                ColaP.Enqueue(Valor);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"Los numeros de la cola P son estos y hay {ColaP.Count} elementos");
            foreach(float i in ColaP)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public void Transpaso()
        {
            foreach(float a in ColaP)
            {
                List1.Add(a);
            }

            foreach (float n in List1)
            {
                ColaNueva.Enqueue(n);
            }
        }

        public void ImprimirNueva()
        {
            Console.WriteLine($"Los numeros de la Nueva Cola son estos y hay {ColaNueva.Count} elementos");
            foreach (float i in ColaNueva)
            {
                Console.WriteLine($"- {i}");
            }
        }

        static void Main(string[] args)
        {
            string WhileLoop = "";
            //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Creado por Jonathan David Guerrero Gomez :D
            //Grupo: 239-2A DIA
            //Turno: Diurno

            do
            {
                Console.WriteLine("Problema N° 11 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Este programa imprime los nuemros flotantes que hay en la cola P");
                Console.WriteLine("----------------------------------------------------------------------------");

                Actividad_7_Problema_11 pv = new Actividad_7_Problema_11();
                pv.Llenar();
                Console.WriteLine("---------------------------------");
                pv.Imprimir();
                Console.WriteLine("---------------------------------");
                pv.Transpaso();
                Console.WriteLine("---------------------------------");
                pv.ImprimirNueva();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("---------------------------------");
            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");
        }
    }
}
