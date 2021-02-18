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

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Jogo MotoGp", 35.99),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
        }
    }
}
