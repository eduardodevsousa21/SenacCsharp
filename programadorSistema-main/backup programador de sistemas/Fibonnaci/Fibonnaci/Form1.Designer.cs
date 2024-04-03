namespace Fibonnaci
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
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblfib = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtposição = new System.Windows.Forms.TextBox();
            this.txtFib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(38, 42);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(48, 15);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "posição";
            // 
            // lblfib
            // 
            this.lblfib.AutoSize = true;
            this.lblfib.Location = new System.Drawing.Point(38, 78);
            this.lblfib.Name = "lblfib";
            this.lblfib.Size = new System.Drawing.Size(33, 15);
            this.lblfib.TabIndex = 5;
            this.lblfib.Text = "valor";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(279, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtposição
            // 
            this.txtposição.Location = new System.Drawing.Point(131, 34);
            this.txtposição.Name = "txtposição";
            this.txtposição.Size = new System.Drawing.Size(100, 23);
            this.txtposição.TabIndex = 0;
            this.txtposição.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFib
            // 
            this.txtFib.Location = new System.Drawing.Point(131, 70);
            this.txtFib.Name = "txtFib";
            this.txtFib.Size = new System.Drawing.Size(100, 23);
            this.txtFib.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFib);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblfib);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtposição);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblResposta;
        private Label lblfib;
        private Button btnPesquisar;
        private TextBox txtposição;
        private TextBox txtFib;
    }
}