using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();

            sicrano.Nome = "Renato";
            sicrano.Idade = 35;

            //Console.WriteLine($"O {sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();


        }
    }
}
