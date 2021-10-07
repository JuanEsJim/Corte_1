using System;
using System.Collections;
using System.Linq;

namespace Ejercicio_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            int indice;
            numeros.Add(4);
            numeros.Add(6);
            numeros.Add(8);
            numeros.Add(50);
            numeros.Add(9);
            numeros.Add(7);
            numeros.Add(3);
            numeros.Add(10);
            numeros.Add(45);
              



            Console.WriteLine("Escriba un numero:");
            int busqueda = int.Parse(Console.ReadLine());
            indice=numeros.IndexOf(busqueda);



            if (indice ==-1)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine("El elemento {0} existe", busqueda);
            }
            Console.WriteLine(indice);



        }
    }
}