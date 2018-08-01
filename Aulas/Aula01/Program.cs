using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        public static int Id { get; set; }
        public static int Id2 { get; set; }
        public static int Conta { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello lixo!");
            Console.ReadKey();

            Console.WriteLine("Digite o primeiro número");

            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");

            Id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: 1- para soma -- 2 para subtração -- 3 para multiplicação -- 4 para divisão");

            Conta = int.Parse(Console.ReadLine());

            if(Conta == 1)
            {
                Console.WriteLine("Soma: " + (Id + Id2));

            } else if(Conta == 2)
            {
                Console.WriteLine("Subtração:" + (Id - Id2));

            } else if(Conta == 3)
            {
                Console.WriteLine("Multiplicação: " + (Id * Id2));
            } else
            {
                Console.WriteLine("Divisão: " + (Id / Id2));
            }
            
            Console.ReadKey();
        }
    }
}
