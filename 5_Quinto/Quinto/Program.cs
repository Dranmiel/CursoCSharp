using System;
using System.Globalization;

namespace Quinto {
    class Program {
        static void Main(string[] args) {
            Retangulo A = new Retangulo();
            
            Console.WriteLine("Entre a largura e a altura do retângulo: ");

            A.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            A.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + A.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + A.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + A.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
