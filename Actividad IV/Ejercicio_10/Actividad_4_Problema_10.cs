using System;

namespace Actividad_4_Problema_10
{
    class Actividad_4_Problema_10
    {
        static void Main(string[] args)
        {
            //Grupo: Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño
            //Elaborado por Jonathan David Guerrero Gomez
            //Grupo: 239-2A DIA
            //Turno: Diurno

            int Opcion = 0;
            int[] Estudiantes = new int[1];
            String Whileloop = "";

            int[] Ingles = new int[1];
            int[] Niveli = new int[3];

            int[] Frances = new int[1];
            int[] Nivelf = new int[3];

            int[] Aleman = new int[1];
            int[] Nivela = new int[3];

            int[] Ruso = new int[1];
            int[] Nivelr = new int[3];

            int[] NivelB = new int[1];
            int[] NivelM = new int[1];
            int[] NivelP = new int[1];

            do 
            { 

                Console.WriteLine("Problema No. 10 --- Jonathan David Guerrero Gomez");
                Console.WriteLine("Matriz con datos de alumnos,especificada en que nivel estan y cual es el idioma que estudia en la academia");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Bienvenido vamos a calcular el numero total de estudiantes de la academia");


                for (int i = 0; i < 4; i++)
                {
                    if (Opcion == 0)
                    {
                        Console.WriteLine("Con que materia primero le gustaria empezar y ingresar sus datos");
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("1. Ingles");
                        Console.WriteLine("2. Frances");
                        Console.WriteLine("3. Aleman");
                        Console.WriteLine("4. Ruso");
                        Console.WriteLine("¿Que opcion escogue?");
                        Opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Escoga otra opcion que no se la misma que la anterior");
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.WriteLine("1. Ingles");
                        Console.WriteLine("2. Frances");
                        Console.WriteLine("3. Aleman");
                        Console.WriteLine("4. Ruso");
                        Console.WriteLine("¿Que opcion escogue?");
                        Opcion = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------------------------");
                    }

                    switch (Opcion)
                    {
                        case 1:
                            {
                                Console.WriteLine("Escogio la opcion de INGLES");
                                Console.WriteLine("Ingrese la cantidad de estudiantes segun el nivel en el que se encuentra");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Basico");
                                Niveli[0] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Medio");
                                Niveli[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel de perfeccionamiento");
                                Niveli[2] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");

                                Ingles[0] = Niveli[0] + Niveli[1] + Niveli[2];

                                NivelB[0] = NivelB[0] + Niveli[0];
                                NivelM[0] = NivelM[0] + Niveli[1];
                                NivelP[0] = NivelP[0] + Niveli[2];

                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Escogio la opcion de FRANCES");
                                Console.WriteLine("Ingrese la cantidad de estudiantes segun el nivel en el que se encuentra");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Basico");
                                Nivelf[0] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Medio");
                                Nivelf[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel de perfeccionamiento");
                                Nivelf[2] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");

                                Frances[0] = Nivelf[0] + Nivelf[1] + Nivelf[2];

                                NivelB[0] = NivelB[0] + Nivelf[0];
                                NivelM[0] = NivelM[0] + Nivelf[1];
                                NivelP[0] = NivelP[0] + Nivelf[2];

                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Escogio la opcion de ALEMAN");
                                Console.WriteLine("Ingrese la cantidad de estudiantes segun el nivel en el que se encuentra");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Basico");
                                Nivela[0] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Medio");
                                Nivela[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel de perfeccionamiento");
                                Nivela[2] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");

                                Aleman[0] = Nivela[0] + Nivela[1] + Nivela[2];

                                NivelB[0] = NivelB[0] + Nivela[0];
                                NivelM[0] = NivelM[0] + Nivela[1];
                                NivelP[0] = NivelP[0] + Nivela[2];

                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("Escogio la opcion de RUSO");
                                Console.WriteLine("Ingrese la cantidad de estudiantes segun el nivel en el que se encuentra");
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Basico");
                                Nivelr[0] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel Medio");
                                Nivelr[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine("Nivel de perfeccionamiento");
                                Nivelr[2] = int.Parse(Console.ReadLine());
                                Console.WriteLine("---------------------------------------");

                                Ruso[0] = Nivelr[0] + Nivelr[1] + Nivelr[2];

                                NivelB[0] = NivelB[0] + Nivelr[0];
                                NivelM[0] = NivelM[0] + Nivelr[1];
                                NivelP[0] = NivelP[0] + Nivelr[2];

                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Opcion invalida, debe de escoguer una opcion valida");

                                break;
                            }
                    }
                }
                                  
                Console.WriteLine("---------------------------------------");
                Estudiantes[0] = Ingles[0] + Frances[0] + Aleman[0] + Ruso[0];

                Console.WriteLine("Resultados");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine("                          |  Ingles   |  Frances  |  Aleman  |   Ruso   |   Total   |     ");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Nivel Basico              |     {Niveli[0]}     |     {Nivelf[0]}     |     {Nivela[0]}    |     {Nivelr[0]}    |      {NivelB[0]}    |");
                Console.WriteLine($"Nivel Medio               |     {Niveli[1]}     |     {Nivelf[1]}     |     {Nivela[1]}    |     {Nivelr[1]}    |      {NivelM[0]}    |");
                Console.WriteLine($"Nivel Perfeccionamiento   |     {Niveli[2]}     |     {Nivelf[2]}     |     {Nivela[2]}    |     {Nivelr[2]}    |      {NivelP[0]}    |");
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Total de estudiantes      |     {Ingles[0]}     |     {Frances[0]}     |     {Aleman[0]}    |     {Ruso[0]}    |      {Estudiantes[0]}    |     ");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine("¿Desea volver a iniciar el programa?");
                Whileloop = Console.ReadLine();
                Console.Clear();

            } while (Whileloop == "s" || Whileloop == "S");

            Console.WriteLine("Fin del programa");
        }
    }
}
