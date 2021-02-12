using System;
using System.Collections.Generic;

using CursoCsharp.Fundamentos;
using CursoCsharp.EstruturasDeControlo;

namespace CursoCsharp
{
    class Program {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos - Seção 3 - Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencias.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Ler Dados do Console - Fundamentos", LerDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões de Tipos de Dados - Fundamentos", ConverteTipos.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos #02 - Fundamentos", OperadoresLogicos2.Executar},
                {"Operadores de Atribuição - Fundamentos", operadorAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadoreTernario.Executar},
               
                //Estruturas de Controlo - Seção 4: Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIF.Executar},
                {"Estrutura IF/ELSE - Estruturas de Controle", Estrutura_IF_ELSE.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}