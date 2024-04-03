namespace Fib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtposição.Text);
            int[] fib = new int[i];

            fib[0] = 1;
            fib[1] = 1;

            for (int j = 2; j < fib.Length; j++)
            {
                fib[j] = fib[j - 2] + fib[j - 1];
            }
            txtvalor.Text = fib[i - 1].ToString();
        }
    }
}