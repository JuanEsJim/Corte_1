using System;
using System.Collections;

namespace Ejercicio_6
{
    class Program
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas 
        //Creado por Juan Esteban Jimenez Cuestas
        //Grupo: 239-2A DIA
        //Turno: Diurno
        static void Main(string[] args)
        { 
            int Cantidad = 0, Dato = 0;
            Queue lista = new Queue();
            Queue listacol = new Queue();
            Queue nuevalistacol = new Queue();

            Console.WriteLine("cantidad de numeros que va ingresar:");
            Cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("============================================");
            Console.WriteLine("Ingrese los numeros:");
            for (int a = 0; a < Cantidad; a++)
            {
                Console.Write("* ");
                Dato = int.Parse(Console.ReadLine());
                lista.Enqueue(Dato);
            }

            foreach (int a in lista)
            {
                listacol.Enqueue(a);
            }
            Console.WriteLine("Los valores ahora estan en otra cola y estos son:");
 
            foreach (int e in listacol)
            {
                nuevalistacol.Enqueue(e);
            }
            foreach (int l in nuevalistacol)
            {
                Console.WriteLine($"* {l}");
            }
            ArrayList num = new ArrayList(nuevalistacol);
            num.Reverse();
            Queue cola2 = new Queue(num);
            Console.WriteLine("Valores invertidos:");
             

            foreach (int q in cola2)
            {
                Console.WriteLine($"* {q}");
            }
            









        }
    }
}