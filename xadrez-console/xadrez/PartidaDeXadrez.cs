using tabuleiro;
using System;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            mudaJogador();
        }

        public void validarPosicaoOrigem (Posicao pos)
        {
            if (Tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição escolhida!");
            }
            if (JogadorAtual != Tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("A peça escolhida não possui movimentos possíveis!");
            }
        }

        public void validarPosicaoDestino(Posicao origem, Posicao Destino)
        {
            if (!Tab.peca(origem).podeMoverPara(Destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
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
            Tab.colocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            Tab.colocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.colocarPeca(new Peao(Tab, Cor.Branca), new PosicaoXadrez('f', 2).ToPosicao());
        }

    }
}
