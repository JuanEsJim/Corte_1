using System;
using System.Collections;

namespace Actividad_7_Problema_9
{
    class Actividad_7_Problema_9
    {
        int Cantidad = 0;
        int Valor = 0;

        Queue ColaP = new Queue();
        Queue ColaN = new Queue();

        ArrayList List1 = new ArrayList();

        public void Llenar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar para llenar la cola");
            Cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write("- ");
                Valor = int.Parse(Console.ReadLine());
                ColaP.Enqueue(Valor);
            }
        }

        public void ImprimirP()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"La Cola P tiene estos valores y son {ColaP.Count} elementos");
            foreach (int i in ColaP)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public void Transpaso()
        {
            Console.WriteLine("Los datos de la Cola P se van a pasar a una nueva cola");
            foreach (int q in ColaP)
            {
                List1.Add(q);
            }

            foreach(int w in List1)
            {
                ColaN.Enqueue(w);
            }
        }

        public void ImprimirN()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Listo, los datos de la nueva cola son estos y hay {ColaN.Count} elementos");
            foreach (int a in ColaN)
            {
                Console.WriteLine($"- {a}");
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
                Console.WriteLine("Problema N° 9 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Este programa llenar una Cola y despues lo pasa a otra Colas y lo imprime");
                Console.WriteLine("----------------------------------------------------------------------------");

                Actividad_7_Problema_9 pv = new Actividad_7_Problema_9();

                pv.Llenar();
                pv.ImprimirP();
                pv.Transpaso();
                pv.ImprimirN();

                Console.WriteLine("---------------------------------");
                Console.WriteLine("¿Desea repetir el programa? (s/n)");
                WhileLoop = Console.ReadLine();
                Console.WriteLine("---------------------------------");
            } while (WhileLoop == "s" || WhileLoop == "S");

            Console.WriteLine("Fin del programa :D");


        }
    }
}
