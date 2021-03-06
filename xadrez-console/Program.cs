using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 3));

            Tela.imprimirTabuleiro(tab);
        }
    }
}
