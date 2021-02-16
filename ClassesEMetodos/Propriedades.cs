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
            var op1 = new CarroOpcional("Ar condicionadao", 3499.9);
            Console.WriteLine("Preço com Desconto :" + op1.PrecoComDesconto);

            //op1.PrecoComDesconto = 3000; //Impossivel de realizar pois o Método é só de leitura 

            var op2 = new CarroOpcional();
            op2.Nome = "Direção elética";
            op2.Preco = 2349.89;

            //Console.Writeline(op1.Nome);
            Console.Write(op1.Nome);
            Console.Write(" | Preço: " + op1.Preco);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(op2.Nome);
            Console.Write(" | Preço: "+ op2.Preco);
            Console.Write(" | Preço com Desconto: " + op2.PrecoComDesconto);
            Console.WriteLine();
        }
    }
}
