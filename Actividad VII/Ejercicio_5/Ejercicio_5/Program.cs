using System;
using System.Collections;
namespace Ejercicio_5
//Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas 
//Creado por Juan Esteban Jimenez Cuestas
//Grupo: 239-2A DIA
//Turno: Diurno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, cantidadcol = 0;

            Queue cola = new Queue();
            Queue nuevacola = new Queue();

            Console.WriteLine("Numero de los datos que desa ingresar");
            cantidadcol = int.Parse(Console.ReadLine());

            for (int cont = 0; cont < cantidadcol; cont++)
            {
                Console.Write("* ");
                numero = int.Parse(Console.ReadLine());
                cola.Enqueue(numero);
            }

            Console.WriteLine("Los valores de la cola seran transferidos a una nueva cola");
            Console.WriteLine("_____________________________________________________________");

            foreach (int s in cola)
            {
                nuevacola.Enqueue(s);
            }

            Console.WriteLine("La nueva cola tiene {0} datos y sus valores son:", nuevacola.Count);
            foreach (int e in nuevacola)
            {
                Console.WriteLine("- {0}", e);
            }
            Console.WriteLine(" _______________________________________________________________");

        }   
    }
}
