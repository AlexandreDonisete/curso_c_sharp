using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPensionato {
    internal class Aluno {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Aluno() {

        }
        public Aluno(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string? ToString() {
            return $"{Nome}, {Email}";
        }
    }
}
