﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        //Implementado pela IDE
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
        //Fim da implemetação através da IDE

        /*
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        // Implementado na aula 67
        public override bool Equals(object obj) {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return base.Equals(obj);
        }
        // Implementado na aula 67
        public override int GetHashCode() {
            return Nome.Length;
        }
        */
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
            
            Console.WriteLine();
            carrinho.RemoveAt(3);
            foreach (var item in carrinho) {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine();
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine();
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
