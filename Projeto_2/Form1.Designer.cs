namespace Projeto_2
{
    partial class Forms_Saudacao
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
            this.Forms_Nome = new System.Windows.Forms.Label();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.Button_Exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Forms_Nome
            // 
            this.Forms_Nome.AutoSize = true;
            this.Forms_Nome.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forms_Nome.Location = new System.Drawing.Point(42, 33);
            this.Forms_Nome.Name = "Forms_Nome";
            this.Forms_Nome.Size = new System.Drawing.Size(61, 20);
            this.Forms_Nome.TabIndex = 0;
            this.Forms_Nome.Text = "Nome:";
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Name.Location = new System.Drawing.Point(109, 30);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(262, 27);
            this.TextBox_Name.TabIndex = 1;
            // 
            // Button_Exibir
            // 
            this.Button_Exibir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Button_Exibir.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exibir.Location = new System.Drawing.Point(377, 30);
            this.Button_Exibir.Name = "Button_Exibir";
            this.Button_Exibir.Size = new System.Drawing.Size(85, 29);
            this.Button_Exibir.TabIndex = 2;
            this.Button_Exibir.Text = "&Clique Aqui!";
            this.Button_Exibir.UseVisualStyleBackColor = false;
            this.Button_Exibir.Click += new System.EventHandler(this.Button_Exibir_Click);
            // 
            // Forms_Saudacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(538, 334);
            this.Controls.Add(this.Button_Exibir);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Forms_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Forms_Saudacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto_2 - Saudação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Forms_Nome;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Button Button_Exibir;
    }
}

