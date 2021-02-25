using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {

    public static class ExtensoesInteiro {
        public static int Somar(this int num, int outroNumero) {
            return num + outroNumero;      
        }

        public static double Subtracao(this double num, int outroNumero) {
            return num - outroNumero;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            double numeroReal = 5.5;

            Console.WriteLine(numero.Somar(3));
            Console.WriteLine(numeroReal.Subtracao(10));

            Console.WriteLine(2.Somar(3));
            Console.WriteLine(5.2.Subtracao(8));
        }
    }
}
