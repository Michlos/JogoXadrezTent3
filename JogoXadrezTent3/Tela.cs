using System;

using tabuleiro;

using xadrez;

namespace JogoXadrezTent3
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor bgOriginal = Console.BackgroundColor;
            ConsoleColor bgAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = bgAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = bgOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = bgOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());

            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            ConsoleColor bgColor = Console.BackgroundColor;
            ConsoleColor fgColor = Console.ForegroundColor;
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(peca);
                    Console.BackgroundColor = bgColor;
                    Console.ForegroundColor = fgColor;
                }
                else if (peca.cor == Cor.Preta)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(peca);
                    Console.BackgroundColor = bgColor;
                    Console.ForegroundColor = fgColor;
                }
                Console.Write(" ");


            }
        }
    }
}
