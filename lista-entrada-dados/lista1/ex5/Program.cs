using System.Globalization;

namespace ex5 {
    internal class Program {
        static void Main(string[] args) {
            int peca1, peca2, qtdP1, qtdP2;
            double valorP1, valorP2;
            double totalP1, totalP2, total;

            string[] vetP1 = Console.ReadLine().Split(" ");
            peca1 = int.Parse(vetP1[0]);
            qtdP1 = int.Parse(vetP1[1]);
            valorP1 = double.Parse(vetP1[2], CultureInfo.InvariantCulture);


            string[] vetP2 = Console.ReadLine().Split(" ");
            peca2 = int.Parse(vetP2[0]);
            qtdP2 = int.Parse(vetP2[1]);
            valorP2 = double.Parse(vetP2[2], CultureInfo.InvariantCulture);


            totalP1 = valorP1 * qtdP1;
            totalP2 = valorP2 * qtdP2;

            total = totalP1 + totalP2;

            Console.WriteLine($"Valor a pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
