namespace sorveteria
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
            this.cbSabores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbGranulado = new System.Windows.Forms.CheckBox();
            this.chbCobertura = new System.Windows.Forms.CheckBox();
            this.chbCalda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSabores
            // 
            this.cbSabores.FormattingEnabled = true;
            this.cbSabores.Items.AddRange(new object[] {
            "Chocolate",
            "Napolitano",
            "Flocos",
            "leite Condensado"});
            this.cbSabores.Location = new System.Drawing.Point(125, 36);
            this.cbSabores.Name = "cbSabores";
            this.cbSabores.Size = new System.Drawing.Size(144, 23);
            this.cbSabores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sabores";
            // 
            // chbGranulado
            // 
            this.chbGranulado.AutoSize = true;
            this.chbGranulado.Location = new System.Drawing.Point(366, 66);
            this.chbGranulado.Name = "chbGranulado";
            this.chbGranulado.Size = new System.Drawing.Size(81, 19);
            this.chbGranulado.TabIndex = 2;
            this.chbGranulado.Text = "Granulado";
            this.chbGranulado.UseVisualStyleBackColor = true;
            // 
            // chbCobertura
            // 
            this.chbCobertura.AutoSize = true;
            this.chbCobertura.Location = new System.Drawing.Point(366, 116);
            this.chbCobertura.Name = "chbCobertura";
            this.chbCobertura.Size = new System.Drawing.Size(79, 19);
            this.chbCobertura.TabIndex = 3;
            this.chbCobertura.Text = "Cobertura";
            this.chbCobertura.UseVisualStyleBackColor = true;
            // 
            // chbCalda
            // 
            this.chbCalda.AutoSize = true;
            this.chbCalda.Location = new System.Drawing.Point(366, 91);
            this.chbCalda.Name = "chbCalda";
            this.chbCalda.Size = new System.Drawing.Size(56, 19);
            this.chbCalda.TabIndex = 4;
            this.chbCalda.Text = "Calda";
            this.chbCalda.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(125, 66);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(144, 23);
            this.txtPreco.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Preço";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbCalda);
            this.Controls.Add(this.chbCobertura);
            this.Controls.Add(this.chbGranulado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSabores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbSabores;
        private Label label1;
        private CheckBox chbGranulado;
        private CheckBox chbCobertura;
        private CheckBox chbCalda;
        private Label label2;
        private Button button1;
        private TextBox txtPreco;
        private Label label3;
    }
}