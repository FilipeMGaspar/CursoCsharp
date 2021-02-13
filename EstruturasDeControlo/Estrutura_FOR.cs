using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.EstruturasDeControlo
{
    class Estrutura_FOR
    {
        public static void Executar()
        {
            int i = 0;

            while(i <= 10)
            {
                Console.WriteLine($"O valor de i é {i}");
                i +=2;
            }
        }

    }
}
