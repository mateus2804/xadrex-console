using xadrez_console.tabuleiro;
using xadrez_console.JogoXadrez;


namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Cavalo(Cor.Branco, tabuleiro), new Posicao(3, 2));

            Tela.imprimirTabuleiro(tabuleiro);
        }
    }
}
