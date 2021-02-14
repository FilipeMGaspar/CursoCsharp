using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class OperadoreTernario
    {
        public static void Executar()
        {
           //operador Ternário
            var nota = 5.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado"; //Operador ternário
            Console.WriteLine(resultado);
        }
    }
}
