using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];//todos os dados são do mesmo tipo e um tamanho constante
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";
            //alunos[5] = "Emanuel"; // indicie fora do ambito
        }
    }
}
