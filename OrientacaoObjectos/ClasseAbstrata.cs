using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim....";
        }
    }

    class ClasseAbstrata {
        public static void Executar() {
            //Celular c = new Celular(); não se pode instanciar classes abestrata
        }
    }
}
