namespace ex4 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int resultado = fatorial(n);

            Console.WriteLine(resultado);

        }
        public static int fatorial(int num) {
            if (num == 0) {
                return 1;
            }
            return num * fatorial(num - 1);
        }
    }
}
