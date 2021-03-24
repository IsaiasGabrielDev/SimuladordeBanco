using System;
using System.Globalization;

namespace SimuladorBanco_aplicandoconhecimento
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;
            


            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            String Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char dimenu = char.Parse(Console.ReadLine());

            if (dimenu == 's')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, Titular, value);


            }
            else
            {
                conta = new ContaBancaria(numero, Titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarFundos(value2);
            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RemoverFundos(value2);
            Console.WriteLine();
            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);


        }
    }
}
