using System;

namespace Actividad_2_Problema_1
{
    class Actividad_2_Problema_1
    {
        static void Main(string[] args)
        {
            //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
            //Realizado por Jonathan David Guerrero Gomez
            //Grupo 239-2A DIA
            //Turno Diurno

            int esc =5;
            double Notam = 0, Notae = 0, Notai = 0, Notaf = 0,Nota=0;
            String Nombre = "",Mensaje1="", Mensaje2 = "", Mensaje3 = "", Mensaje4 = "";

            Console.WriteLine("Problema No.1");
            Console.WriteLine("Evalua la nota de las materias");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Programa evalua como le fue en las materias al estudiante");

            for(int i=1; i<=esc ; i++)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Ingrese el nombre del estudiante");
                Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese las notas notas de las siguientes materias \n(De 0 a 100)");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Matematicas");
                Nota = int.Parse(Console.ReadLine());
                Notam = Nota;

                if (Notam < 50) 
                {
                    Mensaje1 = "Insuficiente";
                }
                else
                {
                    if (Notam < 70)
                    {
                        Mensaje1 = "Suficiente";
                    }
                    else
                    {
                        if(Notam < 80)
                        {
                            Mensaje1 = "Bien";
                        }
                        else
                        {
                            if (Notam < 90)
                            {
                                Mensaje1 = "Notable";
                            }
                            else
                            {
                                if (Notam <= 100)
                                {
                                    Mensaje1 = "Sobresaliente";
                                }
                            }
                        }
                        
                    }
                }

                if ((Nota >= 0) && (Nota <= 100))
                {
                    Console.WriteLine("Español");
                    Nota = int.Parse(Console.ReadLine());
                    Notae = Nota;

                    if (Notae < 50)
                    {
                        Mensaje2 = "Insuficiente";
                    }
                    else
                    {
                        if (Notae < 70)
                        {
                            Mensaje2 = "Suficiente";
                        }
                        else
                        {
                            if (Notae< 80)
                            {
                                Mensaje2 = "Bien";
                            }
                            else
                            {
                                if (Notae < 90)
                                {
                                    Mensaje2 = "Notable";
                                }
                                else
                                {
                                    if (Notae <= 100)
                                    {
                                        Mensaje2 = "Sobresaliente";
                                    }
                                }
                            }

                        }
                    }

                    if ((Nota >= 0) && (Nota <= 100))
                    {
                        Console.WriteLine("Ingles");
                        Nota = int.Parse(Console.ReadLine());
                        Notai = Nota;

                        if (Notai < 50)
                        {
                            Mensaje3 = "Insuficiente";
                        }
                        else
                        {
                            if (Notai < 70)
                            {
                                Mensaje3 = "Suficiente";
                            }
                            else
                            {
                                if (Notai < 80)
                                {
                                    Mensaje3 = "Bien";
                                }
                                else
                                {
                                    if (Notai < 90)
                                    {
                                        Mensaje3 = "Notable";
                                    }
                                    else
                                    {
                                        if (Notai <= 100)
                                        {
                                            Mensaje3 = "Sobresaliente";
                                        }
                                    }
                                }

                            }
                        }

                        if ((Nota >= 0) && (Nota <= 100))
                        {
                            Console.WriteLine("Fisica");
                            Nota = int.Parse(Console.ReadLine());
                            Notaf = Nota;
                            if ((Nota >= 0) && (Nota <= 100))
                            {
                                if (Notaf < 50)
                                {
                                    Mensaje4 = "Insuficiente";
                                }
                                else
                                {
                                    if (Notaf < 70)
                                    {
                                        Mensaje4 = "Suficiente";
                                    }
                                    else
                                    {
                                        if (Notaf < 80)
                                        {
                                            Mensaje4 = "Bien";
                                        }
                                        else
                                        {
                                            if (Notaf < 90)
                                            {
                                                Mensaje4 = "Notable";
                                            }
                                            else
                                            {
                                                if (Notaf <= 100)
                                                {
                                                    Mensaje4 = "Sobresaliente";
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nota no valida, vuelva ingresar la informacion del estudiantes {0}", Nombre);
                                Nota = 0;
                                i = i - 1;
                                Notaf = 0;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Nota no valida, vuelva ingresar la informacion del estudiantes {0}", Nombre);
                            Nota = 0;
                            i = i - 1;
                            Notai = 0;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Nota no valida, vuelva ingresar la informacion del estudiantes {0}", Nombre);
                        Nota = 0;
                        i = i - 1;
                        Notae = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Nota no valida, vuelva ingresar la informacion del estudiantes {0}",Nombre);
                    Nota = 0;
                    i = i - 1;
                    Notam = 0;
                }
               
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("En matematicas el estudiante {0} tuvo un resultado {1} con {2}",Nombre,Mensaje1, Notam);
                Console.WriteLine("En español el estudiante {0} tuvo un resultado {1} con {2}", Nombre, Mensaje2, Notae);
                Console.WriteLine("En ingles el estudiante {0} tuvo un resultado {1} con {2}", Nombre, Mensaje3, Notai);
                Console.WriteLine("En fisica el estudiante {0} tuvo un resultado {1} con {2}", Nombre, Mensaje4,Notaf);
                Notam = 0;
                Notae = 0;
                Notai = 0;
                Notaf = 0;
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Fin del programa");

        }
    }
}
