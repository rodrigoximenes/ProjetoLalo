namespace ProjetoFinal.Domain.Model
{
    public class Item
    {
        /// <summary>
        /// Classe referente ao pedido. Verificação do estoque antes de inserir o produto no pedido
        /// </summary>
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int QuantidadeSolicitada { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}