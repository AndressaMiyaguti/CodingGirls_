using System;
using System.Globalization;
namespace Aula07_exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crie uma classe Conta Bancária que possua os seguintes atributos: número da conta, 
            nome do cliente e saldo privados. Além dos métodos de get para os atributos crie um 
            método para alterar o nome, realizar depósitos e saques. Também construa um construtor 
            onde saldo é opcional, com valor default zero, já os demais atributos são obrigatórios.*/



            ContaBancaria conta;
            Console.WriteLine(" Cadastro Inicial ");
            Console.WriteLine();

            Console.Write(" Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write(" Informe o nome do titular da conta: ");
            string titular = Console.ReadLine().ToUpper();

            Console.Write(" Haverá depósito inicial? \n [ 1 ] SIM\n [ 2 ] NÃO ");
            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                Console.Write(" Informe o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine(" Dados da conta:");
            Console.WriteLine(conta);

            bool navegacao = conta.Sessao();
            while (navegacao)
            {
                Console.WriteLine();
                Console.WriteLine(" Digite:\n [ 1 ] SAQUE\n [ 2 ] DEPOSITO\n [ 3 ] ATUALIZAR NOME\n [ 4 ] FINALIZAR SESSÃO");
                int res = int.Parse(Console.ReadLine());

                if (res == 1)
                {

                    Console.Write(" Informe o valor para saque: ");
                    double quantia = double.Parse(Console.ReadLine());
                    conta.Saque(quantia);
                    Console.WriteLine(" Dados da conta atualizados:");
                    Console.WriteLine(conta);
                }
                else if (res == 2)
                {
                    Console.WriteLine();
                    Console.Write(" Informe o valor para depósito: ");
                    double quantia = double.Parse(Console.ReadLine());
                    conta.Deposito(quantia);

                    Console.WriteLine(" Dados da conta atualizados:");
                    Console.WriteLine(conta);
                }
                else if (res == 3)
                {
                    Console.Write(" Informe o nome do titular atualizado: ");
                    string titularAtualizado = Console.ReadLine();
                    conta.AtualizaNomeTitular(titularAtualizado.ToUpper());

                    Console.WriteLine("  da conta atualizados:");
                    Console.WriteLine(conta);
                }
                else
                {
                    Console.WriteLine("  SESSÃO FINALIZADA.");
                    navegacao = false;
                    
                }
                Console.ReadLine();
            }
        }      
        
    }
    
}
