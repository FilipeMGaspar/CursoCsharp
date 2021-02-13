using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_FOREACH
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
