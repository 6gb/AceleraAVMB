namespace JogoDaVelha
{
    internal class Program
    {
        static char[,] tabuleiro = new char[3, 3];
        static int linha, coluna;


        static void MostraTabuleiro()
        {
            Console.Clear();
            Console.WriteLine($"   1  2  3");

            for (int i = 0; i < 3; i++)
                Console.WriteLine($"{i + 1} [{tabuleiro[i, 0]}][{tabuleiro[i, 1]}][{tabuleiro[i, 2]}]");
        }

        static bool ChecaResultado()
        {
            linha--;
            coluna--;

            switch (linha)
            {
                case 0 when tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2]:
                case 1 when tabuleiro[1, 0] != ' ' && tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2]:
                case 2 when tabuleiro[2, 0] != ' ' && tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2]:
                    return true;
                default:
                    break;
            }

            switch (coluna)
            {
                case 0 when tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0]:
                case 1 when tabuleiro[0, 1] != ' ' && tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1]:
                case 2 when tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2]:
                    return true;
                default:
                    break;
            }

            if (linha == coluna && tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
                return true;

            if (linha + coluna == 2 && tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            /// 
            /// Jogo da velha
            /// jogador x jogador (controlar a vez)
            /// controlar o empate
            /// uma matriz representa o tabuleiro
            /// jogador seleciona a posição (linha e coluna)
            /// controla se a posição está liberada
            /// informa o ganhador
            /// informa o empate
            /// desenhar o tabuleiro a cada rodada
            /// 

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tabuleiro[i, j] = ' ';

            int vez = 1, jogadas = 9;

            while (true)
            {
                MostraTabuleiro();
                char jogador = vez == 1 ? 'X' : 'O';
                

                while (true)
                {
                    while (true)
                    {
                        Console.Write($"(Jogador {jogador}) Linha: ");
                        linha = int.Parse(Console.ReadLine());

                        if (linha >= 1 && linha <= 3)
                            break;
                        else
                            Console.WriteLine("Valor inválido, tente novamente");
                    }

                    while (true)
                    {
                        Console.Write($"(Jogador {jogador}) Coluna: ");
                        coluna = int.Parse(Console.ReadLine());

                        if (coluna < 1 || coluna > 3)
                            Console.WriteLine("Valor inválido, tente novamente");
                        else
                            break;
                    }

                    if (tabuleiro[linha - 1, coluna - 1] != ' ')
                        Console.WriteLine("Casa já utilizada, tente novamente");
                    else
                    {
                        tabuleiro[linha - 1, coluna - 1] = jogador;
                        break;
                    }
                }

                jogadas--;

                if (jogadas <= 0)
                {
                    MostraTabuleiro();
                    Console.WriteLine("Jogo terminou empatado");
                    break;
                }

                if (ChecaResultado())
                {
                    MostraTabuleiro();
                    Console.WriteLine($"Jogador {jogador} venceu");
                    break;
                }
                    

                /*
                if (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 1] == tabuleiro[0, 2] ||
                    tabuleiro[1, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[1, 2] ||
                    tabuleiro[2, 0] == tabuleiro[2, 1] && tabuleiro[2, 1] == tabuleiro[2, 2] ||
                    tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[1, 0] == tabuleiro[2, 0] ||
                    tabuleiro[0, 1] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 1] ||
                    tabuleiro[0, 2] == tabuleiro[1, 2] && tabuleiro[1, 2] == tabuleiro[2, 2] ||
                    tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] ||
                    tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                {
                    MostraTabuleiro();
                    Console.WriteLine($"Jogador {jogador} venceu");
                    break;
                }
                */

                vez *= -1;
            }
        }
    }
}