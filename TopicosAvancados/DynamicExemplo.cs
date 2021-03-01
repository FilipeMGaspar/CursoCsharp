using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.TopicosAvancados {
    class DynamicExemplo {
        public static void Executar() {
            dynamic meuobjecto = "teste";
            Console.WriteLine(meuobjecto);
            Console.WriteLine();
            meuobjecto = 3;
            Console.WriteLine(meuobjecto);
            meuobjecto++;
            Console.WriteLine("\n{0}", meuobjecto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
        }
    }
}
