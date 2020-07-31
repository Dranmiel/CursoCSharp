using System.Globalization;
using System.Windows.Markup;

namespace Nono {
    class Conta {

        //Atributos privativos
        private string _nome;
        private double _tarifa = 5.00;
        //Propriedades autoimplementadas
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        //Construtores
        public Conta(int numero, string nome) {
            Numero = numero;
            _nome = nome;
        }
        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome) {
            Deposito(depositoInicial);
        }

        //Propiedades customizadas
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }
        //Métodos da classe
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= (quantia + _tarifa);
        }
        public override string ToString() {
            return
                "Conta " +
                Numero +
                ", Titular: " +
                _nome +
                ", Saldo: $ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
