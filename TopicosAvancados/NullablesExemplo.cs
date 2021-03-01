using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {
    class NullablesExemplo {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;
            //int num3 = null; //vai dar erro

            if (num1.HasValue) {
                Console.WriteLine("VAlor de num: {0}", num1);
            } else {
                Console.WriteLine("A variavel não possui valor!");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.GetValueOrDefault();
                int y = num1.GetValueOrDefault();
                Console.WriteLine(x +y);
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
