using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Carro {
        protected readonly int VelocidadeMaxima;//Vai ser passado por herança
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {//transmitido por herança
            int novaVelocidade = VelocidadeAtual + delta;//variavel interna do método
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

        
        /*Incorrecto com erro
         * public class Uno : Carro {
            public Uno() : base(200){ 
            
            }
        }

        public class Ferrari : Carro {
            public Ferrari() : base(350) {

            }
        }
        * Com Erro, mal instanciada deveria estar fora da class carro
        */
        
    }

    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
    }

    class Heranca01 {
        public static void Executar() {
            Console.WriteLine("Uno.. ");
            Uno carro1 = new Uno();
            //Carro.Uno carro1 = new Carro.Uno();

            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());

            Console.WriteLine();
            Console.WriteLine(carro1.Travar());
            Console.WriteLine(carro1.Travar());
            Console.WriteLine(carro1.Travar());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            //Carro.Ferrari carro2 = new Carro.Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            
            Console.WriteLine(carro2.Travar());
            Console.WriteLine(carro2.Travar());
            Console.WriteLine(carro2.Travar());
        }
    }
}
