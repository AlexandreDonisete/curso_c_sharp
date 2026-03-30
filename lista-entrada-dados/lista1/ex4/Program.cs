using System.Globalization;

namespace ex4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número do funcionário: ");
            int idFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o quanto ganha por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = valorHora * horas;
            Console.WriteLine();
            Console.WriteLine($"Número: {idFunc}");
            Console.WriteLine($"Salário: U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
