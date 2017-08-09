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

        public int IdProdutoSelecionado { get; set; }

        public AdicionarProdutoView()
        {
            _produtoRepository = LaloKernel.GetInstance<IProdutoRepository>();

            InitializeComponent();

            this.Load += AdicionarProdutoView_Load;
        }

        private void ClearFields()
        {
            IdProdutoSelecionado = 0;
            txtBoxNome.Text = string.Empty;
            txtBoxPrecoUnitario.Text = string.Empty;
            txtBoxQuantidade.Text = string.Empty;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void LoadProdutos()
        {
            gridProdutos.DataSource = _produtoRepository.FindAll();
            ClearFields();
        }

        private void AdicionarProdutoView_Load(object sender, EventArgs e)
        {
            LoadProdutos();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {

            if(string.IsNullOrEmpty(txtBoxPrecoUnitario.Text) ||
                string.IsNullOrEmpty(txtBoxNome.Text) ||
                string.IsNullOrEmpty(txtBoxQuantidade.Text))
            {
                MessageBox.Show("Favor preencher os campos corretamente.");
                return;
            }

            try
            {
                var produto = new Produto();
                produto.Nome = txtBoxNome.Text;
                produto.PrecoUnitario = Decimal.Parse(txtBoxPrecoUnitario.Text);
                produto.Quantidade = Convert.ToInt32(txtBoxQuantidade.Text);

                if (IdProdutoSelecionado > 0)
                {
                    _produtoRepository.Update(produto);
                }
                else
                {
                    _produtoRepository.Add(produto);
                }                

                MessageBox.Show("Produto salvo com sucesso");

                LoadProdutos();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao tentar excluir o produto.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                _produtoRepository.Delete(IdProdutoSelecionado);

                MessageBox.Show("Produto excluído com sucesso");

                LoadProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir o produto.");
            }
        }

        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProdutoSelecionado = Convert.ToInt32(gridProdutos.SelectedRows[0].Cells[0].Value);

            var produto = _produtoRepository.Find(IdProdutoSelecionado);

            txtBoxNome.Text = produto.Nome;
            txtBoxPrecoUnitario.Text = produto.PrecoUnitario.ToString();
            txtBoxQuantidade.Text = produto.Quantidade.ToString();
        }
    }
}
