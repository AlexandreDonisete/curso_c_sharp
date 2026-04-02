using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_classe {
    internal class Triangulo {
        public double A;
        public double B;
        public double C;

        public double CalcularArea(double A, double B, double C) {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }

    }
}
