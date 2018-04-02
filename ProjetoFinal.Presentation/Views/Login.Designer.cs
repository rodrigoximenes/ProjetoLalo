namespace ProjetoFinal.Presentation
{
    partial class Login
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
            this.txtBoxSenha = new System.Windows.Forms.TextBox();
            this.lblLogin = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.lblSenha = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.lblBemVindo = new ProjetoFinal.Presentation.Components.LaloLabel();
            this.btnCancelar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.btnLogar = new ProjetoFinal.Presentation.Components.LaloPrimaryButton();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.6F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.4F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tlpMain.Controls.Add(this.txtBoxSenha, 1, 2);
            this.tlpMain.Controls.Add(this.lblLogin, 0, 1);
            this.tlpMain.Controls.Add(this.lblSenha, 0, 2);
            this.tlpMain.Controls.Add(this.txtBoxLogin, 1, 1);
            this.tlpMain.Controls.Add(this.lblBemVindo, 0, 0);
            this.tlpMain.Controls.Add(this.btnCancelar, 2, 3);
            this.tlpMain.Controls.Add(this.btnLogar, 0, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(309, 171);
            this.tlpMain.TabIndex = 1;
            // 
            // txtBoxSenha
            // 
            this.txtBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpMain.SetColumnSpan(this.txtBoxSenha, 2);
            this.txtBoxSenha.Location = new System.Drawing.Point(139, 94);
            this.txtBoxSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSenha.Name = "txtBoxSenha";
            this.txtBoxSenha.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSenha.TabIndex = 1;
            this.txtBoxSenha.Text = "admin";
            this.txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLogin.AutoSize = true;
            this.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLogin.Location = new System.Drawing.Point(84, 54);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSenha.Location = new System.Drawing.Point(78, 96);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(53, 17);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpMain.SetColumnSpan(this.txtBoxLogin, 2);
            this.txtBoxLogin.Location = new System.Drawing.Point(139, 52);
            this.txtBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(132, 22);
            this.txtBoxLogin.TabIndex = 0;
            this.txtBoxLogin.Text = "admin";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBemVindo.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.lblBemVindo, 3);
            this.lblBemVindo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBemVindo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(4, 12);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(301, 17);
            this.lblBemVindo.TabIndex = 3;
            this.lblBemVindo.Text = "Sistema de Gerenciamento";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(157, 134);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLogar.Location = new System.Drawing.Point(31, 134);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(100, 28);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 171);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.LaloPrimaryButton btnLogar;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Components.LaloLabel lblLogin;
        private Components.LaloLabel lblSenha;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxSenha;
        private Components.LaloLabel lblBemVindo;
        private Components.LaloPrimaryButton btnCancelar;
    }
}

