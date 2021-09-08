using System;

namespace Actividad_4_Problema_12
{
    class Actividad_4_Problema_12
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //CREADO por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int Año = 0;
            int ContadorSemana = 0;

            int[] Meses = new int[13];
            int[] Dias = new int[31];

            int NumerosEventos = 0;
            int[] EventoMes = new int[365];
            int[] EventoDia = new int[365];
            int[] EventoHora = new int[365];
            string[] EventoConcepto = new string[365];

            Console.WriteLine("Problema No. 12 --- Creado por Jonathan David Guerrero Gomez");
            Console.WriteLine("Este programa esta diseñado para que agende eventos en el calendario ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el año al cual va a agendar");
            Año = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------------");

            Console.WriteLine($"Bienvenido vamos agendar eventos futuros para el año {Año}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Este es el calendario del {Año}");
            Console.WriteLine("-----------------------------------------------------------");

            for (int w = 1; w <= 12; w++)
            {
                int z = zeller(Año, w);
                ContadorSemana = 0;
                for (int k = 0; k < z; k++)
                {
                    ContadorSemana = ContadorSemana + 1;
                    Console.Write(" \t");
                }
            }


            for (int a = 1; a <= 12; a++)
            {
                Meses[a] = a;

                if (Meses[a] == 1 || Meses[a] == 3 || Meses[a] == 5 || Meses[a] == 7 || Meses[a] == 8 || Meses[a] == 10 || Meses[a] == 12)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"MES: {a}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                    for (int w = 1; w < 2; w++)
                    {
                        int z = zeller(Año, a);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }

                        for (int i = 1; i <= 31; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                    }
                }

                if (Meses[a] == 2)
                {
                    Console.WriteLine($"MES: {a}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                    for (int w = 1; w < 2; w++)
                    {
                        int z = zeller(Año, a);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }

                        for (int i = 1; i <= 28; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                    }
                }

                if (Meses[a] == 4 || Meses[a] == 6 || Meses[a] == 9 || Meses[a] == 11)
                {
                    Console.WriteLine($"MES: {a}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                    for (int w = 1; w < 2; w++)
                    {
                        int z = zeller(Año, a);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }

                        for (int i = 1; i <= 30; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                    }
                }
                Console.WriteLine("\n-----------------------------------------------------------");
            }


            Console.WriteLine($"¿Cuantos eventos desea ingresar para el año {Año}?");
            NumerosEventos = int.Parse(Console.ReadLine());

            for (int q = 0; q < NumerosEventos; q++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                if (q == 0)
                {
                    Console.WriteLine("En que mes desea ingresar un evento");
                }
                else
                {
                    Console.WriteLine("En que mes desea ingresar el siguiente evento");
                }
                EventoMes[q] = int.Parse(Console.ReadLine());


                if (EventoMes[q] == 1 || EventoMes[q] == 3 || EventoMes[q] == 5 || EventoMes[q] == 7 || EventoMes[q] == 8 || EventoMes[q] == 10 || EventoMes[q] == 12)
                {
                    Console.WriteLine($"MES: {EventoMes[q]}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                    if (EventoMes[q] == 1)
                    {
                        int z = feller1(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 3)
                    {
                        int z = feller3(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 5)
                    {
                        int z = feller5(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 7)
                    {
                        int z = feller7(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 8)
                    {
                        int z = feller8(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 10)
                    {
                        int z = feller10(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 12)
                    {
                        int z = feller12(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    for (int i = 1; i <= 31; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                    
                }

                if (EventoMes[q] == 2)
                {
                    Console.WriteLine($"MES: {EventoMes[q]}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                        int h = feller2(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < h; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }

                        for (int i = 1; i <= 28; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                }

                if (EventoMes[q] == 4 || EventoMes[q] == 6 || EventoMes[q] == 9 || EventoMes[q] == 11)
                {
                    Console.WriteLine($"MES: {EventoMes[q]}");
                    Console.WriteLine("\nDom\tLun\tMar\tMie\tJue\tVie\tSab");

                    if (EventoMes[q] == 4)
                    {
                        int z = feller4(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 6)
                    {
                        int z = feller6(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 9)
                    {
                        int z = feller9(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    if (EventoMes[q] == 11)
                    {
                        int z = feller11(Año);
                        ContadorSemana = 0;
                        for (int k = 0; k < z; k++)
                        {
                            ContadorSemana = ContadorSemana + 1;
                            Console.Write(" \t");
                        }
                    }

                    for (int i = 1; i <= 30; i++)
                        {
                            Console.Write($"{i}\t");
                            ContadorSemana = ContadorSemana + 1;

                            if (ContadorSemana == 7)
                            {
                                Console.WriteLine("");
                                ContadorSemana = 0;
                            }
                        }
                    
                }
                Console.WriteLine("\n-----------------------------------------------------------");

                Console.WriteLine($"Para que dia del mes {EventoMes[q]}");
                EventoDia[q] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese la hora del evento del dia {EventoDia[q]} (Formato 24 horas)");
                EventoHora[q] = int.Parse(Console.ReadLine());

                Console.WriteLine("¿Cual va hacer el evento?");
                EventoConcepto[q] = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Evento Guardado. \n {EventoConcepto[q]} a las {EventoHora[q]} el dia {EventoDia[q]} del mes {EventoMes[q]} del {Año}");
                Console.WriteLine("-----------------------------------------------------------");

            }

            Console.WriteLine($"Fin del programa, sus eventos para el año {Año} son:\n");

            for(int i=0;i<NumerosEventos;i++)
            {
                Console.WriteLine($"{i+1}. {EventoConcepto[i]} a las {EventoHora[i]} el dia {EventoDia[i]} del mes {EventoMes[i]} del {Año}");
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Fin del programa, Creado por Jonathan David Guerrero Gomez");
        }


        private static int zeller(int Año, int Meses)
        {
            int a = (14 - Meses) / 12;
            int y = Año - a;
            int m = Meses + 12 * a - 2;
            int dia = 1, d;

            d = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (d);
        }



        private static int feller1(int Año)
        {
            int a = (14 - 1) / 12;
            int y = Año - a;
            int m = 1 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller2(int Año)
        {
            int a = (14 - 2) / 12;
            int y = Año - a;
            int m = 2 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller3(int Año)
        {
            int a = (14 - 3) / 12;
            int y = Año - a;
            int m = 3 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller4(int Año)
        {
            int a = (14 - 4) / 12;
            int y = Año - a;
            int m = 4 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller5(int Año)
        {
            int a = (14 - 5) / 12;
            int y = Año - a;
            int m = 5 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller6(int Año)
        {
            int a = (14 - 6) / 12;
            int y = Año - a;
            int m = 6 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller7(int Año)
        {
            int a = (14 - 7) / 12;
            int y = Año - a;
            int m = 7 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller8(int Año)
        {
            int a = (14 - 8) / 12;
            int y = Año - a;
            int m = 8 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller9(int Año)
        {
            int a = (14 - 9) / 12;
            int y = Año - a;
            int m = 9 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller10(int Año)
        {
            int a = (14 - 10) / 12;
            int y = Año - a;
            int m = 10 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller11(int Año)
        {
            int a = (14 - 11) / 12;
            int y = Año - a;
            int m = 11 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


        private static int feller12(int Año)
        {
            int a = (14 - 12) / 12;
            int y = Año - a;
            int m = 12 + 12 * a - 2;
            int dia = 1, g;

            g = (dia + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            return (g);
        }


    }
}
