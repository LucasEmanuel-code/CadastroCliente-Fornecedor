using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Diretorio

{
     class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["caminho_arquivos"];
        }
        public static void Ler(int numeroArquivo)
        {
            string arquivoComCaminho = caminhoArquivo() + "arq" + numeroArquivo;
            Console.WriteLine("========================= Lendo Arquivo ===============================\n" + arquivoComCaminho + "\n===========================================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\\ArquivoLucas\\arq" + (numeroArquivo + 1);

            if (File.Exists(arquivoComCaminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }

        }
    }
}
