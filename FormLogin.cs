using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula14_SistemaLogin
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if(CadastroUsuario.Login(usuario, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado! Contate o Suporte!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
