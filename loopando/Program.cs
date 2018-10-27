using System;
using System.Collections.Generic;

namespace loopando
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0, idade = 0;

            Console.ForegroundColor = ConsoleColor.Blue;

            for (int a = 1; a <= 10; a++){
                Console.WriteLine("Informe a Idade: ");
                idade = Int32.Parse(Console.ReadLine());
                if(idade >= 18){
                    quantidade++;
                }
            }

            Console.WriteLine("Ha {0} pessoa(s) maior(es) de idade", quantidade);

        }
    }
}
