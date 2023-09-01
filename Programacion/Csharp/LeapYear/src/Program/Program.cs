using System;
namespace Library;
//using Library;
public class Class1
{
public static bool IsLeap(int year)
{
    return year % 4 == 0 && (!(year % 100 == 0) || year % 400 == 0);
}

static void Main(string[] args)
{
    Console.WriteLine($"2000 es bisiesto? True : {IsLeap(2000)}");
}
}