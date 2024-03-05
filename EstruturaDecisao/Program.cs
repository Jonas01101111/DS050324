using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro número:");
                int n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
                int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a operação desejada(+,-,/,*):");
                string op = Console.ReadLine();

            //decisoes :D
            double res = 0;
            
            if (op == "+")
            {
                res = n1 + n2;
            }
            else if (op == "-")
            {
                res = n1- n2;
            }
            else if (op == "*")
            {
                res = n1* n2;
            }
            else 
            {
                res = n1 / n2;
            }

            Console.WriteLine("resultado:" + res);
            Console.ReadKey();
        }
    }
}
