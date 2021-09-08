using System;

namespace C__proyecto
{
    class Ejercicio_12
    {
    int votantes,jeison,lucia,nuñez,blanco,a, ganador;

    public void votaciones()
    {
        Console.WriteLine (" ");
        Console.WriteLine ("Ingresar el numero de votantes (No puede ser inferior a 20) ");
        votantes= int.Parse (System.Console.ReadLine());
        if (votantes<20)
        {
         Console.WriteLine ("El numero ingresado de votantes no es suficiente ");
        }
        if (votantes>20)
        {
         for (a=0;a<votantes;a++)
         {
         Console.WriteLine ($"Seleccione un candidato votante N{a+1}: ");
         ganador= int.Parse (Console.ReadLine());
         switch (ganador)
         {
             case 1:
             jeison=jeison+1;
             break;

             case 2:
             lucia=lucia+1;
             break;

             case 3:
             nuñez=nuñez+1;
             break;

             default:
             blanco=blanco+1;
             break;

         }

         }

         if (jeison>lucia && jeison>nuñez)
         {
            Console.WriteLine (" ");
            Console.WriteLine ($"El ganador de las votaciones a consejo estudiantil es el candidato Jeison con {jeison} votos");
            Console.WriteLine (" ");
         }
         if (lucia>jeison && lucia>nuñez)
         {
            Console.WriteLine (" ");
            Console.WriteLine ($"El ganador de las votaciones a consejo estudiantil es la candidata Lucia con {lucia} votos");
            Console.WriteLine (" ");
         }
         if (nuñez>lucia && nuñez>jeison)
         {
            Console.WriteLine (" ");
            Console.WriteLine ($"El ganador de las votaciones a consejo estudiantil es la candidata Nuñez con {nuñez} votos");
            Console.WriteLine (" ");
         }
          if (blanco>lucia && blanco>jeison && blanco>nuñez)
         {
            Console.WriteLine (" ");
            Console.WriteLine ($"El voto en blanco prevalece con una cantidad de {blanco} votos");
            Console.WriteLine (" ");
         }


        }
        
    }

        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez Cuestas
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana3
        //Turno: Diurno
        //Codigo: 239-2A DIA
        // Problema 12 los votantes
           
            Console.WriteLine (" ");
            Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine (" ");
            Console.WriteLine ("***Problema 12: Los votantes ");
            Console.WriteLine (" ");
            Console.WriteLine (" ");
            Console.WriteLine ("----BIENVENIDOS A LAS SELECCIONES DEL CONSEJERO ESTUDIANTIL, EN BREVE INICIAMOS LAS VOTACIONES---");
            Console.WriteLine (" ");
            Console.WriteLine ("Candidatos: \n1)Jeison\n2)Lucia\n3)Nuñez\nCualquier otro numero es voto en blanco");
            Ejercicio_12 sc = new Ejercicio_12();
            sc.votaciones();


            





        }
    }
}