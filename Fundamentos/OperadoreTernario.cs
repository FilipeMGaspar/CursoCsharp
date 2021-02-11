using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class OperadoreTernario
    {
        public static void Executar()
        {
            var nota = 7.0;
            string resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; //Operador ternário
            Console.WriteLine(resultado);
        }
    }
}
