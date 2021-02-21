﻿using System;
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
    }


    class Heranca01 {
        public static void Executar() {

        }
    }
}
