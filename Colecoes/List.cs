using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;
    }

    public Produto(string nome, double preco) {
        Nome = nome;
        preco = preco;
    }

    class List {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 22.9);

        }
    }
}
