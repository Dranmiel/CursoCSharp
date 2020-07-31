using System;
using System.Globalization;
using System.Xml;

namespace Setimo {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado() {

            double Faltou = 60.00 - NotaFinal();

            if(NotaFinal() >= 60.00) {
                return "APROVADO";
            }
            else {
                return "REPROVADO\nFALTARAM " + Faltou.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
