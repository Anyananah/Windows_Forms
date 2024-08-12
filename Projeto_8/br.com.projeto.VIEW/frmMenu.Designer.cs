namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clienteConsul = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionaCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_clienteCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_funcionaConsul = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_config = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configTroca = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_configSair = new System.Windows.Forms.ToolStripMenuItem();
            this.Statustrip = new System.Windows.Forms.StatusStrip();
            this.txt_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.tx_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_logado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.Statustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clientes,
            this.menu_funcionario,
            this.menu_fornecedores,
            this.menu_produtos,
            this.menu_config});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(541, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menu_clientes
            // 
            this.menu_clientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_clienteConsul,
            this.menu_clienteCadastro});
            this.menu_clientes.Image = global::Projeto_8.Properties.Resources.Usuario;
            this.menu_clientes.Name = "menu_clientes";
            this.menu_clientes.Size = new System.Drawing.Size(77, 20);
            this.menu_clientes.Text = "Clientes";
            // 
            // menu_funcionario
            // 
            this.menu_funcionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_funcionaCadastro,
            this.menu_funcionaConsul});
            this.menu_funcionario.Image = global::Projeto_8.Properties.Resources.Funcionario;
            this.menu_funcionario.Name = "menu_funcionario";
            this.menu_funcionario.Size = new System.Drawing.Size(103, 20);
            this.menu_funcionario.Text = "Funcionários";
            // 
            // menu_clienteConsul
            // 
            this.menu_clienteConsul.Name = "menu_clienteConsul";
            this.menu_clienteConsul.Size = new System.Drawing.Size(182, 22);
            this.menu_clienteConsul.Text = "Consulta de Clientes";
            // 
            // menu_funcionaCadastro
            // 
            this.menu_funcionaCadastro.Name = "menu_funcionaCadastro";
            this.menu_funcionaCadastro.Size = new System.Drawing.Size(208, 22);
            this.menu_funcionaCadastro.Text = "Cadastro de Funcionários";
            // 
            // menu_clienteCadastro
            // 
            this.menu_clienteCadastro.Name = "menu_clienteCadastro";
            this.menu_clienteCadastro.Size = new System.Drawing.Size(182, 22);
            this.menu_clienteCadastro.Text = "Cadastro de Clientes";
            // 
            // menu_funcionaConsul
            // 
            this.menu_funcionaConsul.Name = "menu_funcionaConsul";
            this.menu_funcionaConsul.Size = new System.Drawing.Size(208, 22);
            this.menu_funcionaConsul.Text = "Consulta de Funcionários";
            // 
            // menu_fornecedores
            // 
            this.menu_fornecedores.Image = global::Projeto_8.Properties.Resources.Fornecedores;
            this.menu_fornecedores.Name = "menu_fornecedores";
            this.menu_fornecedores.Size = new System.Drawing.Size(106, 20);
            this.menu_fornecedores.Text = "Fornecedores";
            // 
            // menu_produtos
            // 
            this.menu_produtos.Image = global::Projeto_8.Properties.Resources.Produto;
            this.menu_produtos.Name = "menu_produtos";
            this.menu_produtos.Size = new System.Drawing.Size(83, 20);
            this.menu_produtos.Text = "Produtos";
            // 
            // menu_config
            // 
            this.menu_config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_configTroca,
            this.menu_configSair});
            this.menu_config.Image = global::Projeto_8.Properties.Resources.Config;
            this.menu_config.Name = "menu_config";
            this.menu_config.Size = new System.Drawing.Size(112, 20);
            this.menu_config.Text = "Configurações";
            // 
            // menu_configTroca
            // 
            this.menu_configTroca.Name = "menu_configTroca";
            this.menu_configTroca.Size = new System.Drawing.Size(180, 22);
            this.menu_configTroca.Text = "Trocar usuário";
            // 
            // menu_configSair
            // 
            this.menu_configSair.Name = "menu_configSair";
            this.menu_configSair.Size = new System.Drawing.Size(180, 22);
            this.menu_configSair.Text = "Sair";
            // 
            // Statustrip
            // 
            this.Statustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_data,
            this.tx_hora,
            this.txt_logado});
            this.Statustrip.Location = new System.Drawing.Point(0, 345);
            this.Statustrip.Name = "Statustrip";
            this.Statustrip.Size = new System.Drawing.Size(541, 22);
            this.Statustrip.TabIndex = 1;
            this.Statustrip.Text = "data_atual";
            // 
            // txt_data
            // 
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(126, 17);
            this.txt_data.Text = "Data Atual: 12/08/2024";
            // 
            // tx_hora
            // 
            this.tx_hora.Name = "tx_hora";
            this.tx_hora.Size = new System.Drawing.Size(55, 17);
            this.tx_hora.Text = "14:30 PM";
            // 
            // txt_logado
            // 
            this.txt_logado.Name = "txt_logado";
            this.txt_logado.Size = new System.Drawing.Size(90, 17);
            this.txt_logado.Text = "Usuario Logado";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 367);
            this.Controls.Add(this.Statustrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.Statustrip.ResumeLayout(false);
            this.Statustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_clientes;
        private System.Windows.Forms.ToolStripMenuItem menu_clienteConsul;
        private System.Windows.Forms.ToolStripMenuItem menu_clienteCadastro;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionario;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionaCadastro;
        private System.Windows.Forms.ToolStripMenuItem menu_funcionaConsul;
        private System.Windows.Forms.ToolStripMenuItem menu_fornecedores;
        private System.Windows.Forms.ToolStripMenuItem menu_produtos;
        private System.Windows.Forms.ToolStripMenuItem menu_config;
        private System.Windows.Forms.ToolStripMenuItem menu_configTroca;
        private System.Windows.Forms.ToolStripMenuItem menu_configSair;
        private System.Windows.Forms.StatusStrip Statustrip;
        private System.Windows.Forms.ToolStripStatusLabel txt_data;
        private System.Windows.Forms.ToolStripStatusLabel tx_hora;
        private System.Windows.Forms.ToolStripStatusLabel txt_logado;
    }
}