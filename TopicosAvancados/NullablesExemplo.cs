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
        }
    }
}
