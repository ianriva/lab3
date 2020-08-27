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
        int aleatorio, entrada, intentos = 0;
        Random rand = new Random();
        aleatorio = rand.Next(101);
        Console.WriteLine("Adivine el número (0-100), -1 para salir");
        do
        {
            try
            {
                entrada = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                entrada = -1;
            }
            intentos++;
            if (entrada == aleatorio)
            {
                Console.WriteLine("Ganó en " + intentos + " intentos!");
                break;
            } else if (entrada < aleatorio && entrada != -1){
                Console.WriteLine("Muy bajo! Intente nuevamente.");
            } else if(entrada > aleatorio){
                Console.WriteLine("Muy Alto! Intente nuevamente.");
            }
        } while (aleatorio != entrada || entrada != -1);
    }
}