namespace ExercicioPensionato {
    internal class Program {
        static void Main(string[] args) {
            Aluno[] quartos = new Aluno[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdQuartos; i++) {
                Console.WriteLine($"Rent #{i + 1}: ");

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Aluno(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < quartos.Length; i++) {
                if (quartos[i] != null) {
                    Console.WriteLine(i + ": " + quartos[i].ToString());
                }
            }

        }
    }
}
