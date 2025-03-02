using AlgoritmosDeOrdenacao.Code.Funcoes;
using AlgoritmosDeOrdenacao.Code.Listas;

namespace AlgoritmosDeOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenadores ordenadores = new();
            ListasParaTeste listas_para_testes = new();

            var listaADesordenados = listas_para_testes.DesordenadosAleatorios();
            var contadorA = listaADesordenados.Count;

            var lista_simples = listas_para_testes.desordenados;
            var contadorS = lista_simples.Count;

            Console.WriteLine("--Lista Aleatoria--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < contadorA; i++)
            {
                Console.Write(" " + listaADesordenados[i] + ",");
            }

            var listaAleatorios = ordenadores.OrdenarPorSelecao(listaADesordenados);

            Console.WriteLine("");
            Console.Write("Lista Ordenada:");
            for (int i = 0; i < contadorA;i++)
            {
                Console.Write(" "+listaAleatorios[i] + ",");
            }
            Console.WriteLine("________________________________________________________________");



            Console.WriteLine("--Lista simples--");
            Console.Write("Lista Desordenada:");

            for (int i = 0; i < contadorS; i++)
            {
                Console.Write(" " + lista_simples[i] + ",");
            }

            Console.WriteLine("");
            Console.Write("Lista Ordenada:");
            for (int i = 0; i < contadorS; i++)
            {
                Console.Write(" " + lista_simples[i] + ",");
            }
            Console.WriteLine("________________________________________________________________");




        }
    }
}
