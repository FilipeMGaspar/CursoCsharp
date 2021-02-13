using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class Pessoa {
        public string Nome; // valor padrão null 
        public int Idade; // tem valor padrão 0

        public string Apresentar() {
            return string.Format($"Olá o meu nome é {Nome} e tenho {Idade} anos"); 
        }
    }
}
