using System.Globalization;
using System.Runtime.CompilerServices;

namespace AceleraAVMB
{
    internal class Exercicios
    {
        static dynamic ReadValue(Type type, string helpText)
        {
            bool check = false;
            dynamic number = 0;
            Console.WriteLine(helpText);

            while (!check)
            {
                string? entrada = Console.ReadLine();

                if (type == typeof(double))
                {
                    double doubleValue;
                    check = double.TryParse(entrada, out doubleValue);
                    number = doubleValue;
                }
                else if (type == typeof(int))
                {
                    int intValue;
                    check = int.TryParse(entrada, out intValue);
                    number = intValue;
                }
                else
                    throw new ArgumentException("Tipo não suportado");

                if (!check)
                    Console.WriteLine("Tente novamente");
            }

            return number;
        }

        static void ExerciciosIniciais()
        {
            int x = 5, y = 10;
            double z;
            z = 3.1415;
            Console.WriteLine("Os valores sao " + x + ", " + y + " e " + z);
            Console.WriteLine("Os valores sao {0}, {1} e {2}", x, y, z);
            Console.WriteLine($"Os valores sao {x}, {y} e {z}");

            double a = double.Parse("3,3", new CultureInfo("pt-BR"));
            Console.WriteLine(a);

            /// Faça a leitura de dois números e apresenta a soma, subtração, multiplicação e divisão
            /// 

            double n1 = ReadValue(typeof(double), "Informe o primeiro número");
            double n2 = ReadValue(typeof(double), "Informe o segundo número");

            Console.Write("Soma: " + (n1 + n2) + "\n");
            Console.WriteLine($"Subtração: {n1 - n2}");
            Console.WriteLine("Multiplicação: {0}", n1 * n2);
            Console.Write("Divisão: " + n1 / n2 + "\n");

            /// Faça um algoritmo para o calculo da área de um retângulo.
            /// 

            double lado1 = n1;
            double lado2 = n2;
            double areaDeRetangulo = lado1 * lado2;
            Console.WriteLine($"Área de retângulo: {areaDeRetangulo}");

            /// Faça um algoritmo para calcular a área de um triângulo equilátero.
            /// 

            double lado = n1;
            /// altura² = lado² + (lado/2)²
            double altura = Math.Sqrt(Math.Pow(lado, 2) - Math.Pow(lado / 2, 2));
            double areaDeTrianguloEquilatero = (lado * altura) / 2;
            Console.WriteLine($"Área de triângulo equilátero: {areaDeTrianguloEquilatero}");

            /// Escreva um algoritmo para calcular a área de um círculo, com base em um raio digitado pelo usuário.
            /// 

            double raio = ReadValue(typeof(double), "Informe um raio para círculo: ");
            /// area = pi * r²
            double areaDeCirculo = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"Área de círculo: {areaDeCirculo}");

            /// Escreva um algoritmo que leia a idade de uma pessoa, e então mostre na tela o ano em que ela nasceu.
            /// 

            int idade = ReadValue(typeof(int), "Informe uma idade: ");

            DateTime hoje = DateTime.Today;

            int ano = hoje.Year - idade;

            Console.Write("Ano de nascimento: ");

            if (hoje.Day == 31 && hoje.Month == 12)
                Console.WriteLine($"{ano}");
            else
                Console.WriteLine($"{ano - 1} ou {ano}");
        }

        public static void Exercicio1()
        {
            var numeros = new List<int>(4);
            /// 1 - Escrever um algoritmo para ler quatro valores inteiros,
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Informe o {i + 1}º nº: ");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            /// calcular a sua média,
            var media = numeros.Sum() / 4;
            /// e escrever na tela os que são superiores à média.
            numeros.ForEach(n =>
            {
                if (n > media)
                    Console.WriteLine(n);
            });
        }

        public static void Exercicio2()
        {
            /// 2 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
            var horas = new List<int>(2);
            var valorPorHora = new List<int>(2);
            var salarios = new List<int>(2);

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Informe a quantidade de horas do {i + 1}º professor: ");
                horas.Add(int.Parse(Console.ReadLine()));
                /// e o valor por hora recebido por cada um deles.
                Console.Write($"Informe o valor por hora recebido pelo {i + 1}º professor: ");
                valorPorHora.Add(int.Parse(Console.ReadLine()));
                salarios.Add(horas[i] * valorPorHora[i]);
            }

            var professorDeSalarioMaisAlto = salarios[0] > salarios[1] ? 1 : 2;

