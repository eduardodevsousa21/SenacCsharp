namespace ProjetoAula1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRecuperação = new System.Windows.Forms.Button();
            this.txtRecuperacao = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2 ";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(121, 56);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(158, 23);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(121, 111);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(158, 23);
            this.txtNum2.TabIndex = 3;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(324, 56);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(86, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "Calcular";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // txtNum3
            // 
            this.txtNum3.Location = new System.Drawing.Point(121, 172);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(158, 23);
            this.txtNum3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 3";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(324, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(121, 232);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(158, 23);
            this.txtmedia.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Média";
            // 
            // btnRecuperação
            // 
            this.btnRecuperação.Location = new System.Drawing.Point(324, 115);
            this.btnRecuperação.Name = "btnRecuperação";
            this.btnRecuperação.Size = new System.Drawing.Size(86, 23);
            this.btnRecuperação.TabIndex = 12;
            this.btnRecuperação.Text = "Recuperação";
            this.btnRecuperação.UseVisualStyleBackColor = true;
            this.btnRecuperação.Click += new System.EventHandler(this.btnRecuperação_Click);
            // 
            // txtRecuperacao
            // 
            this.txtRecuperacao.Enabled = false;
            this.txtRecuperacao.Location = new System.Drawing.Point(121, 298);
            this.txtRecuperacao.Name = "txtRecuperacao";
            this.txtRecuperacao.Size = new System.Drawing.Size(158, 23);
            this.txtRecuperacao.TabIndex = 13;
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Location = new System.Drawing.Point(121, 362);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(158, 23);
            this.txtFinal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Recuperação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtRecuperacao);
            this.Controls.Add(this.btnRecuperação);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnSoma;
        private TextBox txtNum3;
        private Label label3;
        private Button btnLimpar;
        private TextBox txtmedia;
        private Label label4;
        private Button btnRecuperação;
        private TextBox txtRecuperacao;
        private TextBox txtFinal;
        private Label label5;
        private Label label6;
    }
}