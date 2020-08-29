using System;

namespace tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("TP-1 - Riva Ian");
            do
            {
                Console.WriteLine("Elija el ejercicio a ejecutar: (1-7), 0 para salir.");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    opcion = 99;
                }
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    case 1:
                        Ej1.Ejercicio1();
                        break;
                    case 2:
                        Ej2.Ejercicio2();
                        break;
                    case 3:
                        Ej3.Ejercicio3();
                        break;
                    case 4:
                        Ej4.Ejercicio4();
                        break;
                    case 5:
                        Ej5.Ejercicio5();
                        break;
                    case 6:
                        Ej6.Ejercicio6();
                        break;
                    case 7:
                        Ej7.Ejercicio7();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
