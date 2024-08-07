namespace Projeto_3
{
    partial class Forms_Calculadora
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
            this.Calculadora = new System.Windows.Forms.Label();
            this.Text_Peso = new System.Windows.Forms.Label();
            this.Text_Altura = new System.Windows.Forms.Label();
            this.TextBox_Peso = new System.Windows.Forms.TextBox();
            this.TextBox_Altura = new System.Windows.Forms.TextBox();
            this.Text_IMC = new System.Windows.Forms.Label();
            this.Text_Situacao = new System.Windows.Forms.Label();
            this.Button_Sair = new System.Windows.Forms.Button();
            this.Label_ResultIMC = new System.Windows.Forms.Label();
            this.Label_ResultSIT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculadora
            // 
            this.Calculadora.AutoSize = true;
            this.Calculadora.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.Location = new System.Drawing.Point(42, 9);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(212, 23);
            this.Calculadora.TabIndex = 0;
            this.Calculadora.Text = "Calculadora de IMC";
            // 
            // Text_Peso
            // 
            this.Text_Peso.AutoSize = true;
            this.Text_Peso.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Peso.Location = new System.Drawing.Point(12, 60);
            this.Text_Peso.Name = "Text_Peso";
            this.Text_Peso.Size = new System.Drawing.Size(62, 23);
            this.Text_Peso.TabIndex = 1;
            this.Text_Peso.Text = "Peso:";
            // 
            // Text_Altura
            // 
            this.Text_Altura.AutoSize = true;
            this.Text_Altura.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Altura.Location = new System.Drawing.Point(12, 120);
            this.Text_Altura.Name = "Text_Altura";
            this.Text_Altura.Size = new System.Drawing.Size(80, 23);
            this.Text_Altura.TabIndex = 2;
            this.Text_Altura.Text = "Altura:";
            // 
            // TextBox_Peso
            // 
            this.TextBox_Peso.Location = new System.Drawing.Point(12, 86);
            this.TextBox_Peso.Name = "TextBox_Peso";
            this.TextBox_Peso.Size = new System.Drawing.Size(276, 20);
            this.TextBox_Peso.TabIndex = 3;
            this.TextBox_Peso.TextChanged += new System.EventHandler(this.TextBox_Peso_TextChanged);
            // 
            // TextBox_Altura
            // 
            this.TextBox_Altura.Location = new System.Drawing.Point(12, 146);
            this.TextBox_Altura.Name = "TextBox_Altura";
            this.TextBox_Altura.Size = new System.Drawing.Size(276, 20);
            this.TextBox_Altura.TabIndex = 4;
            this.TextBox_Altura.TextChanged += new System.EventHandler(this.TextBox_Altura_TextChanged);
            // 
            // Text_IMC
            // 
            this.Text_IMC.AutoSize = true;
            this.Text_IMC.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_IMC.Location = new System.Drawing.Point(124, 179);
            this.Text_IMC.Name = "Text_IMC";
            this.Text_IMC.Size = new System.Drawing.Size(54, 23);
            this.Text_IMC.TabIndex = 5;
            this.Text_IMC.Text = "IMC";
            this.Text_IMC.Click += new System.EventHandler(this.Text_IMC_Click);
            // 
            // Text_Situacao
            // 
            this.Text_Situacao.AutoSize = true;
            this.Text_Situacao.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Situacao.Location = new System.Drawing.Point(100, 232);
            this.Text_Situacao.Name = "Text_Situacao";
            this.Text_Situacao.Size = new System.Drawing.Size(105, 23);
            this.Text_Situacao.TabIndex = 6;
            this.Text_Situacao.Text = "Situação:";
            this.Text_Situacao.Click += new System.EventHandler(this.Text_Situacao_Click);
            // 
            // Button_Sair
            // 
            this.Button_Sair.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Sair.Location = new System.Drawing.Point(104, 289);
            this.Button_Sair.Name = "Button_Sair";
            this.Button_Sair.Size = new System.Drawing.Size(101, 33);
            this.Button_Sair.TabIndex = 7;
            this.Button_Sair.Text = "Sair";
            this.Button_Sair.UseVisualStyleBackColor = true;
            this.Button_Sair.Click += new System.EventHandler(this.Button_Sair_Click);
            // 
            // Label_ResultIMC
            // 
            this.Label_ResultIMC.AutoSize = true;
            this.Label_ResultIMC.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ResultIMC.Location = new System.Drawing.Point(118, 199);
            this.Label_ResultIMC.Name = "Label_ResultIMC";
            this.Label_ResultIMC.Size = new System.Drawing.Size(69, 16);
            this.Label_ResultIMC.TabIndex = 8;
            this.Label_ResultIMC.Text = "Resultado:";
            this.Label_ResultIMC.Click += new System.EventHandler(this.Label_ResultIMC_Click);
            // 
            // Label_ResultSIT
            // 
            this.Label_ResultSIT.AutoSize = true;
            this.Label_ResultSIT.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ResultSIT.Location = new System.Drawing.Point(117, 252);
            this.Label_ResultSIT.Name = "Label_ResultSIT";
            this.Label_ResultSIT.Size = new System.Drawing.Size(69, 16);
            this.Label_ResultSIT.TabIndex = 9;
            this.Label_ResultSIT.Text = "Resultado:";
            this.Label_ResultSIT.Click += new System.EventHandler(this.Label_ResultSIT_Click);
            // 
            // Forms_Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 351);
            this.Controls.Add(this.Label_ResultSIT);
            this.Controls.Add(this.Label_ResultIMC);
            this.Controls.Add(this.Button_Sair);
            this.Controls.Add(this.Text_Situacao);
            this.Controls.Add(this.Text_IMC);
            this.Controls.Add(this.TextBox_Altura);
            this.Controls.Add(this.TextBox_Peso);
            this.Controls.Add(this.Text_Altura);
            this.Controls.Add(this.Text_Peso);
            this.Controls.Add(this.Calculadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forms_Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calculadora;
        private System.Windows.Forms.Label Text_Peso;
        private System.Windows.Forms.Label Text_Altura;
        private System.Windows.Forms.TextBox TextBox_Peso;
        private System.Windows.Forms.TextBox TextBox_Altura;
        private System.Windows.Forms.Label Text_IMC;
        private System.Windows.Forms.Label Text_Situacao;
        private System.Windows.Forms.Button Button_Sair;
        private System.Windows.Forms.Label Label_ResultIMC;
        private System.Windows.Forms.Label Label_ResultSIT;
    }
}

