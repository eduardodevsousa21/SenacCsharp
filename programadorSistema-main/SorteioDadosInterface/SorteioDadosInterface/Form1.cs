using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteioDadosInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbxNumero.Text);//
            double valor = Convert.ToDouble(tbxValor.Text);
            double dinheiro = Convert.ToDouble(lblDinheiro.Text);
            Random numAleatorio = new Random();//
            int sorteio = numAleatorio.Next(1, 7);//
            //
            if(sorteio == n)
            {
                lblMsn.Text = "O numero sorteado foi " + sorteio + ". Você ganhou!";//
                lblDinheiro.Text = (dinheiro + 3 * valor).ToString();
            }
            else
            {
                lblMsn.Text = "O numero sorteado foi " + sorteio + ". Você perdeu!";//
                lblDinheiro.Text = (dinheiro - valor).ToString();
            }
        }
    }
}
