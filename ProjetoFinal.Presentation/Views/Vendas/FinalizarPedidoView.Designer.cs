namespace ProjetoFinal.Presentation.Views.Vendas
{
    partial class FinalizarPedidoView
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
            this.grpBoxInfoGerais = new System.Windows.Forms.GroupBox();
            this.tlpCliente = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxFormaEntrega = new System.Windows.Forms.TextBox();
            this.lblEntrega = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblEndereco = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.lblEmail = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.grpBoxPedido = new System.Windows.Forms.GroupBox();
            this.tlpProdutos = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxTroco = new System.Windows.Forms.TextBox();
            this.lblTroco = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblValorRecebido = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblValorPedido = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxValorPedido = new System.Windows.Forms.TextBox();
            this.cmbBoxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamento = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxValorTotal = new System.Windows.Forms.TextBox();
            this.lblValor = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxValorDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxValorRecebido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnFinalizarPedido = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.tlpMain.SuspendLayout();
            this.grpBoxInfoGerais.SuspendLayout();
            this.tlpCliente.SuspendLayout();
            this.grpBoxPedido.SuspendLayout();
            this.tlpProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grpBoxInfoGerais, 0, 0);
            this.tlpMain.Controls.Add(this.grpBoxPedido, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMain.Size = new System.Drawing.Size(642, 270);
            this.tlpMain.TabIndex = 0;
            // 
            // grpBoxInfoGerais
            // 
            this.grpBoxInfoGerais.Controls.Add(this.tlpCliente);
            this.grpBoxInfoGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxInfoGerais.Location = new System.Drawing.Point(3, 3);
            this.grpBoxInfoGerais.Name = "grpBoxInfoGerais";
            this.grpBoxInfoGerais.Size = new System.Drawing.Size(636, 87);
            this.grpBoxInfoGerais.TabIndex = 1;
            this.grpBoxInfoGerais.TabStop = false;
            this.grpBoxInfoGerais.Text = "Informações - Gerais";
            // 
            // tlpCliente
            // 
            this.tlpCliente.ColumnCount = 5;
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCliente.Controls.Add(this.lblNome, 0, 0);
            this.tlpCliente.Controls.Add(this.txtBoxNome, 1, 0);
            this.tlpCliente.Controls.Add(this.txtBoxFormaEntrega, 4, 0);
            this.tlpCliente.Controls.Add(this.lblEntrega, 3, 0);
            this.tlpCliente.Controls.Add(this.lblEndereco, 0, 1);
            this.tlpCliente.Controls.Add(this.txtBoxEndereco, 1, 1);
            this.tlpCliente.Controls.Add(this.lblEmail, 3, 1);
            this.tlpCliente.Controls.Add(this.txtBoxEmail, 4, 1);
            this.tlpCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCliente.Location = new System.Drawing.Point(3, 16);
            this.tlpCliente.Name = "tlpCliente";
            this.tlpCliente.RowCount = 2;
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpCliente.Size = new System.Drawing.Size(630, 68);
            this.tlpCliente.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Location = new System.Drawing.Point(85, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNome.Enabled = false;
            this.txtBoxNome.Location = new System.Drawing.Point(129, 4);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(120, 20);
            this.txtBoxNome.TabIndex = 0;
            // 
            // txtBoxFormaEntrega
            // 
            this.txtBoxFormaEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxFormaEntrega.Enabled = false;
            this.txtBoxFormaEntrega.Location = new System.Drawing.Point(507, 4);
            this.txtBoxFormaEntrega.Name = "txtBoxFormaEntrega";
            this.txtBoxFormaEntrega.Size = new System.Drawing.Size(120, 20);
            this.txtBoxFormaEntrega.TabIndex = 1;
            // 
            // lblEntrega
            // 
            this.lblEntrega.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntrega.Location = new System.Drawing.Point(407, 8);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(94, 13);
            this.lblEntrega.TabIndex = 2;
            this.lblEntrega.Text = "Forma de Entrega:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndereco.Location = new System.Drawing.Point(67, 42);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCliente.SetColumnSpan(this.txtBoxEndereco, 2);
            this.txtBoxEndereco.Enabled = false;
            this.txtBoxEndereco.Location = new System.Drawing.Point(129, 38);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(246, 20);
            this.txtBoxEndereco.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Location = new System.Drawing.Point(466, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxEmail.Enabled = false;
            this.txtBoxEmail.Location = new System.Drawing.Point(507, 38);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(120, 20);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // grpBoxPedido
            // 
            this.grpBoxPedido.Controls.Add(this.tlpProdutos);
            this.grpBoxPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxPedido.Location = new System.Drawing.Point(3, 96);
            this.grpBoxPedido.Name = "grpBoxPedido";
            this.grpBoxPedido.Size = new System.Drawing.Size(636, 171);
            this.grpBoxPedido.TabIndex = 3;
            this.grpBoxPedido.TabStop = false;
            this.grpBoxPedido.Text = "Valores do Pedido";
            // 
            // tlpProdutos
            // 
            this.tlpProdutos.ColumnCount = 6;
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.1831F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.96825F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.65079F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93651F));
            this.tlpProdutos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProdutos.Controls.Add(this.txtBoxTroco, 3, 1);
            this.tlpProdutos.Controls.Add(this.lblTroco, 2, 1);
            this.tlpProdutos.Controls.Add(this.lblValorPedido, 0, 0);
            this.tlpProdutos.Controls.Add(this.txtBoxValorPedido, 1, 0);
            this.tlpProdutos.Controls.Add(this.cmbBoxFormaPagamento, 5, 1);
            this.tlpProdutos.Controls.Add(this.lblFormaPagamento, 4, 1);
            this.tlpProdutos.Controls.Add(this.txtBoxValorTotal, 5, 0);
            this.tlpProdutos.Controls.Add(this.lblValor, 4, 0);
            this.tlpProdutos.Controls.Add(this.btnCancelar, 5, 2);
            this.tlpProdutos.Controls.Add(this.btnFinalizarPedido, 3, 2);
            this.tlpProdutos.Controls.Add(this.txtBoxValorDesconto, 1, 1);
            this.tlpProdutos.Controls.Add(this.lblDesconto, 0, 1);
            this.tlpProdutos.Controls.Add(this.lblValorRecebido, 2, 0);
            this.tlpProdutos.Controls.Add(this.txtBoxValorRecebido, 3, 0);
            this.tlpProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProdutos.Location = new System.Drawing.Point(3, 16);
            this.tlpProdutos.Name = "tlpProdutos";
            this.tlpProdutos.RowCount = 3;
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpProdutos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpProdutos.Size = new System.Drawing.Size(630, 152);
            this.tlpProdutos.TabIndex = 2;
            // 
            // txtBoxTroco
            // 
            this.txtBoxTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxTroco.Enabled = false;
            this.txtBoxTroco.Location = new System.Drawing.Point(343, 73);
            this.txtBoxTroco.Name = "txtBoxTroco";
            this.txtBoxTroco.Size = new System.Drawing.Size(80, 20);
            this.txtBoxTroco.TabIndex = 4;
            // 
            // lblTroco
            // 
            this.lblTroco.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTroco.AutoSize = true;
            this.lblTroco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTroco.Location = new System.Drawing.Point(276, 76);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(61, 13);
            this.lblTroco.TabIndex = 22;
            this.lblTroco.Text = "Troco (R$):";
            // 
            // lblValorRecebido
            // 
            this.lblValorRecebido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorRecebido.AutoSize = true;
            this.lblValorRecebido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorRecebido.Location = new System.Drawing.Point(231, 20);
            this.lblValorRecebido.Name = "lblValorRecebido";
            this.lblValorRecebido.Size = new System.Drawing.Size(106, 13);
            this.lblValorRecebido.TabIndex = 21;
            this.lblValorRecebido.Text = "Valor Recebido (R$):";
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValorPedido.Location = new System.Drawing.Point(29, 20);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(108, 13);
            this.lblValorPedido.TabIndex = 9;
            this.lblValorPedido.Text = "Valor do Pedido (R$):";
            // 
            // txtBoxValorPedido
            // 
            this.txtBoxValorPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorPedido.Enabled = false;
            this.txtBoxValorPedido.Location = new System.Drawing.Point(143, 17);
            this.txtBoxValorPedido.Name = "txtBoxValorPedido";
            this.txtBoxValorPedido.Size = new System.Drawing.Size(82, 20);
            this.txtBoxValorPedido.TabIndex = 0;
            // 
            // cmbBoxFormaPagamento
            // 
            this.cmbBoxFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBoxFormaPagamento.FormattingEnabled = true;
            this.cmbBoxFormaPagamento.Location = new System.Drawing.Point(519, 72);
            this.cmbBoxFormaPagamento.Name = "cmbBoxFormaPagamento";
            this.cmbBoxFormaPagamento.Size = new System.Drawing.Size(108, 21);
            this.cmbBoxFormaPagamento.TabIndex = 5;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormaPagamento.Location = new System.Drawing.Point(449, 70);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(64, 26);
            this.lblFormaPagamento.TabIndex = 13;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // txtBoxValorTotal
            // 
            this.txtBoxValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorTotal.Enabled = false;
            this.txtBoxValorTotal.Location = new System.Drawing.Point(519, 17);
            this.txtBoxValorTotal.Name = "txtBoxValorTotal";
            this.txtBoxValorTotal.Size = new System.Drawing.Size(108, 20);
            this.txtBoxValorTotal.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblValor.AutoSize = true;
            this.lblValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblValor.Location = new System.Drawing.Point(429, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(84, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor Total (R$):";
            // 
            // txtBoxValorDesconto
            // 
            this.txtBoxValorDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorDesconto.Location = new System.Drawing.Point(143, 73);
            this.txtBoxValorDesconto.Name = "txtBoxValorDesconto";
            this.txtBoxValorDesconto.Size = new System.Drawing.Size(82, 20);
            this.txtBoxValorDesconto.TabIndex = 3;
            this.txtBoxValorDesconto.Leave += new System.EventHandler(this.txtBoxValorDesconto_Leave);
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDesconto.Location = new System.Drawing.Point(64, 76);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(73, 13);
            this.lblDesconto.TabIndex = 18;
            this.lblDesconto.Text = "Desconto (%):";
            // 
            // txtBoxValorRecebido
            // 
            this.txtBoxValorRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxValorRecebido.Location = new System.Drawing.Point(343, 17);
            this.txtBoxValorRecebido.Name = "txtBoxValorRecebido";
            this.txtBoxValorRecebido.Size = new System.Drawing.Size(80, 20);
            this.txtBoxValorRecebido.TabIndex = 1;
            this.txtBoxValorRecebido.Leave += new System.EventHandler(this.txtBoxValorRecebido_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(519, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProdutos.SetColumnSpan(this.btnFinalizarPedido, 2);
            this.btnFinalizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(399, 120);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(114, 29);
            this.btnFinalizarPedido.TabIndex = 6;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // FinalizarPedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 270);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinalizarPedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Pedido";
            this.tlpMain.ResumeLayout(false);
            this.grpBoxInfoGerais.ResumeLayout(false);
            this.tlpCliente.ResumeLayout(false);
            this.tlpCliente.PerformLayout();
            this.grpBoxPedido.ResumeLayout(false);
            this.tlpProdutos.ResumeLayout(false);
            this.tlpProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpBoxPedido;
        private System.Windows.Forms.GroupBox grpBoxInfoGerais;
        private System.Windows.Forms.TableLayoutPanel tlpCliente;
        private Components.LaloLabel lblNome;
        private Components.LaloLabel lblEntrega;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxFormaEntrega;
        private Components.LaloLabel lblEndereco;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TableLayoutPanel tlpProdutos;
        private Components.LaloLabel lblValorPedido;
        private Components.LaloPrimaryButton btnFinalizarPedido;
        private Components.LaloPrimaryButton btnCancelar;
        private Components.LaloLabel lblFormaPagamento;
        private System.Windows.Forms.TextBox txtBoxValorTotal;
        private Components.LaloLabel lblValor;
        private System.Windows.Forms.TextBox txtBoxValorPedido;
        private System.Windows.Forms.ComboBox cmbBoxFormaPagamento;
        private Components.LaloLabel lblDesconto;
        private System.Windows.Forms.TextBox txtBoxValorDesconto;
        private System.Windows.Forms.TextBox txtBoxTroco;
        private Components.LaloLabel lblTroco;
        private Components.LaloLabel lblValorRecebido;
        private System.Windows.Forms.TextBox txtBoxValorRecebido;
        private Components.LaloLabel lblEmail;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}