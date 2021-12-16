
namespace Gerador_de_Senhas
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
            this.lista_senhas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_gerar = new System.Windows.Forms.Button();
            this.check_maiusculas = new System.Windows.Forms.CheckBox();
            this.count_chars = new System.Windows.Forms.NumericUpDown();
            this.check_algarismos = new System.Windows.Forms.CheckBox();
            this.check_simbolos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_senhas
            // 
            this.lista_senhas.FormattingEnabled = true;
            this.lista_senhas.Location = new System.Drawing.Point(4, 5);
            this.lista_senhas.Name = "lista_senhas";
            this.lista_senhas.Size = new System.Drawing.Size(180, 251);
            this.lista_senhas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N.º chars:";
            // 
            // cmd_gerar
            // 
            this.cmd_gerar.Location = new System.Drawing.Point(200, 207);
            this.cmd_gerar.Name = "cmd_gerar";
            this.cmd_gerar.Size = new System.Drawing.Size(132, 49);
            this.cmd_gerar.TabIndex = 2;
            this.cmd_gerar.Text = "GERAR";
            this.cmd_gerar.UseVisualStyleBackColor = true;
            this.cmd_gerar.Click += new System.EventHandler(this.cmd_gerar_Click);
            // 
            // check_maiusculas
            // 
            this.check_maiusculas.AutoSize = true;
            this.check_maiusculas.Location = new System.Drawing.Point(200, 64);
            this.check_maiusculas.Name = "check_maiusculas";
            this.check_maiusculas.Size = new System.Drawing.Size(132, 17);
            this.check_maiusculas.TabIndex = 3;
            this.check_maiusculas.Text = "Utilizar MAIÚSCULAS.";
            this.check_maiusculas.UseVisualStyleBackColor = true;
            // 
            // count_chars
            // 
            this.count_chars.Location = new System.Drawing.Point(200, 38);
            this.count_chars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_chars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_chars.Name = "count_chars";
            this.count_chars.Size = new System.Drawing.Size(120, 20);
            this.count_chars.TabIndex = 4;
            this.count_chars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // check_algarismos
            // 
            this.check_algarismos.AutoSize = true;
            this.check_algarismos.Location = new System.Drawing.Point(200, 87);
            this.check_algarismos.Name = "check_algarismos";
            this.check_algarismos.Size = new System.Drawing.Size(112, 17);
            this.check_algarismos.TabIndex = 3;
            this.check_algarismos.Text = "Utilizar algarismos.";
            this.check_algarismos.UseVisualStyleBackColor = true;
            // 
            // check_simbolos
            // 
            this.check_simbolos.AutoSize = true;
            this.check_simbolos.Location = new System.Drawing.Point(200, 110);
            this.check_simbolos.Name = "check_simbolos";
            this.check_simbolos.Size = new System.Drawing.Size(105, 17);
            this.check_simbolos.TabIndex = 3;
            this.check_simbolos.Text = "Utilizar símbolos.";
            this.check_simbolos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.count_chars);
            this.Controls.Add(this.check_simbolos);
            this.Controls.Add(this.check_algarismos);
            this.Controls.Add(this.check_maiusculas);
            this.Controls.Add(this.cmd_gerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_senhas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista_senhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_gerar;
        private System.Windows.Forms.CheckBox check_maiusculas;
        private System.Windows.Forms.NumericUpDown count_chars;
        private System.Windows.Forms.CheckBox check_algarismos;
        private System.Windows.Forms.CheckBox check_simbolos;
    }
}

