﻿namespace Banco_de_talentos
{
    partial class ccadastrar_curriculo
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
            dgvcurriculos = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvcurriculos).BeginInit();
            SuspendLayout();
            // 
            // dgvcurriculos
            // 
            dgvcurriculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcurriculos.Location = new Point(700, 128);
            dgvcurriculos.Name = "dgvcurriculos";
            dgvcurriculos.Size = new Size(240, 150);
            dgvcurriculos.TabIndex = 0;
            dgvcurriculos.CellContentClick += dgvcurriculos_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(167, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 128);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 2;
            label1.Text = "nascimento data";
            // 
            // ccadastrar_curriculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 611);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dgvcurriculos);
            Name = "ccadastrar_curriculo";
            Text = "ccadastrar_curriculo";
            Load += ccadastrar_curriculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvcurriculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvcurriculos;
        private DateTimePicker dateTimePicker1;
        private Label label1;
    }
}