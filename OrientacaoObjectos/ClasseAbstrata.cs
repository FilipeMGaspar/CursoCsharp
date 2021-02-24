﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.OrientacaoObjectos {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim....";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá! O meu nome é Bixby!";
        }
    }



    class ClasseAbstrata {
        public static void Executar() {
            //Celular c = new Celular(); não se pode instanciar classes abestrata
        }
    }
}
