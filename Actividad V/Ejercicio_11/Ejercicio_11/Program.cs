using System;

namespace Ejercicio_11
{
	class Program
	{
		static void Main(string[] args)
		{
			//Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
			//Creado por Juan Esteban Jimenez Cuestas
			//Grupo 239-2A DIA
			//Turno Diurno
			//Problema 11
			Console.WriteLine("Escriba el numero de trabajadores");

			int filas = int.Parse(Console.ReadLine());


			int numfilas;
			int col, numcols;
			numfilas = filas;
			numcols = 2;
			int[] marco = new int[filas];
			int[] KMS = new int[filas];
			string[] nombres = new string[filas];
			for (int contfila = 0; contfila < numfilas; contfila++) {




				Console.WriteLine("nombre {0}", contfila+1);
				nombres[contfila] = Console.ReadLine();


				Console.WriteLine("KMS");
				int KMS_Semana = int.Parse(Console.ReadLine());
				int KMS_Semana1 = KMS_Semana * 7;
				KMS[contfila] = KMS_Semana;
				marco[contfila] = KMS_Semana1; 

			}





				 
			
			Console.WriteLine("Nombre      KMS       TOTAL KMS");
			for (int contfila = 0; contfila < numfilas; contfila++)
			{
				Console.Write(nombres[contfila]);
				Console.Write("         ");
				Console.Write(KMS[contfila]);
				Console.Write("          ");


				Console.Write(marco[contfila]);
				Console.Write("             ");

				Console.WriteLine("");



			}
		}
	}
}
