using System;
using System.Collections.Generic;

using CursoCsharp.Fundamentos;

namespace CursoCsharp
{
    class Program {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}