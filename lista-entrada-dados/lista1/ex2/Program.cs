using System.Globalization;

namespace ex2 {
    internal class Program {
        static void Main(string[] args) {
            double pi = 3.14159;

            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"Resultado: {area.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}
