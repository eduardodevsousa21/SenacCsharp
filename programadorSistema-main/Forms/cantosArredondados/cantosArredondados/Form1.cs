using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantosArredondados
{
    public partial class PastaGrafica : Form
    {
        public PastaGrafica()
        {
            InitializeComponent();
        }
        

        private void PastaGrafica_Load(object sender, EventArgs e)
        {
            // ArredondaCantosdoForm();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
        }
    }
}
