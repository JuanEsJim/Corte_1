using System;

namespace C__proyecto
{
    
    class Ejercicio_2
    {
        int []lol = new int [0];
        int cantidad,suma;
        string salida;
        private void aleatorio()
        {
            Random aleatorios = new Random ();

        }

        public void numeros()
        {
            do
            {
            Console.WriteLine ("Inserte el tamaño del array: ");
            cantidad= int.Parse (Console.ReadLine());
            int []can = new int [cantidad];
            Console.WriteLine (" ");
            aleatorio();
            

            for (int a=0; a< can.Length ; a++)
            {  
                Random aleatorios = new Random ();
                can [a]= aleatorios.Next (0,9)+1;
                suma+=can[a];
                Console.WriteLine (" ");
                Console.WriteLine ($"El valor de la posicion {a+1} es de { can[a]} ");
              
                Console.WriteLine (" ");
            }
            Console.WriteLine (" ");
            Console.WriteLine ($"La suma de todos los valores es {suma}");
            Console.WriteLine (" ");   
            suma=0;
            Console.WriteLine (" ¿Quieres salir del programa? (S/N) ");
            salida= Console.ReadLine();
            Console.WriteLine (" ");
            

            }while (salida!="S" && salida!="s");

            
            Console.WriteLine (" Fin del programa. De enter para borrar la pantalla ");
            Console.WriteLine (" ");
            Console.ReadKey();
            Console. Clear();
            
        }
        static void Main(string[] args)
        {
        
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño,
        //Actividad semana4
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 2: números aleatorios entre 0 y 9
             
        Console.WriteLine (" ");
        Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
        Console.WriteLine (" ");
        Console.WriteLine ("***Problema 2: números aleatorios entre 0 y 9");
        Console.WriteLine (" ");

            Ejercicio_2 sc= new Ejercicio_2();
            sc.aleatorio();
            sc.numeros();




        }
    }
}