            Console.WriteLine($"{professorDeSalarioMaisAlto}º professor recebe mais");
        }

        public static void Exercicio3()
        {
            /// 3 - Escreva um programa que pede para o usuário digitar um valor entre 1 e 12,
            Console.Write("Digite valor entre 1 e 12: ");
            int valor = int.Parse(Console.ReadLine());
            /// e então mostre na tela o mês correspondente
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
                /// Caso o usuário digite um valor fora do intervalo,
                /// mostre uma mensagem indicando que é um mês inválido.
                _ => "Mês inválido"
            });
        }

        public static void Exercicio4()
        {
            /// 4 - Escreva um programa que leia um valor entre 0 e 9,
            Console.Write("Digite valor entre 0 e 9: ");
            int valor = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            /// Pergunte também se o usuário quer saber a forma literal em português, inglês ou espanhol.
            Console.Write("Forma literal em [p]ortuguês, [i]nglês ou [e]spanhol? ");
            char lingua = Console.ReadKey().KeyChar;
            Console.WriteLine();

            /// e então escreva na tela o mesmo na forma literal.
            Console.WriteLine((valor, lingua) switch
            {
                ( 0, 'p' or 'i' ) => "Zero",
                ( 0, 'e' ) => "Cero",
                ( 1, 'p' ) => "Um",
                ( 1, 'i' ) => "One",
                ( 1, 'e' ) => "Uno",
                ( 2, 'p' ) => "Dois",
                ( 2, 'i' ) => "Two",
                ( 2, 'e' ) => "Dos",
                ( 3, 'p' ) => "Três",
                ( 3, 'i' ) => "Three",
                ( 3, 'e' ) => "Tres",
                ( 4, 'p' ) => "Quatro",
                ( 4, 'i' ) => "Four",
                ( 4, 'e' ) => "Cuatro",
                ( 5, 'p' or 'e' ) => "Cinco",
                ( 5, 'i' ) => "Five",
                ( 6, 'p' or 'e' ) => "Seis",
                ( 6, 'i' ) => "Six",
                ( 7, 'p' ) => "Sete",
                ( 7, 'i' ) => "Seven",
                ( 7, 'e' ) => "Siete",
                ( 8, 'p' ) => "Oito",
                ( 8, 'i' ) => "Eight",
                ( 8, 'e' ) => "Ocho",
                ( 9, 'p' ) => "Nove",
                ( 9, 'i' ) => "Nine",
                ( 9, 'e') => "Nueve",
                ( < 0 or > 9, 'p' or 'i' or 'e' ) => "Valor numérico inválido",
                ( > 0 and < 9, _ ) => "Valor da forma literal inválido",
                _ => "Valor numérico e da forma literal inválidos"
            });
        }

        public static void Exercicio5()
        {
            /// 5 - Escreva um programa que peça para o usuário digitar uma letra,
            /// e então o programa imprime na tela se a letra é uma vogal ou consoante.
            /// Utilize no máximo 6 cases em um switch-case para resolver esse exercício.

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

            switch (letra) {
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

        public static void Exercicio6()
        {
            /// 6 - Fazer uma algoritmo que leia valores para as variáveis hora, minuto e segundo;
            /// verificando e escrevendo se elas correspondem a um horário válido ou não.
            /// Para um horário ser válido, a hora deve estar no intervalo de 0 a 23, o minuto e o segundo no intervalo de 0 a 59.

            int h, m, s;

            do
            {
                Console.Write("Informe a hora: ");
                h= int.Parse(Console.ReadLine());
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

        public static void Exercicio7()
        {
            /// 7 - Escreva um algoritmo para pesquisa de renda per capita que
            /// leia o valor da renda familiar e o número de integrantes da família.
            /// Calcule o valor da renda per capita da família.

            Console.Write("Informe o valor da renda familiar: R$ ");
            //var renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var renda = double.Parse(Console.ReadLine());

            Console.Write("Informe o número de integrantes da família: ");
            var integrantes = int.Parse(Console.ReadLine());

            var rendaPerCapita = renda / integrantes;

            Console.WriteLine($"Renda per capita: R$ {rendaPerCapita.ToString("N2")}");
        }

        public static void Exercicio8()
        {
            /// 8 - Um comerciante calcula o lucro da venda baseado no valor da compra dos clientes de acordo com os itens a seguir:
            /// Valor da Compra < R$ 10,00  então o Lucro é de 70 %
            /// R$ 10,00 ≤ Valor da Compra < R$ 30,00 então o Lucro é de 50 %
            /// R$ 30,00 ≤ Valor da Compra < R$ 50,00 então o Lucro é de 40 %
            /// Valor da Compra ≥ R$ 50,00 então o Lucro é de 30 %
            /// Criar um algoritmo que leia o valor da compra e imprima uma mensagem indicando de quantos % é o lucro e o valor.

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

        public static void Exercicio9()
        {
            /// 9 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c),
            /// e então diga se esses lados podem ou não formar um triangulo.
            /// Para que os lados formem um triângulo, todos os lados devem ser menores a soma dos outros dois lados.
            /// Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos os lados iguais),
            /// isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).

            var lados = new List<double>(3);

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Informe o tamanho do {i + 1}º lado: ");
                lados.Add(double.Parse(Console.ReadLine()));
            }

            (double a, double b, double c) = (lados[0], lados[1], lados[2]);

            Console.WriteLine((a, b, c) switch
            {
                _ when (a > b + c || b > a + c || c > a + b) => "Não forma triângulo",
                _ when (a == b && b == c) => "Lados formam triângulo equilátero",
                _ when (a == b || a == c || b == c) => "Lados formam triângulo isóceles",
                _ => "Lados formam triângulo escaleno"

            });
        }

        public static void Exercicio10()
        {
            /// 10 - Faça um programa que leia um número e apresente a tabuada deste número.

            Console.Write($"Informe um número: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }

        public static void Exercicio11()
        {
            /// 11 - Escreva um programa em C que gera números entre 1000 e 1999 e mostra aqueles que divididos por 11 dão resto 5.
            for (int i = 1001; i < 1999; i++)
                if (i % 11 == 5)
                    Console.WriteLine(i);
        }

        public static void Exercicio12()
        {
            /// 12 - Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.

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
            /// 13 - Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem,
            /// qual o valor final, e se ele deseja pular os valores pares ou os valores ímpares.
            /// Após, faça um laço de repetição que mostre os valores desejados.

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

            inicial += (opcao == 'p' && inicial % 2 == 0) ? 1 : 0;

            for (int i = inicial; i <= final; i += 2)
                Console.WriteLine(i);
        }

        public static void Exercicio14()
        {
            /// 14 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            /// e então mostre todos os valores desse intervalo.

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
            /// 15 - Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20.
            /// Considere que Polegada = Centímetro * 2,54.

            for (var i = 1; i <= 20; i++)
                Console.WriteLine($"{i}cm em polegadas: {i * 2.54}");
        }

        public static void Exercicio16()
        {
            /// 16 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            /// e então mostre todos os valores desse intervalo.

            Exercicio14();
        }

        public static void Exercicio17()
        {
            /// 17 - Modifique a questão anterior de modo que seja perguntado para o usuário
            /// se ele quer que os números apareçam em ordem crescente ou decrescente.

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
            /// 18 - Utilize o comando break no código abaixo de modo que o laço pare em 5.
            /// static void Main(string[] args)
            /// {
            ///     int i;
            ///     for (i = 0; i < 10; i++)
            ///         Console.WriteLine("Volta numero :" + i);
            /// }

            int i;
            for (i = 0; i < 10; i++)
                if (i == 5)
                    break;
                else
                    Console.WriteLine("Volta numero :" + i);

        }

        public static void Exercicio19()
        {
            /// 19 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas no código da questão anterior.

            int i;
            for (i = 0; i < 10; i++)
                if (i == 5 || i == 7)
                    continue;
                else
                    Console.WriteLine("Volta numero :" + i);
        }

        public static void Exercicio20()
        {
            /// 20 - Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
            /// 1000 / 1 - 997 / 2 + 994 / 3 - 991 / 4 + ...

            int j = 1000;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{i + 1}: {((i % 2 == 0) ? (i + j) : (i - j))}");
                j -= 3;
            }
        }

        public static void Exercicio21()
        {
            /// 21 - Faça um programa que leia um número n e imprima se ele é primo ou não.
            /// (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)

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

            Console.WriteLine(primo ? "É primo" : "Não é primo");

            if (!primo && n != 1)
                Console.WriteLine($"(Divisível por {i})");
        }

        public static void Exercicio22()
        {
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

            var tabuleiro = new char[3, 3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tabuleiro[i, j] = ' ';

            int vez = 1, jogadas = 9;

            while (true)
            {
                Console.WriteLine($"   1  2  3");

                for (int i = 0; i < 3; i++)
                    Console.WriteLine($"{i+1} [{tabuleiro[i, 0]}][{tabuleiro[i, 1]}][{tabuleiro[i, 2]}]");

                var jogador = (vez == 1) ? 'X' : 'O';

                int linha, coluna;

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
                    Console.WriteLine("Jogo terminou empatado");
                    break;
                }

                //linha--;
                //coluna--;

                if (jogador==tabuleiro[0, 0]&&jogador==tabuleiro[0, 1]&&jogador==tabuleiro[0, 2]||
                    jogador==tabuleiro[1, 0]&&jogador==tabuleiro[1, 1]&&jogador==tabuleiro[1, 2]||
                    jogador==tabuleiro[2, 0]&&jogador==tabuleiro[2, 1]&&jogador==tabuleiro[2, 2]||
                    jogador==tabuleiro[0, 0]&&jogador==tabuleiro[1, 0]&&jogador==tabuleiro[2, 0]||
                    jogador==tabuleiro[0, 1]&&jogador==tabuleiro[1, 1]&&jogador==tabuleiro[2, 1]||
                    jogador==tabuleiro[0, 2]&&jogador==tabuleiro[1, 2]&&jogador==tabuleiro[2, 2]||
                    jogador==tabuleiro[0, 0]&&jogador==tabuleiro[1, 1]&&jogador==tabuleiro[2, 2]||
                    jogador==tabuleiro[0, 2]&&jogador==tabuleiro[1, 1]&&jogador==tabuleiro[2, 0])
                {
                    Console.WriteLine($"   1  2  3");

                    for (int i = 0; i < 3; i++)
                        Console.WriteLine($"{i + 1} [{tabuleiro[i, 0]}][{tabuleiro[i, 1]}][{tabuleiro[i, 2]}]");

                    Console.WriteLine($"Jogador {jogador} venceu");
                    break;
                }

                vez *= -1;
            }
        }
    }
}
