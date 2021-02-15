using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class AtributosEstaticos {

        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {

        }

        public double CalculadoraDesconto() {
            return Preco - Preco * Desconto;
        }
        public static void Executar() {

        }
    }
}
