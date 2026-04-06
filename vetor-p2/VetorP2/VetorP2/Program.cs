using System.Globalization;

namespace VetorP2 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            double precoMedio = (vet[0].Preco + vet[1].Preco + vet[2].Preco) / n;

            Console.WriteLine(precoMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
