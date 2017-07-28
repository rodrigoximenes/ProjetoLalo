
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinal.Domain.Model
{
    [Table("PRODUTO")]
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

    }
}