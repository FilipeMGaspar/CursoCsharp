using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Fundamentos
{
    class OperadoresLogicos2
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou Tv 50 {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou sorbete {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32: {0}", comprouTv32);
        }
    }
}
