using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas_aula02_operadores
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
            // 2.1) Faça um programa que pergunte ao usuário ano de nascimento e imprima sua idade.


            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Tarefa Idade --------------------------------------\n\n");
            Console.Write("Insira o ano de seu nascimento: ");
            Console.WriteLine();


            int year = int.Parse(Console.ReadLine());
            int momentYear = 2022;

            Console.WriteLine($"\nOlá você possui {momentYear - year} anos de idade!");
            Console.ReadLine();


        }
        static void Task_02()
        {
            // 2.2) Escreva um programa que leia 10 valores inteiros e ao final exiba a soma dos números.
            //SEM TRATAMENTO DE ERRO


            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Tarefa Soma --------------------------------------\n\n");
            Console.Write("Insira 10 ( dez ) números para serem somados.\n");

            int[] vetor = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($" - {i + 1}°) ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                soma += vetor[i];
            }

            Console.Write("\n A soma dos valores: ");
            vetor.ToList().ForEach(p => Console.Write(p.ToString() + " + "));
            Console.WriteLine($" É igual a {soma}");


            Console.ReadLine();

        }

        static void Task_03()
        {


            /* 2.3) Escreva um programa que leia o número de horas trabalhadas de um funcionário, o valor que recebe por 
             * hora e calcule o salário desse funcionário. A seguir, mostre o número de horas e o salário do funcionário, 
             * com duas casas decimais.
             */

            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Salário --------------------------------------\n\n");
            Console.Write("\nInforme o número de horas trabalhadas ");

            int hours = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o valor por hora trabalhada, que o usuário recebe. ");

            float wage = float.Parse(Console.ReadLine());

            Console.WriteLine($"Quantidade de horas trabalhadas: {hours}\nSalário final recebido: R$ {(hours * wage).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }

        static void Task_04()
        {
            /* 2.4) Leia um valor inteiro correspondente à idade de uma pessoa e mostre-a em anos, meses e dias.
             * Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. 
             * Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. 
             * Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
            */
            //INTERPRETANDO PARA RECEBER A DATA DE NASCIMENTO

            Console.WriteLine();
            Console.WriteLine("-------------------------------------- Idade --------------------------------------\n\n");
            Console.Write("\nInforme sua idade: ");
            int years = int.Parse(Console.ReadLine());

            int month = 12 * years;

            int days = month * 30;

            Console.WriteLine("--------------------------------------Com variáveis--------------------------------------\n\n");
            Console.WriteLine($" Olá, sua idade é {years} anos\n Representando {month} meses ou\n {days} dias de idade! ");

            Console.WriteLine("--------------------------------------Sem variáveis--------------------------------------\n\n");
            Console.WriteLine($" Olá, sua idade é {years} anos\n Representando {years * 12} meses ou\n {years * 365} dias de idade! ");

            Console.ReadLine();
        }

        static void Task_05()
        {

            /* 2.5) Construa um conversor de moedas:
            * Crie um programa que solicite um valor em real ao usuário e converta esse valor, para:
            * DOLAR
            * EURO
            * LIBRA ESTERLINA
            * DÓLAR CANADENSE
            * PESO ARGENTINO
            * PESO CHILENO
            * Para esse exercício você precisará realizar uma pesquisa para saber a cotação de cada moeda em real. 
            * Mostrar o resultado no formato símbolo da moeda e valor, como o exemplo R$ 10,00 para a moeda real.*/

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-------------------------------------- Conversor --------------------------------------\n\n");
            Console.Write("\nInforme o valor em R$(real) para ser convertido: ");

            float value = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe para qual moeda deseja realizar a conversão.\n\n Opções:\n 1 para DOLAR\n 2 para LIBRA ESTERLINA\n" +
                " 3 para DÓLAR CANADENSE\n 4 para PESO ARGENTINO\n 5 para PESO CHILENO\n 6 para EURO ");

            int choice = int.Parse(Console.ReadLine());

            float dolar = 4.87f;
            float euro = 5.21f;
            float libra = 6.13f;
            float canadianDollar = 3.89f;
            float argentinianPeso = 0.040f;
            float chileanPeso = 0.0059f;

            if (choice == 1)
            {
                Console.WriteLine($" Opção: 1\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Dolar US$ {(value / dolar).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 2)
            {
                Console.WriteLine($" Opção: 2\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Libras Esterlina £ {(value / libra).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 3)
            {
                Console.WriteLine($" Opção: 3\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Dolar Canadense CAD {(value / canadianDollar).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 4)
            {
                Console.WriteLine($" Opção: 4\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Peso Argentino ARS {(value / argentinianPeso).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 5)
            {
                Console.WriteLine($" Opção: 5\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Peso Chileno CLP {(value / chileanPeso).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (choice == 6)
            {
                Console.WriteLine($" Opção: 6\n Valor em real R$ {value.ToString("F2", CultureInfo.InvariantCulture)}\n Valor convertido para Euro € {(value / euro).ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.ReadLine();
        }
    }
}
