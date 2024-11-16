
using projeto01;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        contaBancaria conta;

        Console.Write("entre com o numero da conta: ");
        int n=int.Parse(Console.ReadLine());

        Console.Write("entre com o nome do titular da conta: ");
        string nome = Console.ReadLine();
        Console.Write("deja fazer o deposito inicial (s/n): ");
        char a = char.Parse(Console.ReadLine());

        if (a == 's')
        {
            Console.Write("entre com o valor de deposito inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            conta = new contaBancaria(n, nome, saldo);
            
            Console.WriteLine("dados da conta: ");
            Console.WriteLine($"\t conta: {conta.Numero_da_conta}" +
                $" titular: {conta.titular_da_conta} Saldo: {conta.Saldo}");
        }

        else
        {
            conta = new contaBancaria (n, nome);
            Console.WriteLine("dados da conta: ");
            Console.WriteLine($"\t conta: {conta.Numero_da_conta}" +
                $" titular: {conta.titular_da_conta} Saldo: {conta.Saldo}");
        }

        Console.WriteLine("entre com um valor para o  deposito");
        double valor = double.Parse(Console.ReadLine());    
        
        
        conta.Deposito(valor);
        Console.WriteLine("dados da conta atualizados: ");
        Console.WriteLine($"\t conta: {conta.Numero_da_conta}" +
            $" titular: {conta.titular_da_conta} Saldo: {conta.Saldo}");


        Console.WriteLine("entre com um valor para saque: ");
        valor = double.Parse(Console.ReadLine());
        conta.Saque(valor);

        Console.WriteLine("dados da atualizados: ");
        Console.WriteLine($"\t conta: {conta.Numero_da_conta}" +
            $" titular: {conta.titular_da_conta} Saldo: {conta.Saldo}");

    }
}