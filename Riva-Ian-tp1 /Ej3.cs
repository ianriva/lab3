/*

*/
using System;

public class Ej3
{
    public static bool esPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static void Ejercicio3()
    {
        int num;
        Console.WriteLine("Ingrese un número para saber si es par:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(esPar(num));
    }
}