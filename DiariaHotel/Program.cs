using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiariaHotel
{
    internal class Program
    {
        static void Main(string[] args)//calcular o preço de uma hospedagem
        {
            //valor por dia
            Console.WriteLine("Insira o valor da diária:");
                int diaria = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de adultos:");
                int adulto = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o número de crianças:");
                int kid = int.Parse(Console.ReadLine());
            int diatotal = (diaria * adulto) + (kid *diaria/2);
            Console.WriteLine("Valor por dia:" + diatotal.ToString("C"));

            //valor por semana(total)
            Console.WriteLine();
            Console.WriteLine("Insira o número de dias da hospedagem:");
                int dias = int.Parse(Console.ReadLine());
            int totalh = diatotal * dias;
            Console.WriteLine("Valor total da hospedagem" + totalh.ToString("C"));

            //Parcelas
            Console.WriteLine();
            Console.WriteLine("Insira o número de parcelas:");
                int parcela = int.Parse(Console.ReadLine());
            int vparcela = totalh/parcela;
            Console.WriteLine("Valor de cada parcela:" + vparcela.ToString("C"));


            Console.ReadKey();
        }
    }
}
