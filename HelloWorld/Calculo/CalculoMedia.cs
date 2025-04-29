using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo

{
    class Media
    {
        public static void Alunos()
        {

            Console.WriteLine("========================= Opcção ler Média do Aluno ===============================");
            Console.WriteLine("Digite o nome do aluno");
            string name = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + "notas do aluno " + name);
            List<int> notas = new List<int>();
            int TotalNota = 0;
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota numero " + i);
                int nota = int.Parse(Console.ReadLine());
                TotalNota += nota;
                notas.Add(nota);
            }
            int media = TotalNota / notas.Count;
            Console.WriteLine("A méida do aluno " + name + " é: " + media);
            Console.WriteLine("Suas notas são:\n");
            foreach (int nota in notas)
            {
                Console.WriteLine("Nota: " + nota + "\n");
            }

        }
    }
}
