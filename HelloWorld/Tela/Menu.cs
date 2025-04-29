using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculo;
using Diretorio;
using Funcoes;

namespace Tela
{
    internal class Menu
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_usuario = 5;
        public const int FORNECEDOR = 6;
        public static void Criar()
        {
            while (true)
            {
                Console.WriteLine("========================= Menu ===============================");
                string mensagem = "OLÁ ÚSUARIO, BEM VINDO AO PROGRAMA,  APLICAÇÃO CONSOLE FINAL" +
                    "\n  Digite uma das opções abaixo:" +
                    "\n     0 - Sair do programa" +
                    "\n     1 - Para ler Arquivos" +
                    "\n     2 - Para executar a tabuada" +
                    "\n     3 - Para executar o calculo da média de alunos" +
                    "\n     4 - Cadastrar clientes"+
                    "\n     5 - Cadastrar usuario" +
                    "\n     6 - Cadastrar Fornecedor" +
                    "\n  ===============================================================";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa ");

                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("========================= Opcção ler Arquivos ===============================");
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("========================= Opcção ler Tabuada ===============================");
                    Console.WriteLine("Digite o numero que deseja na tabuada");

                    int num = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(num);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Alunos();
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                }
                else if (valor == CADASTRAR_usuario)
                {
                    TelaUsuario.Chamar();
                }
                else if (valor == FORNECEDOR)
                {
                    TelaFornecedor.Chamar();
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente");
                }

            }
        }
    }
}
