using System;

namespace Actividad_5_Problema_4
{
    class Actividad_5_Problema_4
    {
        //Grupo: Jonathan David Guerrero Gomez, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por Jonathan David Guerrero Gomez :D
        //Grupo: 239-2A DIA
        //Turno: Diurno

        double[,] Matriz = new double[5, 5];
        double[,] TranspuestaM = new double[5, 5];
        int Contador = 0, WhileLoop = 0;

        public void Ingresar()
        {
            do
            {
                try
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Ingrese los datos para llenar la matriz (Si va ingresar decimales es con ',')");

                    for (int f = 0; f < 5; f++)
                    {
                        for (int c = 0; c < 5; c++)
                        {
                            Console.Write("- ");
                            Matriz[f, c] = double.Parse(Console.ReadLine());
                            WhileLoop = 0;
                        }
                    }
                }
               catch (System.FormatException ex)
                {
                    Console.WriteLine("|----------------------------------------------------------------------------|");
                    Console.WriteLine("| SOLO SON VALIDADOS NUMEROS PUEDEN SER ENTEROS O CON DECIMALES PERO CON ',' |");
                    Console.WriteLine("|----------------------------------------------------------------------------|");
                    WhileLoop = 1;
                }
            } while (WhileLoop == 1);
        }

        public void Imprimir()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Esta es la matriz normal:\n");

            for(int f=0;f<5;f++)
            {
                for(int c=0;c<5;c++)
                {
                    Console.Write($"\t {Matriz[f, c]}");//  {Matriz[f, c+1]}  {Matriz[f, c+2]}  {Matriz[f, c+3]}  {Matriz[f, c+4]}  |");
                    Contador = Contador + 1;
                    if (Contador == 5)
                    {
                        Console.WriteLine("");
                        Contador = 0;
                    }
                }
            }
            Console.WriteLine("---------------------------------------------");
        }

        public void Transpuesta()
        {
            Console.WriteLine("Esta es la matriz transpuesta:\n");           

            for(int f=0;f<5;f++)
            {
                for(int c=0;c<5;c++)
                {
                    TranspuestaM[f, c] = Matriz[c, f];                 
                }
            }

            Contador = 0;

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write($"\t {TranspuestaM[f, c]}");// {Matriz[f, c + 1]}  {Matriz[f, c + 2]}  {Matriz[f, c + 3]}  {Matriz[f, c + 4]}  |");
                    Contador = Contador + 1;

                    if(Contador==5)
                    {
                        Console.WriteLine("");
                        Contador = 0;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            String Repetir = "";
            do
            {
                Console.WriteLine("Problema 4 - Creado por Jonathan David Guerrero Gomez :D");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("El programa es que el usuario ingresa datos a\nuna matriz 5x5 y el programa la transpone\n");

                Actividad_5_Problema_4 pv = new Actividad_5_Problema_4();
                pv.Ingresar();
                pv.Imprimir();
                pv.Transpuesta();

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("¿Desea repetir el programa?");
                Repetir = Console.ReadLine();
                Console.WriteLine("-----------------------------------------------------");
            } while (Repetir == "s" || Repetir == "S");
            Console.WriteLine("Fin del programa :D");
        }
    }
}
