using System;
using System.Collections.Generic;

namespace ProjetoFinal.Presentation.ViewModel
{
    public class PedidoViewModel
    {
        public int IdPedido { get; set; }

        public string NomeCliente { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string FormaEntrega { get; set; }

        public string EnderecoCliente { get; set; }

        public string EnderecoEntrega { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorRecebido { get; set; }

        public decimal Troco { get; set; }

        public DateTime DataEntrega { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public string TipoEntrega { get; set; }

        public IList<ItemPedidoViewModel> ItemsViewModel { get; set; }

        public PedidoViewModel()
        {
            ItemsViewModel = new List<ItemPedidoViewModel>();
        }

        public decimal getValorTotal()
        {
            decimal valorTotal = 0;

            foreach (var item in ItemsViewModel)
            {
                valorTotal += item.PrecoTotal;
            }
            return valorTotal;
        }
    }
}
