using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula06_exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             A fim de representar empregados em uma empresa, crie uma classe chamada Empregado que inclui os 
            seguintes atributos; nome, cargo e salário mensal.
            Sua classe deve ter um construtor que inicializa os três atributos e também fornecer métodos que 
            executem as seguintes ações:
            Se o salário mensal não for positivo, configure-o como 0.0.
            Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: Salário de 0 até 
            400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 1200.00 ganha 10% Salário 
            de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4% Imprimir o salário de um funcionário.*/

            Console.WriteLine();
            Console.WriteLine("__________________________ Cadastro de funcionários __________________________");
            Console.WriteLine();

           
            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            Empregados emp = new Empregados();
            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(" Número de registro do funcionário: ");
                emp.Id = int.Parse(Console.ReadLine());

                Console.WriteLine(" Nome do " + i + "° funcionário :");
                emp.Nome = Console.ReadLine();

                Console.WriteLine(" Cargo :");
                emp.Cargo = Console.ReadLine();

                Console.Write(" Salario : ");
                emp.SalarioMensal = double.Parse(Console.ReadLine());
                

                list.Add(new Empregados(emp.Id, emp.Nome,  emp.Cargo, emp.SalarioMensal));
                Console.WriteLine();
            }

         //   Empregados empr =  list.FindAll();//Traz todos elementos que tenham tamanho maior que 5
            Console.WriteLine("---------------------");
           
            
            Console.Write("Pesquisa de funcionario ");
            Console.WriteLine(" Deseja acessar? \n [ 1 ] SIM\n [ 2 ] NÃO");
            int res = int.Parse(Console.ReadLine());
            if(res == 1)
            {
                Console.WriteLine(" Insira o número do registro: ");
                int reqId = int.Parse(Console.ReadLine());

                Empregados empr = list.Find(x => x.Id == reqId);

                Console.WriteLine(emp);


                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lista de funcionário");
                Console.WriteLine(" Deseja acessar? \n [ 1 ] SIM\n [ 2 ] NÃO");
                res = int.Parse(Console.ReadLine());
                if (res == 1)
                {
                    foreach (Empregados obj in list)
                    {
                        Console.WriteLine(obj);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine(" Sessão encerrada.");
                }
            }
            
            
            
            Console.ReadLine();
        }
    }
    

}
