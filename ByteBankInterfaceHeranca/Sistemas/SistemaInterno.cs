using ByteBank.Funcionarios;
using ByteBankInterfaceHeranca.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usarioAutenticado = funcionario.Autenticar(senha);

            if (usarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
