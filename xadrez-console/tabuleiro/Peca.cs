namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro tab {  get; protected set; } 

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            this.tab = tab;
        }
    }
}
