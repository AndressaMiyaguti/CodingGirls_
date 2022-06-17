using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_01();
            Task_02();
            Task_03();
            Task_04();
            Task_05();

        }

        static void Task_01()
        {
            /*  Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
             *  A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
             *  As notas consideradas são de 100, 50, 20, 10, 5, 2.
             *  Entrada: 576.73
             *  Exemplo de Saída: NOTAS: 5 nota(s) de R$ 100.00 1 nota(s) de R$ 50.00 1 nota(s) de R$ 20.00 0 nota(s)
             *  de R$ 10.00 1 nota(s) de R$ 5.00 0 nota(s) de R$ 2.008
             *  */

            Console.WriteLine("\n---------------------------------- Cédulas ----------------------------------\n\n ");
            Console.Write(" Insira o valor a ser decomposto:");

            float bankNote = float.Parse(Console.ReadLine());
            float leftovers;
            float hundred;
            float fifty;
            float twenty;
            float ten;
            float five;
            float two;

            if (bankNote >= 100.00)
            {
                hundred = bankNote / 100;
                leftovers = bankNote % 100;
                Console.Write($" Obteremos:\n {(int)hundred} nota(s) de 100.00");
                fifty = leftovers / 50;
                leftovers = leftovers % 50;
                Console.Write($" {(int)fifty} nota(s) de 50.00");
                twenty = leftovers / 20;
                leftovers = leftovers % 20;
                Console.Write($" {(int)twenty} nota(s) de 20.00");
                ten = leftovers / 10;
                leftovers = leftovers % 10;
                Console.Write($" {(int)ten} nota(s) de 10.00");
                five = leftovers / 5;
                leftovers = leftovers % 5;
                Console.Write($" {(int)five} nota(s) de 5.00");
                two = leftovers / 2;
                Console.Write($" e {(int)two} nota(s) de 2.00 .");

                Console.ReadLine();

            }

            Console.ReadLine();

        }

        static void Task_02()
        {
            /*
             Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da 
            mensagem “x é o maior”. 
            Exemplo de Entrada 7 14 106
            Exemplo de Saída 106 é o maior
            */
            Console.WriteLine("\n---------------------------------- Maior ----------------------------------\n\n ");
            Console.WriteLine(" Insira três números para verificar qual tem o maior valor: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                Console.WriteLine($" O número {n1} é  de maior valor");
            else if (n2 > n3)
                Console.WriteLine($" O número {n2} é  de maior valor");
            else
                Console.WriteLine($" O número {n3} é  de maior valor");

            Console.ReadLine();
        }

        static void Task_03()
        {
            /*
             Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno. 
            Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal. Imprima se 
            o aluno foi aprovado ou reprovado considerando a média 7.
            Exemplo de Entrada 7 8 3
            Exemplo de Saída O aluno tirou 6 e foi reprovado.*/

            Console.WriteLine("\n---------------------------------- Aprovado / Reprovado ----------------------------------\n\n ");
            Console.WriteLine(" Insira as três notas do aluno:  ");

            float grade1 = float.Parse(Console.ReadLine());
            float grade2 = float.Parse(Console.ReadLine());
            float grade3 = float.Parse(Console.ReadLine());

            float mean = (grade1 + grade2 + grade3) / 3;

            if (grade1 > 10 || grade2 > 10 || grade3 > 10 || grade1 < 0 || grade2 < 0 || grade3 < 0)
            {
                Console.WriteLine(" Nota inválida!\n Não foi possível calcular a média do aluno, pois há nota(s) inválidas!");
            }
            else if (mean >= 7)
            {
                Console.WriteLine($" Aluno APROVADO com nota {mean.ToString("F1")}");
            }
            else
                Console.WriteLine($" Aluno REPROVADO com nota {mean.ToString("F1")}");


            Console.ReadLine();
        }

        static void Task_04()
        {
            /*
             Leia 3 valores que são as três notas de um aluno. A seguir, calcule a média do aluno.
             Se a nota for menor que 6.0, deve exibir a nota F.
             Se a nota for de 6.0 até 7.0, deve exibir a nota D.
             Se a nota for entre 7.0 e 8.0, deve exibir a nota C.
             Se a nota for entre 8.0 e 9.0, deve exibir a nota B.
             Se a nota fot entre 9.0 e 10.0, deve exibir um belo de um A.
             Não esqueça de adicionar uma mensagem após a nota, pode ser um simples parabéns para aprovação ou algo mais complexo.
             Exemplo de Entrada 10 8 9
             Exemplo de Saída O aluno tirou A. Parabéns!*/

            Console.WriteLine("\n---------------------------------- Nota ----------------------------------\n\n ");


            Console.Write("Digite o nome do aluno: ");

            string name = Console.ReadLine();

            Console.WriteLine(" Insira as três notas do aluno:  ");

            float grade01 = float.Parse(Console.ReadLine());
            float grade02 = float.Parse(Console.ReadLine());
            float grade03 = float.Parse(Console.ReadLine());

            float mean = (grade01 + grade02 + grade03) / 3;

            if (grade01 > 10 || grade02 > 10 || grade03 > 10 || grade01 < 0 || grade02 < 0 || grade03 < 0)
            {
                Console.WriteLine(" Nota inválida!\n Não foi possível calcular a média do aluno, pois há nota(s) inválidas!");
            }
            else if (mean < 6)
            {
                Console.WriteLine($" \n {name} sua nota final é F.\n\n A reprovação é direta e terá que refazer o módulo. ");
            }
            else if (mean <= 7)
            {
                Console.WriteLine($" \n {name} sua nota final é D.\n\n Você voi reprovado(a).\n Tem a opção de refazer o módulo ou solicitar uma nova avaliação no período de 7 dias. ");
            }
            else if (mean <= 8)
            {
                Console.WriteLine($" \n {name} sua nota final é C.\n\n Você foi aprovado(a).\n Caso deseje poderá solicitar uma nova avaliação no período de 7 dias. ");
            }
            else if (mean <= 9)
            {
                Console.WriteLine($" Parabéns {name}, você foi aprovado(a).\nCaso deseje poderá solicitar uma nova avaliação no período de 7 dias. ");
            }
            else if (mean < 10)
            {
                Console.WriteLine($" Parabéns {name}, você foi Aprovado(a)!");
            }
            else

                Console.WriteLine($" Parabéns {name}, você foi Aprovado(a) com a nota MÁXIMA" +
                    $".");


            Console.ReadLine();
        }

        static void Task_05()
        {
            /*
             A Blue resolveu dar um aumento de salários a seus funcionários de acordo com os dados abaixo:
            Salário de 0 até 400.00 ganha 15% Salário de 400.01 até 800.00 ganha 12% Salário de 800.01 até 
            1200.00 ganha 10% Salário de 1200.01 até 2000.00 ganha 7% Acima de 2000.00 ganha 4%
            Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste 
            ganho e o índice reajustado, em percentual.
            Exemplo de Entrada 400.00
            Exemplo de Saída Novo salario: 460.00 Reajuste ganho: 60.00 Em percentual: 15 %*/

            Console.WriteLine("\n---------------------------------- Salário ----------------------------------\n\n ");


            Console.Write("Informe o nome do funcionário: ");
            string name = Console.ReadLine();

            Console.Write($"Informe o salário {name} : ");
            float wage = float.Parse(Console.ReadLine());

            float difference;

            if (wage < 0)
            {
                Console.WriteLine("Salário não contempla reajuste.");
            }
            else if (wage >= 0 && wage <= 400)
            {
                difference = wage * 0.15f;
                wage = wage + difference;

                Console.WriteLine($" O funcionário(a) {name} receberá {wage.ToString("F2")} tendo reajuste ganho de {difference.ToString("F2")} . Representando um percentual de 15%");
            }
            else if (wage >= 400.01 && wage <= 800)
            {
                difference = wage * 0.12f;
                wage = wage + difference;

                Console.WriteLine($" O funcionário(a) {name} receberá {wage.ToString("F2")} tendo reajuste ganho de {difference.ToString("F2")} . Representando um percentual de 12%");
            }
            else if (wage >= 800.01 && wage <= 1200.00)
            {
                difference = wage * 0.10f;
                wage = wage + difference;

                Console.WriteLine($" O funcionário(a) {name} receberá {wage.ToString("F2")} tendo reajuste ganho de {difference.ToString("F2")} . Representando um percentual de 10%");
            }
            else if (wage >= 12000.01 && wage <= 2000)
            {
                difference = wage * 0.7f;
                wage = wage + difference;

                Console.WriteLine($" O funcionário(a) {name} receberá {wage.ToString("F2")} tendo reajuste ganho de {difference.ToString("F2")} . Representando um percentual de 7%");
            }
            else
            {
                difference = wage * 0.4f;
                wage = wage + difference;

                Console.WriteLine($" O funcionário(a) {name} receberá {wage.ToString("F2")} tendo reajuste ganho de {difference.ToString("F2")} . Representando um percentual de 4%");
            }
            Console.ReadLine();



        }


    }
}
