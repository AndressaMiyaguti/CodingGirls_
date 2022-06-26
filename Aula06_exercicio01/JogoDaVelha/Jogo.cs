using Aula06_exercicio01.layout;


namespace Aula06_exercicio01.JogoDaVelha
{
    class Jogo
    {
        public Layout tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }



        private void mudaJogador() 
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        static void ModificaMatriz(int choiceplayer, string player , Layout tab) 
        {
            string[,] tabuleiro = new string[tab.linhas, tab.colunas];

            if (choiceplayer > 0 && choiceplayer <= 9)
            {
                //Valida se o espaço já foi escolhido e altera o valor.
                if (choiceplayer == 1 && tabuleiro[0, 0] != "X" && tabuleiro[0, 0] != "O")
                {
                    tabuleiro[0, 0] = player;
                }
                else if (choiceplayer == 2 && tabuleiro[0, 1] != "X" && tabuleiro[0, 1] != "O")
                {
                    tabuleiro[0, 1] = player;
                }
                else if (choiceplayer == 3 && tabuleiro[0, 2] != "X" && tabuleiro[0, 2] != "O")
                {
                    tabuleiro[0, 2] = player;
                }
                else if (choiceplayer == 4 && tabuleiro[1, 0] != "X" && tabuleiro[1, 0] != "O")
                {
                    tabuleiro[1, 0] = player;
                }
                else if (choiceplayer == 5 && tabuleiro[1, 1] != "X" && tabuleiro[1, 1] != "O")
                {
                    tabuleiro[1, 1] = player;
                }
                else if (choiceplayer == 6 && tabuleiro[1, 2] != "X" && tabuleiro[1, 2] != "O")
                {
                    tabuleiro[1, 2] = player;
                }
                else if (choiceplayer == 7 && tabuleiro[2, 0] != "X" && tabuleiro[2, 0] != "O")
                {
                    tabuleiro[2, 0] = player;
                }
                else if (choiceplayer == 8 && tabuleiro[2, 1] != "X" && tabuleiro[2, 1] != "O")
                {
                    tabuleiro[2, 1] = player;

                }
                else if (choiceplayer == 9 && tabuleiro[2, 2] != "X" && tabuleiro[2, 2] != "O")
                {
                    tabuleiro[2, 2] = player;
                }
                else
                {
                    throw new TabuleiroException(" Essa lacuna já está preenchida, escolha outra posição!");
                }
            }
            else
            {
                throw new TabuleiroException("Posição inválida!"); 
            }

        }

    }
}
