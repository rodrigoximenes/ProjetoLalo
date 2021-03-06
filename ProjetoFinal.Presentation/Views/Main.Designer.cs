﻿namespace ProjetoFinal.Presentation.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMenuStrip = new System.Windows.Forms.Panel();
            this.grpBoxConsolidado = new System.Windows.Forms.GroupBox();
            this.tlpInfoGerais = new System.Windows.Forms.TableLayoutPanel();
            this.grpBoxUsuario = new System.Windows.Forms.GroupBox();
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGestao = new System.Windows.Forms.Panel();
            this.grpBoxCliente = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEstoque = new System.Windows.Forms.Panel();
            this.grpBoxEstoque = new System.Windows.Forms.GroupBox();
            this.tlpEstoque = new System.Windows.Forms.TableLayoutPanel();
            this.pnlVendas = new System.Windows.Forms.Panel();
            this.grpBoxVendas = new System.Windows.Forms.GroupBox();
            this.tlpVendas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloMain = new System.Windows.Forms.Label();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnFecharTela = new System.Windows.Forms.Button();
            this.btnUsuarioNome = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnTipoUsuario = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnAdicionarUsuário = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnAdicionarCliente = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnAdicionarProduto = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnGerenciarPedido = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.btnCriarPedido = new ProjetoFinal.Presentation.Components.LaloMenuButton();
            this.pnlMenuStrip.SuspendLayout();
            this.grpBoxConsolidado.SuspendLayout();
            this.tlpInfoGerais.SuspendLayout();
            this.grpBoxUsuario.SuspendLayout();
            this.tlpUsuario.SuspendLayout();
            this.pnlGestao.SuspendLayout();
            this.grpBoxCliente.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.pnlEstoque.SuspendLayout();
            this.grpBoxEstoque.SuspendLayout();
            this.tlpEstoque.SuspendLayout();
            this.pnlVendas.SuspendLayout();
            this.grpBoxVendas.SuspendLayout();
            this.tlpVendas.SuspendLayout();
            this.pnlIntro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpHeader.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuStrip
            // 
            this.pnlMenuStrip.BackColor = System.Drawing.Color.White;
            this.pnlMenuStrip.Controls.Add(this.grpBoxConsolidado);
            this.pnlMenuStrip.Controls.Add(this.grpBoxUsuario);
            this.pnlMenuStrip.Controls.Add(this.pnlGestao);
            this.pnlMenuStrip.Controls.Add(this.pnlEstoque);
            this.pnlMenuStrip.Controls.Add(this.pnlVendas);
            this.pnlMenuStrip.Controls.Add(this.pnlIntro);
            this.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuStrip.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuStrip.Name = "pnlMenuStrip";
            this.pnlMenuStrip.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlMenuStrip.Size = new System.Drawing.Size(320, 678);
            this.pnlMenuStrip.TabIndex = 0;
            // 
            // grpBoxConsolidado
            // 
            this.grpBoxConsolidado.Controls.Add(this.tlpInfoGerais);
            this.grpBoxConsolidado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxConsolidado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(162)))));
            this.grpBoxConsolidado.Location = new System.Drawing.Point(7, 561);
            this.grpBoxConsolidado.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxConsolidado.Name = "grpBoxConsolidado";
            this.grpBoxConsolidado.Padding = new System.Windows.Forms.Padding(4, 4, 6, 4);
            this.grpBoxConsolidado.Size = new System.Drawing.Size(308, 104);
            this.grpBoxConsolidado.TabIndex = 7;
            this.grpBoxConsolidado.TabStop = false;
            this.grpBoxConsolidado.Text = "Informações Gerais";
            // 
            // tlpInfoGerais
            // 
            this.tlpInfoGerais.ColumnCount = 1;
            this.tlpInfoGerais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfoGerais.Controls.Add(this.btnUsuarioNome, 0, 0);
            this.tlpInfoGerais.Controls.Add(this.btnTipoUsuario, 0, 1);
            this.tlpInfoGerais.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfoGerais.Location = new System.Drawing.Point(4, 20);
            this.tlpInfoGerais.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInfoGerais.Name = "tlpInfoGerais";
            this.tlpInfoGerais.RowCount = 2;
            this.tlpInfoGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfoGerais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpInfoGerais.Size = new System.Drawing.Size(298, 70);
            this.tlpInfoGerais.TabIndex = 6;
            // 
            // grpBoxUsuario
            // 
            this.grpBoxUsuario.Controls.Add(this.tlpUsuario);
            this.grpBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(162)))));
            this.grpBoxUsuario.Location = new System.Drawing.Point(0, 346);
            this.grpBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxUsuario.Name = "grpBoxUsuario";
            this.grpBoxUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxUsuario.Size = new System.Drawing.Size(315, 66);
            this.grpBoxUsuario.TabIndex = 4;
            this.grpBoxUsuario.TabStop = false;
            this.grpBoxUsuario.Text = "Usuários";
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 1;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpUsuario.Controls.Add(this.btnAdicionarUsuário, 0, 0);
            this.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpUsuario.Location = new System.Drawing.Point(4, 20);
            this.tlpUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 1;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpUsuario.Size = new System.Drawing.Size(307, 44);
            this.tlpUsuario.TabIndex = 6;
            // 
            // pnlGestao
            // 
            this.pnlGestao.Controls.Add(this.grpBoxCliente);
            this.pnlGestao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGestao.Location = new System.Drawing.Point(0, 274);
            this.pnlGestao.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGestao.Name = "pnlGestao";
            this.pnlGestao.Size = new System.Drawing.Size(315, 71);
            this.pnlGestao.TabIndex = 3;
            // 
            // grpBoxCliente
            // 
            this.grpBoxCliente.Controls.Add(this.tlpCliente);
            this.grpBoxCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(162)))));
            this.grpBoxCliente.Location = new System.Drawing.Point(0, 0);
            this.grpBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxCliente.Name = "grpBoxCliente";
            this.grpBoxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxCliente.Size = new System.Drawing.Size(315, 71);
            this.grpBoxCliente.TabIndex = 0;
            this.grpBoxCliente.TabStop = false;
            this.grpBoxCliente.Text = "Clientes";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 1;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.Controls.Add(this.btnAdicionarCliente, 0, 0);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(4, 20);
            this.tlpCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 1;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCliente.Size = new System.Drawing.Size(307, 47);
            this.tlpCliente.TabIndex = 2;
            // 
            // pnlEstoque
            // 
            this.pnlEstoque.Controls.Add(this.grpBoxEstoque);
            this.pnlEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEstoque.Location = new System.Drawing.Point(0, 201);
            this.pnlEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEstoque.Name = "pnlEstoque";
            this.pnlEstoque.Size = new System.Drawing.Size(315, 73);
            this.pnlEstoque.TabIndex = 2;
            // 
            // grpBoxEstoque
            // 
            this.grpBoxEstoque.Controls.Add(this.tlpEstoque);
            this.grpBoxEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEstoque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(162)))));
            this.grpBoxEstoque.Location = new System.Drawing.Point(0, 0);
            this.grpBoxEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxEstoque.Name = "grpBoxEstoque";
            this.grpBoxEstoque.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxEstoque.Size = new System.Drawing.Size(315, 73);
            this.grpBoxEstoque.TabIndex = 0;
            this.grpBoxEstoque.TabStop = false;
            this.grpBoxEstoque.Text = "Produtos";
            // 
            // tlpEstoque
            // 
            this.tlpEstoque.ColumnCount = 1;
            this.tlpEstoque.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpEstoque.Controls.Add(this.btnAdicionarProduto, 0, 0);
            this.tlpEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEstoque.Location = new System.Drawing.Point(4, 20);
            this.tlpEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.tlpEstoque.Name = "tlpEstoque";
            this.tlpEstoque.RowCount = 1;
            this.tlpEstoque.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpEstoque.Size = new System.Drawing.Size(307, 49);
            this.tlpEstoque.TabIndex = 2;
            // 
            // pnlVendas
            // 
            this.pnlVendas.Controls.Add(this.grpBoxVendas);
            this.pnlVendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendas.Location = new System.Drawing.Point(0, 73);
            this.pnlVendas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVendas.Name = "pnlVendas";
            this.pnlVendas.Size = new System.Drawing.Size(315, 128);
            this.pnlVendas.TabIndex = 1;
            // 
            // grpBoxVendas
            // 
            this.grpBoxVendas.Controls.Add(this.tlpVendas);
            this.grpBoxVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(120)))), ((int)(((byte)(162)))));
            this.grpBoxVendas.Location = new System.Drawing.Point(0, 0);
            this.grpBoxVendas.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxVendas.Name = "grpBoxVendas";
            this.grpBoxVendas.Padding = new System.Windows.Forms.Padding(4);
            this.grpBoxVendas.Size = new System.Drawing.Size(315, 128);
            this.grpBoxVendas.TabIndex = 0;
            this.grpBoxVendas.TabStop = false;
            this.grpBoxVendas.Text = "Vendas";
            // 
            // tlpVendas
            // 
            this.tlpVendas.ColumnCount = 1;
            this.tlpVendas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendas.Controls.Add(this.btnGerenciarPedido, 0, 1);
            this.tlpVendas.Controls.Add(this.btnCriarPedido, 0, 0);
            this.tlpVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVendas.Location = new System.Drawing.Point(4, 20);
            this.tlpVendas.Margin = new System.Windows.Forms.Padding(4);
            this.tlpVendas.Name = "tlpVendas";
            this.tlpVendas.RowCount = 2;
            this.tlpVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpVendas.Size = new System.Drawing.Size(307, 104);
            this.tlpVendas.TabIndex = 0;
            // 
            // pnlIntro
            // 
            this.pnlIntro.BackColor = System.Drawing.Color.Gray;
            this.pnlIntro.Controls.Add(this.pictureBox1);
            this.pnlIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIntro.Location = new System.Drawing.Point(0, 0);
            this.pnlIntro.Margin = new System.Windows.Forms.Padding(4);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(315, 73);
            this.pnlIntro.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Location = new System.Drawing.Point(320, 74);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(1);
            this.pnlMain.Size = new System.Drawing.Size(860, 557);
            this.pnlMain.TabIndex = 1;
            // 
            // tlpHeader
            // 
            this.tlpHeader.BackColor = System.Drawing.Color.White;
            this.tlpHeader.ColumnCount = 4;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpHeader.Controls.Add(this.lblTituloMain, 0, 0);
            this.tlpHeader.Location = new System.Drawing.Point(320, 0);
            this.tlpHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 1;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(860, 73);
            this.tlpHeader.TabIndex = 2;
            // 
            // lblTituloMain
            // 
            this.lblTituloMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTituloMain.AutoSize = true;
            this.tlpHeader.SetColumnSpan(this.lblTituloMain, 3);
            this.lblTituloMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(151)))), ((int)(((byte)(202)))));
            this.lblTituloMain.Location = new System.Drawing.Point(4, 24);
            this.lblTituloMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloMain.Name = "lblTituloMain";
            this.lblTituloMain.Size = new System.Drawing.Size(122, 25);
            this.lblTituloMain.TabIndex = 0;
            this.lblTituloMain.Text = "lblTituloMain";
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 681F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tlpFooter.Controls.Add(this.btnFecharTela, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(320, 632);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(860, 46);
            this.tlpFooter.TabIndex = 3;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFecharTela.Location = new System.Drawing.Point(685, 4);
            this.btnFecharTela.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(171, 38);
            this.btnFecharTela.TabIndex = 0;
            this.btnFecharTela.Text = "Fechar";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // btnUsuarioNome
            // 
            this.btnUsuarioNome.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarioNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUsuarioNome.FlatAppearance.BorderSize = 0;
            this.btnUsuarioNome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarioNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarioNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioNome.Location = new System.Drawing.Point(4, 4);
            this.btnUsuarioNome.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarioNome.Name = "btnUsuarioNome";
            this.btnUsuarioNome.Size = new System.Drawing.Size(240, 27);
            this.btnUsuarioNome.TabIndex = 0;
            this.btnUsuarioNome.Text = "Nome Usuário";
            this.btnUsuarioNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioNome.UseVisualStyleBackColor = false;
            // 
            // btnTipoUsuario
            // 
            this.btnTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnTipoUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTipoUsuario.FlatAppearance.BorderSize = 0;
            this.btnTipoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTipoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoUsuario.Location = new System.Drawing.Point(4, 39);
            this.btnTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnTipoUsuario.Name = "btnTipoUsuario";
            this.btnTipoUsuario.Size = new System.Drawing.Size(240, 27);
            this.btnTipoUsuario.TabIndex = 1;
            this.btnTipoUsuario.Text = "Tipo Usuário";
            this.btnTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarUsuário
            // 
            this.btnAdicionarUsuário.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarUsuário.FlatAppearance.BorderSize = 0;
            this.btnAdicionarUsuário.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuário.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarUsuário.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarUsuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarUsuário.Location = new System.Drawing.Point(4, 4);
            this.btnAdicionarUsuário.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarUsuário.Name = "btnAdicionarUsuário";
            this.btnAdicionarUsuário.Size = new System.Drawing.Size(240, 33);
            this.btnAdicionarUsuário.TabIndex = 0;
            this.btnAdicionarUsuário.Text = "Gerenciar Usuários";
            this.btnAdicionarUsuário.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarUsuário.UseVisualStyleBackColor = false;
            this.btnAdicionarUsuário.Click += new System.EventHandler(this.btnAdicionarUsuário_Click);
            // 
            // btnAdicionarCliente
            // 
            this.btnAdicionarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarCliente.FlatAppearance.BorderSize = 0;
            this.btnAdicionarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCliente.Location = new System.Drawing.Point(4, 4);
            this.btnAdicionarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarCliente.Name = "btnAdicionarCliente";
            this.btnAdicionarCliente.Size = new System.Drawing.Size(240, 33);
            this.btnAdicionarCliente.TabIndex = 0;
            this.btnAdicionarCliente.Text = "Gerenciar Clientes";
            this.btnAdicionarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarCliente.UseVisualStyleBackColor = false;
            this.btnAdicionarCliente.Click += new System.EventHandler(this.btnAdicionarCliente_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarProduto.FlatAppearance.BorderSize = 0;
            this.btnAdicionarProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(4, 4);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(240, 33);
            this.btnAdicionarProduto.TabIndex = 0;
            this.btnAdicionarProduto.Text = "Gerenciar Produtos";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnGerenciarPedido
            // 
            this.btnGerenciarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciarPedido.FlatAppearance.BorderSize = 0;
            this.btnGerenciarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGerenciarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGerenciarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarPedido.Location = new System.Drawing.Point(4, 56);
            this.btnGerenciarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnGerenciarPedido.Name = "btnGerenciarPedido";
            this.btnGerenciarPedido.Size = new System.Drawing.Size(240, 33);
            this.btnGerenciarPedido.TabIndex = 1;
            this.btnGerenciarPedido.Text = "Gerenciar Pedidos";
            this.btnGerenciarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciarPedido.UseVisualStyleBackColor = false;
            this.btnGerenciarPedido.Click += new System.EventHandler(this.btnGerenciarPedido_Click);
            // 
            // btnCriarPedido
            // 
            this.btnCriarPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPedido.FlatAppearance.BorderSize = 0;
            this.btnCriarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCriarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCriarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPedido.Location = new System.Drawing.Point(4, 4);
            this.btnCriarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPedido.Name = "btnCriarPedido";
            this.btnCriarPedido.Size = new System.Drawing.Size(240, 33);
            this.btnCriarPedido.TabIndex = 0;
            this.btnCriarPedido.Text = "Criar Pedido";
            this.btnCriarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarPedido.UseVisualStyleBackColor = false;
            this.btnCriarPedido.Click += new System.EventHandler(this.btnCriarPedido_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 678);
            this.Controls.Add(this.tlpFooter);
            this.Controls.Add(this.tlpHeader);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto";
            this.TopMost = true;
            this.pnlMenuStrip.ResumeLayout(false);
            this.grpBoxConsolidado.ResumeLayout(false);
            this.tlpInfoGerais.ResumeLayout(false);
            this.grpBoxUsuario.ResumeLayout(false);
            this.tlpUsuario.ResumeLayout(false);
            this.pnlGestao.ResumeLayout(false);
            this.grpBoxCliente.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.pnlEstoque.ResumeLayout(false);
            this.grpBoxEstoque.ResumeLayout(false);
            this.tlpEstoque.ResumeLayout(false);
            this.pnlVendas.ResumeLayout(false);
            this.grpBoxVendas.ResumeLayout(false);
            this.tlpVendas.ResumeLayout(false);
            this.pnlIntro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuStrip;
        private System.Windows.Forms.Panel pnlIntro;
        private System.Windows.Forms.Panel pnlEstoque;
        private System.Windows.Forms.Panel pnlVendas;
        private System.Windows.Forms.Panel pnlGestao;
        private Components.LaloMenuButton btnAdicionarUsuário;
        private Components.LaloMenuButton btnAdicionarCliente;
        private Components.LaloMenuButton btnAdicionarProduto;
        private Components.LaloMenuButton btnCriarPedido;
        private Components.LaloMenuButton btnGerenciarPedido;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.GroupBox grpBoxVendas;
        private System.Windows.Forms.TableLayoutPanel tlpVendas;
        private System.Windows.Forms.GroupBox grpBoxEstoque;
        private System.Windows.Forms.TableLayoutPanel tlpEstoque;
        private System.Windows.Forms.GroupBox grpBoxCliente;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private System.Windows.Forms.GroupBox grpBoxUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.Label lblTituloMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBoxConsolidado;
        private System.Windows.Forms.TableLayoutPanel tlpInfoGerais;
        private Components.LaloMenuButton btnUsuarioNome;
        private Components.LaloMenuButton btnTipoUsuario;
    }
}