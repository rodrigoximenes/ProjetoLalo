﻿namespace ProjetoFinal.Domain.Model
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

    }
}