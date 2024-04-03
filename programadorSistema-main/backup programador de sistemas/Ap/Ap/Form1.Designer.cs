namespace Ap
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnPG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(178, 61);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 23);
            this.txtA1.TabIndex = 0;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(178, 122);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 23);
            this.txtN.TabIndex = 1;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(178, 191);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 2;
            // 
            // txtAn
            // 
            this.txtAn.Enabled = false;
            this.txtAn.Location = new System.Drawing.Point(178, 264);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(100, 23);
            this.txtAn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "A1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "R:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "An:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lista";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(178, 329);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(24, 15);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "=   ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(373, 65);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPG
            // 
            this.btnPG.Location = new System.Drawing.Point(361, 105);
            this.btnPG.Name = "btnPG";
            this.btnPG.Size = new System.Drawing.Size(99, 23);
            this.btnPG.TabIndex = 11;
            this.btnPG.Text = "Calcular PG";
            this.btnPG.UseVisualStyleBackColor = true;
            this.btnPG.Click += new System.EventHandler(this.btnPG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPG);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtA1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtA1;
        private TextBox txtN;
        private TextBox txtR;
        private TextBox txtAn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblLista;
        private Button btnCalcular;
        private Button btnPG;
    }
}