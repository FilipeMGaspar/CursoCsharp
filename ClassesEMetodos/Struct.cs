using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);// método de interface tem de ser público, definição por defeito
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    } 

    class Struct {
        public static void Executar() {

        }
    }
}
