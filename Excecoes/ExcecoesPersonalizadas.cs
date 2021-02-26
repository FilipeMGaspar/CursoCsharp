using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Excecoes {

    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas {

        public static int PositivoPar() {
            Random randon = new Random();
            int valor = randon.Next(-30, 30);

            if(valor < 0) {

            }

        }

        public static void Executar() {

        }
    }
}
