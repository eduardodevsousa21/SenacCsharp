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
    public partial class ccadastrar_curriculo : Form
    {
        public ccadastrar_curriculo()
        {
            InitializeComponent();
        }

        private void ccadastrar_curriculo_Load(object sender, EventArgs e)
        {
            ccadastrar_curriculo c = new ccadastrar_curriculo();
            c.ShowDialog();
        }

        private void dgvcurriculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvcurriculos.DataSource = Banco.ObterTodosCurriculos();
            dgvcurriculos.Columns[0].Width = 50;
        }
    }
}
