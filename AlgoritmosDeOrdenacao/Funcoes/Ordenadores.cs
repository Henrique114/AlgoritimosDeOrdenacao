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
    public class Ordenadores
    {
       
        public List<int> Selection_Sorte(List<int> lista)
        {
            // O Selection_sorte percorre toda a lista e encontra o menor numero e guarda sua posição,
            // em seguida troca a posição do numero maior pelo menor, percorrendo da posição [0] ate [n -1],
            // gerando assim uma ordenação crescente.
            var n = lista.Count;
            for (int j = 0; j < n - 1; j++)
            {
                var min_index = j;
                for (int i = j; i < n; i++)
                {
                    //percorre a lista e verifica qual o menor numero
                    if (lista[i] < lista[min_index])
                    {
                        min_index = i;
                    }
                }
                //percorre a lista e ordena pelo menor numero
                if (lista[j] > lista[min_index])
                {
                    var aux = lista[j];
                    lista[j] = lista[min_index];
                    lista[min_index] = aux;
                }
            }
            return lista;
        }
        public List<int> Buble_Sort(List<int> lista)
        {
            // O Buble_Sort ordena seus itens percorrendo a lista
            // e comparando seu item na posiçao atual selecionada com a posiçao posterior
            var quantidadeElementos = lista.Count;
            // repete a iteraçao por cada item
           for(int j = 1; j < quantidadeElementos; j ++)

            // percorre a lista 
            for (int i = 0; i < quantidadeElementos - 1; i++)
            {
                //troca a posição dos itens caso o iten posterior seja menor, criando assim uma ordem crescente.
                if (lista[i] > lista[i + 1])
                {
                    var aux = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = aux;
                }
            }

            return lista;
        }
    }
}
