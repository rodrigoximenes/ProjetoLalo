using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.MainProject._01__Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public IList<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Atendente { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string TipoEntrega { get; set; }
        public Endereco EnderecoEntrega { get; set; }
    }
}
