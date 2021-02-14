using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            //Membros: Atributos e Métodos com ligação á class Pessoa

            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Renato";
            sicrano.Idade = 35;

            //Console.WriteLine($"O {sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();


            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 22;

            var apresentacaoDoFulano = fulano.Apresentar();
            //Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
