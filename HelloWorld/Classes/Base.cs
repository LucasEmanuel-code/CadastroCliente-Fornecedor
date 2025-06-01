  using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace Classes
{
    public abstract class Base : IPessoa
    {
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Base() { }

        public string Nome;
        public string Telefone;
        public string CPF;
        private string sobrenomes = "Santos";

        public void SetNome(string nome) {  this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }
        public virtual void Gravar()
        { 
            var dados = this.Ler();
            dados.Add(this);
            
            string json = JsonConvert.SerializeObject(dados, Formatting.Indented);
            File.WriteAllText(diretorioComArquivo(), json);
        }
        public abstract List<IPessoa> Ler();
        internal string diretorioComArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".json";
        }
        public virtual void Olhar()
        {
            Console.WriteLine("O usuario " + this.Nome + " " + this.sobrenomes);
        }
        protected int CalcularUmMaisDois()
        {
            return 1 + 2;
        }
        private int CalcularUmMaisDois2()
        {
            return 1 + 2;
        }
        public int CalcularUmMaisDois3()
        {
            return 1 + 2;
        }
        internal int CalcularUmMaisDois4()
        {
            return 1 + 2;
        }
    }
}
