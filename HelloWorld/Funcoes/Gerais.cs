using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
     class Gerais
    {
        public int Calcular2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static int Calcular()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }
        public static void MostrarMensagemTela()
        {
            Console.WriteLine("Mostrando mensagem na tela");
        }

    }
}
