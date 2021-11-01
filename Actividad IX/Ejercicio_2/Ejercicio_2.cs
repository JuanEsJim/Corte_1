using System;
using System.Collections;
namespace C__proyecto
{
    class Ejercicio_2
    {
    int a,b;
      public Ejercicio_2()
      {
        Console.WriteLine ("───────INGRESE VALORES────────");
        Console.WriteLine ("Ingresa el valor 1");
        a= int.Parse (Console.ReadLine());
        Console.WriteLine ("Ingresa el valor 2");
        b= int.Parse (Console.ReadLine());
      }

      int sumar ()
      {
        int c= a+b;
        return c; 
      }
      int resta()
      {
        int c= a-b;
        return c; 
      }
      int multipli()
      {
        int c= a*b;
        return c; 
      }
      
      int division()
      {
        int c= a/b;
        return c; 
      }
    
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Turno: Diurno
        //Codigo: 239-2A DIA

        /* Problema 2: Implementar la clase operaciones. Se deben cargar dos valores enteros en 
        el constructor, calcular su suma, resta, multiplicación y división, cada una en 
        un método, imprimir dichos resultados.
        */
        Ejercicio_2 sc= new Ejercicio_2();
        string opci;
        do
        {
        Console.WriteLine ("───────MENU────────");
        Console.WriteLine ("1)Suma\n2)Restar \n3)Multiplicar \n4)Dividir \n5)Todos ");
        Console.WriteLine ("Elija una opcion: ");
        int op= int.Parse (Console.ReadLine());
        switch (op)
        {
          case 1:
          Console.WriteLine ("───────SUMA────────");
          Console.WriteLine ("El resultado de la suma es: ");
          Console.WriteLine (sc.sumar());           
          Console.WriteLine ("────────────────");
           break;
          case 2:
          Console.WriteLine ("───────RESTA────────");
          Console.WriteLine ("El resultado de la resta es: ");
          Console.WriteLine (sc.resta());           
          Console.WriteLine ("────────────────");
           break;
          case 3:
          Console.WriteLine ("───────MULTIPLICACION────────");
          Console.WriteLine ("El resultado de la multiplicacion es: ");
          Console.WriteLine (sc.multipli());           
          Console.WriteLine ("────────────────");
           break;
          case 4:
          Console.WriteLine ("───────DIVISION────────");
          Console.WriteLine ("El resultado de la division es: ");
          Console.WriteLine (sc.division());           
          Console.WriteLine ("────────────────");
           break;
          case 5:
          Console.WriteLine ("───────TODOS────────");
          Console.WriteLine ("─SUMA: ");
          Console.WriteLine ("El resultado de la suma es: ");
          Console.WriteLine (sc.sumar()); 
          Console.WriteLine ("─RESTA: ");
          Console.WriteLine ("El resultado de la resta es: ");
          Console.WriteLine (sc.resta()); 
          Console.WriteLine ("─MULTIPLICACION: ");
          Console.WriteLine ("El resultado de la multiplicacion es: ");
          Console.WriteLine (sc.multipli());
          Console.WriteLine ("─DIVISION:");
          Console.WriteLine ("El resultado de la division es: ");
          Console.WriteLine (sc.division());               
          Console.WriteLine ("────────────────");
          break;

          default:
          Console.WriteLine ("───────────────");
          Console.WriteLine ("Esta opcion no esta dentro del sistema");       
          Console.WriteLine ("────────────────");
          break;
        }
        Console.WriteLine ("¿Quieres intentarlo de nuevo (S/N)");
        opci= Console.ReadLine();
        }while (opci=="S" || opci =="s");
        
        Console.WriteLine ("Fin del programa (de enter si quiere limpiar la pantalla)");
        Console.ReadKey();
        Console.Clear();
        
        
    }  }
} 