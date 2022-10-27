using System.Reflection;

namespace AtividadesLacosESwitch
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
            /// 1 - Escrever um algoritmo para ler quatro valores inteiros,
            /// calcular a sua média, e escrever na tela os que são superiores à média.
            /// 

            var numeros = new List<int>(4);

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Informe o {i + 1}º nº: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            var media = numeros.Sum() / 4;
            numeros.ForEach(n =>
            {
                if (n > media)
                    Console.WriteLine(n);
            });
        }

        public static void Atividade2()
        {
            //
            /// 2 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
            /// e o valor por hora recebido por cada um deles.
            /// 

            var horas = new List<int>(2);
            var valorPorHora = new List<int>(2);
            var salarios = new List<int>(2);

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Informe a quantidade de horas do {i + 1}º professor: ");
                horas.Add(int.Parse(Console.ReadLine()));

                Console.Write($"Informe o valor por hora recebido pelo {i + 1}º professor: ");
                valorPorHora.Add(int.Parse(Console.ReadLine()));
                salarios.Add(horas[i] * valorPorHora[i]);
            }

            var professorDeSalarioMaisAlto = salarios[0] > salarios[1] ? 1 : 2;

            Console.WriteLine($"{professorDeSalarioMaisAlto}º professor recebe mais");
        }

        public static void Atividade3()
        {
            ///
            /// 3 - Escreva um programa que pede para o usuário digitar um valor entre 1 e 12,
            /// e então mostre na tela o mês correspondente
            /// Caso o usuário digite um valor fora do intervalo,
            /// mostre uma mensagem indicando que é um mês inválido.
            /// 

            Console.Write("Digite valor entre 1 e 12: ");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine(valor switch
            {
                1 => "Janeiro",
                2 => "Fevereiro",
                3 => "Março",
                4 => "Abril",
                5 => "Maio",
                6 => "Junho",
                7 => "Julho",
                8 => "Agosto",
                9 => "Setembro",
                10 => "Outubro",
                11 => "Novembro",
                12 => "Dezembro",
                _ => "Mês inválido"
            });
        }

        public static void Atividade4()
        {
            ///
            /// 4 - Escreva um programa que leia um valor entre 0 e 9,
            /// Pergunte também se o usuário quer saber a forma literal em português, inglês ou espanhol.
            /// e então escreva na tela o mesmo na forma literal.
            /// 

            Console.Write("Digite valor entre 0 e 9: ");
            int valor = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();


            Console.Write("Forma literal em [p]ortuguês, [i]nglês ou [e]spanhol? ");
            char lingua = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine((valor, lingua) switch
            {
                (0, 'p' or 'i') => "Zero",
                (0, 'e') => "Cero",
                (1, 'p') => "Um",
                (1, 'i') => "One",
                (1, 'e') => "Uno",
                (2, 'p') => "Dois",
                (2, 'i') => "Two",
                (2, 'e') => "Dos",
                (3, 'p') => "Três",
                (3, 'i') => "Three",
                (3, 'e') => "Tres",
                (4, 'p') => "Quatro",
                (4, 'i') => "Four",
                (4, 'e') => "Cuatro",
                (5, 'p' or 'e') => "Cinco",
                (5, 'i') => "Five",
                (6, 'p' or 'e') => "Seis",
                (6, 'i') => "Six",
                (7, 'p') => "Sete",
                (7, 'i') => "Seven",
                (7, 'e') => "Siete",
                (8, 'p') => "Oito",
                (8, 'i') => "Eight",
                (8, 'e') => "Ocho",
                (9, 'p') => "Nove",
                (9, 'i') => "Nine",
                (9, 'e') => "Nueve",
                ( < 0 or > 9, 'p' or 'i' or 'e') => "Valor numérico inválido",
                ( > 0 and < 9, _) => "Valor da forma literal inválido",
                _ => "Valor numérico e da forma literal inválidos"
            });
        }

        public static void Atividade5()
        {
            ///
            /// 5 - Escreva um programa que peça para o usuário digitar uma letra,
            /// e então o programa imprime na tela se a letra é uma vogal ou consoante.
            /// Utilize no máximo 6 cases em um switch-case para resolver esse exercício.
            /// 

            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            /*
            Console.WriteLine(letra switch
            {
                'a' or 'e' or 'i' or 'o' or 'u' => "Vogal",
                _ => "Consoante"
            });
            */

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vogal");
                    break;
                default:
                    Console.WriteLine("Consoante");
                    break;
            }
        }

        public static void Atividade6()
        {
            ///
            /// 6 - Fazer uma algoritmo que leia valores para as variáveis hora, minuto e segundo;
            /// verificando e escrevendo se elas correspondem a um horário válido ou não.
            /// Para um horário ser válido, a hora deve estar no intervalo de 0 a 23, o minuto e o segundo no intervalo de 0 a 59.
            /// 

            int h, m, s;

            do
            {
                Console.Write("Informe a hora: ");
                h = int.Parse(Console.ReadLine());
            }
            while (h < 0 || h > 23);

            do
            {
                Console.Write("Informe os minutos: ");
                m = int.Parse(Console.ReadLine());
            }
            while (m < 0 || m > 59);

            do
            {
                Console.Write("Informe os segundos: ");
                s = int.Parse(Console.ReadLine());
            }
            while (s < 0 || s > 59);

            Console.WriteLine($"{h}:{m}:{s}");
        }

        public static void Atividade7()
        {
            ///
            /// 7 - Escreva um algoritmo para pesquisa de renda per capita que
            /// leia o valor da renda familiar e o número de integrantes da família.
            /// Calcule o valor da renda per capita da família.
            /// 

            Console.Write("Informe o valor da renda familiar: R$ ");
            //var renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var renda = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de integrantes da família: ");
            var integrantes = int.Parse(Console.ReadLine());

            var rendaPerCapita = renda / integrantes;

            Console.WriteLine($"Renda per capita: R$ {rendaPerCapita.ToString("N2")}");
        }

        public static void Atividade8()
        {
            ///
            /// 8 - Um comerciante calcula o lucro da venda baseado no valor da compra dos clientes de acordo com os itens a seguir:
            /// Valor da Compra < R$ 10,00  então o Lucro é de 70 %
            /// R$ 10,00 ≤ Valor da Compra < R$ 30,00 então o Lucro é de 50 %
            /// R$ 30,00 ≤ Valor da Compra < R$ 50,00 então o Lucro é de 40 %
            /// Valor da Compra ≥ R$ 50,00 então o Lucro é de 30 %
            /// Criar um algoritmo que leia o valor da compra e imprima uma mensagem indicando de quantos % é o lucro e o valor.
            /// 

            Console.Write("Informe o valor da compra: R$ ");
            //var compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var compra = double.Parse(Console.ReadLine());

            Console.WriteLine(compra switch
            {
                > 0 and < 10 => $"Lucro de 70% (R$ {(compra * .7).ToString("N2")})",
                >= 10 and < 30 => $"Lucro de 50% (R$ {(compra * .5).ToString("N2")})",
                >= 30 and < 50 => $"Lucro de 40% (R$ {(compra * .4).ToString("N2")})",
                >= 50 => $"Lucro de 30% (R$ {(compra * .3).ToString("N2")})",
                _ => "Valor informado é inválido"
            });

        }

        public static void Atividade9()
        {
            ///
            /// 9 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c),
            /// e então diga se esses lados podem ou não formar um triangulo.
            /// Para que os lados formem um triângulo, todos os lados devem ser menores a soma dos outros dois lados.
            /// Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos os lados iguais),
            /// isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).
            /// 

            var lados = new List<double>(3);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe o tamanho do {i + 1}º lado: ");
                lados.Add(double.Parse(Console.ReadLine()));
            }

            (double a, double b, double c) = (lados[0], lados[1], lados[2]);

            Console.WriteLine((a, b, c) switch
            {
                _ when a > b + c || b > a + c || c > a + b => "Não forma triângulo",
                _ when a == b && b == c => "Lados formam triângulo equilátero",
                _ when a == b || a == c || b == c => "Lados formam triângulo isóceles",
                _ => "Lados formam triângulo escaleno"

            });
        }

        public static void Atividade10()
        {
            /// 
            /// 10 - Faça um programa que leia um número e apresente a tabuada deste número.
            /// 

            Console.Write($"Informe um número: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }

        public static void Atividade11()
        {
            /// 
            /// 11 - Escreva um programa em C que gera números entre 1000 e 1999 e mostra aqueles que divididos por 11 dão resto 5.
            /// 

            for (int i = 1001; i < 1999; i++)
                if (i % 11 == 5)
                    Console.WriteLine(i);
        }

        public static void Atividade12()
        {
            /// 
            /// 12 - Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.
            /// 

            int l1, l2, inferior, superior;

            Console.WriteLine("Informe os limites:");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());

            (inferior, superior) = l2 > l1 ? (l1, l2) : (l2, l1);

            inferior += inferior % 2 == 0 ? 2 : 1;

            int soma = 0;

            for (int i = inferior; i < superior; i += 2)
                soma += i;

            Console.WriteLine($"Soma dos números pares contidos no intervalo: {soma}");
        }

        public static void Atividade13()
        {
            /// 
            /// 13 - Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem,
            /// qual o valor final, e se ele deseja pular os valores pares ou os valores ímpares.
            /// Após, faça um laço de repetição que mostre os valores desejados.
            /// 

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

            inicial += opcao == 'p' && inicial % 2 == 0 ? 1 : 0;

            for (int i = inicial; i <= final; i += 2)
                Console.WriteLine(i);
        }

        public static void Atividade14()
        {
            /// 
            /// 14 - Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20.
            /// Considere que Polegada = Centímetro * 2,54.
            /// 

            for (var i = 1; i <= 20; i++)
                Console.WriteLine($"{i}cm em polegadas: {i * 2.54}");
        }

        public static void Atividade15()
        {
            /// 
            /// 15 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            /// e então mostre todos os valores desse intervalo.
            /// 

            int v1, v2, inicial, final;

            Console.WriteLine("Informe os 2 valores (inicial e final)");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            (inicial, final) = v2 > v1 ? (v1, v2) : (v2, v1);

            for (int i = inicial; i <= final; i++)
                Console.WriteLine(i);
        }

        public static void Atividade16()
        {
            /// 
            /// 16 - Modifique a questão anterior de modo que seja perguntado para o usuário
            /// se ele quer que os números apareçam em ordem crescente ou decrescente.
            /// 

            int v1, v2, inicial, final;

            Console.WriteLine("Informe os 2 valores (inicial e final): ");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());

            (inicial, final) = v1 < v2 ? (v1, v2) : (v2, v1);

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

        public static void Atividade17()
        {
            ///
            /// 17 - Utilize o comando break no código abaixo de modo que o laço pare em 5.
            /// static void Main(string[] args)
            /// {
            ///     int i;
            ///     for (i = 0; i < 10; i++)
            ///         Console.WriteLine("Volta numero :" + i);
            /// }
            /// 

            int i;
            for (i = 0; i < 10; i++)
                if (i == 5)
                    break;
                else
                    Console.WriteLine("Volta numero :" + i);

        }

        public static void Atividade18()
        {
            ///
            /// 18 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas no código da questão anterior.
            /// 

            for (int i = 0; i < 10; i++)
                if (i == 5 || i == 7)
                    continue;
                else
                    Console.WriteLine("Volta numero :" + i);
        }

        public static void Atividade19()
        {
            /// 
            /// 19 - Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
            /// 1000 / 1 - 997 / 2 + 994 / 3 - 991 / 4 + ...
            /// 

            int j = 1000;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i + 1}: {(i % 2 == 0 ? i + j : i - j)}");
                j -= 3;
            }
        }

        public static void Atividade20()
        {
            /// 
            /// 20 - Faça um programa que leia um número n e imprima se ele é primo ou não.
            /// (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
            /// 

            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            bool primo = n == 1 ? false : true;

            int i;
            for (i = 2; i < n; i++)
                if (n % i == 0)
                {
                    primo = false;
                    break;
                }

            Console.WriteLine(primo ? "É primo" : "Não é primo");

            if (!primo && n != 1)
                Console.WriteLine($"(Divisível por {i})");
        }
    }
}