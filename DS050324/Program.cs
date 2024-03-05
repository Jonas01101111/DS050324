using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)//atividade:calcular o salário de alguem
        {
        //entrada :)
        Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Salário bruto:");
                int bruto = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Alimentação:");
                int alim = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Número de filhos:");
                int nfilho = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Valor por filho:");
                int vfilho = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Número de horas:");
                int nhoras = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Valor por hora:");
                int vhoras = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor do INSS:");
                int inss = int.Parse(Console.ReadLine()); 
        Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Valor do IRPF:");
                int irpf = int.Parse(Console.ReadLine()); 
            //fim da entrada B)
            Console.ResetColor();
            int liq = bruto + alim + (vfilho * nfilho) + (nhoras * vhoras) - inss - irpf;//calculo :D

            Console.WriteLine("Salário liquido:" + liq.ToString("C"));
            Console.ReadKey();
        }
    }
}
