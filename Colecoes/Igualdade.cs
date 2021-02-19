using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            // Produto contem string nome e double preco

            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            Console.WriteLine();
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
