using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double litros = Convert.ToDouble(tbxLitros.Text);
            double valor = 5.94;
            double desconto = 0;
            if(litros <= 20) {desconto = 0.04;}
            else {desconto = 0.06;}
            double total = (litros * valor) - (litros * valor * desconto);
            tbxDesconto.Text = desconto.ToString();
            tbxTotal.Text = total.ToString();

        }
    }
}
