using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    public class CarroOpcional {
        double desconto = 0.1; //variavél privada -> private double desconto = 0.1;
        string nome;//variavél privada -> private string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriadade autoimplementada
        public double Preco { get; set;}

        //somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);
        }


    }

    class Propriedades {
        public static void Executar() {

        }
    }
}
