using System;

using tabuleiro;

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
                    Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            ConsoleColor bgColor = Console.BackgroundColor;
            ConsoleColor fgColor = Console.ForegroundColor;
            if (peca == null)
            {
                Console.Write("-");
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

            }
        }
    }
}
