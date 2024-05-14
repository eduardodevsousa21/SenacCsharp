using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_de_talentos
{
    public partial class drashboard : Form
    {
        public drashboard(string usuario)
        {
            InitializeComponent();
            lblmensage.Text = "Bem vindo";

        }



        private void drashboard_Load(object sender, EventArgs e)
        {

        }

        private void desejaAcessarSeuLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblmensage_Click(object sender, EventArgs e)
        {

        }

        private void curriculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ccadastrar_curriculo g = new ccadastrar_curriculo();
            g.Show();
        }
    }
}
