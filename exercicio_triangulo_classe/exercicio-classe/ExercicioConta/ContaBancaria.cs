using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioConta {
    internal class ContaBancaria {
        static int Tax = 5;

        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() {
        }

        public ContaBancaria(int numeroConta, string nomeTitular) {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double depositoInicial):this(numeroConta, nomeTitular) {
            Depositar(depositoInicial);
        }

        public void Sacar(double valor) {
            Saldo -= (valor + Tax);
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public override string? ToString() {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
