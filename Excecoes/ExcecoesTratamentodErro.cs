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

            Saldo -= valor;
        }
    }

    class ExcecoesTratamentodErro {
        public static void Executar() {
            var conta = new Conta(1223.45);
            try {
                int.Parse("abc");
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
