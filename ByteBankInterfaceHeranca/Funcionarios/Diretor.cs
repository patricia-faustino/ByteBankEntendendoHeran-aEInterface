using ByteBank.Funcionarios;
using ByteBankInterfaceHeranca.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca.Funcionarios
{
    // classe concreta que pode ser instanciada
    class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
        }


        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        //Sobrepondo comportamento do funcionário
        public override double GetBonificacao()
        {
            //chamar método, propriedade da classe mãe 'base'
            return Salario * 0.5; 
        }
    }
}
