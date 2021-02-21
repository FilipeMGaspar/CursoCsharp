using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Carros {
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carros(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int variacao) {
            int novaVelocidade = VelocidadeAtual + variacao;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Travar() {
            return AlterarVelocidade(-5);
        }

        public class Uno : Carros {
            public Uno() : base(200) {

            }
        }

        public class Ferrari : Carros {
            public Ferrari() : base(350) {

            }

            public override int Acelerar() {
                return AlterarVelocidade(15);
            }
        }
    }

    class Heranca02 {
        public static void Executar() {
            Console.WriteLine("..: Uno :..");
            Carros.Uno carro1 = new Carros.Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Travar());
            Console.WriteLine(carro1.Travar());
            Console.WriteLine(carro1.Travar());

            Console.WriteLine();
            Console.WriteLine(" *** ..: Ferrari :.. *** ");
            Carros.Ferrari carro2 = new Carros.Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Travar());
            Console.WriteLine(carro2.Travar());
            Console.WriteLine(carro2.Travar());
        }
    }
}
