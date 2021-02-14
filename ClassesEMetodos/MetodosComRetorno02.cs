using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }
    class MetodosComRetorno02 {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(8, 3);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            Console.WriteLine(calculadoraComum.Dividir(24, 3));
        }
    }
}
