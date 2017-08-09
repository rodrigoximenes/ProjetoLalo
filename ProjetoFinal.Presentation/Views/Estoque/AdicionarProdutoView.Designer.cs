namespace ProjetoFinal.Presentation.Views.Estoque
{
    partial class AdicionarProdutoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxProdutos = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblQuantidade = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblPrecoUnitario = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.btnNovo = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnExcluir = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnSalvar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.grpBoxProdutosGrid = new System.Windows.Forms.GroupBox();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.tlpMain.SuspendLayout();
            this.grpBoxProdutos.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.grpBoxProdutosGrid.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpBoxProdutos, 0, 0);
            this.tlpMain.Controls.Add(this.grpBoxProdutosGrid, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(642, 363);
            this.tlpMain.TabIndex = 0;
            // 
            // grpBoxProdutos
            // 
            this.grpBoxProdutos.Controls.Add(this.tlpCliente);
            this.grpBoxProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxProdutos.Location = new System.Drawing.Point(3, 3);
            this.grpBoxProdutos.Name = "grpBoxProdutos";
            this.grpBoxProdutos.Size = new System.Drawing.Size(636, 149);
            this.grpBoxProdutos.TabIndex = 1;
            this.grpBoxProdutos.TabStop = false;
            this.grpBoxProdutos.Text = "Produtos";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 5;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.04501F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5873F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.23809F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73016F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCliente.Controls.Add(this.txtBoxPrecoUnitario, 2, 2);
            this.tlpCliente.Controls.Add(this.txtBoxQuantidade, 2, 1);
            this.tlpCliente.Controls.Add(this.txtBoxNome, 2, 0);
            this.tlpCliente.Controls.Add(this.lblNome, 1, 0);
            this.tlpCliente.Controls.Add(this.lblQuantidade, 1, 1);
            this.tlpCliente.Controls.Add(this.lblPrecoUnitario, 1, 2);
            this.tlpCliente.Controls.Add(this.btnNovo, 4, 0);
            this.tlpCliente.Controls.Add(this.btnExcluir, 4, 2);
            this.tlpCliente.Controls.Add(this.btnSalvar, 4, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(3, 16);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 3;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.Size = new System.Drawing.Size(630, 130);
            this.tlpCliente.TabIndex = 0;
            // 
            // txtBoxPrecoUnitario
            // 
            this.txtBoxPrecoUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxPrecoUnitario.Location = new System.Drawing.Point(246, 98);
            this.txtBoxPrecoUnitario.Name = "txtBoxPrecoUnitario";
            this.txtBoxPrecoUnitario.Size = new System.Drawing.Size(153, 20);
            this.txtBoxPrecoUnitario.TabIndex = 2;
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQuantidade.Location = new System.Drawing.Point(246, 54);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(153, 20);
            this.txtBoxQuantidade.TabIndex = 1;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNome.Location = new System.Drawing.Point(246, 11);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(153, 20);
            this.txtBoxNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(202, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantidade.Location = new System.Drawing.Point(175, 58);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(140, 101);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(100, 13);
            this.lblPrecoUnitario.TabIndex = 1;
            this.lblPrecoUnitario.Text = "Preço Unitário (R$):";
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(513, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(111, 33);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(513, 95);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 32);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(513, 46);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(114, 33);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // grpBoxProdutosGrid
            // 
            this.grpBoxProdutosGrid.Controls.Add(this.tlpProdutos);
            this.grpBoxProdutosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxProdutosGrid.Location = new System.Drawing.Point(3, 158);
            this.grpBoxProdutosGrid.Name = "grpBoxProdutosGrid";
            this.grpBoxProdutosGrid.Size = new System.Drawing.Size(636, 202);
            this.grpBoxProdutosGrid.TabIndex = 3;
            this.grpBoxProdutosGrid.TabStop = false;
            this.grpBoxProdutosGrid.Text = "Produtos Cadastrados";
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 6;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.612439F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58692F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.32376F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.409887F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.26794F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.68254F));
            this.tlpProdutos.Controls.Add(this.gridProdutos, 0, 0);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(3, 16);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 1;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tlpProdutos.Size = new System.Drawing.Size(630, 183);
            this.tlpProdutos.TabIndex = 2;
            // 
            // gridProdutos
            // 
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpProdutos.SetColumnSpan(this.gridProdutos, 6);
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Location = new System.Drawing.Point(3, 3);
            this.gridProdutos.MultiSelect = false;
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(624, 177);
            this.gridProdutos.TabIndex = 0;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // AdicionarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdicionarProdutoView";
            this.Text = "Criar Pedido";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxProdutos.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.grpBoxProdutosGrid.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxProdutos;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private Components.LaloLabel lblNome;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxQuantidade;
        private Components.LaloLabel lblPrecoUnitario;
        private Components.LaloPrimaryButton btnSalvar;
        private System.Windows.Forms.GroupBox grpBoxProdutosGrid;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private System.Windows.Forms.DataGridView gridProdutos;
        private Components.LaloPrimaryButton btnNovo;
        private Components.LaloPrimaryButton btnExcluir;
        private Components.LaloLabel lblQuantidade;
        private System.Windows.Forms.TextBox txtBoxPrecoUnitario;
    }
}