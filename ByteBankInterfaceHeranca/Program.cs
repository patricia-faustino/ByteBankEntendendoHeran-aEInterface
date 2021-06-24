using ByteBank.Funcionarios;
using ByteBankInterfaceHeranca.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInterfaceHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "123.456.789-10");
            carlos.Nome = "Carlos Almeida";
      

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos: R$" + carlos.Salario);
            gerenciadorBonificacao.Registrar(carlos);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Diretor rafaela = new Diretor(5000, "546.879.157-20");
            rafaela.Nome = "Rafaela Cerqueira";

            rafaela.AumentarSalario();
            Console.WriteLine("Novo salário do Rafaela: R$" + rafaela.Salario);
            gerenciadorBonificacao.Registrar(rafaela);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            //Polimorfismo
            Funcionario rafaelaTeste = rafaela;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + rafaela.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + rafaelaTeste.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(rafaela.Nome);
            Console.WriteLine(rafaela.GetBonificacao());
            Console.WriteLine("Total de bonificações R$" + gerenciadorBonificacao.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
