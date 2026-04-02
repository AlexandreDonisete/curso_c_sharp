using System.Globalization;

namespace ex2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de testes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(" ");
                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double media = ((a * 2) + (b * 3) + (c * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
