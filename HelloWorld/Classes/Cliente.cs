using System.IO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Classes
{
    public class Cliente : Base
    {
        public Cliente(string nome, string telefone, string cpf )
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Cliente (int telefone)
        {
            this.Telefone = telefone.ToString();
        }
        public Cliente()
        {

        }

        public static string Teste;

        public override List<IPessoa> Ler()
        {
			var dados = new List<Cliente>();
			if (File.Exists(diretorioComArquivo()))
			{
				var conteudoArquivo = File.ReadAllText(diretorioComArquivo());
				dados = JsonConvert.DeserializeObject<List<Cliente>>(conteudoArquivo);
			}

			return dados.Cast<IPessoa>().ToList();
		}
	}
}
