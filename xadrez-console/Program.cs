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

            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(3, 5));
            Tela.imprimirTabuleiro(tab);
        }
    }
}
