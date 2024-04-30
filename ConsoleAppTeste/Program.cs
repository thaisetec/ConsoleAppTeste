using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = { "joão", "pedro", "maria" };
            Console.WriteLine("digite um numero de 0 a 2;");
            int i =int.Parse(Console.ReadLine());
            Console.WriteLine("o nome selecionado foi:" + nome[i]);
            Console.ReadKey();
        }
    }
}
