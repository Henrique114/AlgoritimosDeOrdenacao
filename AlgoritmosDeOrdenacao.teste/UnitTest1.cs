using AlgoritmosDeOrdenacao.Code.Funcoes;

namespace AlgoritmosDeOrdenacao.teste
{
    public class UnitTest1
    {
        [Fact]
        public void ordenacaoCrescenteUmaLista354186DeveRetornar134568()
        {
            //Arrenge
            List<int> numeros = [3,5,4,1,8,6];
            

            //act
            var numeros_ordenados = Ordenadores.OrdenarPorSelecao(numeros);
            
            //Assert
            Assert.Equal(numeros, numeros_ordenados);
        }
    }
}