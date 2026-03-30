

using System.Globalization;

namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = n1 + n2;

            Console.WriteLine($"Resultado: {result.ToString("F2", CultureInfo.InvariantCulture)}" );

        }
    }
}
