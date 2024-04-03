namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p1 = Convert.ToDouble(txtProd1.Text);
            double p2 = Convert.ToDouble(txtProd2.Text);
            double soma = p1 + p2;
            txtsoma.Text = soma.ToString();


            if (soma >= 100)
            {
                double desc = soma * 0.01;
                txtDesconto.Text = desc.ToString();
                double valorFinal = soma - desc;
                txtDesconto.Text = valorFinal.ToString();
            }

            if (soma < 100 && soma > 50)
            {
                double desc = soma * 0.05;
                txtDesconto.Text = desc.ToString();
                double valorFinal = soma - desc;
                txtTotalF.Text = valorFinal.ToString();

            }
            if (soma <= 50)
            {
                double desc = soma * 0.02;
                txtDesconto.Text = desc.ToString();
                double valorFinal = soma - desc;
                txtTotalF.Text = valorFinal.ToString();

            }

        }

        

           

            
        }
    }
}