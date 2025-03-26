using System.Linq;
using AlgoritmosDeOrdenacao.Code.Funcoes;
using AlgoritmosDeOrdenacao.Code.Listas;

namespace AlgoritmosDeOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("--Lista Aleatoria--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < ListasParaTeste.oDesordenadosAleatorios.Length; i++)
            {
                Console.Write(" " + ListasParaTeste.oDesordenadosAleatorios[i] + ",");
            }

            Ordenadores.OrdenarPorSelecao(ListasParaTeste.oDesordenadosAleatorios);

            Console.WriteLine("");
            Console.Write("Lista Ordenada:   ");
            for (int i = 0; i < ListasParaTeste.oDesordenadosAleatorios.Length; i++)
            {
                Console.Write(" "+ ListasParaTeste.oDesordenadosAleatorios[i] + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________");



            Console.WriteLine("--Lista simples--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < ListasParaTeste.desordenados.Length; i++)
            {
                Console.Write(" " + ListasParaTeste.desordenados[i] + ",");
            }

            Ordenadores.OrdenarPorSelecao(ListasParaTeste.desordenados);
            Console.WriteLine("");
            Console.Write("Lista Ordenada:   ");
            for (int i = 0; i < ListasParaTeste.desordenados.Length; i++)
            {
                Console.Write(" " + ListasParaTeste.desordenados[i] + ",");
            }
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________");


        }
    }
}
