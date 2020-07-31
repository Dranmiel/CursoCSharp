using System;
using System.Globalization;

namespace Sextou {
    class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();
            
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + f1);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f1);

        }
    }
}
