using System.Globalization;

namespace DecimoSegundo {
    class Funcionario {

        //Propriedades autoimplementadas
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        //Construtores
        public Funcionario(int id) {
            Id = id;
        }
        public Funcionario(int id, string name, double salary) : this(id) {
            Name = name;
            Salary = salary;
        }

        //Métodos da classe
        public void increaseSalary(double percentage) {
            Salary *= (1 + percentage / 100.0);
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
