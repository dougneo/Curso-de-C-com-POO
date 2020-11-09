using System;
using System.Globalization;

namespace Abertura_de_Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria corrente = new ContaBancaria();
            
            Console.Write("Entre o número da conta: ");
            corrente.Numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Entre o titular da conta: ");
            corrente.Titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial(s / n) ? ");
            char di = char.Parse(Console.ReadLine());
           
            Console.Write("Entre o valor de depósito inicial: ");
            corrente.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(corrente);
            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            corrente.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizado");
            Console.WriteLine(corrente);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            corrente.Saque(quantia);
            Console.WriteLine("Dados da conta atualizado");
            Console.WriteLine(corrente);
        }
    }
}





/*Entre o número da conta: 8532
Entre o titular da conta: Alex Green
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 500.00
Dados da conta:
Conta 8532, Titular: Alex Green, Saldo: $ 500.00
Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 700.00
Entre um valor para saque: 300.00
Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 395.00*/