using AlgoritmosDeOrdenacao.Code.Funcoes;

namespace AlgoritmosDeOrdenacao.teste
{
    public class UnitTest1
    {
        [Fact]
        public void ordenacao_crescente_uma_lista_354186_deve_retornar_134568()
        {
            //Arrenge
            List<int> list = new List<int> {3,5,4,1,8,6};
            var selectionSort = new Ordenadores();

            //act
            var lista = selectionSort.Selection_Sorte(list);

            //Assert
            Assert.Equal(list, lista);
        }
    }
}