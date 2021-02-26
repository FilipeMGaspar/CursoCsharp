using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {
    class ArquivoEscrevendoDados {
        public static void Executar() {
            //var s = @"\test\testetes\a.txt";
            //Console.WriteLine(s);
            var path = @"~/primeiro_arquivo.txt";
            
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Este é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("ficheiro!");
                }
            }
        }
    }
}
