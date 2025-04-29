using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
     class Tabuada
    {
        public static void Calcular(int num)
        {
            Console.WriteLine("============================ Calculo da tabuada do " + num + "=====================================");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num + " X " + i + " = " + (num * i));
            }
            Console.WriteLine("=================================================================");
        }
    }
}
