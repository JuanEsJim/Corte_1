using System;

namespace C__proyecto
{
    class Ejercicio_1
    {
        int []arreglo = new int [ 15 ];
        int numeros,nume, proce, valor=0,xd;

        public void proceso ()
        {

          

            for (int a=0; a<arreglo.Length; a++)
            {
                Console.WriteLine (" ");
                Console.WriteLine ($"Ingrese el dato N {a+1}");
                Console.WriteLine (" ");
                arreglo[a]= int.Parse (Console.ReadLine());
                Console.WriteLine (" ");
                Console.WriteLine ($"¿Quiere realizar una 1)multiplicacion o 2)division?");
                Console.WriteLine (" ");
                numeros = int.Parse (Console.ReadLine());
                switch (numeros)
                {
                    case 1:
                     Console.WriteLine (" ");
                     Console.WriteLine ($"Ingrese el numero con el cual operar: ");
                     Console.WriteLine (" ");
                     nume = int.Parse (Console.ReadLine());
                     proce= arreglo[a]*nume;
                     int [] lol = new int [proce];
                     Console.WriteLine (" ");
                     Console.WriteLine ("El resultado de la operacion {0} es igual a {1}",a+1, proce );
                     Console.WriteLine (" ");
                    break;
                    case 2:
                    Console.WriteLine (" ");
                    Console.WriteLine ($"Ingrese el numero con el cual operar: ");
                    Console.WriteLine (" ");
                    nume = int.Parse (Console.ReadLine());
                    proce= arreglo[a]/nume;
                    Console.WriteLine (" ");
                    Console.WriteLine ("El resultado de la operacion {0} es igual a {1}",a+1, proce );
                    Console.WriteLine (" ");
                    break;
                }

                Console.WriteLine (" ");
                
            }


        }

        public void proceso2( )
        {
             
             
            for (int a=0; a<arreglo.Length;a++)
            {
              Console.WriteLine ("-------Indices-------- ");
              Console.WriteLine ("El indice del numero es {0} y valor corresponde a {1}",a+1, arreglo[a] );
              Console.WriteLine (" ");
              
            }
        }

       
        static void Main(string[] args)
        {
       
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño,
        //Actividad semana4
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 1: array de 15
             
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 1: Un array de 15 ");
            Console.WriteLine (" ");

            Ejercicio_1 sc= new Ejercicio_1();

            sc.proceso();
            sc.proceso2();

           



        }
           



            





        
    }
}