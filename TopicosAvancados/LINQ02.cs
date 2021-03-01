﻿using System;
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
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno=>aluno.Nome.Equals("fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nome} {ana.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno não encontrado!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ano"));
            Console.WriteLine($"{outraAna.Nome} {outraAna.Nota}");
        }
    }
}
