using System;
using System.Collections.Generic;
using System.Text;

namespace Oitavo {
    class ConversorDeMoeda {
        public static double IOF = 0.06;

        public static double Conversao(double cotacao, double quantia) {
            return quantia * cotacao * (1 + IOF);
        }
    }
}
