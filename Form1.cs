using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula14_SistemaLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin fromLogin = new FormLogin();
            //fromLogin.ShowDialog();

            while (CadastroUsuario.UsuarioLogado == null)
            {
                Visible = false;
                fromLogin.ShowDialog();

                if (FormLogin.Cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }
        
        }

        private void lblFormPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
