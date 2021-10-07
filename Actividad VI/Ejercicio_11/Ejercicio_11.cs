using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_11
    {
        ArrayList flotante = new ArrayList();
        int numeros;
        float ele;
        public void lista ()
        {
            Console.WriteLine();
            Console.WriteLine ("Ingrese la cantidad de numeros  que quiere ingresar a la lista: ");
            numeros= int.Parse (Console.ReadLine());
         
            for (int a=0; a<numeros; a++)
            {
                Console.WriteLine();
                Console.WriteLine ($"Ingrese el elemento numero {a+1} de la lista: ");
                Console.WriteLine();
                ele= float.Parse (Console.ReadLine());
                flotante.Add (ele);
            }
            Console.WriteLine();
            Console.WriteLine("La lista de flotantes es: ");
            Console.WriteLine();
            foreach (float a in flotante)
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

        /* Problema 11: Escriba una rutina que reciba una Pila P de números flotantes y devuelva una Cola,
           manteniendo el orden de salida de los elementos. Es de destacar que la Pila P no debe
           sufrir ningún tipo de cambio o alteración. (solo con arraylist)
        */
        Ejercicio_11 list = new Ejercicio_11();
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