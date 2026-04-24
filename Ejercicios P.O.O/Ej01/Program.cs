using System;

namespace Ej01
{
    //Crear CuentaBancaria con saldo privado y metodos Depositar/Retirar.
    public class CuentaBancaria
    {
        private decimal _saldo;

        //Usar readonly para el ID de cuenta generado en constructor.
        private readonly string _numeroCuenta;

        public string NumeroCuenta => _numeroCuenta;

        private string _pin;

        public string Titular { 
            get; 
            private set; 
        }

        public CuentaBancaria(string titular, string numero)
        {
            Titular = titular;
            _numeroCuenta = numero;
            _saldo = 0;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
                _saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            //Agregar validacion en Retirar: no retirar mas del saldo.
            if (monto > 0 && monto <= _saldo)
                _saldo -= monto;
        }

        public decimal ObtenerSaldo() => _saldo;

        public string pin
        {
            //Crear propiedad de solo escritura(solo set).
            set
            {
                _pin = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuenta = new CuentaBancaria("Tamara Britez", "1");
            cuenta.Depositar(5000);

            //Demostrar que _saldo no es accesible directamente desde afuera.
            Console.WriteLine(cuenta._saldo);
        }
    }
}
