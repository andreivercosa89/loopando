using System;

namespace loopando
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Informe um numero: ");
            numero = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++){
                //Console.WriteLine(numero + " x " + i + " = "+ (numero * i));
                Console.WriteLine(" {0} x {1} = {2}", numero, i, (numero * i));
            }
        }
    }
}
