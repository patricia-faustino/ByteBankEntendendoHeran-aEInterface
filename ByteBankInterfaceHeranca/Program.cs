using ByteBank.Funcionarios;
using ByteBankInterfaceHeranca.Funcionarios;
using ByteBankInterfaceHeranca.Sistemas;
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
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();


        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila Silva";
            camila.Senha = "abc";


            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }
        public static void CalcularBonificacao() { 
            
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao( );

            Desenvolvedor guilherme = new Desenvolvedor("123.456.789-20");
            guilherme.Nome = "Guilherme";

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro Costa";

            Diretor rafaela = new Diretor("159.753.398-04");
            rafaela.Nome = "Rafaela Almeida";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor Ferreira";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila Silva";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(rafaela);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês R$" + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
