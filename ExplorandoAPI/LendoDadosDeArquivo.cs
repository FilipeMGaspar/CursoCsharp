using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {

    /*public static class Extensaostring {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    */
    class LendoDadosDeArquivo {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("Produto;Preco;Qtd");
                sw.WriteLine("Caneta Bic Preta;3.59;89");
                sw.WriteLine("Borracha Branca;2.89;27");
            }
        }
    }
}
