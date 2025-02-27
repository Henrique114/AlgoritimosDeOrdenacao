using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgoritmosDeOrdenacao.Code.Funcoes
{
    public class SelectionSort
    {
        public List<int> Selection_Sorte(List<int> lista)
        {
            var n = lista.Count;
            for (int j = 0;  j < n - 1; j++)
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
    }
}
