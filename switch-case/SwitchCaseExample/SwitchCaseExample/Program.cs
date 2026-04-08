namespace SwitchCaseExample {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número de 1 até 7:");
            int day = int.Parse(Console.ReadLine());

            string diaSemana = day switch {
                1 => "Segunda-Feira",
                2 => "Terça-Feira",
                3 => "Quarta-Feira",
                4 => "Quinta-Feira",
                5 => "Sexta-Feira",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Valor inválido!"
            };

            string s = diaSemana.Replace("feira", "cheira", StringComparison.InvariantCulture);
            Console.WriteLine(diaSemana);

        }
    }
}
