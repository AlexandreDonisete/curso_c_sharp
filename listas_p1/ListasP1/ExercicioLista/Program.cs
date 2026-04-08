using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista {
    internal class Program {
        static void Main(string[] args) {
            List<Funcionario> listaFunc = new List<Funcionario>();

            Console.WriteLine("Quantos funcionários você quer cadastrar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"{i + 1}º Cadastro:");

                Console.Write("Insira o Id do funcionário: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Insira o Nome do funcionário: ");
                string nome = Console.ReadLine();

                Console.Write("Insira o Salário do funcionário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFunc.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Insira o Id do funcionario que receberá o aumento: ");
            int procurarId = int.Parse(Console.ReadLine());
            Funcionario func = listaFunc.Find(x => x.Id.Equals(procurarId));

            if (func != null) {
                Console.Write("Insira a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
            } else {
                Console.WriteLine("Esse Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualização da lista de funcionários:");
            foreach (Funcionario funcionario in listaFunc) {
                Console.WriteLine(funcionario);
            }

        }
    }

    internal class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario() {

        }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcetangem) {
            Salario += Salario * (porcetangem / 100);
        }

        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
