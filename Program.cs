using System;
using System.Globalization;

namespace AtividadeFinal {
    internal class Program {
        static void Main(String[] args) {

            Console.Write("Informe o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string nomeConta = Console.ReadLine();

            Conta c = new Conta(numeroConta, nomeConta);

            Console.Write("Haverá depósito inicial (s/n)? ");
            string deposito = Console.ReadLine();
            if (deposito == "s") {
                Console.Write("Informe o valor do depósito inicial: ");
                c.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c.Numero}, Titular: {c.Nome}, Saldo: $ {c.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Entre com um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valorDeposito);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c.Numero}, Titular: {c.Nome}, Saldo: $ {c.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Entre com um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valorSaque);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c.Numero}, Titular: {c.Nome}, Saldo: $ {c.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");





        }
    }
}
