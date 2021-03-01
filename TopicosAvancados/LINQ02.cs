using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp.TopicosAvancados {
    class LINQ02 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome ="Pedro", Idade = 24, Nota = 8.0},
                new Aluno() { Nome ="André", Idade = 21, Nota = 4.3},
                new Aluno() { Nome ="Ana", Idade = 25, Nota = 9.5},
                new Aluno() { Nome ="Jorge", Idade = 20, Nota = 8.5},
                new Aluno() { Nome ="Ana", Idade = 21, Nota = 7.7},
                new Aluno() { Nome ="Julia", Idade = 22, Nota = 7.5},
                new Aluno() { Nome ="Marcio", Idade = 18, Nota = 6.8},
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));

        }
    }
}
