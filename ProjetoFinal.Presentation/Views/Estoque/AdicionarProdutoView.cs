using ProjetoFinal.Domain.Interface.Repository;
using ProjetoFinal.Domain.Model;
using ProjetoFinal.Infrastructure.NinjectConfig;
using System;
using System.Windows.Forms;

namespace ProjetoFinal.Presentation.Views.Estoque
{
    public partial class AdicionarProdutoView : Form
    {
        private readonly IProdutoRepository _produtoRepository;

        public AdicionarProdutoView()
        {
            _produtoRepository = LaloKernel.GetInstance<IProdutoRepository>();

            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var produto = new Produto();
                produto.Nome = txtBoxNome.Text;
                produto.PrecoUnitario = Decimal.Parse(txtBoxPrecoUnitario.Text);
                produto.Quantidade = Convert.ToInt32(txtBoxQuantidade.Text);

                _produtoRepository.Add(produto);
                MessageBox.Show("Produto salvo com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
            }
        }
    }
}
