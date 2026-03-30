namespace ex3 {
    internal class Program {
        static void Main(string[] args) {
            int inicio, fim, duracao;

            string[] vet = Console.ReadLine().Split(" ");
            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio >= fim) {
                duracao = fim - inicio + 24;
            } else {
                duracao = fim - inicio;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

        }
    }
}
