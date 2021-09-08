using System;

namespace C__proyecto
{
    class Ejercicio_5
    {
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 5: la diferencia de fecha,año, meses y dias.
            int meses,años,dias;
            string salida;
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 5: La fecha actual comparacion ");
            Console.WriteLine (" ");
            //aqui se define la fecha actual
            DateTime fecha= DateTime.Now;

            do{
            Console.WriteLine (" ");
            Console.WriteLine ("La fecha actual es: {0} ", fecha);
            Console.WriteLine (" ");
            Console.WriteLine ("Ahora ingrese una nueva fecha: ");
            Console.WriteLine (" ");
            Console.WriteLine("Escriba un año: ");
            años= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine("Escriba un mes: ");
            meses= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            Console.WriteLine("Escriba un dia: ");
            dias= int.Parse (System.Console.ReadLine());
            Console.WriteLine (" ");
            //Esto es una forma de convertir los datos ingresados en una fecha como tal
            DateTime fecha_2= new DateTime(años,meses,dias);

            //Procesos para sacar los años, meses y dias
            TimeSpan defi= fecha-fecha_2;
            //saca el total de dias de la operacion anterior y lo divide
            int año= (int) (defi.TotalDays /365.25);
            //hace lo mismo que lo anterior pero lo resta con años y lo multiplica con el numero de meses
            int mese= (int) (((defi.TotalDays/365.25)-año)*12);

            Console.WriteLine("Diferencia entre años es de: {0} ", año);
            Console.WriteLine("Diferencia entre meses es de: {0} ", mese);
            //define dias
            Console.WriteLine("Diferencia entre dias es de: {0} ", defi.Days);
           


            //asi se define que el año no puede ser mayor a 2021,el mes no puede pasar el 12 y no pueden haber ams de 365 dias
            if (años>=2021)
            {
                Console.WriteLine (" ");
                Console.WriteLine("El año no puede ser superior al 2021. ");
                Console.WriteLine (" ");
            }
            if (meses>=13)
            {
                Console.WriteLine (" ");
                Console.WriteLine("Los meses no pueden ser superior al 12. ");
                Console.WriteLine (" ");
            }
            if (dias>=365)
            {
                Console.WriteLine (" ");
                Console.WriteLine("Los dias no pueden ser superior a 365. ");
                Console.WriteLine (" ");
            }



           // esto es para salir del programa y ya.
            Console.WriteLine("¿Quiere salir del programa (S/N)");
            salida= Console.ReadLine();
             
            } while (salida!="s" && salida!="S");

            Console.WriteLine ("");
            Console.WriteLine ("Fin del programa");
            Console.WriteLine (" ");




        

        }
    }
}