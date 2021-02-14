using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class CalculadoraComum1 {
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
    
    class MetodosComRetorno02 {
        public static void Executar() {
            var calculadoraComum1 = new CalculadoraComum1();
            var resultado = calculadoraComum1.Somar(10, 3);

            Console.WriteLine("Calculadora Comum");
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum1.Subtrair(10, 20));
            Console.WriteLine(calculadoraComum1.Multiplicar(6, 2));
            Console.WriteLine(calculadoraComum1.Dividir(27, 3));
            
            Console.WriteLine();
            Console.WriteLine("Calculadora em cadeia");
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Soma(3).Multiplica(3).Imprime().Limpa().Imprime();

            resultado = calculadoraCadeia.Soma(5).Multiplica(5).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
