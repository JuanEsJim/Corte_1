using System;

namespace C__proyecto
{
    class Ejercicio_5
    {
        private int [,] arreglo;
        private int [,] arreglo1;
        int filas,columnas,filas1,columnas1,suma,traspuesto; 
        public void arreglos1 ()
        {
            Console.WriteLine ();
            Console.WriteLine ("----PRIMER ARREGLO----");
            Console.WriteLine ("Ingrese el numero de filas: ");
            filas= int.Parse (Console.ReadLine());
            Console.WriteLine ();
            Console.WriteLine ("Ingrese el numero de columnas de la matriz: ");
            columnas= int.Parse (Console.ReadLine());
            Console.WriteLine ();
            arreglo= new int [filas,columnas];

            for (int a=0; a<filas; a++)
            {
                for (int b=0; b<columnas; b++)
                {
                    Console.WriteLine (" ");
                    Console.WriteLine ($"Ingresar el valor de la fila [{a+1}] columna [{b+1}] de la matriz: ");
                    Console.WriteLine (" ");
                    arreglo [a,b]= int.Parse (Console.ReadLine());
                }
            } 
            Console.WriteLine ();
            
            Console.WriteLine ();
            Console.WriteLine ("----SEGUNDO ARREGLO----");
        }

        public void arreglo2 ()
        {
            do
           {
            Console.WriteLine ();
            Console.WriteLine ("Ingrese el numero de filas: ");
            filas1= int.Parse (Console.ReadLine());
             if (filas1!=filas)
             {
                 Console.WriteLine ();
                 Console.WriteLine ("El numero de filas tiene que ser el mismo al del anterior para poder realizar la operacion");
                 Console.WriteLine ();
             }
            } while (filas1!=filas);
            do
            {
            Console.WriteLine ();
            Console.WriteLine ("Ingrese el numero de columnas de la matriz: ");
            columnas1= int.Parse (Console.ReadLine());
              if (columnas1!=columnas)
             {
                 Console.WriteLine ();
                 Console.WriteLine ("El numero de columnas tiene que ser el mismo al del anterior para poder realizar la operacion");
                 Console.WriteLine ();
             }
            Console.WriteLine ();
            }while (columnas1!=columnas);

            arreglo1= new int [filas1,columnas1];
            for (int a=0; a<filas1; a++)
            {
                for (int b=0; b<columnas1; b++)
                {
                    Console.WriteLine (" ");
                    Console.WriteLine ($"Ingresar el valor de la fila [{a+1}] columna [{b+1}] de la matriz: ");
                    Console.WriteLine (" ");
                    arreglo1 [a,b]= int.Parse (Console.ReadLine());
                }
            } 
            Console.WriteLine ();
            Console.WriteLine ("Ingrese enter para limpiar la pantalla: ");
            Console.ReadKey();
            System.Console.Clear();

        }   

        public void cargararreglo()
        {
            Console.WriteLine ();Console.WriteLine ();
            Console.WriteLine ("---ARREGLOS----");
            Console.WriteLine ($"-PRIMER ARREGLO\n El primer arreglo es una matriz {filas}x{columnas}: \n");
            for (int a=0; a<arreglo.GetLength(0); a++)
            {
                for (int b=0; b<arreglo.GetLength(1);b++)
                {
                    Console.Write (" [" + arreglo[a,b]+ "] ");

                }
                Console.WriteLine (" ");

            }
             Console.WriteLine ();
            Console.WriteLine ($"-SEGUNDO ARREGLO\n El primer arreglo es una matriz {filas1}x{columnas1}: \n");
             for (int c=0; c<arreglo1.GetLength(0); c++)
            {
                for (int d=0; d<arreglo1.GetLength(1);d++)
                {
                    Console.Write (" [" + arreglo1[c,d]+ "] ");

                }
                Console.WriteLine (" ");

            }
            Console.WriteLine ();
        }

        public void operaciones()
        {
            Console.WriteLine ("-------------------------");
            Console.WriteLine ("El segundo arreglo traspuesto es: ");
             for (int a=0; a<arreglo1.GetLength(0); a++)
            {
                for (int b=0; b<arreglo1.GetLength(1);b++)
                {
                    Console.Write (" [" + arreglo1[b,a]+ "] ");
                }
                Console.WriteLine (" ");

            }
            Console.WriteLine();
            Console.WriteLine ("Y la suma del valor traspuesto con el primer arreglo es: ");
              
              for (int c=0; c<filas; c++)
            {
                for (int d=0; d<columnas;d++)
                {
                    suma= arreglo [c,d] + arreglo1[d,c];
                    Console.Write (" [" + suma + "] ");
               
                }
                Console.WriteLine (" ");
            }
            

            
        }


        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 5: Datos bidimensionales, su suma y traspuesto

         Ejercicio_5 matriz = new Ejercicio_5();
        Console.WriteLine ();
        Console.WriteLine ("5) Datos bidimensionales, su suma y traspuesto (de enter para continuar) ");
        Console.WriteLine ();
        Console.ReadKey();
        matriz.arreglos1();
        matriz.arreglo2();
        matriz.cargararreglo();
        matriz.operaciones();
            
            





        }
    }
}