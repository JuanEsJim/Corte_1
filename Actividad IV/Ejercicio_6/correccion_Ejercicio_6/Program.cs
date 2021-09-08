using System;

namespace correccion_Ejercicio_6
{
    class Program
    {

             static void Main(string[] args)
            {

                int[] num;
                int texto;
                num= new int[300];



                 
                Console.WriteLine("introduce un tamaño");
                texto = int.Parse(Console.ReadLine());
                num[texto] = num[texto]; 

                int ultimodi;
                do
                {
                    Console.WriteLine("introduce numero entre 0 y 9");
                    ultimodi = int.Parse(Console.ReadLine());
                } while (!(ultimodi >= 0 && ultimodi <= 9));

                  rellenar(num, 1, 300);

            int[] terminadosen = numterminados(num, ultimodi);

                 
                mostrarterminados(terminadosen);

             } 
        public static void rellenar(int[] lista, int a, int b)
        {

            for (int i = 0; i < lista.Length; i++)
            {

                double number, number2;
                Random rnd = new Random();
                number = rnd.NextDouble();
                number2 = number * (a - b) + b;
                lista[i] = (int)Math.Floor(number2);

            }
        }



        public static void mostrarterminados(int[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {

                if (lista[i] != 0)
                {
                    Console.WriteLine("El numero " + lista[i] + " acaba en el numero deseado");
                }
            }
        }

        public static int[] numterminados(int[] num, int ultimo_numero)
        {


            int[] terminadosen = new int[num.Length];

            int numeroFinal = 0;

            for (int i = 0; i < terminadosen.Length; i++)
            {



                numeroFinal = num[i] - (num[i] / 10 * 10);


                if (numeroFinal == ultimo_numero)
                {
                    terminadosen[i] = num[i];
                }
            }

            return terminadosen;
        }






    }
}


