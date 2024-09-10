using System;

namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        
        private double Taxa = 5.00;
        public Conta(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Conta(int numeroConta, string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + Taxa;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"\nConta: {NumeroConta}\nTitular: {Nome}\nSaldo atual: {Saldo.ToString("C")}");
        }
    }
}