namespace EjercicioBancario
{
  class CuentaCorriente
    {
        public int contador=0;
        private double saldoCuenta = 0;
        public double VerSaldo()
        {
            contador++;
            return saldoCuenta;
        }

        public void Depositar(double monto)
        {
            contador++;
            saldoCuenta += monto;

        }
        public bool Extraer(double monto)
        {
            contador++;
            bool tieneSaldo = false;

            if (monto <= saldoCuenta)
            {
                saldoCuenta -= monto;
                tieneSaldo = true;
            }
            return tieneSaldo;
        }

    }
}