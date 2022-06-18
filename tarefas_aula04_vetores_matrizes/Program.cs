using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas_aula04_vetores_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
            Task02();
            Task03();
            Task04();
            Task05();
            
           

        }

        static void Task01()
        {
            /*Crie um programa que solicite a entrada de 10 números pelo usuário, armazenando-os em um vetor, 
             * e então monte outro vetor com os valores do primeiro multiplicados por 5.
             * Exiba os valores dos dois vetores na tela, um em cada linha.*/

            Console.WriteLine("\n-------------------------------------------- Vetor --------------------------------------------\n\n");
            Console.WriteLine(" Informe 10 números para serem multiplicados:\n\n ");



            int[] vetor01 = new int[10];
            int[] vetor02 = new int[10];

            int soma = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"- {i + 1}°) ");
                vetor01[i] = Convert.ToInt16(Console.ReadLine());
                soma += vetor01[i];

                for (int j = 0; j < 10; j++)
                {
                    vetor02[j] = vetor01[j] * 5;

                }
            }
            Console.WriteLine("\n\n Números inseridos :{ " + String.Join(",", vetor01) + " } ");
            Console.WriteLine("\n\n Resultado dos números inseridos multiplicados por 5 : {" + String.Join(",", vetor02) + "}");
            Console.ReadLine();
        }

        static void Task02()
        {
            /*Crie um programa que armazene 10 números digitados pelo usuário em dois vetores: 
             * um somente para números pares, e outro somente para números ímpares. Após, exiba 
             * os valores dos dois vetores na tela, um vetor em cada linha.*/

            Console.WriteLine("\n-------------------------------------------- Pares / Ímpares --------------------------------------------\n\n");
            Console.WriteLine(" Infome 10 números para serem separados entre pares e ímpares:\n\n ");


            //Variável (pairs e odd) para gerar a quantidade do vetor par e ímpar
            int pairs = 0;
            int odd = 0;
            int[] auxiliar = new int[10];


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"- {i + 1}°) ");
                auxiliar[i] = Convert.ToInt16(Console.ReadLine());


                if (auxiliar[i] % 2 == 0)
                {
                    pairs++;
                }
                else
                {
                    odd++;

                }
            }
            //atribuição da quantidade no vetor
            int[] vetorPar = new int[pairs];
            int[] vetorImpar = new int[odd];

            //Variavel para contagem do indice
            int iPar = 0, iImpar = 0;

            for (int i = 0; i < 10; i++)
            {
                if (auxiliar[i] % 2 == 0)
                {

                    vetorPar[iPar++] = auxiliar[i];
                }
                else
                {
                    vetorImpar[iImpar++] = auxiliar[i];
                }
            }



            Console.WriteLine(" Numeros inseridos {" + String.Join(",", auxiliar) + "}");
            Console.WriteLine(" Quantidade de numeros pares :" + pairs);
            Console.WriteLine(" Quantidade de numeros ímpares :" + odd);
            Console.WriteLine($" Os números digitados, foram separados em dois grupos, descritos abaixo\n\n Números pares: {String.Join(",", vetorPar)} \n Números ímpares: {String.Join(",", vetorImpar)}  ");

            Console.ReadLine();


        }
        static void Task03()
        {
            /*Crie um programa que lê 5 palavras e as ordena em um vetor de strings pelo seu tamanho. 
             * Se o tamanho das strings for igual, deve-se manter a ordem inserida pelo usuário.*/

            Console.WriteLine("\n-------------------------------------------- Palavras --------------------------------------------\n\n");
            Console.WriteLine(" Escreva 5 palavras para serem ordenadas por sua quantidade de letras:\n\n ");

            string[] words = new string[5];


            for (int i = 0; i < 5; i++)
            {

                Console.Write($"- {i + 1}°) ");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("\n Palavras inseridas : {" + String.Join(",", words) + "}");

            Array.Sort(
                words,
                new Comparison<String>((s1, s2) => s1.Length.CompareTo(s2.Length))
            );


            Console.WriteLine("\n As palavras inseridas foram organizadas da seguinte forma: {" + String.Join(",", words) + "}");

            Console.ReadLine();
        }

        static void Task04()
        {
            /*                  Jogo Jokenpô
             *Utilizando os conceitos aprendidos até estruturas de repetição, crie um programa que jogue pedra, 
             *papel e tesoura (Jokenpô) com você.
             *Permitir que eu decida quantas rodadas iremos fazer;
             *Ler a minha escolha (Pedra, papel ou tesoura);
             *Decidir de forma aleatória a decisão do computador;
             *Mostrar quantas rodadas cada jogador ganhou;
             *Determinar quem foi o grande campeão de acordo com a quantidade de vitórias de cada um (computador e jogador);
             *Perguntar se o Jogador quer jogar novamente, se sim inicie volte a escolha de quantidade de rodadas, 
             *se não finalize o programa.*/

            Console.WriteLine("\n-------------------------------------------- Jokenpô --------------------------------------------\n\n");

            Console.Write("\n Quantas vezes você quer jogar? : ");
            int turns = int.Parse(Console.ReadLine());

            Console.Write(" Qual seu nome:  ");
            string playerName = Console.ReadLine();
            // Quantidade de vitórias do usúario
            int playerWins = 0;
            //Escolha do usuário
            string choice;


            // Vetor com as possíbilidades aleatórias
            string[] ArrayrndChoice = { "Pedra", "Papel", "Tesoura" };
            string choiceRandom;
            int cpuWins = 0;



            for (int i = 0; i < turns; i++)
            {

                Random rnd = new Random();

                int rndChoice = rnd.Next(ArrayrndChoice.Length);
                //Recebe o resultado aleatório, tendo como dados disponíveis o tamanho total do array
                choiceRandom = ArrayrndChoice[rndChoice];

                Console.WriteLine(" Qual sua escolha:\n [1] Pedra\n [2] Papel\n [3] Tesoura  ");
                choice = Console.ReadLine();

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    Console.WriteLine(" Opção inválida, ponto adicionado automaticamente para o computador!\n Mais atenção na próxima rodada.\n");
                    cpuWins++;
                }
                else if (choice == "1" && choiceRandom == "Pedra" || choice == "2" && choiceRandom == "Papel" || choice == "3" && choiceRandom == "Tesoura")
                {
                    Console.WriteLine($" Escolha de {playerName} : {choice}\n Escolha do computador : {choiceRandom}\n");
                    Console.WriteLine(" EMPATE, nenhum jogador recebe pontuação!\n\n");
                }
                else if (choice == "1" && choiceRandom == "Tesoura" || choice == "2" && choiceRandom == "Pedra" || choice == "3" && choiceRandom == "Papel")
                {
                    Console.WriteLine($"\n Escolha de {playerName} : {choice}\n Escolha do computador : {choiceRandom}\n");
                    Console.WriteLine($"\n\n {playerName} você ganhou essa jogada !!!\n\n");

                    playerWins++;
                }
                else
                {
                    Console.WriteLine($"\n Escolha de {playerName} : {choice}\n Escolha do computador : {choiceRandom}\n");
                    Console.WriteLine($"\n\n {playerName} você perdeu essa jogada !!!");
                    Console.WriteLine("\n O computador deu mais sorte nessa.\n\n");
                    cpuWins++;
                }

            }

            if (playerWins > cpuWins)
            {
                Console.WriteLine($" O ganhador é você {playerName}. \n \n {playerName} : {playerWins} X {cpuWins} : computador.\n----------- PARABÉNS! -----------\n\n");
            }
            else if (playerWins < cpuWins)
            {
                Console.WriteLine($" Que pena, não foi dessa vez! \n \n Computador: {cpuWins} X {playerWins} : {playerName}.\n----------- MAIS SORTE NA PRÓXIMA! -----------\n\n");
            }
            else
            {
                Console.WriteLine($" EMPATE!\n \n {playerName} : {playerWins} X {cpuWins} : computador.\n----------- ESSA FOI POR POUCO! -----------\n\n");
            }

            Console.ReadLine();
        }
        static void Task05()
        {
            /*                              Jogo da Velha
             *Crie um algorítimo que possibilite que dua pessoas joguem o jogo da velha e exiba quem foi o vencedor.
             *O tabuleiro é uma matriz de três linhas e três colunas.
             *Dois jogadores escolhem uma marcação cada um, geralmente um círculo (O) e um xis (X).
             *Os jogadores jogam alternadamente, uma marcação por vez, numa célula que esteja vazia.
             *O objetivo é conseguir três círculos ou três xis em linha, quer horizontal, vertical 
             *ou diagonal , e ao mesmo tempo, quando possível, impedir o adversário de ganhar na próxima jogada.
             *Quando um jogador conquista o objetivo ele é o vencedor. Se os dois jogadores jogarem sempre 
             *da melhor forma, o jogo terminará sempre em empate ou seja "Deu a Velha!".*/


            Console.WriteLine("\n\n--------------------------------------------------- JOGO DA VELHA ---------------------------------------------------\n");
            //Nome do 1° usuário
            Console.Write(" Player1 digite seu nome:  ");
            string playerName01 = Console.ReadLine().ToUpper();

            //Escolha entre X ou O;;
            Console.Write(" Player1 escolha\n [1] para X\n [2] para O:  ");

            string player1 = Console.ReadLine();
            string player2;

            //Valida opção digitada do símbolo
            if (player1 != "1" && player1 != "2")
            {
                //Garante inicio do jogo após validação
                while (player1 != "1" && player1 != "2")
                {
                    Console.WriteLine("Opção inválida!");
                    Console.Write(" Player1 escolha\n [1] para X\n [2] par O:  ");
                    player1 = Console.ReadLine();
                }
            }
            if (player1 == "1")
            {
                player2 = "O";
                player1 = "X";
            }
            else
            {
                player1 = "O";
                player2 = "X";
            }

            //Nome 2° jogador
            Console.Write(" Player 2 digite seu nome:  ");
            string playerName02 = Console.ReadLine().ToUpper();

            //-------------------------------------------------------------------------------------------------------

            Console.WriteLine("------------------------------------------------------ Iniciando -----------------------------------------------------");
            Console.WriteLine($"\n   Player01 : {playerName01} representando [ {player1} ]\n   Player02 : {playerName02} representando [ {player2} ] \n ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------\n\n");



            //Tabuleiro
            string[,] itemMatriz = new string[3, 3]
            {
                {"1", "2", "3" },
                { "4", "5", "6"},
                {"7", "8", "9" }
            };
            // Quantidade de vitórias do usúario
            int player01Wins = 0;
            int player02Wins = 0;
            //Escolha da posição
            int choiceplayer01;
            int choiceplayer02;



            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"    {itemMatriz[0, 0]}         |       {itemMatriz[0, 1]}        |       {itemMatriz[0, 2]}");
                Console.WriteLine("________________________________________________");
                Console.WriteLine($"    {itemMatriz[1, 0]}         |       {itemMatriz[1, 1]}        |       {itemMatriz[1, 2]}");
                Console.WriteLine("________________________________________________");
                Console.WriteLine($"    {itemMatriz[2, 0]}         |       {itemMatriz[2, 1]}        |       {itemMatriz[2, 2]}");



                Console.WriteLine("\n\n" +
                    "____________________________________________________________________________________________________________________________");
                Console.Write($"\n {playerName01} informe o número da posição que deseja jogar:  \n\n");
                string auxiliar = Console.ReadLine();
                /* if (auxiliar != "1" && auxiliar != "2" && auxiliar != "3" && auxiliar != "4" && auxiliar != "5" && auxiliar != "6" && auxiliar != "7" && auxiliar != "8" && auxiliar != "9")
                 {

                     Console.WriteLine("Opção inválida!");
                     while (auxiliar != "1" && auxiliar != "2" && auxiliar != "3" && auxiliar != "4" && auxiliar != "5" && auxiliar != "6" && auxiliar != "7" && auxiliar != "8" && auxiliar != "9")
                     {                        
                         Console.Write($"\n {playerName01} informe o número da posição que deseja jogar:  \n\n");
                         auxiliar = Console.ReadLine();
                         Console.WriteLine("esse é " + auxiliar);                      

                     }
                     Console.WriteLine("consegui");
                     choiceplayer01 = int.Parse(auxiliar);
                 }
                 else
                 {
                     choiceplayer01 = int.Parse(auxiliar);
                 }*/
                choiceplayer01 = int.Parse(auxiliar);





                //passando matriz, jogador e posição para ModificaMatriz 
                ModificaMatriz(choiceplayer01, player1, itemMatriz);
                //ganhador01 recebe verificaGanhador com matriz como atributo
                string ganhador01 = VerificaGanhador(itemMatriz);

                if (ganhador01 == player1)
                {
                    //Adiciona ponto para o jogador caso seja vencedor
                    player01Wins++;
                    Console.WriteLine($"-------------------------------------------------------- PARABÉNS! ------------------------------------------------------");
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ {playerName01} você GANHOU! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
                    Console.WriteLine($"-------------------------------------------------------- PLACAR --------------------------------------------------------\n");
                    Console.WriteLine($"\n {playerName01} : {player01Wins}  X  {player02Wins} : {playerName02} \n");
                    Console.WriteLine("_______________________________________________________________________________________________________________\n\n\n");

                    //Opção de continuar jogando com os mesmos usuários
                    Console.WriteLine(" Jogar novamente?\n\n [ 1 ] SIM\n\n [ 2 ] NÃO");
                    string play = Console.ReadLine();

                    if (play == " 2 ")
                    {
                        break;
                    }
                    else
                    {
                        //"Zera" Matriz para iniciar o jogo
                        itemMatriz = new string[3, 3]
                        {
                        {"1", "2", "3" },
                        { "4", "5", "6"},
                        {"7", "8", "9" }
                        };

                    }
                }
                else if (ganhador01 == "empate")
                {
                    Console.WriteLine("--------------------------- Empate ---------------------------");
                    Console.WriteLine(" Jogar novamente?\n\n [ 1 ] SIM\n\n [ 2 ] NÃO");
                    //armazena resposta
                    string play = Console.ReadLine();
                    //verifica resposta
                    if (play == " 2 ")
                    {
                        break;
                    }
                    //Optanto por jogar novamente "Zerar" matriz
                    else
                    {
                        itemMatriz = new string[3, 3]
                        {
                        {"1", "2", "3" },
                        { "4", "5", "6"},
                        {"7", "8", "9" }
                        };

                    }
                }

                Console.WriteLine();
                Console.WriteLine($"    {itemMatriz[0, 0]}         |       {itemMatriz[0, 1]}        |       {itemMatriz[0, 2]}");
                Console.WriteLine("________________________________________________");
                Console.WriteLine($"    {itemMatriz[1, 0]}         |       {itemMatriz[1, 1]}        |       {itemMatriz[1, 2]}");
                Console.WriteLine("________________________________________________");
                Console.WriteLine($"    {itemMatriz[2, 0]}         |       {itemMatriz[2, 1]}        |       {itemMatriz[2, 2]}");
                Console.WriteLine("____________________________________________________________________________________________________\n\n");
                Console.Write($"\n {playerName02} informe o número da posição que deseja jogar:  \n");

                auxiliar = Console.ReadLine();
                /*  if (auxiliar != "1" && auxiliar != "2" && auxiliar != "3" && auxiliar != "4" && auxiliar != "5" && auxiliar != "6" && auxiliar != "7" && auxiliar != "8" && auxiliar != "9")
                  {
                      Console.WriteLine("Opção inválida!");
                      while (auxiliar != "1" && auxiliar != "2" && auxiliar != "3" && auxiliar != "4" && auxiliar != "5" && auxiliar != "6" && auxiliar != "7" && auxiliar != "8" && auxiliar != "9")
                      {
                          Console.Write($"\n {playerName01} informe o número da posição que deseja jogar:  \n\n");
                          auxiliar = Console.ReadLine();
                          Console.WriteLine("esse é " + auxiliar);

                      }
                      choiceplayer02 = int.Parse(auxiliar);
                  }
                  else
                  {
                      choiceplayer02 = int.Parse(auxiliar);
                  }*/
                choiceplayer02 = int.Parse(auxiliar);


                ModificaMatriz(choiceplayer02, player2, itemMatriz);
                string ganhador02 = VerificaGanhador(itemMatriz);

                if (ganhador02 == player2)
                {
                    player02Wins++;
                    Console.WriteLine($"------------------------------------- PARABÉNS! -------------------------------------");
                    Console.WriteLine($"\n {playerName02} você é o vencedor");
                    Console.WriteLine($"------------------------------------- PLACAR _________________________________________");
                    Console.WriteLine($"\n {playerName02} : {player02Wins}  X  {player01Wins} : {playerName01} ");

                    //Opção de continuar jogando com os mesmos usuários
                    Console.WriteLine(" Jogar novamente?\n\n [ 1 ] SIM\n\n [ 2 ] NÃO");
                    string play = Console.ReadLine();

                    if (play == " 2 ")
                    {
                        break;
                    }
                    else
                    {
                        //"Zera" Matriz para iniciar o jogo
                        itemMatriz = new string[3, 3]
                        {
                    {"1", "2", "3" },
                    { "4", "5", "6"},
                    {"7", "8", "9" }
                        };

                    }
                }
                else if (ganhador02 == "empate")
                {
                    Console.WriteLine(" Jogar novamente?\n\n [ 1 ] SIM\n\n [ 2 ] NÃO");
                    string play = Console.ReadLine();

                    if (play == " 2 ")
                    {
                        break;
                    }
                    else
                    {
                        itemMatriz = new string[3, 3]
                        {
                    {"1", "2", "3" },
                    { "4", "5", "6"},
                    {"7", "8", "9" }
                        };

                    }
                }
            }
        }

        static string VerificaGanhador(string[,] itemMatriz)
        {
            // Se linhaMatriz na posição 0,1,2 são iguais, retorna seu valor 
            if (itemMatriz[0, 0] == itemMatriz[0, 1] && itemMatriz[0, 1] == itemMatriz[0, 2])
            {
                return itemMatriz[0, 0];
            }
            else if (itemMatriz[1, 0] == itemMatriz[1, 1] && itemMatriz[1, 1] == itemMatriz[1, 2])
            {
                return itemMatriz[1, 0];
            }
            else if (itemMatriz[2, 0] == itemMatriz[2, 1] && itemMatriz[2, 1] == itemMatriz[2, 2])
            {
                return itemMatriz[2, 0];
            }
            // Se os valores da coluna são iguais, retorna seu valor
            else if (itemMatriz[0, 0] == itemMatriz[1, 0] && itemMatriz[1, 0] == itemMatriz[2, 0])
            {
                return itemMatriz[0, 0];
            }
            else if (itemMatriz[0, 1] == itemMatriz[1, 1] && itemMatriz[1, 1] == itemMatriz[2, 1])
            {
                return itemMatriz[0, 1];
            }
            else if (itemMatriz[0, 2] == itemMatriz[1, 2] && itemMatriz[1, 2] == itemMatriz[2, 2])
            {
                return itemMatriz[0, 2];
            }
            // Se na diagonal os valores são iguais, retorna seu valor
            else if (itemMatriz[0, 0] == itemMatriz[1, 1] && itemMatriz[1, 1] == itemMatriz[2, 2])
            {
                return itemMatriz[0, 0];
            }
            else if (itemMatriz[0, 2] == itemMatriz[1, 1] && itemMatriz[1, 1] == itemMatriz[2, 0])
            {
                return itemMatriz[0, 2];
            }
            else
            {
                //Verifica se todos os campos foram preenchidos e se houve empate
                Boolean empate = true;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (itemMatriz[i, j] != "X" && itemMatriz[i, j] != "O")
                        {
                            empate = false;
                            break;
                        }
                    }
                    if (empate == false)
                    {
                        break;
                    }

                }
                if (empate)
                {
                    return "empate";
                }

            }
            return String.Empty;
        }


        static void ModificaMatriz(int choiceplayer, string player, string[,] itemMatriz)
        {
            //verifica se o número digitado referente a posição é válido

            if (choiceplayer > 0 && choiceplayer <= 9)
            {
                //Valida se o espaço já foi escolhido e altera o valor.
                if (choiceplayer == 1 && itemMatriz[0, 0] != "X" && itemMatriz[0, 0] != "O")
                {
                    itemMatriz[0, 0] = player;
                }
                else if (choiceplayer == 2 && itemMatriz[0, 1] != "X" && itemMatriz[0, 1] != "O")
                {
                    itemMatriz[0, 1] = player;
                }
                else if (choiceplayer == 3 && itemMatriz[0, 2] != "X" && itemMatriz[0, 2] != "O")
                {
                    itemMatriz[0, 2] = player;
                }
                else if (choiceplayer == 4 && itemMatriz[1, 0] != "X" && itemMatriz[1, 0] != "O")
                {
                    itemMatriz[1, 0] = player;
                }
                else if (choiceplayer == 5 && itemMatriz[1, 1] != "X" && itemMatriz[1, 1] != "O")
                {
                    itemMatriz[1, 1] = player;
                }
                else if (choiceplayer == 6 && itemMatriz[1, 2] != "X" && itemMatriz[1, 2] != "O")
                {
                    itemMatriz[1, 2] = player;
                }
                else if (choiceplayer == 7 && itemMatriz[2, 0] != "X" && itemMatriz[2, 0] != "O")
                {
                    itemMatriz[2, 0] = player;
                }
                else if (choiceplayer == 8 && itemMatriz[2, 1] != "X" && itemMatriz[2, 1] != "O")
                {
                    itemMatriz[2, 1] = player;

                }
                else if (choiceplayer == 9 && itemMatriz[2, 2] != "X" && itemMatriz[2, 2] != "O")
                {
                    itemMatriz[2, 2] = player;
                }
                else
                {
                    Console.WriteLine(" Essa lacuna já está preenchida, escolha outra posição!");
                    // recebe nova posição
                    int novaPosicao = int.Parse(Console.ReadLine());
                    //Função recursiva com o novo atributo de posição
                    ModificaMatriz(novaPosicao, player, itemMatriz);
                }
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

        }


    }
}
