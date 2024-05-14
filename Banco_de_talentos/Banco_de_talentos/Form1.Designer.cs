namespace Banco_de_talentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tbxusuaio = new TextBox();
            tbxsenha = new TextBox();
            lblusuario = new Label();
            lblsenha = new Label();
            btnconf = new Button();
            lblmens = new Label();
            SuspendLayout();
            // 
            // tbxusuaio
            // 
            tbxusuaio.Cursor = Cursors.IBeam;
            tbxusuaio.Location = new Point(417, 50);
            tbxusuaio.Name = "tbxusuaio";
            tbxusuaio.Size = new Size(100, 23);
            tbxusuaio.TabIndex = 0;
            // 
            // tbxsenha
            // 
            tbxsenha.Cursor = Cursors.IBeam;
            tbxsenha.Location = new Point(417, 90);
            tbxsenha.MaximumSize = new Size(100, 23);
            tbxsenha.MinimumSize = new Size(100, 23);
            tbxsenha.Name = "tbxsenha";
            tbxsenha.Size = new Size(100, 23);
            tbxsenha.TabIndex = 1;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(320, 53);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(53, 15);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "Usuario: ";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(320, 90);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(45, 15);
            lblsenha.TabIndex = 3;
            lblsenha.Text = "Senha: ";
            // 
            // btnconf
            // 
            btnconf.Cursor = Cursors.IBeam;
            btnconf.Location = new Point(429, 124);
            btnconf.Name = "btnconf";
            btnconf.Size = new Size(75, 23);
            btnconf.TabIndex = 5;
            btnconf.Text = "Confirmar";
            btnconf.UseVisualStyleBackColor = true;
            btnconf.Click += btnconf_Click;
            // 
            // lblmens
            // 
            lblmens.AutoSize = true;
            lblmens.Location = new Point(557, 238);
            lblmens.Name = "lblmens";
            lblmens.Size = new Size(0, 15);
            lblmens.TabIndex = 6;
            lblmens.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmens);
            Controls.Add(btnconf);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(tbxsenha);
            Controls.Add(tbxusuaio);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxusuaio;
        private TextBox tbxsenha;
        private Label lblusuario;
        private Label lblsenha;
        private Button btnconf;
        private Label lblmens;
    }
}
