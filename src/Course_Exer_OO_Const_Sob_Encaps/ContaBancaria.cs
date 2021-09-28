using System;
using System.Globalization;

namespace Course_Exer_OO_Const_Sob_Encaps
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string tituar)
        {
            Numero = numero;
            Titular = tituar;
        }

        public ContaBancaria (int numero, string titular, double depositoInicial) : this (numero,titular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return ($"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2",CultureInfo.InvariantCulture)}");
        }

    }
}
