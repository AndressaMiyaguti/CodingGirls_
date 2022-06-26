using System;
using System.Globalization;

namespace Aula05_exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina. 
             * Cada objeto dessa classe deve guardar os seguintes dados do aluno: matrícula, nome, 
             * 2 notas de prova e 1 nota de trabalho. Escreva os seguintes métodos para esta classe:
             * Calcular média: calcula e exibe a média final do aluno com base em suas notas;
             * Calculo nota final: calcula quanto o aluno precisa tirar na prova final para ser aprovado.*/

            Console.WriteLine();
            Console.WriteLine("------------------------------------- Formulário Simples Cadastro de Alunos ----------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Insira os dados do Alunos ---------------------------------------------");

            //variável para armazenar os atributos;
            Aluno dadosAluno = new Aluno();


            Console.Write(" Nome: ");
            dadosAluno.Nome = Console.ReadLine().ToUpper();

            Console.Write(" Matrícula: ");
            dadosAluno.Matricula = int.Parse(Console.ReadLine());

            Console.Write(" Nota primeira prova : ");
            dadosAluno.Nota_prova01 = double.Parse(Console.ReadLine());

            Console.Write(" Nota segunda prova : ");
            dadosAluno.Nota_prova02 = double.Parse(Console.ReadLine());

            Console.Write(" Nota do projeto : ");
            dadosAluno.Nota_trabalho = double.Parse(Console.ReadLine());

            Console.WriteLine(" Dados do aluno: \n" + dadosAluno);
           // Console.WriteLine(dadosAluno.resultadoFinal());

            Console.ReadLine();
        }
    }
}
