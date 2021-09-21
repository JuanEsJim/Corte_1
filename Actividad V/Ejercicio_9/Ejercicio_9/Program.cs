using System;

namespace Ejercicio_9
{
    class Program
    {
		static void Main(string[] args)
		{
			//Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
			//Creado por Juan Esteban Jimenez Cuestas
			//Grupo 239-2A DIA
			//Turno Diurno
			//Problema 9
			int[,] marco=new int[5,15];

			int num_filas, num_cols;
			int col;
			num_filas = 5;
			num_cols = 15;
			for (int fila = 0; fila < num_filas; fila++) {
				 
				for (col = 0; col < num_cols; col++)
				{

					if (fila == 0 || fila == num_filas - 1 || col == 0 || col == num_cols - 1)
					{

						marco[fila, col] = 1;
					}
	
					else
					{

						marco[fila, col] = 0;
					}



				}
			}

			for (int fila = 0; fila < num_filas ; fila++) {
				for (col = 0; col < num_cols ; col++) {
					 Console.Write(marco[fila, col]);
				}
				Console.WriteLine("");

			}
			
		}
    }
}
