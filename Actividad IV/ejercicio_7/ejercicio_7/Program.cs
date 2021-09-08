using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string whilepool;
            
            int Cont = 1, notas = 0 ;
            do
            {

                //Grupo:  Juan Esteban Jimenez, Jonathan David Guerrero y Juan Diego Rodriguez Riaño  
                //Creado por Juan Esteban Jimenez Cuestas
                //Grupo 239-2A DIA
                //Turno Diurno



                Console.WriteLine("Escriba numeros de estudiantes:(max 12)");
                notas = int.Parse(Console.ReadLine());

                double a;
                string s=null;
                 

               
                string[] nombres; 
                  
                nombres = new string[13];
                if (notas < 13) {
                    for (Cont = 1; Cont <= notas ; Cont++)
                    {
                        Console.WriteLine("Nombre del estudiante: {0}", Cont);
                        nombres[Cont] = Console.ReadLine();
                        Console.WriteLine( "Escriba la nota del estudiante: {0}", Cont);
                         a= double.Parse(Console.ReadLine());

                         

                         
                         



                        switch (a)
                        {
                            case 0:
                                s = "cero";
                                break;
                            case 1:
                                s = "uno";
                                break;
                            case 1.1:
                                s = "uno punto uno";
                                break;
                            case 1.2:
                                s = "uno punto dos";
                                break;
                            case 1.3:
                                s = "uno punto tres";
                                break;
                            case 1.4:
                                s = "uno punto cuatro";
                                break;
                            case 1.5:
                                s = "uno punto cinco";
                                break;
                            case 1.6:
                                s = "uno punto seis";
                                break;
                            case 1.7:
                                s = "uno punto siete";
                                break;
                            case 1.8:
                                s = "uno punto ocho";
                                break;
                            case 1.9:
                                s = "uno punto nueve";
                                break; 
                            case 2:
                                s = "dos";
                                break;
                            case 2.1:
                                s = "dos punto uno";
                                break;
                            case 2.2:
                                s = "dos punto dos";
                                break;
                            case 2.3:
                                s = "dos punto tres";
                                break;
                            case 2.4:
                                s = "dos punto cuatro";
                                break;
                            case 2.5:
                                s = "dos punto cinco";
                                break;
                            case 2.6:
                                s = "dos punto seis";
                                break;
                            case 2.7:
                                s = "dos punto siete";
                                break;
                            case 2.8:
                                s = "dos punto ocho";
                                break;
                            case 2.9:
                                s = "dos punto nueve";
                                break;
                            case 3:
                                s = "tres";
                                break;
                            case 3.1:
                                s = "tres punto uno";
                                break;
                            case 3.2:
                                s = "dos punto dos";
                                break;
                            case 3.3:
                                s = "tres punto tres";
                                break;
                            case 3.4:
                                s = "tres punto cuatro";
                                break;
                            case 3.5:
                                s = "tres punto cinco";
                                break;
                            case 3.6:
                                s = "tres punto seis";
                                break;
                            case 3.7:
                                s = "tres punto siete";
                                break;
                            case 3.8:
                                s = "tres punto ocho";
                                break;
                            case 3.9:
                                s = "tres punto nueve";
                                break;
                            case 4:
                                s = "cuatro";
                                break;
                            case 4.1:
                                s = "cuatro punto uno";
                                break;
                            case 4.2:
                                s = "cuatro punto dos";
                                break;
                            case 4.3:
                                s = "cuatro punto tres";
                                break;
                            case 4.4:
                                s = "cuatro punto cuatro";
                                break;
                            case 4.5:
                                s = "cuatro punto cinco";
                                break;
                            case 4.6:
                                s = "cuatro punto seis";
                                break;
                            case 4.7:
                                s = "cuatro punto siete";
                                break;
                            case 4.8:
                                s = "cuatro punto ocho";
                                break;
                            case 4.9:
                                s = "cuatro punto nueve";
                                break;
                            case 5:
                                s = "cinco";
                                break;
                            case 5.1:
                                s = "cinco punto uno";
                                break;
                            case 5.2:
                                s = "cinco punto dos";
                                break;
                            case 5.3:
                                s = "cinco punto tres";
                                break;
                            case 5.4:
                                s = "cinco punto cuatro";
                                break;
                            case 5.5:
                                s = "cinco punto cinco";
                                break;
                            case 5.6:
                                s = "cinco punto seis";
                                break;
                            case 5.7:
                                s = "cinco punto siete";
                                break;
                            case 5.8:
                                s = "cinco punto ocho";
                                break;
                            case 5.9:
                                s = "cinco punto nueve";
                                break;
                            case 6:
                                s = "seis";
                                break;
                            case 6.1:
                                s = "seis punto uno";
                                break;
                            case 6.2:
                                s = "seis punto dos";
                                break;
                            case 6.3:
                                s = "seis punto tres";
                                break;
                            case 6.4:
                                s = "seis punto cuatro";
                                break;
                            case 6.5:
                                s = "seis punto cinco";
                                break;
                            case 6.6:
                                s = "seis punto seis";
                                break;
                            case 6.7:
                                s = "seis punto siete";
                                break;
                            case 6.8:
                                s = "seis punto ocho";
                                break;
                            case 6.9:
                                s = "seis punto nueve";
                                break;
                            case 7:
                                s = "siete";
                                break;
                            case 7.1:
                                s = "siete punto uno";
                                break;
                            case 7.2:
                                s = "siete punto dos";
                                break;
                            case 7.3:
                                s = "siete punto tres";
                                break;
                            case 7.4:
                                s = "siete punto cuatro";
                                break;
                            case 7.5:
                                s = "siete punto cinco";
                                break;
                            case 7.6:
                                s = "siete punto seis";
                                break;
                            case 7.7:
                                s = "siete punto siete";
                                break;
                            case 7.8:
                                s = "siete punto ocho";
                                break;
                            case 7.9:
                                s = "siete punto nueve";
                                break;
                            case 8:
                                s = "ocho";
                                break;
                            case 8.1:
                                s = "ocho punto uno";
                                break;
                            case 8.2:
                                s = "ocho punto dos";
                                break;
                            case 8.3:
                                s = "ocho punto tres";
                                break;
                            case 8.4:
                                s = "ocho punto cuatro";
                                break;
                            case 8.5:
                                s = "ocho punto cinco";
                                break;
                            case 8.6:
                                s = "ocho punto seis";
                                break;
                            case 8.7:
                                s = "ocho punto siete";
                                break;
                            case 8.8:
                                s = "ocho punto ocho";
                                break;
                            case 8.9:
                                s = "ocho punto nueve";
                                break;
                            case 9:
                                s = "nueve";
                                break;
                            case 9.1:
                                s = "nueve punto uno";
                                break;
                            case 9.2:
                                s = "nueve punto dos";
                                break;
                            case 9.3:
                                s = "nueve punto tres";
                                break;
                            case 9.4:
                                s = "nueve punto cuatro";
                                break;
                            case 9.5:
                                s = "nueve punto cinco";
                                break;
                            case 9.6:
                                s = "nueve punto seis";
                                break;
                            case 9.7:
                                s = "nueve punto siete";
                                break;
                            case 9.8:
                                s = "nueve punto ocho";
                                break;
                            case 9.9:
                                s = "nueve punto nueve";
                                break;
                            case 10:
                                s = "diez";
                                break;
                             
                              

                        }


                        if ( a <= 4.9)
                            {
                                Console.WriteLine(" {0} es insuficiente y su nota es de: {1}", nombres[Cont], s);



                        } 
                            if ( a >= 5)
                            {
                                if (a<= 6.9)
                                {
                                    Console.WriteLine(" {0} es aceptable y su nota es de: {1}", nombres[Cont], s);


                                } 
                            }
                            if (a >= 7)
                            {
                                if (a      <= 8.9)
                                {

                                    Console.WriteLine(" {0} es sobresaliente y su nota es de: {1}", nombres[Cont], s);

                                } 
                            }
                            if (a  >= 9)
                            {
                                if (a  <= 10)
                                {
                                    Console.WriteLine(" {0} es excelente y su nota es de: {1}", nombres[Cont],s);


                                }
                            }
                        


                    }
                    Console.WriteLine("¿Desea salir?(S/N):");
                    whilepool = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Se esperaba que fueran menos de 12");
                    Console.WriteLine("¿Desea salir?(S/N):");
                    whilepool = Console.ReadLine();
                }
                 
            } while (whilepool == "n" || whilepool=="N");
        }
    }
}
