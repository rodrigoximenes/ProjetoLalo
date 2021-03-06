﻿using System;
using System.Collections.Generic;

namespace ProjetoFinal.Domain.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public IList<Item> Itens { get; set; }
        public Cliente Cliente { get; set; }
        public int IdCliente { get; set; }
        public int IdAtendente { get; set; }
        public Usuario Atendente { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public string TipoEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
    }
}
