using AlgoritmosDeOrdenacao.Code.Funcoes;
using AlgoritmosDeOrdenacao.Code.Listas;

namespace AlgoritmosDeOrdenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenadores ordenar = new();
            ListasParaTeste listaTest = new();

            var listaADesordenados = listaTest.Desordenados_Aleatorios();
            
            var contadorA = listaADesordenados.Count;

            Console.Write("Lista Desordenada:");

            for (int i = 0; i < contadorA; i++)
            {
                Console.Write(" " + listaADesordenados[i] + ",");
            }

            var listaAleatorios = ordenar.Selection_Sorte(listaADesordenados);

            Console.WriteLine("");
            Console.Write("Lista Ordenada:");
            for (int i = 0; i < contadorA;i++)
            {
                Console.Write(" "+listaAleatorios[i] + ",");
            }

            
           

            // Console.WriteLine("lista Ordenada:" + ordenar.Selection_Sorte(listaTest.desordenados) + "/n" + "Desordenados:" + listaTest.desordenados);


            // Console.WriteLine("Hello, World!");
        }
    }
}
