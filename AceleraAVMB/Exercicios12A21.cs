namespace AceleraAVMB
{
    internal class Exercicios12A21
    {
        public static void Exercicio12()
        {
            // 12 - Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.

            int l1, l2, inferior, superior;

            Console.WriteLine("Informe os limites:");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());

            (inferior, superior) = (l2 > l1) ? (l1, l2) : (l2, l1);

            inferior += (inferior % 2 == 0) ? 2 : 1;

            int soma = 0;

            for (int i = inferior; i < superior; i += 2)
                soma += i;

            Console.WriteLine($"Soma dos números pares contidos no intervalo: {soma}");
        }

        public static void Exercicio13()
        {
            // 13 - Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem,
            // qual o valor final, e se ele deseja pular os valores pares ou os valores ímpares.
            // Após, faça um laço de repetição que mostre os valores desejados.

            int inicial, final;

            Console.Write("Informe o valor inicial: ");
            inicial = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.Write("Informe o valor final: ");
                final = int.Parse(Console.ReadLine());

                if (inicial < final)
                    break;
                else
                    Console.WriteLine("Valor final deve ser maior que o valor inicial");
            }

            Console.Write("Pular [p]ares ou [i]mpares: ");
            var opcao = Console.ReadKey().KeyChar;
            Console.WriteLine();

            inicial += (opcao == 'p' && inicial % 2 == 0) ? 1 : 0 ;

            for (int i = inicial; i <= final; i += 2)
                Console.WriteLine(i);
        }

        public static void Exercicio14()
        {
            // 14 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            // e então mostre todos os valores desse intervalo.

            int v1, v2, inicial, final;

            Console.WriteLine("Informe os 2 valores (inicial e final)");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            (inicial, final) = (v2 > v1) ? (v1, v2) : (v2, v1);

            for (int i = inicial; i <= final; i++)
                Console.WriteLine(i);
        }

        public static void Exercicio15()
        {
            // 15 - Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20.
            // Considere que Polegada = Centímetro * 2,54.

            for (var i = 1; i <= 20; i++)
                Console.WriteLine($"{i}cm em polegadas: {i * 2.54}");
        }

        public static void Exercicio16()
        {
            // 16 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            // e então mostre todos os valores desse intervalo.

            Exercicio14();
        }

        public static void Exercicio17()
        {
            // 17 - Modifique a questão anterior de modo que seja perguntado para o usuário
            // se ele quer que os números apareçam em ordem crescente ou decrescente.

            int v1, v2, inicial, final;

            Console.WriteLine("Informe os 2 valores (inicial e final): ");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            (inicial, final) = (v1 < v2) ? (v1, v2) : (v2, v1);

            Console.Write("Ordem [c]rescente ou [d]ecrescente? ");
            dynamic ordem = Console.ReadKey().KeyChar;
            Console.WriteLine();

            (inicial, final, ordem) = ordem switch
            {
                'c' when v1 < v2 => (v1, v2, 1),
                'c' when v1 > v2 => (v2, v1, 1),
                'd' when v1 < v2 => (v2, v1, -1),
                'd' when v1 > v2 => (v1, v2, -1),
                _ => (0, 0, 0)
            };

            for (int i = inicial; i != final + ordem; i += ordem)
                Console.WriteLine(i);
        }

        public static void Exercicio18()
        {
            // 18 - Utilize o comando break no código abaixo de modo que o laço pare em 5.
            // static void Main(string[] args)
            // {
            //     int i;
            //     for (i = 0; i < 10; i++)
            //         Console.WriteLine("Volta numero :" + i);
            // }

            int i;
            for (i = 0; i < 10; i++)
                if (i == 5)
                    break;
                else
                    Console.WriteLine("Volta numero :" + i);
            
        }

        public static void Exercicio19()
        {
            // 19 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas no código da questão anterior.

            int i;
            for (i = 0; i < 10; i++)
                if (i == 5 || i == 7)
                    continue;
                else
                    Console.WriteLine("Volta numero :" + i);
        }

        public static void Exercicio20()
        {
            // 20 - Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
            // 1000 / 1 - 997 / 2 + 994 / 3 - 991 / 4 + ...

            int j = 1000;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i + 1}: {((i % 2 == 0) ? (i + j) : (i-j))}");
                j -= 3;
            }
        }

        public static void Exercicio21()
        {
            // 21 - Faça um programa que leia um número n e imprima se ele é primo ou não.
            // (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)

            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            bool primo = (n == 1) ? false : true;

            int i;
            for (i = 2; i < n; i++)
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }

            Console.WriteLine( primo ? "É primo" : "Não é primo");

            if (!primo && n != 1)
                Console.WriteLine($"(Divisível por {i})");
        }
    }
}
