using System;

namespace ContaBancaria
{
    class Programa
    {
        static void Main(string[] args)
        {
            double depositoInicial = 0;
            string resposta;

            do
            {
                Console.WriteLine("Deseja fazer um depósito inicial? (Digite '1' para SIM ou '0' para NÃO):");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("Digite o valor do depósito inicial:");
                    depositoInicial = double.Parse(Console.ReadLine());
                }
                else if (resposta == "0")
                {
                    Console.WriteLine("Nenhum depósito inicial será realizado.");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, digite '1' para SIM ou '0' para NÃO.");
                }

            } while (resposta != "1" && resposta != "0");

            Conta conta = new Conta(100934, "Charleu", depositoInicial);
            Console.WriteLine(conta);
            Console.WriteLine("\nDigite o valor para depósito:");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);
            Console.WriteLine("\nDigite o valor para saque:");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);
            Console.ReadKey();
        }
    }
}