namespace EjercicioBancario
{
        class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double monto;
            CuentaCorriente cuenta = new CuentaCorriente();
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la opcion deseada:\n" +
                "1- Deposito.\n" +
                "2- Extraccón.\n" +
                "3- Consultar Saldo.\n" +
                "4- Salir.");

                Console.Write("Opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("por favor ingrese monto a Depositar.");
                        monto = Convert.ToDouble(Console.ReadLine());
                        cuenta.Depositar(monto);
                        break;
                    case 2:
                        Console.WriteLine("Por favor ingrese monto a extraer.");
                        monto = Convert.ToDouble(Console.ReadLine());

                        if (cuenta.Extraer(monto))
                        {
                            Console.WriteLine("Operacion exitosa.");
                        }
                        else
                        {
                            Console.WriteLine("No posee saldo suficiente para realizar la operacion.");
                        }

                        break;
                    case 3:
                        Console.WriteLine($"Su saldo es : ${cuenta.VerSaldo():c2}\n" +
                        $"Operaciones realizadas {cuenta.contador}");
                        break;
                    default:
                        Console.WriteLine("opcion no valida.");
                        break;
                }

                Console.WriteLine("Precione una tecla para continuar.");
                Console.ReadKey();
            } while (opcion != 4);

        }
    }
}