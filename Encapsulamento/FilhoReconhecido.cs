using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class FilhoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("** FilhoReconhecido! **");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);

        }
    }
}
