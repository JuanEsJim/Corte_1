using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_12
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
            ArrayList copia = new ArrayList();
            copia.AddRange(entero);
             Console.WriteLine();
            Console.WriteLine("La lista copiada es: ");
            Console.WriteLine();
            foreach (int a in copia)
            {
           
                Console.Write (a+" ");
            }
            Console.WriteLine ("\n");
            entero.Clear();
            Console.WriteLine("La lista original ahora no tiene ningun elemento: ");
              foreach (int a in entero)
            {
           
                Console.Write (a+" ");
            }
            Console.WriteLine();
            

        }
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 12:  . Escriba una rutina que reciba una Cola C de números enteros y mueva sus elementos a
           una nueva Pila, pero manteniendo el orden de salida de los elementos. Al finalizar la Cola
           C no debe contener elementos(solo con arraylist)
        */
        Ejercicio_12 list = new Ejercicio_12();
        string opciones;
      
        do
        {
        Console.WriteLine ("─────────────────────");  
        list.lista();
        Console.WriteLine ("─────────────────────");  
        Console.WriteLine ("¿Quieres repetir el programa? (S/N)");
        opciones= Console.ReadLine();
        }while (opciones!="n" && opciones!="N");
        Console.WriteLine ("Fin del programa (De enter para borrar pantalla)");
        Console.ReadKey();
        Console.Clear();

        }
    }
} 