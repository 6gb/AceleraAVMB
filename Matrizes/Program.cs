using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Matrizes
{
    internal class Program
    {
        static int[,] leMatrizInt(int linhas, int colunas)
        {
            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine($"Leitura de matriz ({linhas}x{colunas})");

            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"({i + 1}x{j + 1}) Informe o valor: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }

            return matriz;
        }

        static double[,] leMatrizDouble(int linhas, int colunas)
        {
            double[,] matriz = new double[linhas, colunas];

            Console.WriteLine($"Leitura de matriz ({linhas}x{colunas})");

            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"({i + 1}x{j + 1}) Informe o valor: ");
                    matriz[i, j] = double.Parse(Console.ReadLine());
                }

            return matriz;
        }

        static void Main(string[] args)
        {
            Type t = new Program().GetType();

            try
            {
                t.InvokeMember($"Atividade{args[0]}", BindingFlags.InvokeMethod, null, null, null);
            }
            catch
            {
                while (true)
                {
                    Console.Write("Informe o nº da atividade: ");
                    var n = Console.ReadLine();

                    try
                    {
                        t.InvokeMember($"Atividade{n}", BindingFlags.InvokeMethod, null, null, null);
                    }
                    catch
                    {
                        Console.WriteLine("Argumento inválido informado");
                    }

                    Console.Write("Pressione qualquer tecla para continuar... ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public static void Atividade1()
        {
            /// 
            /// 1) Crie uma Matriz 5x3.
            /// Na primeira coluna, solicite que o usuário preencha.
            /// A 2ª coluna, some 10 aos elementos da 1ª coluna.
            /// Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
            /// 

            int[,] matriz = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                matriz[i, 0] = int.Parse(Console.ReadLine());
                matriz[i, 1] = matriz[i, 0] + 10;
                matriz[i, 2] = matriz[i, 0] * 2;
            }

            for (int i = 0; i < 5; i++)
                Console.WriteLine(
                    $"|{matriz[i, 0].ToString().PadLeft(4).PadRight(6)}" +
                    $"|{matriz[i, 1].ToString().PadLeft(4).PadRight(6)}" +
                    $"|{matriz[i, 2].ToString().PadLeft(4).PadRight(6)}|");
        }

        public static void Atividade2()
        {
            /// 
            /// 2) Solicite ao usuário, preencher uma Matriz 3x3
            /// Informe ao usuário:
            /// *A soma dos elementos de cada linha
            /// 	-Ex: Linha 1: 30
            /// 	     Linha 2: 17
            /// *A soma dos elementos de cada coluna
            /// 	-Ex: Coluna 1: 23
            /// 	     Coluna 2: 36
            /// 

            int[,] matriz = new int[3, 3];
            int[] somaDeCadaLinha = new int[3], somaDeCadaColuna = new int[3];

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"({i + 1}x{j + 1}) Informe o valor: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    somaDeCadaLinha[i] += matriz[i, j];
                    somaDeCadaColuna[j] += matriz[i, j];
                }

            for (int i = 0; i < 3; i++)
                Console.WriteLine(
                        $"|{matriz[i, 0].ToString().PadLeft(6),-10}" +
                        $"|{matriz[i, 1].ToString().PadLeft(6),-10}" +
                        $"|{matriz[i, 2].ToString().PadLeft(6),-10}| Soma: {somaDeCadaLinha[i]}");

            Console.WriteLine(
                $" {$"Soma: {somaDeCadaColuna[0]}".PadLeft(9),-10}" +
                $" {$"Soma: {somaDeCadaColuna[1]}".PadLeft(9),-10}" +
                $" {$"Soma: {somaDeCadaColuna[2]}".PadLeft(9),-10}");
        }

        public static void Atividade3()
        {
            /// 
            /// 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            /// 

            int[,] matriz = new int[4, 4];
            int[] diagonalPrincipal = new int[4];

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"({i + 1}x{j + 1}) Informe o valor: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (i == j)
                        diagonalPrincipal.Append(matriz[i, j]);
                }

            for (int i = 0; i < diagonalPrincipal.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("\t");

                Console.WriteLine($"|{matriz[i, i]}|");
            }
        }

        public static void Atividade4()
        {
            /// 
            /// 4) Popule uma matriz 5x5 e informe:
            /// - Quantos números são pares
            /// - Quantos números são impares
            /// - Quantos números são positivos
            /// - Quantos números são negativos
            /// - Quantos zeros existem!
            /// 

            int[,] matriz = leMatrizInt(5, 5);
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    (pares, impares, positivos, negativos, zeros) = matriz[i, j] switch
                    {
                        < 0 when matriz[i, j] % 2 == 0 => (pares + 1, impares, positivos, negativos + 1, zeros),
                        < 0 when matriz[i, j] % 2 != 0 => (pares, impares + 1, positivos, negativos + 1, zeros),
                        > 0 when matriz[i, j] % 2 == 0 => (pares + 1, impares, positivos + 1, negativos, zeros),
                        > 0 when matriz[i, j] % 2 != 0 => (pares, impares + 1, positivos + 1, negativos, zeros),
                        _ => (pares + 1, impares, positivos, negativos, zeros + 1)
                    };
                }

            Console.WriteLine(
                $"Pares: {pares}\n" +
                $"Ímpares: {impares}\n" +
                $"Positivos: {positivos}\n" +
                $"Negativos: {negativos}\n" +
                $"Zeros: {zeros}");
        }

        public static void Atividade5()
        {
            /// 
            /// 5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.
            /// 

            double[,] matrizA = leMatrizDouble(2, 3), matrizB = leMatrizDouble(2, 3);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("|");
                
                for (int j = 0; j < 3; j++)
                    Console.Write(matrizA[i, j] + matrizB[i, j] + "|");

                Console.WriteLine();
            }
        }

        public static void Atividade6()
        {
            /// 
            /// 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
            /// Após isso determine o maior número da matriz.
            /// Random random = new Random();
            /// int randomNumber = random.Next(0, 100);
            /// 

            int[,] matriz = new int[4, 4];
            Random random;
            int maior = -1;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write("|");

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    random = new Random();
                    matriz[i, j] = random.Next(0, 9);
                    Console.Write(matriz[i, j] + "|");
                    maior = matriz[i, j] > maior ? matriz[i, j] : maior;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Maior valor: " + maior);
        }

        public static void Atividade7()
        {
            /// 
            /// 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C,
            /// onde cada elemento de C é a subtração do elemento correspondente de A com B.
            /// 

            int[,] matrizA = leMatrizInt(3, 3);
            int[,] matrizB = leMatrizInt(3, 3);
            int[,] matrizC = new int[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
        }

        public static void Atividade8()
        {
            /// 
            /// 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            /// 

            int[,] matriz = leMatrizInt(4, 4);

            for (int i = 3; i >= 0; i--)
                for (int j = 3; j >= 0; j--)
                    Console.WriteLine(matriz[i, j]);
        }

        public static void Atividade9()
        {
            /// 
            /// 9) Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
            /// Caso, seja verdade imprima a mensagem:  “O número existe no vetor”, caso contrário “Número inexistente”.
            /// 

            int[,] matriz = leMatrizInt(3, 3);

            Console.Write("Informe um valor: ");
            int valor = int.Parse(Console.ReadLine());

            bool numeroExisteNoVetor = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numeroExisteNoVetor = matriz[i, j] == valor;

                    if (numeroExisteNoVetor)
                        break;
                }

                if (numeroExisteNoVetor)
                    break;
            }

            Console.WriteLine(numeroExisteNoVetor ? "O número existe no vetor" : "Número inexistente");
        }

        public static void Atividade10()
        {
            /// 
            /// 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, 
            /// diga quantos dos elementos lidos estão abaixo, acima e na média.
            /// 

            double[,] matrizA = leMatrizDouble(4, 4);
            //double[,] matrizes 
            double[,] matrizB = leMatrizDouble(4, 4);

            (double a, double b) somas = (a: 0, b: 0);
            (double a, double b) medias = (a: 0, b: 0);
            (double a, double b) abaixoDaMedia = (a: 0, b: 0);
            (double a, double b) acimaDaMedia = (a: 0, b: 0);
            (double a, double b) naMedia = (a: 0, b: 0);

            //double somaA = 0, somaB = 0, mediaA, mediaB, abaixo, acima, naMedia;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    somas = (somas.a + matrizA[i, j], somas.b + matrizB[i, j]);
                    
                    somaA += matrizA[i, j];

                    somaB += matrizB[i, j];
                }

            medias = (somas.a / matrizA.Length, somas.b / matrizB.Length);
            mediaB = somaB / matrizB.Length;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    switch matrizA[i, j];
                    somaB = matrizB[i, j];
                }


        }

        public static void Atividade11()
        {
            /// 
            /// 11) Leia uma matriz A de tipo double de dimenção 3x3, 
            /// crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
            /// 

        }

        public static void Atividade12()
        {
            /// 
            /// 12) Escreva um programa que leia os valores de uma matriz 4x3, 
            /// e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.
            /// 

        }

        public static void Atividade13()
        {
            /// 
            /// 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) 
            /// e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da diagonal secundária.
            /// 

        }

        public static void Atividade14()
        {
            /// 
            /// 14) Escreva um programa que leia uma matriz de ordem 5 e verifique 
            /// se os elementos da diagonal principal (da esquerda para a direita)
            /// são os mesmos da diagonalsecundária(direita pra esquerda).
            /// 

        }

        public static void Atividade15()
        {
            /// 
            /// 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. 
            /// Mostrar a matriz resultante.
            /// 

        }

        public static void Atividade16()
        {
            /// 
            /// 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            /// Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
            /// 

        }

        public static void Atividade17()
        {
            /// 
            /// 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas 
            /// e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o maior elemento da matriz. 
            /// Escreva também a linha e a coluna onde foi encontrado.
            /// 

        }
    }
}