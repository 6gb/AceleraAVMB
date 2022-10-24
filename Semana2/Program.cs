using System.Reflection;

namespace Semana2
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
            /// 1. Escreva um algoritmo que leia os valores para um vetor de 10 elementos 
            /// e então mostre na tela a quantidade de números pares e ímpares.
            /// 

            const int TAM = 10;
            int[] vet = new int[TAM];
            int pares = 0;

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                vet[i] = int.Parse(Console.ReadLine());
                pares += (vet[i] % 2 == 0) ? 1 : 0;
            }

            Console.WriteLine($"Pares: {pares}\nÍmpares: {TAM - pares}");
        }

        public static void Atividade2()
        {
            /// 
            /// 2. Escreva um algoritmo que leia valores para dois vetores de 20 elementos 
            /// e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.
            /// 

            const int TAM = 20;
            int[] v1 = new int[TAM];
            int[] v2 = new int[TAM];
            int[] v3 = new int[TAM];

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor do 1º vetor: ");
                v1[i] = int.Parse(Console.ReadLine());
                Console.Write($"Informe o {i + 1}º valor do 2º vetor: ");
                v2[i] = int.Parse(Console.ReadLine());

                v3[i] = v1[i] + v2[i];
            }

            Console.Write("[");

            for (int i = 0; i < TAM - 1; i++)
                Console.Write($"{v3[i]}, ");

            Console.WriteLine($"{v3[TAM - 1]}]");
        }

        public static void Atividade3()
        {
            /// 
            /// 3. Escreva um algoritmo que leia os valores para um vetor de 20 elementos 
            /// e então mostre na tela o índice da posição dos valores correspondentes a números primos.
            /// 

            const int TAM = 20;
            int[] valores = new int[TAM];
            string indices = "";

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                valores[i] = int.Parse(Console.ReadLine());

                if (valores[i] == 2)
                    indices += $"{i}, ";

                for (int j = 2; j < valores[i]; j++)
                    if (valores[i] % j == 0)
                        break;
                    else if (j == valores[i] - 1)
                        indices += $"{i}, ";
            }

            Console.WriteLine(indices.Remove(indices.LastIndexOf(',')));
        }

        public static void Atividade4()
        {
            /// 
            /// 4. Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, 
            /// colocando o resultado em um terceiro vetor.
            /// Mostre o vetor resultante.
            /// 

            const int TAM = 10;
            int[] v1 = new int[TAM];
            int[] v2 = new int[TAM];
            int[] v3 = new int[TAM];

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor do 1º vetor: ");
                v1[i] = int.Parse(Console.ReadLine());
                Console.Write($"Informe o {i + 1}º valor do 2º vetor: ");
                v2[i] = int.Parse(Console.ReadLine());

                v3[i] = v1[i] * v2[i];
            }

            Console.Write("[");

            for (int i = 0; i < TAM - 1; i++)
                Console.Write($"{v3[i]}, ");

            Console.WriteLine($"{v3[TAM - 1]}]");
        }

        public static void Atividade5()
        {
            /// 
            /// 5. Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
            /// Encontre e mostre o menor elemento e a sua posição.
            /// 

            const int TAM = 80;
            int[] v = new int[TAM];
            int posicaoDoMenor = 0;

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < v[posicaoDoMenor])
                    posicaoDoMenor = i;
            }

            Console.WriteLine($"Menor elemento: {v[posicaoDoMenor]}");
            Console.WriteLine($"Posição do menor elemento: {posicaoDoMenor}");
        }

        public static void Atividade6()
        {
            /// 
            /// 6. Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. 
            /// Exemplo:
            /// a. lê:      |7|40|3|9|21|0|63|31|7|22|
            /// b. escreve: |22|7|31|63|0|21|9|3|40|7|
            /// 

            const int TAM = 10;
            int[] v = new int[TAM];

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("|");

            for (int i = TAM - 1; i >= 0; i--)
                Console.Write($"{v[i]}|");

            Console.WriteLine();
        }

        public static void Atividade7()
        {
            /// 
            /// 7. Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor 
            /// e escreva primeiramente todos os números pares lidos e após todos os ímpares.
            /// Exemplo:
            /// a. lê:      |7|40|3|9|21|0|63|31|7|22|
            /// b. escreve: |40|0|22|7|3|9|21|63|31|7|
            /// 

            const int TAM = 10;
            int[] v = new int[TAM];

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("|");

            for (int i = 0; i < TAM; i++)
                if (v[i] % 2 == 0)
                    Console.Write($"{v[i]}|");

            for (int i = 0; i < TAM; i++)
                if (v[i] % 2 != 0)
                    Console.Write($"{v[i]}|");

            Console.WriteLine();
        }

        public static void Atividade8()
        {
            /// 
            /// 8. Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor 
            /// e após escreva a posição de cada número menor que zero desse vetor.
            /// Exemplo:
            /// a. lê:      |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
            /// b. escreve: |3|5|6|7|9|10|14|. . .
            /// 

            const int TAM = 10;
            double[] v = new double[TAM];
            string posicoes = "|";

            for (int i = 0; i < TAM; i++)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                v[i] = int.Parse(Console.ReadLine());

                if (v[i] < 0)
                    posicoes += $"{i}|";
            }
            
            Console.WriteLine(posicoes);
        }

        public static void Atividade9()
        {
            /// 
            /// 9. Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
            /// e em seguida ordene em ordem crescente os valores desse vetor, 
            /// utilizando um vetor auxiliar.
            /// 
            
        }

        public static void Atividade10()
        {
            /// 
            /// 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            /// Crie um segundo vetor, substituindo os valores nulos por 2. 
            /// Mostre os vetores lidos e o vetor resultado.
            /// 
            
        }

        public static void Atividade11()
        {
            /// 
            /// 11.	Escreva um programa que leia valores em um vetor de 5 posições.
            /// Escrever os elementos do vetor e após escrever os elementos na ordem inversa.
            /// 
            
        }

        public static void Atividade12()
        {
            /// 
            /// 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor.
            /// Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".
            /// 
            
        }

        public static void Atividade13()
        {
            /// 
            /// 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. 
            /// O vetor terá no máximo 100 posições.
            /// Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.
            /// 
            
        }

        public static void Atividade14()
        {
            /// 
            /// 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. 
            /// Se o código for zero, termine o algoritmo. 
            /// Se o código for 1, mostre o vetor na ordem em que foi lido. 
            /// Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.
            /// 
            
        }

        public static void Atividade15()
        {
            /// 
            /// 15.	Faça um programa em C que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, 
            /// e copie estes conteúdos para outro vetor, invertendo sua ordem.
            /// Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. 
            /// Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.
            /// 
            
        }

        public static void Atividade16()
        {
            /// 
            /// 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva.
            /// Crie, a seguir, um vetor para cada uma das operações:
            /// •	A união de X com Y
            /// •	A diferença entre X e Y
            /// •	A interseção entre X e Y
            /// Escreva o vetor resultado de cada uma das operações.
            /// 

        }
    }
}