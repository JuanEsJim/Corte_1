using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Socio
    {
        private string nombre;
        private int antiguedad;

        public Socio()
        {
            Console.Write("Ingrese el nombre del socio:");
            nombre = Console.ReadLine(); ;
            Console.Write("Ingrese la antiguedad:");
            string linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene una antiguedad de " + antiguedad);
        }

        public int RetornarAntiguedad()
        {
            return antiguedad;
        }
    }


    class Club
    {
        private Socio socio1, socio2, socio3;

        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void MayorAntiguedad()
        {
            Console.Write("Socio con mayor antiguedad:");
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }

        }

        static void Main(string[] args)
        {
            Club club1 = new Club();
            club1.MayorAntiguedad();
            Console.ReadKey();
        }
    }
}