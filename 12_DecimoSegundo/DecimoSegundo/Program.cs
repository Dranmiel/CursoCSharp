using System;
using System.Collections.Generic;
using System.Globalization;

namespace DecimoSegundo {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> list = new List<Funcionario>();
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            //Laço para preencher a lista com objetos do tipo funcionário
            for (int i = 1; i <= n; i++) {
                string name;
                int id;
                double salary;
                Console.WriteLine("\nEmployee #" + i + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, name, salary));
            }

            //Pesquisa da lista de objetos pelo parâmetro id do objeto.
            Console.Write("\nEnter the employee id that will have salary increase : ");
            int idzera = int.Parse(Console.ReadLine());
            Funcionario pesquisa = list.Find(x => x.Id == idzera);
            if (pesquisa != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pesquisa.increaseSalary(percentage);

            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            //updater da lista            
            Console.WriteLine("\nUpdated list of employees: ");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
