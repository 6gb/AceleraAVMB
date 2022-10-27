using System.Reflection;

namespace AtividadesMatrizes
{
    internal class Program
    {
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

        }

        public static void Atividade3()
        {
            /// 
            /// 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            /// 

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

        }

        public static void Atividade5()
        {
            /// 
            /// 5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.
            /// 

        }

        public static void Atividade6()
        {
            /// 
            /// 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9.
            /// Após isso determine o maior número da matriz.
            /// Random random = new Random();
            /// int randomNumber = random.Next(0, 100);
            /// 

        }

        public static void Atividade7()
        {
            /// 
            /// 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C,
            /// onde cada elemento de C é a subtração do elemento correspondente de A com B.
            /// 

        }

        public static void Atividade8()
        {
            /// 
            /// 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            /// 

        }

        public static void Atividade9()
        {
            /// 
            /// 9) Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.
            /// Caso, seja verdade imprima a mensagem:  “O número existe no vetor”, caso contrário “Número inexistente”.
            /// 

        }

        public static void Atividade10()
        {
            /// 
            /// 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, 
            /// diga quantos dos elementos lidos estão abaixo, acima e na média.
            /// 

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