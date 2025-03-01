using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDeOrdenacao.Code.Listas
{
    class ListasParaTeste
    {

        // Listas para testes
        // - numeros desordenados:
        public List<int> desordenados = [50, 48, 33, 99, 45, 22, 34, 11, 57, 1, 5, 9];

        // - numeros desordenados repitidos:
        public List<int> desordenadosRepitidos = [4, 4, 6, 5, 6, 5, 1, 1, 1, 2, 1, 6, 2, 2, 2];

        // - numeros ordenados decrescente:
        public List<int> ordenadosDecrescente = [90, 80, 77, 55, 44, 40, 35, 33, 20, 10, 1];

        // - numeros desordenados aleatorios:
        public List<int> Desordenados_Aleatorios()
        {
            Random randon = new();

            List<int> lista = new();
            for (int i = 0; i < 12; i++)
            {
                lista.Add(randon.Next(100));
            }
            //var dec = lista.OrderByDescending(n => n).ToList();

            return lista;
        }

    }
}
