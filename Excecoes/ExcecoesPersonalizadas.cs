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

    }

    class ExcecoesPersonalizadas {
        public static void Executar() {

        }
    }
}
