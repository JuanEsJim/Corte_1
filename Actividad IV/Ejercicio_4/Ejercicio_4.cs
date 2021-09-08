using System;

namespace C__proyecto
{
    class Ejercicio_4
    {
    int [] posicion = new int [100];
    int suma_de_array=0;
    double media_array;
    public void proceso ()
    {

        for (int a=0 ; a<posicion.Length;a++)
        {
            posicion[a]=a+1;
            suma_de_array+=posicion[a];
        }
        media_array= suma_de_array/posicion.Length;
            
        Console.WriteLine (" ");
        Console.WriteLine ($"La suma de los 100 arrays es igual a {suma_de_array}");    
        Console.WriteLine (" ");
        Console.WriteLine ($"La media de los 100 arrays es igual a {media_array}");
        Console.WriteLine (" ");
    }

        static void Main(string[] args)
        {
         //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño,
        //Actividad semana4
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 4: array de 100 con su suma y media
             
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 4: Array de 100 con suma y media ");
            Console.WriteLine (" ");

            Ejercicio_4 sc= new Ejercicio_4();
            sc.proceso();





        }
    }
}