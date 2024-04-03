namespace formaDePagamento
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
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbAvista = new System.Windows.Forms.RadioButton();
            this.rbPrazo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(246, 89);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(163, 20);
            this.tbxPreco.TabIndex = 0;
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(246, 135);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(163, 20);
            this.tbxQuantidade.TabIndex = 1;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Enabled = false;
            this.tbxTotal.Location = new System.Drawing.Point(246, 185);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.Size = new System.Drawing.Size(163, 20);
            this.tbxTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(288, 236);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbAvista
            // 
            this.rbAvista.AutoSize = true;
            this.rbAvista.Checked = true;
            this.rbAvista.Location = new System.Drawing.Point(480, 101);
            this.rbAvista.Name = "rbAvista";
            this.rbAvista.Size = new System.Drawing.Size(57, 17);
            this.rbAvista.TabIndex = 7;
            this.rbAvista.TabStop = true;
            this.rbAvista.Text = "À vista";
            this.rbAvista.UseVisualStyleBackColor = true;
            // 
            // rbPrazo
            // 
            this.rbPrazo.AutoSize = true;
            this.rbPrazo.Location = new System.Drawing.Point(480, 135);
            this.rbPrazo.Name = "rbPrazo";
            this.rbPrazo.Size = new System.Drawing.Size(52, 17);
            this.rbPrazo.TabIndex = 8;
            this.rbPrazo.TabStop = true;
            this.rbPrazo.Text = "Prazo";
            this.rbPrazo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbPrazo);
            this.Controls.Add(this.rbAvista);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.tbxPreco);
            this.Name = "Form1";
            this.Text = "Calculo de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbAvista;
        private System.Windows.Forms.RadioButton rbPrazo;
    }
}

