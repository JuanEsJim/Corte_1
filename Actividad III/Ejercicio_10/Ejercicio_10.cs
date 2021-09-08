using System;

namespace C__proyecto
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana3
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 10 las vacunas
        string salida;
        int a,b,c,vacunas=1000;
        Console.WriteLine (" ");
        Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
        Console.WriteLine (" ");
        Console.WriteLine ("***Problema 10: Las vacunas ");
        Console.WriteLine (" ");
        Console.WriteLine ("---Cada dia se entregan a 3 puntos determinados una cantidad de vacunas basadas en 1000 unidades ");

        do
        {
        Console.WriteLine (" ");
        
         do
        {

        Console.WriteLine ("¿Cuantas vacunas va entregar al punto A?: ");
        a= int.Parse (Console.ReadLine());
        vacunas= vacunas-a;
        Console.WriteLine ("¿Cuantas vacunas va entregar al punto B?: ");
        b= int.Parse (Console.ReadLine());
        vacunas= vacunas-b;
        Console.WriteLine ("¿Cuantas vacunas va entregar al punto C?: ");
        c= int.Parse (Console.ReadLine());
        vacunas= vacunas-c;
        }while (vacunas>200);
        
        Console.WriteLine ("El inventario de vacunas ya es menor a 200 ");
         
         Console.WriteLine ($"La cantidad de vacunas usadas en el punto A fueron de {a} ");
         Console.WriteLine ($"La cantidad de vacunas usadas en el punto B fueron de {b} ");
         Console.WriteLine ($"La cantidad de vacunas usadas en el punto C fueron de {c} ");
       

      
         
        
          a=0;
          b=0;
          c=0;
          vacunas=0;
          vacunas=1000;


        
        
        Console.WriteLine ("¿Quieres salir del programa de vacunas? (S/N) ");
        salida= Console.ReadLine();

        }while(salida!="S" && salida!="s");


            





        }
    }
}