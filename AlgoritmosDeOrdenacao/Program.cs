using System.Linq;
using AlgoritmosDeOrdenacao.Code.Funcoes;
using AlgoritmosDeOrdenacao.Code.Listas;

namespace AlgoritmosDeOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaDesordenadosA = ListasParaTeste.DesordenadosAleatorios();
            Console.WriteLine("--Lista Aleatoria--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < listaDesordenadosA.Length; i++)
            {
                Console.Write(" " + listaDesordenadosA[i] + ",");
            }

            var OrdenadosA = Ordenadores.OrdenarPorFusão(listaDesordenadosA);

            Console.WriteLine("");
            Console.Write("Lista Ordenada:   ");
            for (int i = 0; i < listaDesordenadosA.Length; i++)
            {
                Console.Write(" "+OrdenadosA[i] + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________");



            Console.WriteLine("--Lista simples--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < ListasParaTeste.desordenados.Length; i++)
            {
                Console.Write(" " + ListasParaTeste.desordenados[i] + ",");
            }

            var ordenarSimples = Ordenadores.OrdenarPorFusão(ListasParaTeste.desordenados);
            Console.WriteLine("");
            Console.Write("Lista Ordenada:   ");
            for (int i = 0; i < ordenarSimples.Length; i++)
            {
                Console.Write(" " + ordenarSimples[i] + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________");


        }
    }
}
