namespace Library;
//using Library;
using System;
public class Class1
{
/* Implementar la diferencia simétrica de dos listas. La diferencia simétrica consiste en
 todos los elementos de la primera lista que no están en la segunda y de todos los
elementos de la segunda lista que no están en la primera.
Por ejemplo symdif([1, 2, 3], [3, 4, 5]) devuelve [1, 2, 4, 5]. El resultado no debe tener
duplicados. */
public static List<int>SymDiff(List<int>list1, List<int>list2)
{

    List<int>diferencia = new List<int>();

    foreach (int elemento in list1)
    {
        if (!list2.Contains(elemento))
        {
             diferencia.Add(elemento);
        }
    }
           
    foreach (int elemento in list2)
    {
        if (!list1.Contains(elemento))
        {

            diferencia.Add(elemento);

        }
           
    }
        
    return diferencia;

}

 static void Main(string[] args)
    {
        List<int> resultado = SymDiff(new List<int>{ 1, 2, 3 }, new List<int>{ 3, 4, 5 });

        foreach (int n in resultado)
        {
            Console.WriteLine(n);
        }
    }
}