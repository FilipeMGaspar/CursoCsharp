using System;
using Encapsulamento;


namespace CursoCsharp.OrientacaoObjectos {

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("## FilhoNãoReconhecido ##");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento {
        public static void Executar() {
            
        }
    }
}
