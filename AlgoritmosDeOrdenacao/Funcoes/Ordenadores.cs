using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgoritmosDeOrdenacao.Code.Funcoes
{
    public static class Ordenadores
    {
       
        public static List<int> OrdenarPorSelecao(List<int> numeros)
        {
            // O OrdenarPorSelecao percorre toda a lista e encontra o menor numero e guarda sua posição,
            // em seguida troca a posição do numero maior pelo menor, percorrendo da posição [0] ate [n -1],
            // gerando assim uma ordenação crescente.
            var n = numeros.Count;
            for (int j = 0; j < n - 1; j++)
            {
                var indicador_menor_numero = j;
                for (int i = j; i < n; i++)
                {
                    //percorre a lista e verifica qual o menor numero
                    if (numeros[i] < numeros[indicador_menor_numero])
                    {
                        indicador_menor_numero = i;
                    }
                }
                //percorre a lista e ordena pelo menor numero
                if (numeros[j] > numeros[indicador_menor_numero])
                {
                    var aux = numeros[j];
                    numeros[j] = numeros[indicador_menor_numero];
                    numeros[indicador_menor_numero] = aux;
                }
            }
            return numeros;
        }
        public static List<int> OrdenacaoPorBolha(List<int> numeros)
        {
            // O OrdenacaoPorBolha ordena seus itens percorrendo a lista
            // e comparando seu item na posiçao atual selecionada com a posiçao posterior

            var quantidadeElementos = numeros.Count;
            // repete a iteraçao por cada item
            for (int j = 1; j < quantidadeElementos; j++)
            {

                // percorre a lista 
                for (int i = 0; i < quantidadeElementos - 1; i++)
                {
                    //troca a posição dos itens caso o iten posterior seja menor, criando assim uma ordem crescente.
                    if (numeros[i] > numeros[i + 1])
                    {
                        var aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                    }
                }
            }

            return numeros;
        }

        public static int[] OrdenarPorInsercao(int[] numeros)
        {
            //Esta ordenação consiste em comparar cada item inserido com os anteriores
            //verificando se os anteriores são maiores e mudando caso o resultado for verdadeiro.
            for (int i = 1; i < numeros.Length; i++)
            {
                var chave = numeros[i];
                var j = i - 1;
                while (j >= 0 && numeros[j] > chave) 
                {
                    numeros[j+1] = numeros[j];
                    j = j - 1;
                    
                }
                numeros[j + 1] = chave;
            }

            return numeros;
        }

        public static int[] OrdenarSeparandoEUnindo(int[] numeros, int inicio = 0, int fim = 0)
        {
            // Diviidr em listas menores, duas por vez, gerando sempre uma bifurcaçao que sera entendida
            // como lista da direita e lista da esquerda ate atingir um item por lista, apos isso, será
            // unificada levando em conta o topo de cada lista, os quais serao comparados qual é o menor
            // e assim sera inserido na lista retrocedendo as bifurcaçoes ate completar toda a lista já
            // ordenada, neste caso crescente.
            if (fim == 0)
            {
                fim = numeros.Length;
            }
            if (fim - inicio > 1)
            {
                var meio = (fim + inicio) / 2;
                OrdenarSeparandoEUnindo(numeros, inicio, meio);
                OrdenarSeparandoEUnindo(numeros, meio, fim);
                Unir(numeros, inicio, meio, fim);


            }
           
            return numeros;     


        }
        public static void Unir(int[] numeros, int inicio, int meio, int fim)
        {
            var esquerda = numeros[inicio..meio];
            var direita = numeros[meio..fim];
            var topo_direita = 0;
            var topo_esquerda = 0;

            for (int i = inicio; i < fim; i++)
            {
                if (topo_esquerda >= esquerda.Length)
                {
                    numeros[i] = direita[topo_direita];
                    topo_direita = topo_direita + 1;
                }
                else if (topo_direita >= direita.Length)
                {
                    numeros[i] = esquerda[topo_esquerda];
                    topo_esquerda = topo_esquerda + 1;
                }
                else if (esquerda[topo_esquerda] < direita[topo_direita])
                {
                    numeros[i] = esquerda[topo_esquerda];
                    topo_esquerda = topo_esquerda + 1;
                }
                else {
                    numeros[i] = direita[topo_direita];
                    topo_direita = topo_direita + 1;
                
                }
            }



        }


    }
}
