using System;

namespace Ejercisios
{
    public class Adivinanza
    {
        public Adivinanza()
        {
            #region definicion de variables
            Random dato = new Random();
            int numero, azar;
            int intentos = 0;
            bool gano = false;
            #endregion
            
            azar = dato.Next(10) + 1;
            Console.WriteLine(azar);
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero == azar)
                    gano = true;
                intentos++;


            } while (!gano && intentos < 3);
            if (gano)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                for (int f = 12; f < 18; f++)
                {

                    for (int c = 40; c < 80; c++)
                    {
                        Console.SetCursorPosition(c, f);
                        Console.Write("*");
                    }
                    Console.SetCursorPosition(65, 10);
                    Console.WriteLine($"Gano en {intentos} intentos");
                }

            }
            else
            {
                Console.WriteLine($"Perdiste el numero que fue elegido al azar es :{azar}");
            }

        }
    }
}