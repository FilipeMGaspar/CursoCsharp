using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() { }//Construtor padrão
    }

    public class Feijao : Comida {
        public double Peso;
    }

    public class Arroz : Comida {
        public double Peso;
    }

    public class Carne : Comida {
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
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa Cliente = new Pessoa();
            Cliente.Peso = 80.2;
            Cliente.Comer(ingrediente1);
            Cliente.Comer(ingrediente2);
            Cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {Cliente.Peso}Kg");
        }
    }
}
