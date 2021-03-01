﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {

    public class Caixa<T> {
        T valorPrivado;
        
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { 
        }
    }

    class GenericsExemplo {
        public static void Executar() {

        }
    }
}
