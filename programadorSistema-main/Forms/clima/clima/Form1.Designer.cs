namespace clima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxDinheiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.cboxClima = new System.Windows.Forms.ComboBox();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDinheiro
            // 
            this.tbxDinheiro.Location = new System.Drawing.Point(292, 153);
            this.tbxDinheiro.Name = "tbxDinheiro";
            this.tbxDinheiro.Size = new System.Drawing.Size(231, 20);
            this.tbxDinheiro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade de dinheiro";
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(361, 200);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(75, 23);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // cboxClima
            // 
            this.cboxClima.FormattingEnabled = true;
            this.cboxClima.Items.AddRange(new object[] {
            "sol",
            "chuva"});
            this.cboxClima.Location = new System.Drawing.Point(292, 107);
            this.cboxClima.Name = "cboxClima";
            this.cboxClima.Size = new System.Drawing.Size(231, 21);
            this.cboxClima.TabIndex = 5;
            // 
            // pbxImg
            // 
            this.pbxImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxImg.Image")));
            this.pbxImg.Location = new System.Drawing.Point(558, 58);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(197, 165);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 6;
            this.pbxImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.cboxClima);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDinheiro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxDinheiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.ComboBox cboxClima;
        private System.Windows.Forms.PictureBox pbxImg;
    }
}

