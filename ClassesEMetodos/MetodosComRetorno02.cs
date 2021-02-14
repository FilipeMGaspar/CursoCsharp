using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    /*
    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Soma(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplica(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpa() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprime() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }
    */
    class MetodosComRetorno02 {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(8, 3);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(24, 3));


            //var calculadoraCadeia = new CalculadoraCadeia();
            //calculadoraCadeia.Soma(3).Multiplica(3).Imprime().Limpa().Imprime();
        }
    }
}
