using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_7
{
    static class CadastroUsuario
    {
        //USUARIOS QUE PODEM LOGAR
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Leonardo", Senha = "Aryassilla996264972Lilac2502Abe"},
            new Usuario(){Nome = "Yago", Senha = "Victoria996248792Veronika3110Levi"},
            new Usuario(){Nome = "Vitoria", Senha = "Ayko996369220Nero2512Semye"},
        };

        //CONTEM USUARIO QUE ESTA LOGADO
        private static Usuario _userLogado = null;

        //DEFINIR O VALOR E ATIVA O ARRAY ACIMA
        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            set { _userLogado = value; }
        }

        //CONTROLE E LOGIN
        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }
    }
}
