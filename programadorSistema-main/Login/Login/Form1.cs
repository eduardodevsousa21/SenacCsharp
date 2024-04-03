using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //pegar os valor das caixas de texto tbxUsuario e tbxSenha
            string usuario = tbxUsuario.Text;
            string senha   = tbxSenha.Text;
            //verificar se Usuário e senha são válido
            if(usuario == "adm")
            {
                if(senha == "admin123")
                {
                    lblConfirm.ForeColor = Color.Green;
                    lblConfirm.Text = "ok, acesso confirmado.";
                }
                else
                {
                    lblConfirm.ForeColor= Color.Red;
                    lblConfirm.Text = "Senha incorreta.";
                }
            }
            else
            {
                lblConfirm.ForeColor = Color.Red;
                lblConfirm.Text = "Usuário incorreto.";
            }
            //modificar o label lblConfirm
            
        }
    }
}
