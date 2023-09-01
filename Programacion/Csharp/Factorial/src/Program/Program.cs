using System;
namespace Library;
// Calcular el factorial de un número N. Plantear la solución utilizando la
// estructura WHILE y la estructura FOR.
class Program
{   
public static int FactorialFor(int n)
{
    int r = 1;
    for (int i = 1; i <= n; i++)
        r = r * i;
    return r;
}


public static int FactorialWhile(int n)
{
    int r = 1;
    int i = 1;
    while (i <= n)
    {
        r = r * i;
        i += 1;
    }
    return r;
}

static void Main(string[] args)
{

    Console.WriteLine($"El factorial de 5 es: {FactorialFor(5)}");
    Console.WriteLine($"El factorial de 5 es: {FactorialWhile(5)}");

}
}