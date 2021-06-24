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
            CalcularBonificacao();
            Console.ReadLine();


        }
        public static void CalcularBonificacao() { 
            
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao( );

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro Costa";

            Funcionario rafaela = new Diretor("159.753.398-04");
            rafaela.Nome = "Rafaela Almeida";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor Ferreira";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila Silva";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(rafaela);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês R$" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
