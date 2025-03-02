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
       
        public List<int> OrdenarPorSelecao(List<int> numeros)
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
        public List<int> OrdenacaoPorBolha(List<int> numeros)
        {
            // O OrdenacaoPorBolha ordena seus itens percorrendo a lista
            // e comparando seu item na posiçao atual selecionada com a posiçao posterior

            var quantidadeElementos = numeros.Count;
            // repete a iteraçao por cada item
           for(int j = 1; j < quantidadeElementos; j ++)

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

            return numeros;
        }
    }
}
