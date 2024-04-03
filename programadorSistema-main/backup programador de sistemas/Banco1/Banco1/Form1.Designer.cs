namespace Banco1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textAgencia = new System.Windows.Forms.TextBox();
            this.textContacorrente = new System.Windows.Forms.TextBox();
            this.textChavepix = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gpOperacoes = new System.Windows.Forms.GroupBox();
            this.gpOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "agencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "conta corrente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "chave pix";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(109, 46);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(100, 23);
            this.textValor.TabIndex = 4;
            // 
            // textAgencia
            // 
            this.textAgencia.Location = new System.Drawing.Point(109, 80);
            this.textAgencia.Name = "textAgencia";
            this.textAgencia.Size = new System.Drawing.Size(100, 23);
            this.textAgencia.TabIndex = 5;
            // 
            // textContacorrente
            // 
            this.textContacorrente.Location = new System.Drawing.Point(109, 120);
            this.textContacorrente.Name = "textContacorrente";
            this.textContacorrente.Size = new System.Drawing.Size(100, 23);
            this.textContacorrente.TabIndex = 6;
            // 
            // textChavepix
            // 
            this.textChavepix.Location = new System.Drawing.Point(109, 161);
            this.textChavepix.Name = "textChavepix";
            this.textChavepix.Size = new System.Drawing.Size(100, 23);
            this.textChavepix.TabIndex = 7;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(118, 217);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "saldo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "saque";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 19);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "deposito";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(93, 19);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "transferencia";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gpOperacoes
            // 
            this.gpOperacoes.Controls.Add(this.radioButton1);
            this.gpOperacoes.Controls.Add(this.radioButton4);
            this.gpOperacoes.Controls.Add(this.radioButton2);
            this.gpOperacoes.Controls.Add(this.radioButton3);
            this.gpOperacoes.Location = new System.Drawing.Point(301, 33);
            this.gpOperacoes.Name = "gpOperacoes";
            this.gpOperacoes.Size = new System.Drawing.Size(200, 192);
            this.gpOperacoes.TabIndex = 13;
            this.gpOperacoes.TabStop = false;
            this.gpOperacoes.Text = "Operacoes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpOperacoes);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textChavepix);
            this.Controls.Add(this.textContacorrente);
            this.Controls.Add(this.textAgencia);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpOperacoes.ResumeLayout(false);
            this.gpOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textValor;
        private TextBox textAgencia;
        private TextBox textContacorrente;
        private TextBox textChavepix;
        private Button btnEntrar;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox gpOperacoes;
    }
}