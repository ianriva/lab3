/*
Cree las funciones necesarias para Calcular el sueldo de los trabajadores
dependiendo las horas trabajadas. El valor de la hora en horario diurnos (8:00 a
20:00) es de $10/hora, si el horario es nocturno (20:00 a 8:00) se incrementa en un
50%. El programa debe pedir al usuario en que horario trabajo el empleado (hora
ingreso, minuto ingreso, hora salida, minuto salida), validar que la hora/minuto de
ingreso no sea mayor a la hora/minuto de salida, validar que la cantidad de horas
trabajadas no supere las 8 horas, calcular cuantas horas trabajo en total y cuanto
corresponde pagarle. Nota: Se recomienda calcular el tiempo laboral en minutos.
*/
using System;

public class Ej5
{
    public static void Ejercicio5()
    {
        static void CalcularSueldo()
        {
            double horasTrabajadas = 0.0, salario = 0.0;
            //int tiempoDiurno = 0, tiempoNocturno = 0; 
            const int pagoDiurno = 10;
            const int pagoNocturno = 15;
            int horaEntrada, minutoEntrada, horaSalida, minutoSalida;
            do
            {
                System.Console.WriteLine("Ingrese la hora de entrada: ");
                horaEntrada = Convert.ToInt32(Console.ReadLine());
            } while (horaEntrada < 0 || horaEntrada > 23);
            do
            {
                System.Console.WriteLine("Ingrese minuto de entrada: ");
                minutoEntrada = Convert.ToInt32(Console.ReadLine());
            } while (minutoEntrada < 0 || minutoEntrada > 59);
            do
            {
                System.Console.WriteLine("Ingrese la hora de salida: ");
                horaSalida = Convert.ToInt32(Console.ReadLine());
            } while (horaSalida < 0 || horaSalida > 23);
            do
            {
                System.Console.WriteLine("Ingrese minuto de salida: ");
                minutoSalida = Convert.ToInt32(Console.ReadLine());
            } while (minutoSalida < 0 || minutoSalida > 59);
            horaEntrada = horaEntrada * 60 + minutoEntrada;
            horaSalida = horaSalida * 60 + minutoSalida;
            if (horaEntrada >= 480 && horaSalida < 1200)
            {
                salario = (horaSalida - horaEntrada) * pagoDiurno;
                horasTrabajadas = (horaSalida - horaEntrada) / 60;
            }
            else if (horaEntrada >= 1200 && horaSalida > 1200 || horaSalida < 480)
            {
                if ((horaEntrada >= 1200 && horaSalida <= 1440) || (horaEntrada >= 0 && horaSalida <= 480))
                {
                    salario = (horaSalida - horaEntrada) * pagoNocturno;
                }
                else
                {
                    horaEntrada = 1200 - horaEntrada;
                    salario = (horaSalida - horaEntrada) * pagoNocturno;
                }
            }
            // falta calcular parte de salario diurno y parte nocturno... y ordenar todo esto en funciones
            if (horasTrabajadas < 8)
            {
                System.Console.WriteLine("El salario es de: $" + salario);
            }
            else
            {
                System.Console.WriteLine("Supera las 8 hs");
            }
        }
        CalcularSueldo();
    }
}