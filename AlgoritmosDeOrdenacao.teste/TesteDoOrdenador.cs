using AlgoritmosDeOrdenacao.Code.Funcoes;


namespace AlgoritmosDeOrdenacao.teste
{
    public class TesteDoOrdenador
    {
        [Fact]
        public void ordenacaoCrescenteUmaLista354186DeveRetornar134568()
        {
            //Arrenge
            int[] numeros = {3, 5, 4, 1, 8, 6};
            

            //act
            var numeros_ordenados = Ordenador.PorSelecao(numeros);
            
            //Assert
            Assert.Equal(numeros, numeros_ordenados);
        }

        [Theory]
        [InlineData(new int[] { 8, 6, 7, 3, 1, 5 }, new int[] { 1, 3, 5, 6, 7, 8 })]
        [InlineData(new int[] { 9, 8, 7, 6, 5, 4 }, new int[] { 4, 5, 6, 7, 8, 9 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        public void OrdenarNumerosEmOrdemCres(int[] numeros, int[] numerosOrdenadosEsperados) 
        {
            //Arrenge
           
            //Act 
            var rOrdenados = Ordenador.SeparandoEUnindo(numeros);


            //Assert
            Assert.Equal(numerosOrdenadosEsperados, rOrdenados);
        
        }
    }
}