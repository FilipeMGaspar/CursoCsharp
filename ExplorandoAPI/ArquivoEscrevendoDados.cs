using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {
    public static class Extensaostring {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~",home);
        }
    }

    class ArquivoEscrevendoDados {
        public static void Executar() {
            //var s = @"\test\testetes\a.txt";
            //Console.WriteLine(s);
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Este é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("ficheiro!");
                }
            }

            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais Texto!!");
            }
        }
    }
}
