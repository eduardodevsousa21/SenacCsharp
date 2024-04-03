using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string clima = cboxClima.Text;
            double dinheiro = Convert.ToDouble(tbxDinheiro.Text);
            if(clima == "sol" && dinheiro >= 500)
            {
                MessageBox.Show("Praia");
            }
            if (clima == "sol" && dinheiro <= 500)
            {
                MessageBox.Show("Sorvete");
                pbxImg.ImageLocation = "../../../sorvete.jpg";
            }
            if (clima == "chuva" && dinheiro >= 500)
            {
                MessageBox.Show("Serra");
                pbxImg.ImageLocation = "../../../serra.jpg";
            }
            if (clima == "chuva" && dinheiro <= 500)
            {
                MessageBox.Show("Chocolate quente");
            }
        }
    }
}
