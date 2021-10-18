using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_2
    {
        Queue cola= new Queue();
        int ca,num;
        public void cuadrados()
        {
            
            Console.WriteLine ("Ingrese la cantidad de numeros que quiere ingresar en la cola");
            ca= int.Parse (Console.ReadLine());
            Console.WriteLine();
            for (int a=0;a<ca;a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese valor {a+1}");
                num= int.Parse(Console.ReadLine());
                cola.Enqueue(num);
            }
       
            Console.WriteLine();
            Console.WriteLine("La sumatoria de los elementos dentro de la lista son los siguientes: ");
            Console.WriteLine("─────────────────────");
            foreach (int a in cola)
            {
              int b=a+1;
              int c= a+b;
              int total= a*b*c;
              int sumatoria= total/6;
             
              Console.WriteLine ("-"+sumatoria);

            }
           


        }

    
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 2: Escriba un programa que calcule la sumatoria de los cuadrados de los elementos de una
        lista/pila/cola de números enteros.
        */
        Ejercicio_2 llamado= new Ejercicio_2();
            
      
        Console.WriteLine ("--EJERCICIO 2--");
        Console.WriteLine ("La sumatoria cuadrada de N numeros ingresados en una cola");
        Console.WriteLine ("─────────────────────");  
        llamado.cuadrados();
        Console.WriteLine ("─────────────────────");  
        Console.WriteLine("Fin del programa, de enter para limpiar pantalla");
        Console.ReadKey();
        Console.Clear();
        

        
        
    }  }
} 