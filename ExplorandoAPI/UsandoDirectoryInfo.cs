using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {
    class UsandoDirectoryInfo {
        public static void Executar() {
            var DirProjecto = @"~/source/repos".ParseHome();

            var dirInfo = new DirectoryInfo(DirProjecto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("...: Arquivos :.........");
            var arquivos = dirInfo.GetFiles();

            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n==Directorios ========= ");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
        }
    }
}
