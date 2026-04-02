namespace ExercicioPessoa {

    internal class Program {

        static void Main() {
            Console.WriteLine("Hello World");

            Pessoa p1 = new Pessoa();
            Console.WriteLine("Digite os dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Pessoa p2 = new Pessoa();
            Console.WriteLine("Digite os dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine($"A pessoa mais velha é a {p1.nome}!");
            } else if (p1.idade < p2.idade) {
                Console.WriteLine($"A pessoa mais velha é a {p2.nome}!");
            } else {
                Console.WriteLine("As duas pessoas possuem idades iguais!");
            }

        }
    }
}


