using System.Globalization;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(" ");
                int dividendo = int.Parse(vet[0]);
                int divisor = int.Parse(vet[1]);

                if (divisor == 0) {
                    Console.WriteLine("DivisC#o impossC-vel.");
                } else {
                    double resultado = (double)dividendo / divisor;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}