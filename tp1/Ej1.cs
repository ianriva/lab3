/*
1- Muestra los números del 1 al 100 (ambos incluidos) divisibles entre 2 y 5. 
Utiliza las iteraciones for, while, do/while para resolver el mismo problema.
*/
using System;
public class Ej1
{
    public static void Ejercicio1()
    {
        Console.WriteLine("Usando for");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Usando while:");
        int a = 1;
        while (a <= 100)
        {
            if (a % 2 == 0 || a % 5 == 0)
            {
                Console.WriteLine(a);
            }
            a++;
        }
        Console.WriteLine("Usando do/while:");
        int b = 1;
        do
        {
            if (b % 2 == 0 || b % 5 == 0)
            {
                Console.WriteLine(b);
            }
            b++;
        } while (b<=100);
    }
}