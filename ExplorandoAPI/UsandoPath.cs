﻿using System;
using System.IO;

namespace CursoCsharp.ExplorandoAPI {
    class UsandoPath {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    sw.WriteLine("Um novo Arquivo Criado!");
                }
            }


        }
    }
}
