using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_487_033.65;
        }
    }

    //class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        public override bool HonrarNomeFamilia() {
            return false;
        }

    class Classe_Metodo_Sealed {
        public static void Executar() {

        }
    }
}
