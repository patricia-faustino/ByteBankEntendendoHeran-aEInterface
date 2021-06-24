using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //classe abstrata que não pode ser instanciada, servindo de base para suas filhas
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }

        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario; 
            TotalDeFuncionarios++;
        }
        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        // A classe filha pode mudar o comportamento
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
