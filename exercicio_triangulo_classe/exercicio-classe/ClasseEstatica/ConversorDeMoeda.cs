using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseEstatica {
    internal class ConversorDeMoeda {
        static double tax = 0.06;

        public double ConverterParaDolar(double cotacao, double valorComprado) {
            double totalSemTaxa = cotacao * valorComprado;
            double totalComTaxa = totalSemTaxa * tax + totalSemTaxa;
            return totalComTaxa;
        }
    }
}
