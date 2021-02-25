﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCsharp.MetodosFuncoes {
    class DelegateComFuncoesAnonimas {
        delegate string StringOperacao(string s);
        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

        }
    }
}
