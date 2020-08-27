/*

*/
using System;

public class Ej4
{
    public static void Ejercicio4()
    {
        static double sumar(double n1, double n2)
        {
            return n1 + n2;
        }
        static double restar(double n1, double n2)
        {
            return n1 - n2;
        }
        static double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
        static double dividir(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("No se puede dividir por 0");
                throw new DivideByZeroException();
            }
            else
            {
                return n1 / n2;
            }
        }
        static double modulo(double n1, double n2)
        {
            return n1 % n2;
        }
        char operacion;
        double n1, n2;

        Console.WriteLine("Ingrese el 1er n°, puede ser decimal (con punto):");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el 2do n°, puede ser decimal (con punto):");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el operador ( + - * / % ):");
        operacion = Convert.ToChar(Console.ReadLine());
        switch(operacion){
            case '+':
                Console.WriteLine(sumar(n1,n2));
                break;
            case '-':
                Console.WriteLine(restar(n1,n2));
                break;
            case '*':
                Console.WriteLine(multiplicar(n1,n2));
                break;
            case '/':
                Console.WriteLine(dividir(n1,n2));
                break;
            case '%':
                Console.WriteLine(modulo(n1,n2));
                break;
            default:
                Console.WriteLine("Comando incorrecto.");
                break;
        }
    }
}