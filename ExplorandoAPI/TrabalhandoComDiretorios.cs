using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {
    class TrabalhandoComDiretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjectos = @"~/source/repos".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ==============");
            var pastas = Directory.GetDirectories(dirProjectos);
            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n..: Arquivos :..");
            var arquivos = Directory.GetFiles(dirProjectos);
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            
            
        }
    }
}
