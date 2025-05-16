using System;

namespace Ejercisios
{
  public class Dado
    {
        public Dado()
        {
            int dividendo, divisor, a = 0;
            double division = 0;

            Console.WriteLine("Ingrese dos Numeros a dividir: ");
            dividendo = Convert.ToInt32(Console.ReadLine());
            divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor != 0 && (a = dividendo * 10) > 0)
            { // si el divisor *10 sea mayor que a. Asigna la variable
                division = (double)dividendo / divisor;
                Console.WriteLine($"El resultado de la division es: {division:f2}");
            }
            else
            {
                Console.WriteLine("Error.");
                Console.WriteLine("No se puede dividir un numero por 0.");
            }
        }

    }
}