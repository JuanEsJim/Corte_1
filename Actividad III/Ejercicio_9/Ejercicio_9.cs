using System;

namespace C__proyecto
{
    class Ejercicio_9
    {

        int lado1,lado2,lado3, cantidad;
        string salida;
        public void datos ()
        {
            do
            {

            Console.WriteLine ("Escoja la cantidad de niveles que debe de tener un triangulo: \n 1)5 \n 2)3 \n 3)4 \n 4)Ninguna de las anteriores \n:");
            cantidad= int.Parse (System.Console.ReadLine());

            switch (cantidad)
            {
                case 1:
                  Console.WriteLine (" ");
                  Console.WriteLine ("La opcion elegida es la incorrecta");
                 break;

                case 2:
                  Console.WriteLine (" ");
                  Console.WriteLine ("¡La opcion elegida es la correcta!");
                  Console.WriteLine (" ");
                  Console.WriteLine ("Ingrese el valor del lado superior : ");
                  lado1= int.Parse (System.Console.ReadLine());
                  Console.WriteLine (" ");
                  Console.WriteLine ("Ingrese el valor del lado inferior 1 : ");
                  lado2= int.Parse (System.Console.ReadLine());
                  Console.WriteLine (" ");
                  Console.WriteLine ("Ingrese el valor del lado inferior 2  ");
                  lado3= int.Parse (System.Console.ReadLine());

                  if (lado2+lado3>=lado1)
                  {

                      if (lado1==lado2 || lado1==lado3)
                      {
                        Console.WriteLine (" ");
                        Console.WriteLine ("El triangulo es de tipo equilatero ");
                      }
                        else 
                        {
                          if (lado1==lado2 || lado1==lado3 || lado2==lado3)
                           {
                            Console.WriteLine (" ");
                            Console.WriteLine ("El triangulo es de tipo isoceles ");
                           }
                           else
                           {
                              if (lado1!=lado2 || lado1!= lado3 || lado2!=lado3)
                             {
                             Console.WriteLine (" ");
                             Console.WriteLine ("El triangulo es de tipo escaleno ");
                             }
                           }
                       }
                      
                  }
                  else
                  {
                     Console.WriteLine (" ");
                     Console.WriteLine ("No es posible formar el triangulo, pues la suma de los lados inferiores es menor al lado superior"); 
                  }




                 break;

                case 3:
                  Console.WriteLine (" ");
                  Console.WriteLine ("La opcion elegida es la incorrecta");
                 break;

                case 4:
                  Console.WriteLine (" ");
                  Console.WriteLine ("La opcion elegida es la incorrecta");
                 break;

                default:
                  Console.WriteLine (" ");
                  Console.WriteLine ("La opcion elegida no esta dentro de la seleccion");
                 break;
            }
            lado1=0;
            lado2=0;
            lado3=0;

            Console.WriteLine (" ");
            Console.WriteLine ("¿Quiere salir del programe en cuestion? (S/N)");
            salida= Console.ReadLine();
            }while (salida != "S" && salida != "s");

        }
        static void Main(string[] args)
        {
       
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño,
        //Actividad semana3
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 9: Elegir los tipos de triangulos
           
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 9: Elegir los tipos de triangulos ");
            Console.WriteLine (" ");

            Ejercicio_9 sc = new Ejercicio_9();
            sc.datos();

           



        }
           



            





        
    }
}