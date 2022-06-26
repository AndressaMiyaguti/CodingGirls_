using System;
using System.Globalization;

namespace Aula07_exercicio01
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }

        public string Titular { get;private set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
        public void AtualizaNomeTitular(string titularAtualizado)
        {
            Titular = titularAtualizado;
        }
        
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia ;
        }
        public bool Sessao()
        {
            return true;
        }
        public override string ToString()
        {
            return " Conta "
                + Numero
                + "\n Titular: "
                + Titular
                + "\n Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

