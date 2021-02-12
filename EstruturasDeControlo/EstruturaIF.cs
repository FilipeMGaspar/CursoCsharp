using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a Nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

        }
    }
}
