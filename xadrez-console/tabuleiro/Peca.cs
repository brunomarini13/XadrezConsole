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

        public void IncrementarQteMovimento()
        {
            NumeroDeMovimentos++;
        }
    }
}
