using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class Set {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 22.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("Jogo MotoGp", 35.99),
                new Produto("Poster", 10)
            };
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            Console.WriteLine();
           // carrinho.RemoveAt(3);
            foreach (var item in carrinho) {
               // Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine();
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            Console.WriteLine();
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
