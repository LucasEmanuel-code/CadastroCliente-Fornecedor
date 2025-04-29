using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Funcoes
{
    internal class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("=======================Cadastro de usuario=============================");

            while (true) {
            string mensagem = "===============================================================" +
                    "\n Digite uma das opções abaixo:" +
                    "\n     0 - Sair do Cadastro" + 
                    "\n     1 - Para cadastrar usuarios" +
                    "\n     2 - Para listar usuarios" +
                    "\n  ===============================================================";

            Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0 )
                {
                    break;
                }
                else if (valor == 1 )
                {
                    var usuario = new usuario();
                    Console.WriteLine("Digite o nome do usuario: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do usuario: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do usuario: ");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();

                }
                else
                {
                    var usuarios = new usuario().Ler();
                    foreach (usuario c in usuarios)
                    {
                        Console.WriteLine("======================================================================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                        Console.WriteLine("======================================================================");
                    }
                }
            }
        }
    }
}
