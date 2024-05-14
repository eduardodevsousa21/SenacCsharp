namespace Banco_de_talentos
{
    partial class drashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblmensage = new Label();
            menuStrip1 = new MenuStrip();
            desejaAcessarSeuLoginToolStripMenuItem = new ToolStripMenuItem();
            curriculoToolStripMenuItem = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblmensage
            // 
            lblmensage.AutoSize = true;
            lblmensage.Location = new Point(34, 97);
            lblmensage.Name = "lblmensage";
            lblmensage.Size = new Size(38, 15);
            lblmensage.TabIndex = 0;
            lblmensage.Text = "label1";
            lblmensage.Click += lblmensage_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { desejaAcessarSeuLoginToolStripMenuItem, listarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // desejaAcessarSeuLoginToolStripMenuItem
            // 
            desejaAcessarSeuLoginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { curriculoToolStripMenuItem });
            desejaAcessarSeuLoginToolStripMenuItem.Name = "desejaAcessarSeuLoginToolStripMenuItem";
            desejaAcessarSeuLoginToolStripMenuItem.Size = new Size(69, 20);
            desejaAcessarSeuLoginToolStripMenuItem.Text = "Cadastrar";
            desejaAcessarSeuLoginToolStripMenuItem.Click += desejaAcessarSeuLoginToolStripMenuItem_Click;
            // 
            // curriculoToolStripMenuItem
            // 
            curriculoToolStripMenuItem.Name = "curriculoToolStripMenuItem";
            curriculoToolStripMenuItem.Size = new Size(180, 22);
            curriculoToolStripMenuItem.Text = "Curriculo";
            curriculoToolStripMenuItem.Click += curriculoToolStripMenuItem_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(47, 20);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // drashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblmensage);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "drashboard";
            Text = "drashboard";
            Load += drashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmensage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem desejaAcessarSeuLoginToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem curriculoToolStripMenuItem;
    }
}