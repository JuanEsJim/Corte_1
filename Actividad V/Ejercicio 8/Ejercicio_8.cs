using System;

namespace C__proyecto
{
    class Ejercicio_8
    {
        int [,] sucursal_producto = new int [5,4];
        int [,] lol= new int [4,5];
        int [] precio= new int [5];
        int [,] productoyventas= new int [5,4];
        int [] cantidad= new int [5];
        int [] recaudacion= new int [5];
        int producto,venta,sucursal1=0,sucursal2=0,total,mejorventas=0,mejorsucursal=0;

        public void sucursales()
        {

         for (int a=0; a<sucursal_producto.GetLength(0);a++)
            {
            
                Console.WriteLine ();
                Console.WriteLine ($"-Ingrese el precio del producto {a+1}: ");
                precio[a]= int.Parse (Console.ReadLine());
                Console.WriteLine ();    

                   for (int b=0; b<sucursal_producto.GetLength(1);b++)
                  {
                  Console.WriteLine ();
                  Console.WriteLine ($"Ingrese las ventas del producto en la sucursal {b+1}: ");  
                  Console.WriteLine ();
                  productoyventas[a,b]= int.Parse (Console.ReadLine());
                  }
            }
                           
               
    

             
        sucursal1= productoyventas[1,3];

        for (int c=0; c<sucursal_producto.GetLength(0);c++)
            {
              cantidad [c]=0;

              for (int d=0; d<sucursal_producto.GetLength(1);d++)
              {
                  recaudacion [d]=0;
              }

            }

            for (int e=0; e<sucursal_producto.GetLength(0);e++)
            {
               
                  for (int f=0; f<sucursal_producto.GetLength(1);f++)
                  {
                      cantidad[f]+= productoyventas[e,f];
                      if (e==2)
                      {
                        sucursal2+=productoyventas[e,f];
                      }
                      recaudacion[e]+= (productoyventas[e,f]*precio[f]);
                      total+= (productoyventas[e,f]*precio[e]);
                  }   
            }

     


        }

        public void totalvendido()
        {
            Console.WriteLine ("---------");
            Console.WriteLine ("1) TOTAL DE VENTAS: ");
            for (int a=0; a<sucursal_producto.GetLength(1);a++)
            {
                Console.WriteLine ($"El articulo {a+1} tiene un total de ventas de: {cantidad[a]}");
            }
            Console.WriteLine();
            Console.WriteLine ($"2) El total de ventas de la sucursal 2 fue de: {sucursal2}");
            Console.WriteLine ();
            Console.WriteLine ($"3) La cantidad de articulos 3 en la sucursal 1 es de: {sucursal1}");
            Console.WriteLine();
             Console.WriteLine ("4) TOTAL DE VENTAS POR SUCURSAL: ");
            for (int b=0; b<sucursal_producto.GetLength(1);b++)
            {
                if (recaudacion[b]>mejorventas)
                {
                    mejorventas=recaudacion[b];
                    mejorsucursal=b;
                }
                Console.WriteLine ($"El total de ventas de la sucursal N#{b+1} es de: {recaudacion[b]}");
                 
            }
            Console.WriteLine();
            Console.WriteLine ($"5)  La recaudación total de la empresa es de: {total}");
            Console.WriteLine ();
            Console.WriteLine();
            Console.WriteLine ($"6) La mejor sucursal es {mejorsucursal} con ventas de: {mejorventas}");
            Console.WriteLine ();
            
        }


        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 8:  Los 5 articulos y sus cantidades vendidas

        Ejercicio_8 ventas= new Ejercicio_8();
        Console.WriteLine ();
        Console.WriteLine ("--EL PRECIO DE LOS PRODUCTOS--");
        Console.WriteLine();

        ventas.sucursales();
        ventas.totalvendido();
        

            





        }
    }
} 