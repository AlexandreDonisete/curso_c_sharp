using System.Globalization;

namespace ex3 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o valor de a: ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de b: ");
            int b = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de c: ");
            int c = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de d: ");
            int d = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int diff = (a * b) - (c * d);

            Console.WriteLine($"Resultado: {diff}");
        }
    }
}







