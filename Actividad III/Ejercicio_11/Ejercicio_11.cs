using System;

namespace C__proyecto
{
    class Ejercicio_11
    {
        String genero,salida;
        int sueldo, empleado,legajo,a,mujer,hombre,suma1,suma2;
        int canhombre,canmujer;

        public void ejercicio()
        {
            Console.WriteLine (" ");
            Console.WriteLine ("Escriba el numero de empleados: ");
            empleado= int.Parse (System.Console.ReadLine());

            for (a=0; a<empleado; a++)
            {
                Console.WriteLine (" ");
                Console.WriteLine ($"Escriba el genero del empleado {a+1} (M/H)");
                genero= Console.ReadLine();

                if (genero == "M" || genero == "m")
                {
                canmujer=canmujer+1;
                Console.WriteLine (" ");
                Console.WriteLine ("Escriba el legajo del empleado: ");
                legajo= int.Parse (System.Console.ReadLine ());
                Console.WriteLine (" ");
                Console.WriteLine ("Escriba el sueldo del empleado: ");
                sueldo= int.Parse (System.Console.ReadLine ());
                if (sueldo>=1000000)
                 {
                    mujer++;
                 }
                 suma1=sueldo+sueldo;

                }

                if (genero == "H" || genero == "h")
                {
                canhombre=canhombre+1;
                Console.WriteLine (" ");
                Console.WriteLine ("Escriba el legajo del empleado: ");
                legajo= int.Parse (System.Console.ReadLine ());
                Console.WriteLine (" ");
                Console.WriteLine ("Escriba el sueldo del empleado: ");
                sueldo= int.Parse (System.Console.ReadLine ());
                if (sueldo<=900000)
                 {
                    hombre++;
                 }
                 suma2=sueldo+sueldo;
                }


            }

            Console.WriteLine (" ");
            Console.WriteLine ($"La cantidad de empleados dentro de la empresa son: {empleado}");
            Console.WriteLine ($"La cantidad de mujeres dentro de la empresa es de: {canmujer}");
            Console.WriteLine ($"La cantidad de hombres dentro de la empresa es ed: {canhombre}");
            Console.WriteLine ($"La cantidad de mujeres que tienen un sueldo superior a 1.000.000 son: {mujer} ");
            Console.WriteLine ($"La cantidad de hombres que tienen un sueldo inferior a 900.000 son: {hombre} ");
            Console.WriteLine ($"El sueldo en total de las mujeres es de: {suma1} ");
            Console.WriteLine ($"El sueldo en total de los hombres es de: {suma2} ");

        }
        
        
        
        static void Main(string[] args)
        {
       
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana3
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 11: La empresa
           
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 11: La empresa ");
            Console.WriteLine (" ");
            Ejercicio_11 sc = new Ejercicio_11();
            sc.ejercicio();
            



        }
    }
}