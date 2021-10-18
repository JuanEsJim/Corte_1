using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_4
    {
       Queue cola1 = new Queue();
       Queue cola2= new Queue();
     
       int rango,rango2,num,num2;

        public void proceso()
        {
            Console.WriteLine ("-Ingrese el rango de numeros de la primera cola");
            rango= int.Parse (Console.ReadLine());
            Console.WriteLine();
            for (int a=0; a<rango;a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el valor {a+1} de la cola 1");
                num= int.Parse (Console.ReadLine());
                cola1.Enqueue(num);
            }
            Console.WriteLine();
            Console.WriteLine ("-Ingrese el rango de numeros de la segunda cola");
            rango2= int.Parse (Console.ReadLine());
            Console.WriteLine();
            for (int a=0; a<rango2;a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el valor {a+1} de la cola 2");
                num2= int.Parse (Console.ReadLine());
                cola2.Enqueue(num2);
            }

            Console.WriteLine ("De enter para continuar");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine ("─────────────────────"); 
             Console.WriteLine ("La primera cola tiene como valores:");
            foreach (int a in cola1)
            {
                Console.Write (a+ " ");
                
            }
             Console.WriteLine ("\n");
            
      
            Console.WriteLine ("─────────────────────"); 
            Console.WriteLine ("La segunda cola tiene como valores:");
            foreach (int a in cola2)
            {
                Console.Write (a+ " ");
                
            }
            Console.WriteLine ("\n");
            
      
            Console.WriteLine ("─────────────────────"); 
            Console.WriteLine ("La concatenacion de las colas es: ");
           ArrayList conversion= new ArrayList(cola1);
           ArrayList conversion2= new ArrayList(cola2);
           conversion.AddRange(conversion2);
           Queue cola3= new Queue (conversion);
           foreach (int a in cola3)
           {
               Console.WriteLine ("-"+a);
           }
           Console.WriteLine ("\n");



        }
        
        
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 4:Escriba un programa que dadas dos lista/pila/cola ordenadas de números enteros, realice
        la concatenación en forma ordenada de ambas lista/pila/cola
        */
       
      
        Ejercicio_4 agregar = new Ejercicio_4();
       
      
      
        Console.WriteLine ("─────────────────────");  
        agregar.proceso();
        Console.WriteLine ("─────────────────────");  
        Console.WriteLine("Fin del programa, de enter si quiere borrar la pantalla");
        Console.ReadKey();
        Console.Clear();
        }
    }
} 