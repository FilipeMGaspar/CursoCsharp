using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = Nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro: ..: {nome} :.. incluido");
        }
    }

    class UsandoThis {
        public static void Executar() {

        }
    }
}
