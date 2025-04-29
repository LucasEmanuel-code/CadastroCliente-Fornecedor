using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public Fornecedor(string nome, string telefone, string cpf, string cNPJ)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.CNPJ = cNPJ;
        }
        public Fornecedor() { }
        public override void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            string json = JsonConvert.SerializeObject(dados, Formatting.Indented);
            File.WriteAllText(diretorioComArquivo(), json);
        }
        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioComArquivo()))
            {
                string conteudoArquivo = File.ReadAllText(diretorioComArquivo());
                if(!string.IsNullOrWhiteSpace(conteudoArquivo))
                {
                   var tipo = typeof(List<>).MakeGenericType(this.GetType());
                   var listaObjetos = JsonConvert.DeserializeObject(conteudoArquivo, tipo);
                   
                   if (listaObjetos is IEnumerable<Object> lista)
                    {
                        foreach ( var item in lista)
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
