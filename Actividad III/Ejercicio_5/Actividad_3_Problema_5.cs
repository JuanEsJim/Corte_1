using System;

namespace Actividad_3_Problema_5
{
    class Actividad_3_Problema_5
    {
        static void Main(string[] args)
        {
            //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
            //Creado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            int Numerou = 0, Opcion = 0,Mostrar=0;
            int Mayor = 0, Mayor2 = 0, Mayor3 = 0, Mayor4 = 0;
            int Menor = 0, Menor2 = 0, Menor3 = 0, Menor4 = 0;
            int Unidades = 0, Decenas = 0, Miles = 0, Centenas = 0;
            string Whileloop = "";

            Console.WriteLine("Problema No. 5 ---- Creado por Jonathan David Guerrero Gomez");
            Console.WriteLine("Este programa se basa en convertir el digito ingresado en un numero mayor o menor");

            do
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Ingrese un numero de 4 cifras (NO se pueden repetir numero)");
                Numerou = int.Parse(Console.ReadLine());

                if (Numerou.ToString().Length != 4)
                {
                    Console.WriteLine("Numero invalido, tiene que ser de 4 digitos");
                }
                else
                {
                    Mostrar = Numerou;
                    Unidades = Numerou % 10; Numerou = Numerou / 10;
                    Decenas = Numerou % 10; Numerou = Numerou / 10;
                    Centenas = Numerou % 10; Numerou /= 10;
                    Miles = Numerou % 10;

                    if (Unidades == Decenas || Unidades == Centenas || Unidades == Miles)
                        Console.WriteLine("Se repitio un numero");
                    else if (Decenas == Unidades || Decenas == Centenas || Decenas == Miles)
                        Console.WriteLine("Se repitio un numero");
                    else if (Centenas == Unidades || Centenas == Decenas || Centenas == Miles)
                        Console.WriteLine("Se repitio un numero");
                    else if (Miles == Unidades || Miles == Decenas || Miles == Centenas)
                        Console.WriteLine("Se repitio un numero");
                    else
                    {

                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("                  Menu");
                        Console.WriteLine("1. Formar el numero mayor con los digitos anteriores");
                        Console.WriteLine("2. Formar el numero menor con los digitos anteriores");
                        Console.WriteLine("¿Que opcion escogue?");
                        Opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------------------------------------------");

                        switch (Opcion)
                        {
                            case 1:
                                {

                                    // 1 Opcion --------------------------------------------------------------

                                    if (Mayor == 0)
                                    {
                                        if (Miles > Centenas && Miles > Decenas && Miles > Unidades)
                                        {
                                            Mayor = Miles;
                                        }
                                        else if (Centenas > Miles && Centenas > Decenas && Centenas > Unidades)
                                        {
                                            Mayor = Centenas;
                                        }
                                        else if (Decenas > Miles && Decenas > Centenas && Decenas > Unidades)
                                        {
                                            Mayor = Decenas;
                                        }
                                        else if (Unidades > Miles && Unidades > Centenas && Unidades > Decenas)
                                        {
                                            Mayor = Unidades;
                                        }
                                        //------------------------------------------------------------
                                        if (Mayor == Miles)
                                        {
                                            if (Centenas > Decenas && Centenas > Unidades)
                                            {
                                                Mayor2 = Centenas;
                                            }
                                            else if (Decenas > Centenas && Decenas > Unidades)
                                            {
                                                Mayor2 = Decenas;
                                            }
                                            else if (Unidades > Centenas && Unidades > Decenas)
                                            {
                                                Mayor2 = Unidades;
                                            }
                                        }
                                        else if (Mayor == Centenas)
                                        {
                                            if (Miles > Decenas && Miles > Unidades)
                                            {
                                                Mayor2 = Miles;
                                            }
                                            else if (Decenas > Miles && Decenas > Unidades)
                                            {
                                                Mayor2 = Decenas;
                                            }
                                            else if (Unidades > Miles && Unidades > Decenas)
                                            {
                                                Mayor2 = Unidades;
                                            }
                                        }
                                        else if (Mayor == Decenas)
                                        {
                                            if (Miles > Centenas && Miles > Unidades)
                                            {
                                                Mayor2 = Miles;
                                            }
                                            else if (Centenas > Miles && Centenas > Unidades)
                                            {
                                                Mayor2 = Centenas;
                                            }
                                            else if (Unidades > Miles && Unidades > Centenas)
                                            {
                                                Mayor2 = Unidades;
                                            }
                                        }
                                        else if (Mayor == Unidades)
                                        {
                                            if (Miles > Centenas && Miles > Decenas)
                                            {
                                                Mayor2 = Miles;
                                            }
                                            else if (Centenas > Miles && Centenas > Decenas)
                                            {
                                                Mayor2 = Centenas;
                                            }
                                            else if (Decenas > Miles && Decenas > Centenas)
                                            {
                                                Mayor2 = Decenas;
                                            }
                                        }
                                        //------------------------------------------------------------

                                        if (Mayor2 == Centenas)
                                        {
                                            if (Mayor == Miles)
                                            {
                                                if (Unidades > Decenas)
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }
                                            else if (Mayor == Unidades)
                                            {
                                                if (Miles > Decenas)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }

                                            else if (Mayor == Decenas)
                                            {
                                                if (Miles > Unidades)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                            }

                                        }

                                        else if (Mayor2 == Miles)
                                        {
                                            if (Mayor == Unidades)
                                            {
                                                if (Centenas > Decenas)
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }
                                            else if (Mayor == Centenas)
                                            {
                                                if (Unidades > Decenas)
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }

                                            else if (Mayor == Decenas)
                                            {
                                                if (Unidades > Centenas)
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                            }
                                        }

                                        else if (Mayor2 == Unidades)
                                        {
                                            if (Mayor == Miles)
                                            {
                                                if (Centenas > Decenas)
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }
                                            else if (Mayor == Centenas)
                                            {
                                                if (Miles > Decenas)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Decenas;
                                                }
                                            }

                                            else if (Mayor == Decenas)
                                            {
                                                if (Miles > Centenas)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                            }
                                        }

                                        else if (Mayor2 == Decenas)
                                        {
                                            if (Mayor == Miles)
                                            {
                                                if (Centenas > Unidades)
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                            }
                                            else if (Mayor == Centenas)
                                            {
                                                if (Miles > Unidades)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Unidades;
                                                }
                                            }

                                            else if (Mayor == Unidades)
                                            {
                                                if (Miles > Centenas)
                                                {
                                                    Mayor3 = Miles;
                                                }
                                                else
                                                {
                                                    Mayor3 = Centenas;
                                                }
                                            }
                                        }

                                        //------------------------------------------------------------

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Centenas)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Centenas)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Decenas)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Centenas)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Centenas)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Centenas)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Centenas)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Centenas)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Miles)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Unidades)
                                        {
                                            if (Mayor2 == Miles)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Centenas)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Centenas)
                                                {
                                                    Mayor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Decenas)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Decenas)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Unidades)
                                            {
                                                if (Mayor == Centenas)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Mayor3 == Miles)
                                        {
                                            if (Mayor2 == Centenas)
                                            {
                                                if (Mayor == Unidades)
                                                {
                                                    Mayor4 = Decenas;
                                                }
                                            }
                                        }
                                    }
                                    //------------------------------------------------------------
                                

                                    Console.WriteLine($"El numero mayor que se puede hacer con {Mostrar}");
                                    Console.WriteLine($"Es {Mayor}{Mayor2}{Mayor3}{Mayor4}");
                                    Mayor = 0;
                                    Mayor2 = 0;
                                    Mayor3 = 0;
                                    Mayor4 = 0;
                                    break;
                                }

                            case 2:
                                {
                                    if (Menor == 0)
                                    {
                                        if (Miles < Centenas && Miles < Decenas && Miles < Unidades)
                                        {
                                            Menor = Miles;
                                        }
                                        else if (Centenas < Miles && Centenas < Decenas && Centenas < Unidades)
                                        {
                                            Menor = Centenas;
                                        }
                                        else if (Decenas < Miles && Decenas < Centenas && Decenas < Unidades)
                                        {
                                            Menor = Decenas;
                                        }
                                        else if (Unidades < Miles && Unidades < Centenas && Unidades < Decenas)
                                        {
                                            Menor = Unidades;
                                        }
                                        //------------------------------------------------------------
                                        if (Menor == Miles)
                                        {
                                            if (Centenas < Decenas && Centenas < Unidades)
                                            {
                                                Menor2 = Centenas;
                                            }
                                            else if (Decenas < Centenas && Decenas < Unidades)
                                            {
                                                Menor2 = Decenas;
                                            }
                                            else if (Unidades < Centenas && Unidades < Decenas)
                                            {
                                                Menor2 = Unidades;
                                            }
                                        }
                                        else if (Menor == Centenas)
                                        {
                                            if (Miles < Decenas && Miles < Unidades)
                                            {
                                                Menor2 = Miles;
                                            }
                                            else if (Decenas < Miles && Decenas < Unidades)
                                            {
                                                Menor2 = Decenas;
                                            }
                                            else if (Unidades < Miles && Unidades < Decenas)
                                            {
                                                Menor2 = Unidades;
                                            }
                                        }
                                        else if (Menor == Decenas)
                                        {
                                            if (Miles < Centenas && Miles < Unidades)
                                            {
                                                Menor2 = Miles;
                                            }
                                            else if (Centenas < Miles && Centenas < Unidades)
                                            {
                                                Menor2 = Centenas;
                                            }
                                            else if (Unidades < Miles && Unidades < Centenas)
                                            {
                                                Menor2 = Unidades;
                                            }
                                        }
                                        else if (Menor == Unidades)
                                        {
                                            if (Miles < Centenas && Miles < Decenas)
                                            {
                                                Menor2 = Miles;
                                            }
                                            else if (Centenas < Miles && Centenas < Decenas)
                                            {
                                                Menor2 = Centenas;
                                            }
                                            else if (Decenas < Miles && Decenas < Centenas)
                                            {
                                                Menor2 = Decenas;
                                            }
                                        }
                                        //------------------------------------------------------------

                                        if (Menor2 == Centenas)
                                        {
                                            if (Menor == Miles)
                                            {
                                                if (Unidades < Decenas)
                                                {
                                                    Menor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }
                                            else if (Menor == Unidades)
                                            {
                                                if (Miles < Decenas)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }

                                            else if (Menor == Decenas)
                                            {
                                                if (Miles < Unidades)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Unidades;
                                                }
                                            }

                                        }

                                        else if (Menor2 == Miles)
                                        {
                                            if (Menor == Unidades)
                                            {
                                                if (Centenas < Decenas)
                                                {
                                                    Menor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }
                                            else if (Menor == Centenas)
                                            {
                                                if (Unidades < Decenas)
                                                {
                                                    Menor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }

                                            else if (Menor == Decenas)
                                            {
                                                if (Unidades < Centenas)
                                                {
                                                    Menor3 = Unidades;
                                                }
                                                else
                                                {
                                                    Menor3 = Centenas;
                                                }
                                            }
                                        }

                                        else if (Menor2 == Unidades)
                                        {
                                            if (Menor == Miles)
                                            {
                                                if (Centenas < Decenas)
                                                {
                                                    Menor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }
                                            else if (Menor == Centenas)
                                            {
                                                if (Miles < Decenas)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Decenas;
                                                }
                                            }

                                            else if (Menor == Decenas)
                                            {
                                                if (Miles < Centenas)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Centenas;
                                                }
                                            }
                                        }

                                        else if (Menor2 == Decenas)
                                        {
                                            if (Menor == Miles)
                                            {
                                                if (Centenas < Unidades)
                                                {
                                                    Menor3 = Centenas;
                                                }
                                                else
                                                {
                                                    Menor3 = Unidades;
                                                }
                                            }
                                            else if (Menor == Centenas)
                                            {
                                                if (Miles < Unidades)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Unidades;
                                                }
                                            }

                                            else if (Menor == Unidades)
                                            {
                                                if (Miles < Centenas)
                                                {
                                                    Menor3 = Miles;
                                                }
                                                else
                                                {
                                                    Menor3 = Centenas;
                                                }
                                            }
                                        }

                                        //------------------------------------------------------------

                                        if (Menor3 == Decenas)
                                        {
                                           if(Menor2==Unidades)
                                            {
                                                if(Menor==Miles)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Decenas)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Decenas)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Menor3 == Decenas)
                                        {
                                            if (Menor2 == Unidades)
                                            {
                                                if (Menor == Centenas)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Menor3 == Decenas)
                                        {
                                            if (Menor2 == Centenas)
                                            {
                                                if (Menor == Miles)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Decenas)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }
                                      
                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Unidades)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Miles)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Unidades)
                                            {
                                                if (Menor == Miles)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Centenas)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Centenas)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Centenas)
                                            {
                                                if (Menor == Miles)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Centenas)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Centenas)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Miles;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Miles)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Unidades)
                                        {
                                            if (Menor2 == Miles)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Centenas)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Centenas)
                                                {
                                                    Menor4 = Unidades;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Unidades)
                                            {
                                                if (Menor == Decenas)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Decenas)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Centenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Unidades)
                                            {
                                                if (Menor == Centenas)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }

                                        if (Menor3 == Miles)
                                        {
                                            if (Menor2 == Centenas)
                                            {
                                                if (Menor == Unidades)
                                                {
                                                    Menor4 = Decenas;
                                                }
                                            }
                                        }
                                    }

                                    Console.WriteLine($"El numero menor que se puede hacer con {Mostrar}");
                                    Console.WriteLine($"Es {Menor}{Menor2}{Menor3}{Menor4}");
                                    Menor = 0;
                                    Menor2 = 0;
                                    Menor3 = 0;
                                    Menor4 = 0;
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Opcion no valida");
                                    break;
                                }
                        }
                    }
                    Console.WriteLine("¿Desea salir del programa? (S/N)");
                    Whileloop=Console.ReadLine();
                }
            } while(Whileloop != "S" && Whileloop != "s");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Fin del programa");
        }
    }
}