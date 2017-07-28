using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Domain.Model
{
    public class Estoque
    {
        public int Id { get; set; }
        public IList<Produto> Produtos { get; set; }
    }
}
