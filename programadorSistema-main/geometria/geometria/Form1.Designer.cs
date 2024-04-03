namespace geometria
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
            this.tbxBase = new System.Windows.Forms.TextBox();
            this.tbxAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbxArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rbtriangulo = new System.Windows.Forms.RadioButton();
            this.rbtrapézio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbxBase
            // 
            this.tbxBase.Location = new System.Drawing.Point(308, 86);
            this.tbxBase.Name = "tbxBase";
            this.tbxBase.Size = new System.Drawing.Size(171, 20);
            this.tbxBase.TabIndex = 0;
            // 
            // tbxAltura
            // 
            this.tbxAltura.Location = new System.Drawing.Point(308, 136);
            this.tbxAltura.Name = "tbxAltura";
            this.tbxAltura.Size = new System.Drawing.Size(171, 20);
            this.tbxAltura.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(308, 238);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tbxArea
            // 
            this.tbxArea.Location = new System.Drawing.Point(308, 187);
            this.tbxArea.Name = "tbxArea";
            this.tbxArea.Size = new System.Drawing.Size(171, 20);
            this.tbxArea.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(404, 238);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rbtriangulo
            // 
            this.rbtriangulo.AutoSize = true;
            this.rbtriangulo.Location = new System.Drawing.Point(580, 93);
            this.rbtriangulo.Name = "rbtriangulo";
            this.rbtriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbtriangulo.TabIndex = 8;
            this.rbtriangulo.TabStop = true;
            this.rbtriangulo.Text = "Triangulo";
            this.rbtriangulo.UseVisualStyleBackColor = true;
            // 
            // rbtrapézio
            // 
            this.rbtrapézio.AutoSize = true;
            this.rbtrapézio.Location = new System.Drawing.Point(580, 136);
            this.rbtrapézio.Name = "rbtrapézio";
            this.rbtrapézio.Size = new System.Drawing.Size(66, 17);
            this.rbtrapézio.TabIndex = 9;
            this.rbtrapézio.TabStop = true;
            this.rbtrapézio.Text = "Trapézio";
            this.rbtrapézio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtrapézio);
            this.Controls.Add(this.rbtriangulo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbxAltura);
            this.Controls.Add(this.tbxBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBase;
        private System.Windows.Forms.TextBox tbxAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbxArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RadioButton rbtriangulo;
        private System.Windows.Forms.RadioButton rbtrapézio;
    }
}

