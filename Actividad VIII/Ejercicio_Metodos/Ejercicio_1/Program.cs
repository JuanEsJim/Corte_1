using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Globalization;
using System.Threading;

namespace Ejercicio_1
{
    class Program
    {
        static void rapidin()
        {
            Console.WriteLine("paint rapido");
            Console.WriteLine("=================");
            Console.WriteLine("");

            string s1 = "****hola****";

            Console.Clear();
            Console.WriteLine("1.eliminar hacia una direccion");
            Console.WriteLine("2.Eliminar");
            int elec = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            if (elec == 1)
            {
                char[] M = { '*', 'o' };

                Console.WriteLine("");
                Console.WriteLine("desea eliminarlos de la derecha o izquierda (fin/ini)");
                string whilepool = Console.ReadLine();
                if (whilepool == "FIN" || whilepool == "fin" || whilepool == "Fin" || whilepool == "FiN")
                {
                    s1 = s1.TrimEnd(M);
                }
                if (whilepool == "Ini" || whilepool == "ini" || whilepool == "Ini" || whilepool == "InI")
                {
                    s1 = s1.TrimStart(M);
                }
            }
            if (elec == 2)
            {
                char[] quitar = { '*', 'o' };
                s1 = s1.Trim(quitar);
            }
            Console.WriteLine(s1);
        }
        static void completo()
        {
            StringBuilder s = new StringBuilder(20);
            Console.WriteLine("Escriba dos palabras");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            char[] l = new char[2];
            int st = string.Compare(s1, s2);
            s.Append("la palabra que consiguio el metodo es:");

            s1.CopyTo(0, l, 0, 0);
            int pos = Array.LastIndexOf(l, s1);
            int pos2 = Array.LastIndexOf(l, s2);
            if (st == -1)
            {
                Console.WriteLine("son casi iguales");
            }
            if (st == 0)
            {
                Console.WriteLine("son iguales");
            }
            if (st == 1)
            {
                Console.WriteLine("son diferentes");
            }
            Console.WriteLine($"la primera palabra esta en la pocision:{pos}");
            Console.WriteLine($"la segunda palabra esta en la pocision:{pos2}");
            Console.Write(s);
            Console.WriteLine(l);


        }
        static void segundojuego()
        {
            Console.WriteLine(" juegode vista: este juego es mirar la palabra por 3 segundos");
            Console.WriteLine("=============================================================");
            Random rnd = new Random();
            string[] palabras = { "Estructura de,datos", "espejo.", "YouTuBe_MiuSic" };
            int num = rnd.Next(0, 2);
            Console.WriteLine(palabras[num]);

            for (int cont = 1; cont <= 2; cont++)
            {


                TimeSpan ts = new TimeSpan(0, 0, 1);

                Thread.Sleep(ts);
                Console.Write(cont);
            }
            Console.Clear();
            Console.WriteLine("¿La palabra que salio que signo de putacion tenia?");
            string adivina1 = Console.ReadLine();
            if (num == 0)
            {
                var adivina = palabras[0];
                bool s = adivina.EndsWith(adivina1);
                if (s == true)
                {
                    Console.WriteLine("CORRECTO :D");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            if (num == 1)
            {
                var adivina = palabras[1];
                bool s = adivina.EndsWith(adivina1);
                if (s == true)
                {
                    Console.WriteLine("CORRECTO :D");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            if (num == 2)
            {
                var adivina = palabras[2];
                bool s = adivina.EndsWith(adivina1);
                if (s == true)
                {
                    Console.WriteLine("CORRECTO :D");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
        static void iva()
        {
            StringBuilder s = new StringBuilder("esto cuesta el objeto: ", 2);
            double iva = 1.19;
            Console.WriteLine("cuanto pesa o si es liquido cuando contiene");
            string peso = Console.ReadLine();
            Console.WriteLine("Cuanto cuesta su producto");
            double producto = double.Parse(Console.ReadLine());
            double TOTAL = producto * iva;
            s.AppendFormat("{0:C} ", TOTAL);
            Console.Write($"{s}-{peso}");
        }
        static void paint()
        {
            string whiloop;
            do
            {
                Console.WriteLine("diseñador de palabras ");
                Console.WriteLine("============================= ");
                Console.WriteLine("Escriba una palabra a la que quiera diseñar");
                string b;
                string a;


                b = Console.ReadLine();
                a = b;

                Console.Clear();
                Console.WriteLine("¿Desea diseñar la palabra?");
                Console.WriteLine("1.colocar palabra en mayuscula");
                string whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    b = b.ToUpper(new CultureInfo("es_MX"));
                }
                Console.WriteLine("2.colocar palabra en minuscula");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    b = b.ToLower(new CultureInfo("es_MX"));
                }
                Console.WriteLine("3.mover a la derecha o izquiera");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    Console.Clear();
                    Console.WriteLine("Izquierda o derecha(IZ/DE)");
                    string lados = Console.ReadLine();
                    if (lados == "IZ" || lados == "iz" || lados == "Iz" || lados == "iZ")
                    {
                        Console.WriteLine("cuantos espacions queire que se corra a ala izquierda");
                        int i = int.Parse(Console.ReadLine());
                        b = b.PadLeft(i);
                    }
                    if (lados == "DE" || lados == "de" || lados == "De" || lados == "dE")
                    {
                        Console.WriteLine("cuantos espacions queire que se corra a ala derecha");
                        int i = int.Parse(Console.ReadLine());
                        b = b.PadRight(i);
                    }
                }
                Console.WriteLine("4.¿Desea agregar algo?");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    Console.Clear();
                    Console.WriteLine("Que desea agregar a la palabra");
                    string l = Console.ReadLine();
                    b = b.Replace(" ", l);

                }
                Console.WriteLine("¿Desea quitar la mitad de su palabra?");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    int separar = b.IndexOf(" ");
                    int separar2 = b.IndexOf(" ", separar + 1);

                    if (separar != separar2 && separar >= 0)
                    {
                        b = b.Remove(separar + 1, separar2 - separar);


                    }
                }
                Console.WriteLine("¿Desea se pararlo por columnas?");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    string[] sub = b.Split(' ');

                    bool m = b.Equals(a);
                    if (m == true)
                    {
                        foreach (var s in sub)
                        {
                            Console.WriteLine($"{s}");
                        }
                    }

                }
                bool f = b.Equals(a);
             
                Console.WriteLine("¿Desea quitarle letras?");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    Console.Clear();
                    Console.WriteLine("¿Cuantas letras desea quitarle?");
                    int Tamletra = int.Parse(Console.ReadLine());
                    b = b.Substring(Tamletra);
                }
                Console.WriteLine("¿Desea agregarle algo a su palabra?");
                whilepool = Console.ReadLine();
                if (whilepool == "SI" || whilepool == "si" || whilepool == "Si" || whilepool == "sI")
                {
                    Console.Clear();
                    Console.WriteLine("¿Que desea agregarle?");
                    string u = Console.ReadLine();
                    Console.WriteLine("¿despues de cuantas letras?");
                    int despuesletra = int.Parse(Console.ReadLine());
                    b = b.Insert(despuesletra, u);

                }
                if (f == false)
                {
                    Console.WriteLine("RESULTADO DE SU PALABRA ES:");

                    Console.WriteLine($"-{b}");
                }
               
                Console.WriteLine("¿desea agragar otra palabra?");
                whiloop = Console.ReadLine();
                


            } while (whiloop == "SI" || whiloop == "si" || whiloop == "Si" || whiloop == "sI");

        }
        static void juego()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Vamos  JUGAR un juego :D");
            Console.WriteLine("=========================");
            const int tamaño_palabra = 10;
            string[] words = { "acepciones", "fabricador", "videojuego", "habitantes" };
            double[] keys = new double[tamaño_palabra];
            string[] letters = new string[tamaño_palabra];
            Random rnd = new Random();


