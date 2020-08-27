/*
2- Codifique un programa de consola en C# que permita realizar las siguientes acciones:
Generar un número aleatorio entre 0 y 100, para ello use la función random de C#
Una vez generado el número codifique la lógica necesaria para encontrar el número
aleatorio ayudando al usuario informando al mismo si el número ingresado es mayor o
menor al número aleatorio buscado. Una vez encontrado el número muestre la cantidad
de intentos necesarios para lograrlo.
*/
using System;

public class Ej2
{
    public static void Ejercicio2()
    {
        int aleatorio;
        Random rand = new Random();
        aleatorio = rand.Next(101);
        Console.WriteLine(aleatorio);
    }
}