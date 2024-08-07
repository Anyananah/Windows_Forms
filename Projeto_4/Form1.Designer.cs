namespace Projeto_4
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
            this.Label_Rpassagem = new System.Windows.Forms.Label();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.TextBox_Nome = new System.Windows.Forms.TextBox();
            this.Label_Destino = new System.Windows.Forms.Label();
            this.ComboBox_Destino = new System.Windows.Forms.ComboBox();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Date_Time = new System.Windows.Forms.DateTimePicker();
            this.GroupBox_Valor = new System.Windows.Forms.GroupBox();
            this.Label_MoneyT = new System.Windows.Forms.Label();
            this.Label_MoneyD = new System.Windows.Forms.Label();
            this.Label_Money = new System.Windows.Forms.Label();
            this.Label_VTotal = new System.Windows.Forms.Label();
            this.Label_GastoTransp = new System.Windows.Forms.Label();
            this.Label_GastoDestino = new System.Windows.Forms.Label();
            this.GroupBox_Transp = new System.Windows.Forms.GroupBox();
            this.RadioButton_aviao = new System.Windows.Forms.RadioButton();
            this.RadioButton_bus = new System.Windows.Forms.RadioButton();
            this.Button_Confirm = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.Button_Calc = new System.Windows.Forms.Button();
            this.Button_Sair = new System.Windows.Forms.Button();
            this.GroupBox_Valor.SuspendLayout();
            this.GroupBox_Transp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Rpassagem
            // 
            this.Label_Rpassagem.AutoSize = true;
            this.Label_Rpassagem.BackColor = System.Drawing.Color.MediumPurple;
            this.Label_Rpassagem.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rpassagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Rpassagem.Location = new System.Drawing.Point(27, 2);
            this.Label_Rpassagem.Name = "Label_Rpassagem";
            this.Label_Rpassagem.Padding = new System.Windows.Forms.Padding(160, 0, 160, 0);
            this.Label_Rpassagem.Size = new System.Drawing.Size(590, 28);
            this.Label_Rpassagem.TabIndex = 0;
            this.Label_Rpassagem.Text = "Reserva de Passagem";
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome.Location = new System.Drawing.Point(12, 48);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(51, 16);
            this.Label_Nome.TabIndex = 1;
            this.Label_Nome.Text = "Nome:";
            // 
            // TextBox_Nome
            // 
            this.TextBox_Nome.Location = new System.Drawing.Point(63, 47);
            this.TextBox_Nome.Name = "TextBox_Nome";
            this.TextBox_Nome.Size = new System.Drawing.Size(218, 20);
            this.TextBox_Nome.TabIndex = 2;
            // 
            // Label_Destino
            // 
            this.Label_Destino.AutoSize = true;
            this.Label_Destino.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Destino.Location = new System.Drawing.Point(10, 76);
            this.Label_Destino.Name = "Label_Destino";
            this.Label_Destino.Size = new System.Drawing.Size(64, 16);
            this.Label_Destino.TabIndex = 3;
            this.Label_Destino.Text = "Destino:";
            // 
            // ComboBox_Destino
            // 
            this.ComboBox_Destino.FormattingEnabled = true;
            this.ComboBox_Destino.Items.AddRange(new object[] {
            "SP",
            "ES",
            "GO",
            "RJ",
            "SC"});
            this.ComboBox_Destino.Location = new System.Drawing.Point(76, 75);
            this.ComboBox_Destino.Name = "ComboBox_Destino";
            this.ComboBox_Destino.Size = new System.Drawing.Size(205, 21);
            this.ComboBox_Destino.TabIndex = 4;
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data.Location = new System.Drawing.Point(11, 105);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(45, 16);
            this.Label_Data.TabIndex = 5;
            this.Label_Data.Text = "Data:";
            // 
            // Date_Time
            // 
            this.Date_Time.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Time.Location = new System.Drawing.Point(57, 102);
            this.Date_Time.MaxDate = new System.DateTime(2025, 12, 20, 23, 59, 0, 0);
            this.Date_Time.MinDate = new System.DateTime(2024, 1, 20, 23, 59, 0, 0);
            this.Date_Time.Name = "Date_Time";
            this.Date_Time.Size = new System.Drawing.Size(224, 21);
            this.Date_Time.TabIndex = 6;
            this.Date_Time.Value = new System.DateTime(2024, 7, 25, 23, 59, 59, 0);
            this.Date_Time.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GroupBox_Valor
            // 
            this.GroupBox_Valor.Controls.Add(this.Label_MoneyT);
            this.GroupBox_Valor.Controls.Add(this.Label_MoneyD);
            this.GroupBox_Valor.Controls.Add(this.Label_Money);
            this.GroupBox_Valor.Controls.Add(this.Label_VTotal);
            this.GroupBox_Valor.Controls.Add(this.Label_GastoTransp);
            this.GroupBox_Valor.Controls.Add(this.Label_GastoDestino);
            this.GroupBox_Valor.Location = new System.Drawing.Point(17, 141);
            this.GroupBox_Valor.Name = "GroupBox_Valor";
            this.GroupBox_Valor.Size = new System.Drawing.Size(425, 108);
            this.GroupBox_Valor.TabIndex = 7;
            this.GroupBox_Valor.TabStop = false;
            this.GroupBox_Valor.Text = "Valores do Pacote:";
            // 
            // Label_MoneyT
            // 
            this.Label_MoneyT.AutoSize = true;
            this.Label_MoneyT.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MoneyT.Location = new System.Drawing.Point(329, 68);
            this.Label_MoneyT.Name = "Label_MoneyT";
            this.Label_MoneyT.Size = new System.Drawing.Size(59, 16);
            this.Label_MoneyT.TabIndex = 12;
            this.Label_MoneyT.Text = "R$ 00.00";
            // 
            // Label_MoneyD
            // 
            this.Label_MoneyD.AutoSize = true;
            this.Label_MoneyD.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MoneyD.Location = new System.Drawing.Point(182, 68);
            this.Label_MoneyD.Name = "Label_MoneyD";
            this.Label_MoneyD.Size = new System.Drawing.Size(59, 16);
            this.Label_MoneyD.TabIndex = 11;
            this.Label_MoneyD.Text = "R$ 00.00";
            // 
            // Label_Money
            // 
            this.Label_Money.AutoSize = true;
            this.Label_Money.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Money.Location = new System.Drawing.Point(33, 68);
            this.Label_Money.Name = "Label_Money";
            this.Label_Money.Size = new System.Drawing.Size(59, 16);
            this.Label_Money.TabIndex = 9;
            this.Label_Money.Text = "R$ 00.00";
            // 
            // Label_VTotal
            // 
            this.Label_VTotal.AutoSize = true;
            this.Label_VTotal.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VTotal.Location = new System.Drawing.Point(321, 23);
            this.Label_VTotal.Name = "Label_VTotal";
            this.Label_VTotal.Size = new System.Drawing.Size(74, 16);
            this.Label_VTotal.TabIndex = 10;
            this.Label_VTotal.Text = "Valor Total";
            // 
            // Label_GastoTransp
            // 
            this.Label_GastoTransp.AutoSize = true;
            this.Label_GastoTransp.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GastoTransp.Location = new System.Drawing.Point(11, 23);
            this.Label_GastoTransp.Name = "Label_GastoTransp";
            this.Label_GastoTransp.Size = new System.Drawing.Size(111, 16);
            this.Label_GastoTransp.TabIndex = 0;
            this.Label_GastoTransp.Text = "Gasto Transporte";
            // 
            // Label_GastoDestino
            // 
            this.Label_GastoDestino.AutoSize = true;
            this.Label_GastoDestino.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GastoDestino.Location = new System.Drawing.Point(156, 23);
            this.Label_GastoDestino.Name = "Label_GastoDestino";
            this.Label_GastoDestino.Size = new System.Drawing.Size(118, 16);
            this.Label_GastoDestino.TabIndex = 9;
            this.Label_GastoDestino.Text = "Gasto com Destino";
            // 
            // GroupBox_Transp
            // 
            this.GroupBox_Transp.Controls.Add(this.RadioButton_aviao);
            this.GroupBox_Transp.Controls.Add(this.RadioButton_bus);
            this.GroupBox_Transp.Location = new System.Drawing.Point(301, 47);
            this.GroupBox_Transp.Name = "GroupBox_Transp";
            this.GroupBox_Transp.Size = new System.Drawing.Size(141, 48);
            this.GroupBox_Transp.TabIndex = 8;
            this.GroupBox_Transp.TabStop = false;
            this.GroupBox_Transp.Text = "Meios de Transporte:";
            // 
            // RadioButton_aviao
            // 
            this.RadioButton_aviao.AutoSize = true;
            this.RadioButton_aviao.Location = new System.Drawing.Point(70, 22);
            this.RadioButton_aviao.Name = "RadioButton_aviao";
            this.RadioButton_aviao.Size = new System.Drawing.Size(52, 17);
            this.RadioButton_aviao.TabIndex = 1;
            this.RadioButton_aviao.TabStop = true;
            this.RadioButton_aviao.Text = "Avião";
            this.RadioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // RadioButton_bus
            // 
            this.RadioButton_bus.AutoSize = true;
            this.RadioButton_bus.Location = new System.Drawing.Point(6, 22);
            this.RadioButton_bus.Name = "RadioButton_bus";
            this.RadioButton_bus.Size = new System.Drawing.Size(58, 17);
            this.RadioButton_bus.TabIndex = 0;
            this.RadioButton_bus.TabStop = true;
            this.RadioButton_bus.Text = "Ônibus";
            this.RadioButton_bus.UseVisualStyleBackColor = true;
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Location = new System.Drawing.Point(448, 76);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Button_Confirm.TabIndex = 9;
            this.Button_Confirm.Text = "Confirmar";
            this.Button_Confirm.UseVisualStyleBackColor = true;
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Button_Clean
            // 
            this.Button_Clean.Location = new System.Drawing.Point(527, 48);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(75, 23);
            this.Button_Clean.TabIndex = 10;
            this.Button_Clean.Text = "Limpar";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // Button_Calc
            // 
            this.Button_Calc.Location = new System.Drawing.Point(448, 48);
            this.Button_Calc.Name = "Button_Calc";
            this.Button_Calc.Size = new System.Drawing.Size(75, 23);
            this.Button_Calc.TabIndex = 11;
            this.Button_Calc.Text = "Calcular";
            this.Button_Calc.UseVisualStyleBackColor = true;
            this.Button_Calc.Click += new System.EventHandler(this.Button_Calc_Click);
            // 
            // Button_Sair
            // 
            this.Button_Sair.Location = new System.Drawing.Point(527, 77);
            this.Button_Sair.Name = "Button_Sair";
            this.Button_Sair.Size = new System.Drawing.Size(75, 23);
            this.Button_Sair.TabIndex = 12;
            this.Button_Sair.Text = "Sair";
            this.Button_Sair.UseVisualStyleBackColor = true;
            this.Button_Sair.Click += new System.EventHandler(this.Button_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.Button_Sair);
            this.Controls.Add(this.Button_Calc);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.GroupBox_Transp);
            this.Controls.Add(this.GroupBox_Valor);
            this.Controls.Add(this.Date_Time);
            this.Controls.Add(this.Label_Data);
            this.Controls.Add(this.ComboBox_Destino);
            this.Controls.Add(this.Label_Destino);
            this.Controls.Add(this.TextBox_Nome);
            this.Controls.Add(this.Label_Nome);
            this.Controls.Add(this.Label_Rpassagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Valor.ResumeLayout(false);
            this.GroupBox_Valor.PerformLayout();
            this.GroupBox_Transp.ResumeLayout(false);
            this.GroupBox_Transp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Rpassagem;
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.TextBox TextBox_Nome;
        private System.Windows.Forms.Label Label_Destino;
        private System.Windows.Forms.ComboBox ComboBox_Destino;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.DateTimePicker Date_Time;
        private System.Windows.Forms.GroupBox GroupBox_Valor;
        private System.Windows.Forms.GroupBox GroupBox_Transp;
        private System.Windows.Forms.RadioButton RadioButton_aviao;
        private System.Windows.Forms.RadioButton RadioButton_bus;
        private System.Windows.Forms.Label Label_VTotal;
        private System.Windows.Forms.Label Label_GastoTransp;
        private System.Windows.Forms.Label Label_GastoDestino;
        private System.Windows.Forms.Label Label_MoneyT;
        private System.Windows.Forms.Label Label_MoneyD;
        private System.Windows.Forms.Label Label_Money;
        private System.Windows.Forms.Button Button_Confirm;
        private System.Windows.Forms.Button Button_Clean;
        private System.Windows.Forms.Button Button_Calc;
        private System.Windows.Forms.Button Button_Sair;
    }
}

