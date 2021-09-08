using System;

namespace C__proyecto
{
    class Ejercicio_6
    {
        static void Main(string[] args)
        {
        int seleccion,numeros,unidades,decenas,centenas,miles;
        string salida,valor;
        



        //Grupo: Jonathan David Guerrero, Juan Diego Rodriguez Riaño y Juan Esteban Jimenez 
        //Creado por: Juan Diego Rodriguez Riaño
        //Actividad semana2
        //Turno: Diurno
        //Codigo: 239-2A DIA

        // Problema 6: de numero a letras y de letras a numeros

        Console.WriteLine (" ");
        Console.WriteLine ("Presentado por Juan Diego Rodriguez Riaño");
        Console.WriteLine (" ");
        Console.WriteLine ("***Problema 6: De letras a numeros y de numeros a letras ");
        Console.WriteLine (" ");

        do
        {

        Console.WriteLine (" ");
        Console.WriteLine ("Menu de seleccion");
        Console.WriteLine (" ");
        Console.WriteLine ("--1)De numeros a letras ");
        Console.WriteLine ("--2)De letras a numeros ");


        Console.WriteLine ("Ingrese a que opcion quiere acceder");
        seleccion= int.Parse (System.Console.ReadLine());

        if (seleccion==1)
        {
            
        Console.WriteLine (" ");
        Console.WriteLine ("Escriba el numero que quiere convertir a letras (0 a 9999): ");
        numeros= int.Parse (System.Console.ReadLine());
         if (numeros>=0 && numeros<=9999)
         {
           //Estas cuentas ayudaran a definir los switch
          unidades= numeros%10;  numeros=numeros/10;
          decenas= numeros%10; numeros= numeros/10;
          centenas= numeros%10; numeros/= 10;
          miles= numeros%10; 
          //se definen los numeros que van del mil para mas adelante

          switch (miles)
          {
            case 0:
            Console.WriteLine(" ");break;
            case 1:
            Console.WriteLine (" mil ");break;
            case 2: 
            Console.WriteLine ("dos mil");break;
            case 3: 
            Console.WriteLine( "tres mil ");break;
            case 4:
            Console.WriteLine (" cuatro mil "); break;
            case 5: 
            Console.WriteLine (" cinco mil");break;
            case 6: 
            Console.WriteLine( " seis mil ");break;
            case 7: 
            Console.WriteLine( " siete mil ");break;
            case 8:
            Console.WriteLine (" ocho mil ");break;
            case 9: 
            Console.WriteLine (" nueve mil");break;

          }
          //se definen las centenas para mas adelante
           switch (centenas)
          {
            case 0:
            Console.WriteLine(" ");break;
            case 1:
              if (decenas==0 && unidades==0)
              {
                Console.WriteLine (" cien ");
              }
              else 
              {
                 Console.WriteLine (" ciento ");
              } break;
            case 2: 
            Console.WriteLine ("doscientos");break;
            case 3: 
            Console.WriteLine( "trescientos ");break;
            case 4:
            Console.WriteLine (" cuatrocientos ");break;
            case 5: 
            Console.WriteLine (" quinientos ");break;
            case 6: 
            Console.WriteLine( " seiscientos ");break;
            case 7: 
            Console.WriteLine( " setecientos ");break;
            case 8:
            Console.WriteLine (" ochocientos "); break;
            case 9: 
            Console.WriteLine (" novecientos "); break;

          }
          //se definen las decenas para mas adelante

          switch (decenas)
          {
            case 0:
            Console.WriteLine(" "); break;
            case 1: switch (unidades)
              {
              case 0: Console.WriteLine(" diez ");break;
              case 1: Console.WriteLine (" once ");break;
              case 2: Console.WriteLine (" doce ");break;
              case 3: Console.WriteLine( " trece ");break;
              case 4: Console.WriteLine (" catorce "); break;
              case 5: Console.WriteLine (" quince  ");break;
              case 6: Console.WriteLine( " dieceseis ");break;
              case 7: Console.WriteLine( " diecisiete ");break;
              case 8: Console.WriteLine (" dieciocho ");break;
              case 9: Console.WriteLine (" diecinueve ");break;
              } break;
            case 2: switch (unidades)
              {
              case 0: Console.WriteLine(" veinte");break;
              case 1: Console.WriteLine (" veintiuno ");break;
              case 2: Console.WriteLine (" veintidos ");break;
              case 3: Console.WriteLine( " veintitres ");break;
              case 4: Console.WriteLine (" veinticuatro "); break;
              case 5: Console.WriteLine (" veinticinco ");break;
              case 6: Console.WriteLine( " veintiseis ");break;
              case 7: Console.WriteLine( " veintisiete ");break;
              case 8: Console.WriteLine (" veinteocho ");break;
              case 9: Console.WriteLine (" veintenueve ");break;
              } break;
            case 3: if (unidades==0)
            {
              Console.WriteLine (" treinta ");
            } else {
              Console.WriteLine (" treinta y");
            }break;

            case 4: if (unidades==0)
            {
              Console.WriteLine (" cuarenta ");
            } else {
              Console.WriteLine (" cuarenta y");
            }break;

            case 5: if (unidades==0)
            {
              Console.WriteLine (" cincuenta ");
            } else {
              Console.WriteLine (" cincuenta y");
            }break;

            case 6: if (unidades==0)
            {
              Console.WriteLine (" sesenta ");
            } else {
              Console.WriteLine (" sesenta y");
            }break;

            case 7: if (unidades==0)
            {
              Console.WriteLine (" setenta ");
            } else {
              Console.WriteLine (" setenta y");
            }break;

            case 8:if (unidades==0)
            {
              Console.WriteLine (" ochenta ");
            } else {
              Console.WriteLine (" ochenta y");
            }break;

            case 9: if (unidades==0)
            {
              Console.WriteLine (" noventa ");
            } else {
              Console.WriteLine (" noventa y");
            }break;

          }

          switch (unidades)
          {
            case 0: if (miles==0 && centenas==0 && decenas==0){
              Console.WriteLine (" uno ");
            }
            else{
              Console.WriteLine ("  ");
            } break;

            case 1: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" uno ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" uno ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" uno ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" uno ");
            }
            else 
            {
              Console.WriteLine (" ");
            }
            break;




            case 2:  if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" dos ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" dos ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" dos ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" dos ");
            }
            else 
            {
              Console.WriteLine (" ");
            }
            break;


            case 3:  if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" tres ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" tres ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" tres ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" tres ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;

            case 4: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" cuatro ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" cuatro ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" cuatro ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" cuatro ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;


            case 5: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" cinco ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" cinco ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" cinco ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" cinco ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;


            case 6: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" seis ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" seis ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" seis ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" seis ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;
          

            case 7: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" siete ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" siete ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" siete ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" siete ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;


            case 8: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" ocho ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" ocho ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" ocho ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" ocho ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            break;
            

            case 9: if (miles ==0 && centenas==0 && decenas==0)
            {
              Console.WriteLine (" nueve ");
            } 
            else if (miles==0 && centenas==0 && decenas>=3)
            {
              Console.WriteLine (" nueve ");
            }
            else if (miles==0 && centenas>=1 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" nueve ");
            }
            else if (miles==1 && centenas>=0 && decenas>=3 || decenas==0)
            {
              Console.WriteLine (" nueve ");
            }
            else 
            {
              Console.WriteLine ("  ");
            }
            
            break;
          }



         }
         else
         {
           Console.WriteLine (" El numero ingresado no es valido, pues no se encuentra dentro de la lista");
         }
        }
       
      


    

