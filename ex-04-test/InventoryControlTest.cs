using ex_04;

namespace ex_04_test
{
    public class InventoryControlTest
    {
        [Fact]
        public void AddProductTester()
        {
            // Arrange
            var inventario = new InventoryControl();
            var nomeProduto = "Celular";
            var quantidade = 10;

            // Act
            inventario.AdicionarProduto(nomeProduto, quantidade);
            var quantidadeObtida = inventario.ObterQuantidade(nomeProduto);

            // Assert
            Assert.Equal(quantidade, quantidadeObtida);
        }

        [Fact]
        public void QuantityOfProducts()
        {
            // Arrange
            var inventario = new InventoryControl();
            var nomeProduto = "Celular";

            // Act
            var quantidadeObtida = inventario.ObterQuantidade(nomeProduto);

            // Assert
            Assert.Equal(0, quantidadeObtida);
        }
    }
}