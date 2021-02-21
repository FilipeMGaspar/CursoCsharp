using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Carro {
        protected readonly int VelocidadeMaxima;//Vai ser passado por herança
        private int VelocidadeAtual;

        //public Carro(){ }//Construtor padrão

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {//transmitido por herança
            int novaVelocidade = VelocidadeAtual + delta; ;//variavel interna do método
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

        public class Uno : Carro {
            public Uno() : base(200){ 
            
            }
        }

    }


    class Heranca01 {
        public static void Executar() {
            Console.WriteLine("Uno.. ");
            /*
            // Uno Carro1 = new Uno();
            //var carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            
            Console.WriteLine(carro1.Travar());
            Console.WriteLine(carro1.Travar());
            */
           
        }
    }
}
