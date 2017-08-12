namespace ProjetoFinal.Presentation.Views.Vendas
{
    partial class CriarPedidoView
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
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxValorTotal = new System.Windows.Forms.TextBox();
            this.lblValor = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblQuantidade = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblProduto = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.cmbBoxProdutos = new System.Windows.Forms.ComboBox();
            this.gridProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnConfirmarPedido = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnRetirarProduto = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnAdicionarProduto = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxQuantidade = new System.Windows.Forms.NumericUpDown();
            this.grpBoxInfoEntrega = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEndereco = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblDataEntrega = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.btnAdicionarEndereco = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.chkBoxTrocaEndereco = new System.Windows.Forms.CheckBox();
            this.lblTipoCompra = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.dtTmPkrDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxFormaEntrega = new System.Windows.Forms.ComboBox();
            this.grpBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblNome = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblCPF = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.chkBoxUsuarioPadrao = new System.Windows.Forms.CheckBox();
            this.lblTelefone = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.tlpMain.SuspendLayout();
            this.grpBoxProdutos.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).BeginInit();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQuantidade)).BeginInit();
            this.grpBoxInfoEntrega.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpBoxInfoCliente.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpBoxProdutos, 0, 2);
            this.tlpMain.Controls.Add(this.grpBoxInfoEntrega, 0, 1);
            this.tlpMain.Controls.Add(this.grpBoxInfoCliente, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpMain.Size = new System.Drawing.Size(642, 363);
            this.tlpMain.TabIndex = 0;
            // 
            // grpBoxProdutos
            // 
            this.grpBoxProdutos.Controls.Add(this.tlpProdutos);
            this.grpBoxProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxProdutos.Location = new System.Drawing.Point(3, 199);
            this.grpBoxProdutos.Name = "grpBoxProdutos";
            this.grpBoxProdutos.Size = new System.Drawing.Size(636, 161);
            this.grpBoxProdutos.TabIndex = 3;
            this.grpBoxProdutos.TabStop = false;
            this.grpBoxProdutos.Text = "Incluir Produtos no Pedido";
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 7;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50794F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.26984F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.365079F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.19048F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30159F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31746F));
            this.tlpProdutos.Controls.Add(this.txtBoxValorTotal, 5, 0);
            this.tlpProdutos.Controls.Add(this.lblValor, 4, 0);
            this.tlpProdutos.Controls.Add(this.lblQuantidade, 2, 0);
            this.tlpProdutos.Controls.Add(this.lblProduto, 0, 0);
            this.tlpProdutos.Controls.Add(this.cmbBoxProdutos, 1, 0);
            this.tlpProdutos.Controls.Add(this.gridProdutos, 0, 1);
            this.tlpProdutos.Controls.Add(this.tlpButtons, 6, 1);
            this.tlpProdutos.Controls.Add(this.btnAdicionarProduto, 6, 0);
            this.tlpProdutos.Controls.Add(this.txtBoxQuantidade, 3, 0);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(3, 16);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 2;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProdutos.Size = new System.Drawing.Size(630, 142);
            this.tlpProdutos.TabIndex = 2;
            // 
            // txtBoxValorTotal
            // 
            this.txtBoxValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorTotal.Enabled = false;
            this.txtBoxValorTotal.Location = new System.Drawing.Point(393, 10);
            this.txtBoxValorTotal.Name = "txtBoxValorTotal";
            this.txtBoxValorTotal.Size = new System.Drawing.Size(103, 20);
            this.txtBoxValorTotal.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.AutoSize = true;
            this.lblValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValor.Location = new System.Drawing.Point(303, 14);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(84, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor Total (R$):";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantidade.Location = new System.Drawing.Point(161, 14);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProduto.AutoSize = true;
            this.lblProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProduto.Location = new System.Drawing.Point(4, 14);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto:";
            // 
            // cmbBoxProdutos
            // 
            this.cmbBoxProdutos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProdutos.FormattingEnabled = true;
            this.cmbBoxProdutos.Location = new System.Drawing.Point(57, 10);
            this.cmbBoxProdutos.Name = "cmbBoxProdutos";
            this.cmbBoxProdutos.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxProdutos.TabIndex = 0;
            this.cmbBoxProdutos.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxProdutos_SelectionChangeCommitted);
            // 
            // gridProdutos
            // 
            this.gridProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.Quantidade,
            this.PrecoUnitario,
            this.PrecoTotal});
            this.tlpProdutos.SetColumnSpan(this.gridProdutos, 6);
            this.gridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProdutos.Location = new System.Drawing.Point(3, 44);
            this.gridProdutos.Name = "gridProdutos";
            this.gridProdutos.ReadOnly = true;
            this.gridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos.Size = new System.Drawing.Size(493, 95);
            this.gridProdutos.TabIndex = 4;
            this.gridProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_CellClick);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProduto";
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.DataPropertyName = "PrecoUnitario";
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            // 
            // PrecoTotal
            // 
            this.PrecoTotal.DataPropertyName = "PrecoTotal";
            this.PrecoTotal.HeaderText = "Total";
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.ReadOnly = true;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.btnConfirmarPedido, 0, 2);
            this.tlpButtons.Controls.Add(this.btnRetirarProduto, 0, 0);
            this.tlpButtons.Location = new System.Drawing.Point(504, 41);
            this.tlpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 3;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(120, 101);
            this.tlpButtons.TabIndex = 12;
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarPedido.Location = new System.Drawing.Point(3, 63);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(114, 35);
            this.btnConfirmarPedido.TabIndex = 1;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.UseVisualStyleBackColor = false;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // btnRetirarProduto
            // 
            this.btnRetirarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirarProduto.Location = new System.Drawing.Point(3, 3);
            this.btnRetirarProduto.Name = "btnRetirarProduto";
            this.btnRetirarProduto.Size = new System.Drawing.Size(114, 27);
            this.btnRetirarProduto.TabIndex = 0;
            this.btnRetirarProduto.Text = "Retirar Produto";
            this.btnRetirarProduto.UseVisualStyleBackColor = false;
            this.btnRetirarProduto.Click += new System.EventHandler(this.btnRetirarProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(508, 4);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(114, 33);
            this.btnAdicionarProduto.TabIndex = 3;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // txtBoxQuantidade
            // 
            this.txtBoxQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxQuantidade.Location = new System.Drawing.Point(232, 10);
            this.txtBoxQuantidade.Name = "txtBoxQuantidade";
            this.txtBoxQuantidade.Size = new System.Drawing.Size(53, 20);
            this.txtBoxQuantidade.TabIndex = 1;
            this.txtBoxQuantidade.ValueChanged += new System.EventHandler(this.txtBoxQuantidade_ValueChanged);
            // 
            // grpBoxInfoEntrega
            // 
            this.grpBoxInfoEntrega.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxInfoEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxInfoEntrega.Location = new System.Drawing.Point(3, 96);
            this.grpBoxInfoEntrega.Name = "grpBoxInfoEntrega";
            this.grpBoxInfoEntrega.Size = new System.Drawing.Size(636, 97);
            this.grpBoxInfoEntrega.TabIndex = 2;
            this.grpBoxInfoEntrega.TabStop = false;
            this.grpBoxInfoEntrega.Text = "Informações - Entrega";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblEndereco, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDataEntrega, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarEndereco, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEndereco, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkBoxTrocaEndereco, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoCompra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtTmPkrDataEntrega, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbBoxFormaEntrega, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 78);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndereco.Location = new System.Drawing.Point(67, 50);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDataEntrega.Location = new System.Drawing.Point(287, 11);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(88, 13);
            this.lblDataEntrega.TabIndex = 1;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // btnAdicionarEndereco
            // 
            this.btnAdicionarEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarEndereco.Location = new System.Drawing.Point(507, 39);
            this.btnAdicionarEndereco.Name = "btnAdicionarEndereco";
            this.btnAdicionarEndereco.Size = new System.Drawing.Size(114, 33);
            this.btnAdicionarEndereco.TabIndex = 4;
            this.btnAdicionarEndereco.Text = "Adicionar Endereço";
            this.btnAdicionarEndereco.UseVisualStyleBackColor = false;
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtBoxEndereco, 3);
            this.txtBoxEndereco.Location = new System.Drawing.Point(129, 47);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(372, 20);
            this.txtBoxEndereco.TabIndex = 3;
            // 
            // chkBoxTrocaEndereco
            // 
            this.chkBoxTrocaEndereco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBoxTrocaEndereco.AutoSize = true;
            this.chkBoxTrocaEndereco.Location = new System.Drawing.Point(507, 9);
            this.chkBoxTrocaEndereco.Name = "chkBoxTrocaEndereco";
            this.chkBoxTrocaEndereco.Size = new System.Drawing.Size(106, 17);
            this.chkBoxTrocaEndereco.TabIndex = 2;
            this.chkBoxTrocaEndereco.Text = "Trocar Endereço";
            this.chkBoxTrocaEndereco.UseVisualStyleBackColor = true;
            // 
            // lblTipoCompra
            // 
            this.lblTipoCompra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoCompra.AutoSize = true;
            this.lblTipoCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoCompra.Location = new System.Drawing.Point(29, 11);
            this.lblTipoCompra.Name = "lblTipoCompra";
            this.lblTipoCompra.Size = new System.Drawing.Size(94, 13);
            this.lblTipoCompra.TabIndex = 9;
            this.lblTipoCompra.Text = "Forma de Entrega:";
            // 
            // dtTmPkrDataEntrega
            // 
            this.dtTmPkrDataEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtTmPkrDataEntrega.Location = new System.Drawing.Point(381, 8);
            this.dtTmPkrDataEntrega.Name = "dtTmPkrDataEntrega";
            this.dtTmPkrDataEntrega.Size = new System.Drawing.Size(120, 20);
            this.dtTmPkrDataEntrega.TabIndex = 1;
            // 
            // cmbBoxFormaEntrega
            // 
            this.cmbBoxFormaEntrega.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBoxFormaEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFormaEntrega.FormattingEnabled = true;
            this.cmbBoxFormaEntrega.Location = new System.Drawing.Point(129, 7);
            this.cmbBoxFormaEntrega.Name = "cmbBoxFormaEntrega";
            this.cmbBoxFormaEntrega.Size = new System.Drawing.Size(120, 21);
            this.cmbBoxFormaEntrega.TabIndex = 0;
            this.cmbBoxFormaEntrega.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFormaEntrega_SelectedIndexChanged);
            // 
            // grpBoxInfoCliente
            // 
            this.grpBoxInfoCliente.Controls.Add(this.tlpCliente);
            this.grpBoxInfoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxInfoCliente.Location = new System.Drawing.Point(3, 3);
            this.grpBoxInfoCliente.Name = "grpBoxInfoCliente";
            this.grpBoxInfoCliente.Size = new System.Drawing.Size(636, 87);
            this.grpBoxInfoCliente.TabIndex = 1;
            this.grpBoxInfoCliente.TabStop = false;
            this.grpBoxInfoCliente.Text = "Informações - Cliente";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 6;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCliente.Controls.Add(this.txtBoxEmail, 3, 1);
            this.tlpCliente.Controls.Add(this.lblEmail, 2, 1);
            this.tlpCliente.Controls.Add(this.lblNome, 0, 1);
            this.tlpCliente.Controls.Add(this.lblCPF, 0, 0);
            this.tlpCliente.Controls.Add(this.txtBoxNome, 1, 1);
            this.tlpCliente.Controls.Add(this.txtBoxCPF, 1, 0);
            this.tlpCliente.Controls.Add(this.btnBuscarCliente, 2, 0);
            this.tlpCliente.Controls.Add(this.txtBoxTelefone, 5, 1);
            this.tlpCliente.Controls.Add(this.chkBoxUsuarioPadrao, 3, 0);
            this.tlpCliente.Controls.Add(this.lblTelefone, 4, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(3, 16);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 2;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpCliente.Size = new System.Drawing.Size(630, 68);
            this.tlpCliente.TabIndex = 0;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmail.Location = new System.Drawing.Point(315, 38);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(98, 20);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Location = new System.Drawing.Point(274, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(63, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCPF.AutoSize = true;
            this.lblCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCPF.Location = new System.Drawing.Point(71, 8);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNome.Location = new System.Drawing.Point(107, 38);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(98, 20);
            this.txtBoxNome.TabIndex = 3;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCPF.Location = new System.Drawing.Point(107, 4);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(98, 20);
            this.txtBoxCPF.TabIndex = 0;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Location = new System.Drawing.Point(211, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(98, 23);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTelefone.Location = new System.Drawing.Point(523, 38);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(104, 20);
            this.txtBoxTelefone.TabIndex = 5;
            // 
            // chkBoxUsuarioPadrao
            // 
            this.chkBoxUsuarioPadrao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkBoxUsuarioPadrao.AutoSize = true;
            this.tlpCliente.SetColumnSpan(this.chkBoxUsuarioPadrao, 2);
            this.chkBoxUsuarioPadrao.Location = new System.Drawing.Point(315, 6);
            this.chkBoxUsuarioPadrao.Name = "chkBoxUsuarioPadrao";
            this.chkBoxUsuarioPadrao.Size = new System.Drawing.Size(99, 17);
            this.chkBoxUsuarioPadrao.TabIndex = 2;
            this.chkBoxUsuarioPadrao.Text = "Usuário Padrão";
            this.chkBoxUsuarioPadrao.UseVisualStyleBackColor = true;
            this.chkBoxUsuarioPadrao.CheckedChanged += new System.EventHandler(this.chkBoxUsuarioPadrao_CheckedChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTelefone.Location = new System.Drawing.Point(465, 42);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone:";
            // 
            // CriarPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 363);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriarPedidoView";
            this.Text = "Criar Pedido";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxProdutos.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            this.tlpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxQuantidade)).EndInit();
            this.grpBoxInfoEntrega.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpBoxInfoCliente.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxProdutos;
        private System.Windows.Forms.GroupBox grpBoxInfoEntrega;
        private System.Windows.Forms.GroupBox grpBoxInfoCliente;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private Components.LaloLabel lblNome;
        private Components.LaloLabel lblCPF;
        private Components.LaloLabel lblTelefone;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.CheckBox chkBoxUsuarioPadrao;
        private Components.LaloLabel lblTipoCompra;
        private System.Windows.Forms.ComboBox cmbBoxFormaEntrega;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Components.LaloLabel lblDataEntrega;
        private Components.LaloLabel lblEndereco;
        private Components.LaloPrimaryButton btnAdicionarEndereco;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.CheckBox chkBoxTrocaEndereco;
        private System.Windows.Forms.DateTimePicker dtTmPkrDataEntrega;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private Components.LaloLabel lblProduto;
        private System.Windows.Forms.ComboBox cmbBoxProdutos;
        private System.Windows.Forms.DataGridView gridProdutos;
        private Components.LaloPrimaryButton btnConfirmarPedido;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private Components.LaloPrimaryButton btnRetirarProduto;
        private Components.LaloPrimaryButton btnAdicionarProduto;
        private Components.LaloLabel lblQuantidade;
        private System.Windows.Forms.TextBox txtBoxValorTotal;
        private Components.LaloLabel lblValor;
        private System.Windows.Forms.NumericUpDown txtBoxQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
        private Components.LaloPrimaryButton btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private Components.LaloLabel lblEmail;
    }
}