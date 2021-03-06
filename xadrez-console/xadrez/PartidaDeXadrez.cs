using tabuleiro;
using System;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQteMovimento();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            Tab.colocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            Tab.colocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.colocarPeca(new Dama(Tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            Tab.colocarPeca(new Bispo(Tab, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
            Tab.colocarPeca(new Cavalo(Tab, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());
        }

    }
}
