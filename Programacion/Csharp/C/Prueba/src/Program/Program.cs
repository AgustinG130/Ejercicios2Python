using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    private static int suma(int d, int f) //metodo
    {
        d = d + f;
        return d;
    }
    static void Main()
    {
        int calculadora = 0;
        int n;
        int m;
        List<string> listaprueba = new List<string>(); //creo las variables y una lista



        Console.WriteLine("1- suma, 2-resta, 3- lista... 0-exit");
        calculadora = Convert.ToInt32(Console.ReadLine());//esto seria el equivalente en python de input(int())

        switch (calculadora)
        {
            case 1:
                Console.WriteLine("suma: ingrese su primer numero");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("suma: ingrese su segundo numero");
                m = Convert.ToInt32(Console.ReadLine()); 
                if (m < 0)
                {
                    Console.WriteLine("suma: ingrese su numero nuevamente");
                    m = Convert.ToInt32(Console.ReadLine());
                }

                /* while (m > 5)
                {
                    Console.WriteLine("s");
                } */

                Console.WriteLine("La suma es: " + (m + n));
                break;

            case 2:
                Console.WriteLine("resta: ingrese su primer numero");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("resta: ingrese su segundo numero");
                m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("La resta es: " + (m - n));
                break;

            case 3:
                Console.WriteLine("lista: ingrese un valor");
                string a = Console.ReadLine();
                listaprueba.Add(a);

                Console.WriteLine("Elementos de la lista:");
                foreach (string elemento in listaprueba) //estructura de control y bucle que permite iterar sobre una lista
                {
                    Console.WriteLine(elemento);
                }
                break;

            case 0:
                Console.WriteLine("exit");
                break;

            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
}