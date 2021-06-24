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
        //Métodos abstratos não possuem corpo, servem para o desenvolvedor lembrar de 
        // criar essa classe
        public abstract void AumentarSalario();

        // A classe filha pode mudar o comportamento
        public abstract double GetBonificacao();
    }
}
