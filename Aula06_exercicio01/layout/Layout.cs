using Aula06_exercicio01.layout;
using System;



namespace Aula06_exercicio01
{
    class Layout
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Cor cor { get; protected set; }



        public Layout(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            //Atribuir a matriz a quantidade de linha e colunas que o tabuleiro terá
           
        }
        public static void imprimirTabuleiro(Layout tab)
        {
            string[,] tabuleiro = new string[tab.linhas, tab.colunas];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    count++;
                    if(tabuleiro[i,j] == null)
                    {
                        Console.Write($"  {count}  |");
                    }
                    else
                    {
                        LayoutTabuleiro(tab);
                   
                    }
                 
                }
                Console.WriteLine();
                Console.WriteLine("____________________");
                Console.WriteLine();


            }
            Console.ReadLine();
        }
       
        public static void LayoutTabuleiro(Layout tab)
        {

            
            if (tab.cor == Cor.Branca)
            {
                Console.Write($"  {tab}  |");
            }
            else
            {
                //ConsoleColor tipo do c# referente a cor do sistema armazenando na variavel a cor atual que é cinza.
                ConsoleColor aux = Console.ForegroundColor;
                //Modifica a cor padrão para amarelo
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Exibe a peça com a cor alterada
                Console.Write($"  {tab}  |");
                //Retorna a cor padrão
                Console.ForegroundColor = aux;
            }
            
            
        }

    }
}
