using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_1
    {
        Queue cola= new Queue();
        int valor;
        public void ejercicio()
        {
            do
            {
                
                Console.WriteLine ($"Ingrese el valor a la cola: ");
                valor= int.Parse (Console.ReadLine());
                Console.WriteLine();
                cola.Enqueue(valor);

            }while (valor!=0);
            Console.WriteLine ("La lista de numeros enteros ingresados a la cola son los siguientes: ");
            Console.WriteLine("─────────────────────");
              foreach (int a in cola)
              {
               Console.Write(a+". ");   
              }
            Console.WriteLine("\n");
            Console.WriteLine("─────────────────────");
      

        }
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 1:  Escriba un programa que inserte valores ordenadamente en una lista. La lista/pila/cola
        debe almacenar números enteros. El programa debe leer una secuencia de números
        enteros de la entrada hasta que se ingrese el número cero*/
        Ejercicio_1 llamado = new Ejercicio_1();
        Console.WriteLine ("--Ejercicio 1---");
        Console.WriteLine ("Puede ingresar una cantidad ilimitada de numeros a la cola, para terminarla escriba cero");
        Console.WriteLine();
        Console.WriteLine("─────────────────────");
        llamado.ejercicio();
        Console.WriteLine();
        Console.WriteLine ("Fin del programa, de enter si quiere limpiar la pantalla");
        Console.ReadKey();
        Console.Clear();
        
        
        }
    }
} 