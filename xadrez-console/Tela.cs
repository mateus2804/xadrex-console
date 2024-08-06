using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i =0; i < tab.linhas; i++)
            {
                Console.Write($"{tab.linhas - i} ");
                for (int j =0; j < tab.colunas; j++)
                {
                    if (tab.getPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.getPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.Write(" ");
            for (int k = 0; k <  tab.colunas; k++)
            {
                Console.Write($" {(char)('a' + k)}");
            }
        }
        
    }
}
