using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Feijao {
        public double Peso;
    }

    public class Arroz {
        public double Peso;
    }

    public class Carne {
        public double Peso;
    }

    public class Pessoa {
        public double Peso;

        public void Comer(Feijao feijao) {
            Peso += feijao.Peso;
        }

        public void Comer(Arroz arroz) {
            Peso += arroz.Peso;
        }

        public void Comer(Carne carne) {
            Peso += carne.Peso;
        }
    }

    class Polimorfismo {
        public static void Executar() {

        }
    }
}
