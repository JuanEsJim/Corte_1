using System;

namespace C__proyecto
{
    class Ejercicio_7
    {
        static void Main(string[] args)
        {
        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 7: Indicar la cantidad de vocales, cantidad de números y cantidad de consonantes
        string contenido,salida;
        int vocala=0,consonante=0,a=0,numero;
        Console.WriteLine (" ");
        Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
        Console.WriteLine (" ");
        Console.WriteLine ("***Problema 7: Indicar la cantidad de vocales, cantidad de números y cantidad de consonantes ");
        Console.WriteLine (" ");

        do
        {
            Console.WriteLine (" ");
            Console.WriteLine ("Escriba la frase que quiere ingresar: ");
            contenido= Console.ReadLine();

            //length sirve para hacer la cuenta del string
        
        
                for (a=0; a<contenido.Length;a++)
                {
                    
                     if (contenido[a]=='a' || contenido [a]== 'e' || contenido [a]== 'i' || contenido [a]== 'o' || contenido[a] == 'u')
                    {
                        vocala++;

                    }

                    else if (contenido[a]=='A' || contenido [a]== 'E' || contenido [a]== 'I' || contenido [a]== 'O' || contenido[a] == 'U')
                    {
                        vocala++;
                    }


                    if (contenido[a]=='B' || contenido[a] =='C' || contenido[a] =='D' || contenido[a]=='F' || contenido[a]=='G' || contenido[a]=='H' || contenido[a]=='J' || contenido[a]=='K' || contenido[a]=='L' || contenido[a]=='M' || contenido[a] =='N' || contenido[a] =='Ñ' || contenido[a]=='P' || contenido[a]=='Q' || contenido[a]=='R' || contenido[a]=='S' || contenido[a]=='T' || contenido[a]=='V' || contenido[a]=='W' || contenido[a]=='X' || contenido[a] =='Y' || contenido[a]=='Z' )
                     {
                     consonante++;
                     }
                   else if  (contenido[a]=='b' || contenido[a] =='c' || contenido[a] =='d' || contenido[a]=='f' || contenido[a]=='g' || contenido[a]=='h' || contenido[a]=='j' || contenido[a]=='k' || contenido[a]=='l' || contenido[a]=='m' || contenido[a] =='n' || contenido[a] =='ñ' || contenido[a]=='p' || contenido[a]=='q' || contenido[a]=='r' || contenido[a]=='s' || contenido[a]=='t' || contenido[a]=='v' || contenido[a]=='w' || contenido[a] =='x' || contenido[a] =='y' || contenido[a]=='z' )
                     {
                     consonante++;
                     }
              
              
                }



               
           
            Console.WriteLine (" ");
            Console.WriteLine ("La frase escrita es {0}", contenido);
            Console.WriteLine (" ");
            Console.WriteLine ("La cantidad de consonantes dentro de la frase es {0}", consonante);
            Console.WriteLine (" ");
            Console.WriteLine ("La cantidad de vocales dentro de la frase es de {0}", vocala);
            numero= contenido.Length;
            Console.WriteLine (" ");
            Console.WriteLine ("La frase {0} tiene {1} caracteres",contenido,numero);

            a=0;
            consonante=0;
            vocala= 0;
            numero=0;
        
            
            Console.WriteLine (" ");
            Console.WriteLine ("¿Desea salir del sistema? (S/N)");
            salida= Console.ReadLine();

        }while (salida!="S" && salida !="S");

        
        
        }
    }
}