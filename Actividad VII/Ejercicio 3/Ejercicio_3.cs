using System;
using System.Collections;

namespace C__proyecto
{
    class Ejercicio_3
    {
        Queue cola= new Queue();
        int rango,num,indi;
        String opcion;
        public void proceso()
        {
            Console.WriteLine ("Escriba el rango de numeros que va ingresar en la cola");
            rango= int.Parse (Console.ReadLine());
            for (int a=0; a<rango;a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingresar el valor numero {a+1}");
                num= int.Parse (Console.ReadLine());
                cola.Enqueue(num);
                
            }
            ArrayList indice = new ArrayList(cola);
             Console.WriteLine ("─────────────────────");  
            Console.WriteLine ("Consulte el indice de un valor ingresado");
            Console.WriteLine ();  
            do
            {
            Console.WriteLine ("¿Que valor quiere consultar?");
            indi= int.Parse (Console.ReadLine());
             
            bool contiene= cola.Contains(indi);
           
            if (contiene==true)
            {
            Console.WriteLine (); 
            Console.WriteLine ($"El valor esta dentro de la lista, y su posicion es {indice.IndexOf(indi)}");
            Console.WriteLine ();     
            }
            else
            {
            Console.WriteLine (); 
            Console.WriteLine ("Null");
            }
            Console.WriteLine ();  
            Console.WriteLine ("¿Desea salir del programa? S/N");  
            opcion= Console.ReadLine();
            Console.WriteLine (); 
           
            }while (opcion!="s" && opcion!="S");
        }

        

  
      
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 3: Escriba un programa que reciba la dirección del primer elemento de una lista/pila/cola
        simple de números enteros y devuelva un apuntador al elemento donde exista el número. 
        <x>. Este número es recibido por el método. Se debe retornar NULL si el valor de <x> no
        se encuentra en la lista/pila/cola
        */
        Ejercicio_3 agregar = new Ejercicio_3();
       
      
        Console.WriteLine ("--Ejercicio 3--");
        Console.WriteLine ("Investigar si un elemento esta en la lista y ver su indice");
        Console.WriteLine ("─────────────────────");  
        agregar.proceso();
        Console.WriteLine ("─────────────────────");  
        Console.WriteLine("Fin del programa, de enter si quiere borrar la pantalla");
        Console.ReadKey();
        Console.Clear();

        }
    }
} 