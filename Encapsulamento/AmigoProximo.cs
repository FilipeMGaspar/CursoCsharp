using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class AmigoProximo {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine(" -- AmigoProximo --");
            Console.WriteLine();
        }
    }
}
