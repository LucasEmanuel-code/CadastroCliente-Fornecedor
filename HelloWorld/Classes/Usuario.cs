using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Classes
{
    public class usuario : Base
    {
        public usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public usuario() { }

        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivo()))
            {
                string conteudoArquivo = File.ReadAllText(diretorioComArquivo());
                if (!string.IsNullOrWhiteSpace(conteudoArquivo))
                {
                    var tipo = typeof(List<>).MakeGenericType(this.GetType());
                    var listaObjetos = JsonConvert.DeserializeObject(conteudoArquivo, tipo);

                    if (listaObjetos is IEnumerable<Object> lista)
                    {
                        foreach (var item in lista)
                        {
                            if (item is IPessoa pessoa)
                            {
                                dados.Add(pessoa);
                            }
                        }
                    }
                }

            }
            return dados;
        }
    }
}