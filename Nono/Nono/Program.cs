using System;
using System.Globalization;

namespace Nono {
    class Program {
        static void Main(string[] args) {
            Conta acc;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if(resp == 's' || resp == 'S'){
                Console.Write("Digite o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc = new Conta(numero, titular, depositoInicial);
            }
            else {
                acc = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            acc.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            acc.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(acc);
        }
    }
}
