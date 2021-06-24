using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca.Funcionarios
{
    class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
        //Sobrepondo comportamento do funcionário
        public override double GetBonificacao()
        {
            //chamar método, propriedade da classe mãe 'base'
            return Salario * 0.25;
        }
    }
}
