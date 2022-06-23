using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas_aula05_introducao_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task01();
              Task02();

            



        }
        static void Task01()
        {
            /*
             1 ) Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
                 Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
                 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
                 - Calcular média: calcula e exibe a média final do aluno com base em suas notas;
                 - Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.*/


            Console.WriteLine("\n\n------------------------------------- Formulário Simples Cadastro de Alunos ----------------------------------\n\n");
            Console.WriteLine("\n\n-------------------------------------- Insira os dados do Alunos ---------------------------------------------\n\n");

            //variável para armazenar os atributos;
            Alunos dadosAlunos = new Alunos();

            Console.Write(" Nome: ");
            dadosAlunos.Nome = Console.ReadLine().ToUpper();

            Console.Write(" Matrícula: ");
            dadosAlunos.Matricula = int.Parse(Console.ReadLine());

            Console.Write(" Nota primeira prova : ");
            dadosAlunos.Nota_prova01 = double.Parse(Console.ReadLine());

            Console.Write(" Nota segunda prova : ");
            dadosAlunos.Nota_prova02 = double.Parse(Console.ReadLine());

            Console.Write(" Nota do projeto : ");
            dadosAlunos.Nota_trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine(" Dados do aluno: " + dadosAlunos);
            Console.WriteLine(dadosAlunos.Calculo_para_Aprov_Reprov());

            Console.ReadLine();

        }

        static void Task02() {

            Console.WriteLine(" Dados do aluno: " + dadosAlunos );
            Console.WriteLine( dadosAlunos.Calculo_para_Aprov_Reprov());

            Console.ReadLine();

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
                 - Ver horário: Imprime a data e o horário do vôo.*/


            Voos voos = new Voos();

            Console.WriteLine("\n\n_____________________________________ Faça sua reserva _____________________________________ ");

            Console.WriteLine();

            Console.Write("\n Insira seu nome: \n\n");
            voos.Nome = Console.ReadLine();

            Console.Write("\n Local de Destino: \n\n");
            voos.Destino = Console.ReadLine();

            Console.Write("\n Período: \n [ 1 ] MANHÃ\n [ 2 ] TARDE\n [ 3 ] NOITE\n\n");
            voos.VerificaVoo(int.Parse(Console.ReadLine()));


            Console.ReadLine();
            /*

                 - Ver horário: Imprime a data e o horário do vôo.


             3 )  Crie uma classe Calculadora, que possui como métodos a multiplicação, divisão, subtração e 
                 - soma de dois valores e exibe para o usuário.*/


        }

    }
}
