using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Excecoes {

    public class Conta {
        private double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente!");
            }
        }
    }

    class ExcecoesTratamentodErro {
        public static void Executar() {

        }
    }
}
