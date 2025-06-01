using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Text.RegularExpressions;

namespace Funcoes
{
    internal class TelaFornecedor
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public static void Chamar()
        {

            Console.WriteLine("=======================Cadastro de Fornecedor=============================");

            while (true)
            {
                string mensagem = "===============================================================" +
                        "\n Digite uma das opções abaixo:" +
                        "\n     0 - Sair do Cadastro" +
                        "\n     1 - Para cadastrar fornecedores" +
                        "\n     2 - Para listar fornecedores" +
                        "\n  ===============================================================";

                Console.WriteLine(mensagem);

                int valor;
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Opção inválida! Digite um número.");
                    continue;
                }

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var fornecedor = new Fornecedor();
                    var fornecedoresCadastrados = new Fornecedor().Ler().Cast<Fornecedor>().ToList();

                    bool cnpjValido = false;
                    do
                    {
                        Console.WriteLine("Digite o CNPJ do Fornecedor (apenas números): ");
                        string cnpj = Console.ReadLine();

                        if (ValidarCNPJ(cnpj))
                        {
                            if (fornecedoresCadastrados.Any(f => f.CNPJ == cnpj))
                            {
                                Console.WriteLine("CNPJ já cadastrado! Digite um CNPJ diferente.");
                            }
                            else
                            {
                                fornecedor.CNPJ = cnpj;
                                cnpjValido = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("CNPJ inválido! Deve conter 14 dígitos numéricos.");
                        }
                    } while (!cnpjValido);

                    bool nomeValido = false;
                    do
                    {
                        Console.WriteLine("Digite o nome do Fornecedor: ");
                        string nome = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nome) && nome.Length >= 3)
                        {
                            fornecedor.Nome = nome;
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
                            if (fornecedoresCadastrados.Any(f => f.Telefone == telefone))
                            {
                                Console.WriteLine("Telefone já cadastrado! Digite um Telefone diferente.");
                            }
                            else
                            {
                                fornecedor.Telefone = telefone;
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
                            if (fornecedoresCadastrados.Any(f => f.CPF == cpf))
                            {
                                Console.WriteLine("CPF já cadastrado! Digite um CPF diferente.");
                            }
                            else
                            {
                                fornecedor.CPF = cpf;
                                cpfValido = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido! Deve conter 11 dígitos numéricos.");
                        }
                    } while (!cpfValido);

                    fornecedor.Gravar();
                    Console.WriteLine("Fornecedor cadastrado com sucesso!");
                }
                else if (valor == 2)
                {
                    var fornecedores = new Fornecedor().Ler();
                    if (fornecedores.Count == 0)
                    {
                        Console.WriteLine("Nenhum fornecedor cadastrado ainda.");
                    }
                    else
                    {
                        foreach (Fornecedor c in fornecedores)
                        {
                            Console.WriteLine("======================================================================");
                            Console.WriteLine("CNPJ: " + FormatCNPJ(c.CNPJ));
                            Console.WriteLine("Nome: " + c.Nome);
                            Console.WriteLine("Telefone: " + FormatTelefone(c.Telefone));
                            Console.WriteLine("CPF do gerente: " + FormatCPF(c.CPF));
                            Console.WriteLine("======================================================================");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite 0, 1 ou 2.");
                }
            }
        }

        private static bool ValidarCNPJ(string cnpj)
        {
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");
            return cnpj.Length == 14 && cnpj.All(char.IsDigit);
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

        private static string FormatCNPJ(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj) || cnpj.Length != 14) return cnpj;
            return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12)}";
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