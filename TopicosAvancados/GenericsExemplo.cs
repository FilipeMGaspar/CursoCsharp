using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {

    public class Caixa<T> {
        T valorPrivado;
        
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class GenericsExemplo {
        public static void Executar() {

        }
    }
}
