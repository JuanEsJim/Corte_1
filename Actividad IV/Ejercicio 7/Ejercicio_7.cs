using System;

namespace C__proyecto
{
    class Ejercicio_7
    {
        int [,] familia = new int [1,3];
        int estrato;
        double agua,gas,luz, descuento1,descuento2,descuento3;

        public void familiar()
        {
            for (int a=0; a<familia.GetLength(1); a++)
            {
                
                Console.WriteLine ();
                Console.WriteLine ($"--FAMILIA{a+1}--");
                Console.WriteLine ();
                do
                {
                Console.WriteLine ("Ingresar el estrato de esta familia: ");
                estrato= int.Parse (Console.ReadLine());

                  if (estrato>=4)
                  {
                    Console.WriteLine();
                    Console.WriteLine ("Las familias no pueden superar el estrato 3");
                    Console.WriteLine();
                  }
                }while (estrato!=3 && estrato>=4);
                Console.WriteLine ();
                Console.WriteLine ("Ingrese el valor del recibo del agua: ");
                agua= double.Parse (Console.ReadLine());
                Console.WriteLine ();
                Console.WriteLine ("Ingrese el valor del recibo del gas: ");
                gas= double.Parse (Console.ReadLine());
                Console.WriteLine ();
                Console.WriteLine ("Ingrese el valor del recibo de la luz: ");
                luz= double.Parse (Console.ReadLine());
                 if (estrato==1)
                {
                 descuento1=agua*0.20;
                 descuento2= gas*0.20;
                 descuento3= luz*0.20;
                 Console.WriteLine ();
                 Console.WriteLine($"La familia {a+1} tiene que pagar en total: \n -En agua: {descuento1} \n -En gas: {descuento2} \n -En luz: {descuento3}");
                 Console.WriteLine ();
                }
                  if (estrato==2)
                {
                 descuento1=agua*0.15;
                 descuento2= gas*0.15;
                 descuento3= luz*0.15;
                 Console.WriteLine ();
                 Console.WriteLine($"La familia {a+1} tiene que pagar en total: \n -En agua: {descuento1} \n -En gas: {descuento2} \n -En luz: {descuento3}");
                 Console.WriteLine ();
                }
                  if (estrato==3)
                {
                 descuento1=agua*0.9;
                 descuento2= gas*0.9;
                 descuento3= luz*0.9;
                 Console.WriteLine ();
                 Console.WriteLine($"La familia {a+1} tiene que pagar en total: \n -En agua: {descuento1} \n -En gas: {descuento2} \n -En luz: {descuento3}");
                 Console.WriteLine ();
                }
            }

        }
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 7:Recibos del agua, gas y luz basados en el estrato

        Ejercicio_7 matriz= new Ejercicio_7();

        matriz.familiar();
       
        }
    }
}