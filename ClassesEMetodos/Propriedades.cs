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
        public double Preco { get; set; }

        //propriedade somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Notação lambda
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
}
    }

    class Propriedades {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionadao",11959.89);
            Console.WriteLine(op1.PrecoComDesconto);
        }
    }
}
