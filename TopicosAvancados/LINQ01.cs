using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCsharp.TopicosAvancados {

    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    } 

    class LINQ01 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome ="Pedro", Idade = 24, Nota = 8.0},
                new Aluno() { Nome ="André", Idade = 21, Nota = 4.3},
                new Aluno() { Nome ="Ana", Idade = 25, Nota = 9.5},
                new Aluno() { Nome ="Jorge", Idade = 28, Nota = 8.5},
                new Aluno() { Nome ="Ana", Idade = 21, Nota = 7.7},
                new Aluno() { Nome ="Julia", Idade = 22, Nota = 7.5},
                new Aluno() { Nome ="Marcio", Idade = 18, Nota = 6.8},
            };

            Console.WriteLine("=== Aprovados ==========");
            var aprovados = alunos.Where(a => a.Idade > 24);

            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome);
            }
        }
    }
}
