using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Funcoes
{
    internal class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("=======================Cadastro de Fornecedor=============================");

            while (true) {
            string mensagem = "===============================================================" +
                    "\n Digite uma das opções abaixo:" +
                    "\n     0 - Sair do Cadastro" + 
                    "\n     1 - Para cadastrar fornecedores" +
                    "\n     2 - Para listar fornecedores" +
                    "\n  ===============================================================";

            Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0 )
                {
                    break;
                }
                else if (valor == 1 )
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o CNPJ do Fornecedor: ");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o nome do Fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Gerente: ");
                    fornecedor.CPF = Console.ReadLine();

                    fornecedor.Gravar();

                }
                else
                {
                    var fornecedores = new Fornecedor().Ler() ;
                    foreach (Fornecedor c in fornecedores)
                    {
                        Console.WriteLine("======================================================================");
                        Console.WriteLine("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF do gerente: " + c.CPF);
                        Console.WriteLine("======================================================================");
                    }
                }
            }
        }
    }
}
