namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número inteiro:");
            int num = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < num; i++) {
                int numInterval = int.Parse(Console.ReadLine());
                if (numInterval >= 10 && numInterval <= 20) {
                    dentro++;
                } else {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
