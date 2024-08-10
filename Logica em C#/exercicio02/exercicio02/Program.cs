using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Dados da Compra--------");
            Console.WriteLine("Digite seu Saldo: ");
            string saldo = Console.ReadLine();

            Console.WriteLine("Digite seu Nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite seu Produto: ");
            string Produto = Console.ReadLine();

            Console.WriteLine("----------------Dados da Compra----------------");
            Console.WriteLine("Produto:" + Produto);

            Console.WriteLine("Nome:" + Nome);

            Console.WriteLine("Saldo:" + saldo);
            Console.ReadLine();


        }
    }
}
