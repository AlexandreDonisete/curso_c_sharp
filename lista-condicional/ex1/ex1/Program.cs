namespace ex1 {
    internal class Program {
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());

            if(num < 0) {
                Console.WriteLine("NEGATIVO");
            } else {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
