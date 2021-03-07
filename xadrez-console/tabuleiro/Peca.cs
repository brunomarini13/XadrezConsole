namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }

        public Cor Cor { get; protected set; }

        public int NumeroDeMovimentos { get; protected set; }

        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            NumeroDeMovimentos = 0;
        }

        public abstract bool[,] movimentosPossiveis();

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void IncrementarQteMovimento()
        {
            NumeroDeMovimentos++;
        }

        public void DecrementarQteMovimento()
        {
            NumeroDeMovimentos--;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
