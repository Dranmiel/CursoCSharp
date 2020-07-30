using System.Globalization;

namespace Quarto {
    class Produto {


        //Atributos privativos
        private string _nome;

        //Propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Construtores
        public Produto() {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
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
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
