using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {
    class AtribuicaoValorVsReferencia {

        public class Dependente {
            public string Nome;
            public int Idade;
        }

        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;
        }
    }
}
