
namespace Componentes.cs
{
    public class Ferramentas
    {
        internal string MetodoSomenteAssembly()
        {
            return "Este método só pode ser acessado dentro deste assembly componentes";
        }
        public string MetodoTodosAssembly()
        {
            return "Este método é para todos";
        }
        public bool ValidarCPF(string cpf)
        {
            return true;
        }

    }
}
