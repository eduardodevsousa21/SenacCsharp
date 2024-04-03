namespace Fib
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblposição = new System.Windows.Forms.Label();
            this.txtposição = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(407, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblposição
            // 
            this.lblposição.AutoSize = true;
            this.lblposição.Location = new System.Drawing.Point(60, 65);
            this.lblposição.Name = "lblposição";
            this.lblposição.Size = new System.Drawing.Size(48, 15);
            this.lblposição.TabIndex = 1;
            this.lblposição.Text = "posição";
            // 
            // txtposição
            // 
            this.txtposição.Location = new System.Drawing.Point(196, 62);
            this.txtposição.Name = "txtposição";
            this.txtposição.Size = new System.Drawing.Size(100, 23);
            this.txtposição.TabIndex = 2;
    //        this.txtposição.TextChanged += new System.EventHandler(this.txtposição_TextChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(60, 124);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(196, 124);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 23);
            this.txtvalor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtposição);
            this.Controls.Add(this.lblposição);
            this.Controls.Add(this.btnPesquisar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPesquisar;
        private Label lblposição;
        private TextBox txtposição;
        private Label lblValor;
        private TextBox txtvalor;
    }
}