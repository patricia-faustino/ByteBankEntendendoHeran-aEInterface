using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca.Funcionarios
{
    class Diretor : Funcionario
    { 
        //Sobrepondo comportamento do funcionário
        public override double GetBonificacao()
        {
            return Salario; 
        }
    }
}
