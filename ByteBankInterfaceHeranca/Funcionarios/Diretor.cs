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
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("CRIANDO UM DIRETOR");
        }
        //Sobrepondo comportamento do funcionário
        public override double GetBonificacao()
        {
            //chamar método, propriedade da classe mãe 'base'
            return Salario + base.GetBonificacao(); 
        }
    }
}
