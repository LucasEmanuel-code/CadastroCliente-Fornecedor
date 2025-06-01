using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                int valor;
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Opção inválida! Digite um número");
                    continue;
                }
                if (valor == 0 )
                {
                    break;
                }
                else if (valor == 1 )
                {
                    var usuario = new usuario();
                    var usuarioCadastro = new usuario().Ler().Cast<usuario>().ToList();

                    bool nomeValido = false;
                    do
                    {
                        Console.WriteLine("Digite o nome do Cliente: ");
                        string nome = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                        {
                            usuario.Nome = nome;
                            nomeValido = true;
                        }
                        else
                        {
                            Console.WriteLine("Nome inválido! Deve ter pelo menos 3 caracteres.");
                        }
                    } while (!nomeValido);

                    bool telefoneValido = false;
                    do
                    {
                        Console.WriteLine("Digite o Telefone do Fornecedor (com DDD, apenas números): ");
                        string telefone = Console.ReadLine();

                        if (ValidarTelefone(telefone))
                        {
                            if (usuarioCadastro.Any(f => f.Telefone == telefone))
                            {
                                Console.WriteLine("Telefone já cadastrado! Digite um Telefone diferente.");
                            }
                            else
                            {
                                usuario.Telefone = telefone;
                                telefoneValido = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Telefone inválido! Deve conter 10 ou 11 dígitos.");
                        }
                    } while (!telefoneValido);

                    bool cpfValido = false;
                    do
                    {
                        Console.WriteLine("Digite o CPF do Gerente (apenas números): ");
                        string cpf = Console.ReadLine();

                        if (ValidarCPF(cpf))
                        {
                            if (usuarioCadastro.Any(f => f.CPF == cpf))
                            {
                                Console.WriteLine("CPF já cadastrado! Digite um CPF diferente.");
                            }
                            else
                            {
                                usuario.CPF = cpf;
                                cpfValido = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido! Deve conter 11 dígitos numéricos.");
                        }
                    } while (!cpfValido);

                    usuario.Gravar();
                    Console.WriteLine("Usuario cadastrado com sucesso");
                }
                else if (valor == 2)
                {
                    var usuarios = new usuario().Ler();
                    if(usuarios.Count == 0)
                    {
                        Console.WriteLine("Nenhum for");
                    }
                    else
                    {
                        foreach (usuario c in usuarios)
                        {
                            Console.WriteLine("======================================================================");
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Telefone: " + FormatTelefone(c.Telefone));
                            Console.WriteLine("CPF: " +FormatCPF(c.CPF));
                            Console.WriteLine("======================================================================");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opcção inválida! Digite 0, 1 ou 2.");
                }
            }
        }
        private static bool ValidarCPF(string cpf)
        {
            cpf = Regex.Replace(cpf, @"[^\d]", "");
            return cpf.Length == 11 && cpf.All(char.IsDigit);
        }
        private static bool ValidarTelefone(string telefone)
        {
            telefone = Regex.Replace(telefone, @"[^\d]", "");
            return (telefone.Length == 10 || telefone.Length == 11) && telefone.All(char.IsDigit);
        }
        private static string FormatCPF(string cpf)
        {
            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11) return cpf;
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
        }
        private static string FormatTelefone(string telefone)
        {
            if (string.IsNullOrEmpty(telefone)) return telefone;

            telefone = Regex.Replace(telefone, @"[^\d]", "");

            if (telefone.Length == 10)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6)}";
            }
            else if (telefone.Length == 11)
            {
                return $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7)}";
            }

            return telefone;
        }
    }
}
