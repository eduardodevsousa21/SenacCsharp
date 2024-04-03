using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoarSangue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //pegar a a idade no tbxIdade
            int idade = Convert.ToInt32(tbxIdade.Text);
            //verificar se é maior ou igual a 18 e menor ou igual a 67
            if(idade >= 18 && idade <= 67)
            {
                //se verdadeiro inserir no label lblMsg
                //a frase "Você pode doar sangue"
                MessageBox.Show("Você pode doar sangue!","Verificação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Você não pode doar sangue!","Verificação Concluida", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
    }
}
