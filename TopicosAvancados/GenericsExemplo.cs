using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {

    public class Caixa<T> {
        T valorPrivado;
        
        public T Coisa { get; set; }

        public Caixa(T coisa) {

        }
    }

    class GenericsExemplo {
        public static void Executar() {

        }
    }
}
