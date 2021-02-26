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


        }
    }
}
