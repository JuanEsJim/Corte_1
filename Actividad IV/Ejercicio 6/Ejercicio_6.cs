using System;

namespace C__proyecto
{
    class Ejercicio_6
    {
        int numeroalumnos,calificacion1,calificacion2,calificacion3,estudiantealto,promedioalto=0;
        int cali,cali2,cali3, promediogeneral,promedio, b;
        private int [] arreglo;
        public void alumnos()
        {
       Console.WriteLine();
            Console.WriteLine ("Ingrese el numero de estudiantes a calificar: ");
            numeroalumnos= int.Parse (Console.ReadLine());
            Console.WriteLine();

            arreglo= new int [numeroalumnos];

            for (int a=0; a<arreglo.Length; a++)
            {
            Console.WriteLine();
            Console.WriteLine ($"Ingrese la calificacion del estudiante {a+1}");
             Console.WriteLine();
             Console.WriteLine ("Examen 1: ");
             calificacion1= int.Parse (Console.ReadLine());
             Console.WriteLine();
             cali+=calificacion1;
             Console.WriteLine ("Examen 2: ");
             calificacion2= int.Parse (Console.ReadLine());
             cali2+=calificacion2;
             Console.WriteLine();
             Console.WriteLine ("Examen 3: ");
             calificacion3= int.Parse (Console.ReadLine());
             cali3+=calificacion3;
             promedio= (calificacion1+calificacion2+calificacion3)/3;
             
             Console.WriteLine ("--------");
             Console.WriteLine ($"El promedio del estudiante {a+1} es de: {promedio}");
             Console.WriteLine ("--------");
            if (promedio>promedioalto)
            {
                  promedioalto=promedio;  
                  b=a+1;  
            }

            }
             
             
               
            

            promediogeneral= (cali+cali2+cali3)/3;
            Console.WriteLine ();
            Console.WriteLine ($"El estudiante con el promedio mas alto es el numero {b} y el promedio es: {promedioalto}");
            Console.WriteLine ();

            Console.WriteLine ();
            Console.WriteLine ($"El promedio general del grupo es de: {promediogeneral}");
            Console.WriteLine ();
        }
        static void Main(string[] args)
        {
        
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 6: N alumnos y 3 exámenes.

        Ejercicio_6 alum = new Ejercicio_6();
        alum.alumnos();
        }
    }
}