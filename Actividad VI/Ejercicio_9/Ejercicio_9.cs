using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_9
    {
        ArrayList entero = new ArrayList();
        int numeros,ele;
        public void lista ()
        {
            Console.WriteLine();
            Console.WriteLine ("Ingrese la cantidad de numeros enteros que quiere ingresar a la lista: ");
            numeros= int.Parse (Console.ReadLine());
         
            for (int a=0; a<numeros; a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el elemento numero {a+1} de la lista: ");
                Console.WriteLine();
                ele= int.Parse (Console.ReadLine());
                entero.Add (ele);
            }
            Console.WriteLine();
            Console.WriteLine("La copia de la lista actual es: ");
            Console.WriteLine();
            foreach (int a in entero)
            {
           
                Console.Write (a+" ");
            }
            Console.WriteLine ("\n");
            

        }
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 9:  Escriba una rutina que reciba una Pila P de números enteros y devuelva una copia exacta 
        de la misma. Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o alteració (solo con arraylist)
        */
        Ejercicio_9 list = new Ejercicio_9();
        string opciones;
      
        do
        {
        Console.WriteLine ("─────────────────────");  
        list.lista();
        Console.WriteLine ("─────────────────────");  
        Console.WriteLine ("¿Quieres agregar mas numeros a la lista? (S/N)");
        opciones= Console.ReadLine();
        }while (opciones!="n" && opciones!="N");
        Console.WriteLine ("Fin del programa (De enter para borrar pantalla)");
        Console.ReadKey();
        Console.Clear();

        }
    }
} 