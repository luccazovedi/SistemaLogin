using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14_SistemaLogin
{
    static class CadastroUsuario
    {
        private static Usuario[] usuarios =
        {
        new Usuario() { Nome = "Lucca", Senha = "1234"},
        new Usuario() { Nome = "Zovedi", Senha = "4321"},
        new Usuario() { Nome = "LuccaZovedi", Senha = "2502" }
        };

        //Propriedades
        private static Usuario _UserLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _UserLogado; }
            private set { _UserLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }

    }
}
