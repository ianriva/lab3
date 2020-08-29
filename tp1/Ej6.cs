/*
Programar un algoritmo recursivo que en cada recursión multiplique a si mismo un
número ingresado por el usuario hasta que el valor resultante sea mayor
100.000.000. Valide que el número ingresado por el usuario sea mayor a 1
*/
using System;

public class Ej6
{
    public static void Ejercicio6()
    {
        static double Multiplicar(double n)
        {
            n *= n;
            System.Console.WriteLine(n);
            if (n <= 100000000)
            {
                Multiplicar(n);
            }
            return n;
        }
        double numero;
        System.Console.WriteLine("Ingrese un número a multiplicar de forma recursiva:");
        numero = Convert.ToDouble(Console.ReadLine());
        Multiplicar(numero);
    }
}