            foreach (string word in words)
            {
                for (int ctr = 0; ctr < word.Length; ctr++)
                {
                    keys[ctr] = rnd.NextDouble();
                    letters[ctr] = word[ctr].ToString();
                }
                Array.Sort(keys, letters, 0, tamaño_palabra, Comparer.Default);
                string scrambledWord = String.Concat(letters[0], letters[1], letters[2], letters[3], letters[4], letters[5],
                letters[4], letters[5], letters[6], letters[7], letters[3], letters[8], letters[9]);
                Console.WriteLine("{0}", scrambledWord);
                string palabraale = Console.ReadLine();
                bool e = words.Contains(palabraale);
                if (e == true)
                {
                    Console.WriteLine("CORRECTO :D");

                }
                else
                {
                    Console.WriteLine("MAL D:");
                }
               
            }
        }
        static void hora()
        {
            Console.WriteLine("mes:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("dia:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("año:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("hora:");
            int o = int.Parse(Console.ReadLine());
            Console.WriteLine("minutos:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("segundos:");
            int s = int.Parse(Console.ReadLine());

            var tiempo = new DateTime(i, t, a, o, p, s);
            Console.WriteLine("idioma");
            Console.WriteLine("1. español");
            Console.WriteLine("2. Italiano");
            Console.WriteLine("3. ingles");
            int idiom = int.Parse(Console.ReadLine());
            
            if (idiom == 1)
            {
                Console.WriteLine(tiempo.ToString("F", new System.Globalization.CultureInfo("es_MX")));
            }
            if (idiom == 2)
            {
                Console.WriteLine(tiempo.ToString("F", new System.Globalization.CultureInfo("it_IT")));
            }
            if (idiom == 3)
            {
                Console.WriteLine(tiempo.ToString("F", new System.Globalization.CultureInfo("en_US")));
            }


        } 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hecho po: Juan Esteban Jimenez Cuestas");
            Console.WriteLine("================================");
            Console.Write("");
            Console.WriteLine("Lista");
            Console.WriteLine("1.numeros a calendario :)");
            Console.WriteLine("2.Adivina la palabra(Juegoo)");
            Console.WriteLine("3.Paint de palabras");
            Console.WriteLine("4.productos con iva");
            Console.WriteLine("5.juego de vista");
            Console.WriteLine("6.paint rapido con palabra");
            Console.WriteLine("7.comparacion entre palabras");

            int leer = int.Parse(Console.ReadLine());
            Console.Clear();
            if (leer == 1)
            {
                hora();
            }
            if (leer == 2)
            {
                juego();  
            }
            if (leer == 3)
            {
                paint();
            }
            if (leer == 4)
            {
                iva();        
            }
            if (leer == 5)
            {
                segundojuego();
            }
            if (leer == 6)
            {
                rapidin();
            }
            if (leer == 7)
            {
                completo();
            }
        }
        
    }
}
