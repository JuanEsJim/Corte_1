using System;
using System.Collections;

namespace Actividad_7_Problema_10
{
    class Actividad_7_Problema_10
    {
        int Cantidad = 0;
        float Valor = 0f;

        Queue ColaP = new Queue();
        ArrayList List1 = new ArrayList();
        Queue ColaN = new Queue();

        public void Llenar()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que va a ingresar para llenar la cola");
            Cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < Cantidad; i++)
            {
                Console.Write("- ");
                Valor = float.Parse(Console.ReadLine());
                ColaP.Enqueue(Valor);
            }
        }

        public void ImprimirP()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"La Cola P tiene estos valores y son {ColaP.Count} elementos");
            foreach (float i in ColaP)
            {
                Console.WriteLine($"- {i}");
            }
        }

        public void Invertir()
        {
            foreach (float s in ColaP)
            {
                List1.Add(s);
            }

            List1.Reverse();

            foreach (float r in List1)
            {
                ColaN.Enqueue(r);
            }
        }

        public void ImprimirN()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Los numeros son estos y son {ColaN.Count}");
            foreach (float a in ColaN)
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
                Console.WriteLine("Problema N° 10 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Este programa llenar Cola con numeros flotantes y imprime otra cola pero con los numeros invertidos");
                Console.WriteLine("----------------------------------------------------------------------------");

                Actividad_7_Problema_10 pv = new Actividad_7_Problema_10();
                pv.Llenar();
                pv.ImprimirP();
                pv.Invertir();
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
