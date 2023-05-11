using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Operadores
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos
            int adicao = 5 + 3;
            int subtracao = 5 - 3;
            int multiplicacao = 5 * 3;
            int divisao = 15 / 3;

            int expressao = (1 + 2) * (5 - 2) / 2;

            // Operadores relacionais
            string c1 = "blumenau";
            string c2 = "teresopolis";

            bool ret1 = c1 == c2;
            bool ret2 = c1 != c2;

            int i = 2;
            int j = 5;

            bool ret3 = i == j;
            bool ret4 = i != j;
            bool ret5 = i > j;
            bool ret6 = i >= j;
            bool ret7 = i < j;
            bool ret8 = i <= j;

            // Operadores lógicos
            bool ret9 = i == j && c1 == c2; // AND
            bool ret10 = i == j || c1 == c2; // OR
            bool ret11 = !(i == j && c1 == c2); // NOT
            Console.WriteLine("i == j" + (i == j));
            Console.WriteLine(" c1 == c2" + (c1 == c2));
            Console.WriteLine(ret9);

        }
    }
}
