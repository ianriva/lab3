/*
Explique y ejemplifique los métodos para el manejo de cadenas en C#, Lenght,
Contains, IndexOf, Remove, Replace, Substring, Append, ToUpper, ToLower.
*/
using System;

public class Ej7
{
    public static void Ejercicio7()
    {
        // Lenght
        System.Console.WriteLine("Lenght muestra la longitud de un arreglo");
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        System.Console.WriteLine(cars);
        Console.WriteLine(cars.Length);

        //Contains
        System.Console.WriteLine("Contains muestra si algo en particular está dentro de un string");
        string text = "Texto de prueba"; 
        System.Console.WriteLine(text);
        System.Console.WriteLine(text.Contains("de"));

        //IndexOf
        System.Console.WriteLine("IndexOf muestra el índice de lo que se busca en el arreglo si es que se encuentra");
        System.Console.WriteLine(text.IndexOf("x"));

        //Remove 
        System.Console.WriteLine("Remove elimina los elementos desde el indice que se indica");
        System.Console.WriteLine(text.Remove(1,2));
        //Replace 
        System.Console.WriteLine("Replace reemplaza un caracter por otro");
        System.Console.WriteLine(text.Replace('x','s'));
        //Substring 
        System.Console.WriteLine("Substring devuelve una nueva cadena que es parte de la cadena original");
        System.Console.WriteLine(text.Substring(4,3));
        //Append 
        System.Console.WriteLine("Append agrega cadena al final de un objeto StringBuilder");
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        System.Console.WriteLine(sb.Append(text));
        //ToUpper 
        System.Console.WriteLine("ToUpper transforma la cadena a mayúsculas");
        System.Console.WriteLine(text.ToUpper());
        //ToLower
        System.Console.WriteLine("ToLower transforma la cadena a minúsculas");
        System.Console.WriteLine(text.ToLower());

    }
}