        if (seleccion == 2)
        {
        Console.WriteLine (" ");
        Console.WriteLine ("Escriba el numero (letras) que quiere convertir a numeros enteros : ");
        valor=Console.ReadLine();
         switch (valor)
        {
            case "uno":
              Console.WriteLine (1);
              break;
            case "dos":
              Console.WriteLine (2);
              break;
            case "tres":
              Console.WriteLine (3);
              break;
            case "cuatro":
              Console.WriteLine (4);
              break;
            case "cinco":
              Console.WriteLine (5);
               break;
            case "seis":
              Console.WriteLine (6);
              break;
            case "siete":
              Console.WriteLine (7);
              break;
            case "ocho":
              Console.WriteLine (8);
              break;
            case "nueve":
              Console.WriteLine (9);
              break;
            case "diez":
            Console.WriteLine (10);
            break;
            case "cero":
              Console.WriteLine (0);
               break;
               
            default:
               Console.WriteLine ("Ese numero no esta dentro de la lista");
               break;

        }



        }
        

        if (seleccion >=3 )
        {
            Console.WriteLine (" ");
            Console.WriteLine ("Esta opcion no esta dentro del sistema. ");

        }


        Console.WriteLine ("¿Quieres salir del programa? (S/N)");
        salida= Console.ReadLine();

        }while (salida!="s" && salida!="S");




        }
    }
}