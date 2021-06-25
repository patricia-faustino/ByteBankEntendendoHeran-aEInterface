using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca.Sistemas
{
    public interface IAutenticavel 
    {
        //métodos não tem modificador de acesso e não tem corpo de método
        // todos os membros são públicos para quem implementa
        bool Autenticar(string senha);
    }
}
