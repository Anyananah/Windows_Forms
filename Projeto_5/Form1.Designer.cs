namespace Projeto_5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Valor_1 = new System.Windows.Forms.Label();
            this.textBox_V1 = new System.Windows.Forms.TextBox();
            this.Valor_2 = new System.Windows.Forms.Label();
            this.textBox_V2 = new System.Windows.Forms.TextBox();
            this.button_mais = new System.Windows.Forms.Button();
            this.button_divisao = new System.Windows.Forms.Button();
            this.button_multiplicacao = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_menos = new System.Windows.Forms.Button();
            this.button_sair = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Valor_1
            // 
            this.Valor_1.AutoSize = true;
            this.Valor_1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_1.Location = new System.Drawing.Point(12, 25);
            this.Valor_1.Name = "Valor_1";
            this.Valor_1.Size = new System.Drawing.Size(112, 20);
            this.Valor_1.TabIndex = 0;
            this.Valor_1.Text = "Digite o valor:";
            this.Valor_1.Click += new System.EventHandler(this.Valor_1_Click);
            // 
            // textBox_V1
            // 
            this.textBox_V1.Location = new System.Drawing.Point(196, 27);
            this.textBox_V1.Name = "textBox_V1";
            this.textBox_V1.Size = new System.Drawing.Size(187, 20);
            this.textBox_V1.TabIndex = 1;
            // 
            // Valor_2
            // 
            this.Valor_2.AutoSize = true;
            this.Valor_2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_2.Location = new System.Drawing.Point(12, 50);
            this.Valor_2.Name = "Valor_2";
            this.Valor_2.Size = new System.Drawing.Size(143, 20);
            this.Valor_2.TabIndex = 2;
            this.Valor_2.Text = "Digite outro valor:";
            // 
            // textBox_V2
            // 
            this.textBox_V2.Location = new System.Drawing.Point(196, 53);
            this.textBox_V2.Name = "textBox_V2";
            this.textBox_V2.Size = new System.Drawing.Size(187, 20);
            this.textBox_V2.TabIndex = 3;
            // 
            // button_mais
            // 
            this.button_mais.Location = new System.Drawing.Point(16, 114);
            this.button_mais.Name = "button_mais";
            this.button_mais.Size = new System.Drawing.Size(44, 23);
            this.button_mais.TabIndex = 4;
            this.button_mais.Text = "+";
            this.button_mais.UseVisualStyleBackColor = true;
            this.button_mais.Click += new System.EventHandler(this.button_mais_Click);
            // 
            // button_divisao
            // 
            this.button_divisao.Location = new System.Drawing.Point(16, 143);
            this.button_divisao.Name = "button_divisao";
            this.button_divisao.Size = new System.Drawing.Size(44, 23);
            this.button_divisao.TabIndex = 6;
            this.button_divisao.Text = "/";
            this.button_divisao.UseVisualStyleBackColor = true;
            this.button_divisao.Click += new System.EventHandler(this.button_divisao_Click);
            // 
            // button_multiplicacao
            // 
            this.button_multiplicacao.Location = new System.Drawing.Point(66, 143);
            this.button_multiplicacao.Name = "button_multiplicacao";
            this.button_multiplicacao.Size = new System.Drawing.Size(44, 23);
            this.button_multiplicacao.TabIndex = 7;
            this.button_multiplicacao.Text = "*";
            this.button_multiplicacao.UseVisualStyleBackColor = true;
            this.button_multiplicacao.Click += new System.EventHandler(this.button_multiplicacao_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(308, 114);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 9;
            this.button_clean.Text = "Limpar";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_menos
            // 
            this.button_menos.Location = new System.Drawing.Point(66, 114);
            this.button_menos.Name = "button_menos";
            this.button_menos.Size = new System.Drawing.Size(44, 23);
            this.button_menos.TabIndex = 5;
            this.button_menos.Text = "-";
            this.button_menos.UseVisualStyleBackColor = true;
            this.button_menos.Click += new System.EventHandler(this.button_menos_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(308, 143);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 10;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(12, 76);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(87, 20);
            this.Resultado.TabIndex = 11;
            this.Resultado.Text = "Resultado:";
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Location = new System.Drawing.Point(196, 79);
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.Size = new System.Drawing.Size(187, 20);
            this.textBox_Resultado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 175);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_multiplicacao);
            this.Controls.Add(this.button_divisao);
            this.Controls.Add(this.button_menos);
            this.Controls.Add(this.button_mais);
            this.Controls.Add(this.textBox_V2);
            this.Controls.Add(this.Valor_2);
            this.Controls.Add(this.textBox_V1);
            this.Controls.Add(this.Valor_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Valor_1;
        private System.Windows.Forms.TextBox textBox_V1;
        private System.Windows.Forms.Label Valor_2;
        private System.Windows.Forms.TextBox textBox_V2;
        private System.Windows.Forms.Button button_mais;
        private System.Windows.Forms.Button button_divisao;
        private System.Windows.Forms.Button button_multiplicacao;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_menos;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox textBox_Resultado;
    }
}

