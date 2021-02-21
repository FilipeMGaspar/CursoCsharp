using System;
using System.Collections.Generic;

using CursoCsharp.Fundamentos;
using CursoCsharp.EstruturasDeControlo;
using CursoCsharp.ClassesEMetodos;
using CursoCsharp.Colecoes;
using CursoCsharp.OrientacaoObjectos;

namespace CursoCsharp
{
    class Program {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos - Seção 3 - Fundamentos
                {"Primeiro Programa! - Fundamentos", PrimeiroPrograma.Executar},
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
                {"Estrutura IF/ELSE IF - Estruturas de Controle", Estrutura_IF_ELSE_IF.Executar},
                {"Estrutura SWITCH - Estruturas de Controle", Estrutura_SWITCH.Executar},
                {"Estrutura WHILE - Estruturas de Controle", Estrutura_WHILE.Executar},
                {"Estrutura DO WHILE - Estruturas de Controle", Estrutura_DO_WHILE.Executar},
                {"Estrutura FOR - Estruturas de Controle", Estrutura_FOR.Executar},
                {"Estrutura FOREACH - Estruturas de Controle", Estrutura_FOREACH.Executar},
                {"Usando BREAK - Estruturas de Controle", Usando_BREAK.Executar},
                {"Usando CONTINUE - Estruturas de Controle", Usando_CONTINUE.Executar},


                //Seção 5: Classes & Métodos
                {"Membros, Atributos e Métodos - Classes & Métodos ", Membros.Executar},
                {"Construtores, Atributos e Métodos - Classes & Métodos ", Construtores.Executar},
                {"Métodos Com Retorno 01 - Classes & Métodos ", MetodosComRetorno01.Executar},
                {"Métodos Com Retorno 02 - Classes & Métodos ", MetodosComRetorno02.Executar},
                {"Métodos Estáticos - Classes & Métodos ", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes & Métodos ", AtributosEstaticos.Executar},
                {"Desafio Acessar Atributo - Classes & Métodos ", Desafio_Acessar_Atributo.Executar},
                {"Parâmetros Variáveis - Classes & Métodos ", ParametrosVariaveis.Executar},
                {"Parâmetros Nomeados - Classes & Métodos ", ParametrosNomeados.Executar},
                {"Getters & Setters - Classes & Métodos ", Getters_e_Setters.Executar},
                {"Propriedades - Classes & Métodos ", Propriedades.Executar},
                {"Atributos Readonly - Classes & Métodos ", AtributosReadonly.Executar},
                {"Enumerações (Enum) - Classes & Métodos ", Enumeracoes.Executar},
                {"Struct - Classes & Métodos ", ExemploStruct.Executar},
                {"Class vs Struct - Classes & Métodos ", Class_Vs_Struct.Executar},
                {"Atribuição por Valor vs Referência - Classes & Métodos ", AtribuicaoValorVsReferencia.Executar},
                {"Parâmetros por Referência (Ref/Out) - Classes & Métodos ", ParametrosPorReferencia.Executar},
                {"Parâmetro com Valor Padrão - Classes & Métodos ", ParametroComValorPadrao.Executar},

                // Seção 6: Coleções
                { "Array - Coleções ", Colecoes.Array.Executar},
                { "List - Coleções ", Colecoes.List.Executar},
                { "ArrayList - Coleções ", ColecoesArrayList.Executar},
                { "Set - Coleções ", Set.Executar},
                { "Queue - Coleções ", QueueColecoes.Executar},
                { "Igualdade (Equals e GetHashCode) - Coleções ", Igualdade.Executar},
                { "Stack - Coleções ", StackColecoes.Executar},
                { "Dictionary - Coleções ", DictionaryColecoes.Executar},

                //Seção 7 - Orientação a Objetos
                { "Herança #01 - Orientação a Objetos ", Heranca01.Executar},
                { "Herança #02 - Orientação a Objetos ", Heranca02.Executar},
                { "Usando This - Orientação a Objetos ", UsandoThis.Executar},
            });
            

            central.SelecionarEExecutar();
        }
    }
}