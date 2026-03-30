using System.Globalization;

namespace ex6 {
    internal class Program {
        static void Main(string[] args) {
            double a, b, c, pi = 3.14159;

            string[] vetNum = Console.ReadLine().Split(" ");

            a = double.Parse(vetNum[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetNum[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetNum[2], CultureInfo.InvariantCulture);

            double areaTriangulo = (a * c) / 2;
            double areaCirculo = pi * Math.Pow(c, 2);
            double areaTrapezio = ((a + b) * c) / 2;
            double areaQuadrado = Math.Pow(b, 2);
            double areaRetangulo = a * b;

            Console.WriteLine($"Triangulo {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            

        }
    }
}
