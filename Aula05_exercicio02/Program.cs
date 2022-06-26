using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula05_exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 ) Escreva uma classe em que cada objeto representa um vôo que acontece em determinada data 
                 e em determinado horário. Cada vôo possui no máximo 100 passageiros, e a classe permite 
                 controlar a ocupação das vagas.
                 A classe deve ter os seguintes métodos:
                 - Ocupar Vaga: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro, 
                   e retorna verdadeiro se a cadeira ainda não estiver ocupada (operação foi bem sucedida) 
                   e falso caso contrário
                 - Vagas Livres: retorna o número de cadeiras vagas disponíveis (não ocupadas) no vôo;
                 - Cadeira Livre: Retorna o número da próxima cadeira livre;
                 - Ocupa: ocupa determinada cadeira do vôo, cujo número é recebido como parâmetro. 
                   Caso a cadeira esteja ocupada exibe uma mensagem, caso esteja vazia, reserva e exibe uma 
                   mensagem de confirmação;
                 - Ver horário: Imprime a data e o horário do vôo.*/

            Voos voos = new Voos();

            Console.WriteLine("\n\n_____________________________________ Faça sua reserva _____________________________________ ");

             
            
            while (!voos.finalizar)
           {
                
                Console.Write("\n Insira o assento de sua escolha:");
                string escolha = Console.ReadLine().ToUpper();                
                voos.VerificaAssentos( escolha);
               // Console.Write("\n Insira o assento de sua escolha:");
                
           }

            voos.VooManha();

            /*  Console.Write("\n Insira seu nome: \n\n");
              voos.Nome = Console.ReadLine();

              Console.Write("\n Local de Destino: \n\n");
              voos.Destino = Console.ReadLine();

              Console.Write("Insira a data de sua viagem (DD/MM/YYYY): ");
              DateTime date = DateTime.Parse(Console.ReadLine());

              Console.Write("\n Período: \n [ 1 ] MANHÃ\n [ 2 ] TARDE\n [ 3 ] NOITE\n\n");
              voos.VerificaVoo(int.Parse(Console.ReadLine()));

              */
           
            Console.ReadLine();
        }
    }
}
