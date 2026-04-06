using System.Globalization;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Insira a quantidade de posições do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite a {i + 1}ª altura: ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double alturaMedia = (vet[0] + vet[1] + vet[2]) / n;
            Console.WriteLine("Altura média : " + alturaMedia.ToString("F2", CultureInfo.InvariantCulture));



        }

    }
}
