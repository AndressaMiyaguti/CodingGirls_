using Aula06_exercicio01.layout;
using System;
using System.Collections.Generic;


namespace Aula06_exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Jogo da Velha
            Lembra do nosso jogo da velha da aula de matrizes? Vamos refazê - lo orientado a objetos?
            Crie uma classe para o Jogo da Velha:
            A classe deve conter como dados privados uma matriz 3x3 para representar a grade do jogo
            O construtor deve inicializar a matriz vazia
            Forneça um método para exibir a matriz com status do jogo
            Permita dois jogadores humanos
            Forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia; depois de 
            cada movimento valide se uma vitória ou um empate.*/
            
            //Layout.imprimirTabuleiro(tab);
            try
            {
                Layout tab = new Layout(3, 3);
              
              // tab.colocarPeca(new X(tab, Cor.Preta), new Posicao(0, 1));

                Layout.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                throw new TabuleiroException("Posição inválida!");
            }
            Console.ReadLine();
        }
    }
}
