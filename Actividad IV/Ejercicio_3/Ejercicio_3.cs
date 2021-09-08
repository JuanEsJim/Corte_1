using System;

namespace C__proyecto
{
    class Ejercicio_3
    {
          public static void primosaleatorios(  int [] tamaño, int z, int b)
        {
            
            int a=0;

            while (a<tamaño.Length)
            {
                Random prim= new Random();
                int nu= ((int) prim.Next( )*(z-b)+b);
                       
                if (pri(nu))
                {
                 tamaño [a]=nu;
                 a++;

                }
            

            }

    
        }
   
        private static Boolean pri (int nu)
        {
            if (nu<=1)
            {
                return false;
            }
            else
            {
                int pruebas;
                int conta=0;
                pruebas= (int) Math.Sqrt(nu);
                for (; pruebas>1;pruebas--)
                {
                    if (nu%pruebas==0)
                    {
                        conta++;

                    }

                }
                  return conta<1;
            }
           
        }

        public static void arreglo (int [] tamaño)
        {
            for (int a=0; a<tamaño.Length;a++)
            {
                Console.WriteLine ($"El indice de la operacion es {a+1} y su numero primo es: {tamaño[a]}");
            }
        }

        public void mayorymenor (int [] tamaño)
        {
            int mayorarray=0;
            int menorarray=0;

            for (int a=0; a<tamaño.Length; a++)
            {
                if (tamaño[a]>mayorarray)
                {
                    mayorarray= tamaño[a];

                }
                else if (tamaño[a]<mayorarray)
                {
                    menorarray= tamaño[a];
                }
    

            }
            Console.WriteLine (" ");
            Console.WriteLine ($"El primo mayor en la operacion es {mayorarray}");
            Console.WriteLine (" ");
            Console.WriteLine (" ");
            Console.WriteLine ($"El primo menor en la operacion es {menorarray}");
            Console.WriteLine (" ");

            
        }

 
       
        static void Main(string[] args)
        {
       
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño,
        //Actividad semana4
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 3: array con numeros aleatorios primos
            int dato;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 3: Un array con numeros aleatorios primos ");
            Console.WriteLine (" ");

            Ejercicio_3 sc= new Ejercicio_3();
            Console.WriteLine (" ");
            Console.Write ("Ingrese el tamaño del array: ");
            dato= int.Parse (Console.ReadLine());
            int [] tamaño = new int [dato];
            Console.WriteLine (" ");
            primosaleatorios(tamaño,1,100);

            arreglo (tamaño);

            sc.mayorymenor(tamaño);

      
        


        }
        
      
    }
}