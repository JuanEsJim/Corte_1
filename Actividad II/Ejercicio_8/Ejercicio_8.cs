using System;

namespace C__proyecto
{
    class Ejercicio_8
    {
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 8:  Leer una variable entera mes y compruebe si el valor corresponde a un mes de 30 días
       int meses;
       string salida;
        Console.WriteLine (" ");
        Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
        Console.WriteLine (" ");
        Console.WriteLine ("***Problema 8: Leer una variable entera mes y compruebe si el valor corresponde a un mes de 30 días ");
        Console.WriteLine (" ");
        
        do
        {
        Console.WriteLine (" ");
        Console.WriteLine ("Ingrese el numero del mes que quiere conocer: ");
        meses= int.Parse(System.Console.ReadLine());

        if (meses<1 || meses>12)
        {
            Console.WriteLine (" ");
            Console.WriteLine ("El mes ingresado es incorrecto");
        }
        else
        {
            switch (meses)
            {
                case 1:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Febrero");
                 break;
                case 2:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Enero");
                 break;
                case 3:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Marzo");
                 break;
                case 4:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Abril");
                 break;
                case 5:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Mayo");
                 break;
                case 6:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Junio");
                 break;
                case 7:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Julio");
                 break;
                case 8:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Agosto");
                 break;
                case 9:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Septiembre");
                 break;
                case 10:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Octubre");
                 break;
                case 11:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Noviembre");
                 break;
                case 12:
                 Console.WriteLine (" ");
                 Console.WriteLine ("Diciembre");
                 break;

        
            }
            if (meses==4|| meses==6 || meses==9 || meses==11 )
            {
                Console.WriteLine (" ");
                Console.WriteLine ("El mes ingresado es de 30 dias");
            }
            else if (meses==2)
            {
                Console.WriteLine (" ");
                Console.WriteLine ("EL mes ingresado es de 28 dias");
            }
            else 
            {
                Console.WriteLine (" ");
                Console.WriteLine ("EL mes ingresado es de 31 dias");
            }
         
        }
           



            
        Console.WriteLine (" ");
        Console.WriteLine ("¿Desea salir del programa? (S/N)");
        salida= Console.ReadLine();

        }while (salida!="s" && salida!="S");

        Console.WriteLine ("Fin del programa, de enter para limpiar la pantalla.");
        Console.ReadKey();
        Console.Clear();
             




            





        }
    }
} 