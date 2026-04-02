namespace ex6 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                double quadrado = Math.Pow(i, 2);
                double cubo = Math.Pow(i, 3);
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}
