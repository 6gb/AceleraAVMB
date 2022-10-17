namespace AceleraAVMB
{
    internal class Exercicios
    {
        public static void Exercicio1()
        {
            var numeros = new List<int>(4);
            // 1 - Escrever um algoritmo para ler quatro valores inteiros,
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º nº");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            // calcular a sua média,
            var media = numeros.Sum() / 4;
            // e escrever na tela os que são superiores à média.
            numeros.ForEach(n =>
            {
                if (n > media)
                    Console.WriteLine(n);
            });
        }

        public static void Exercicio2()
        {
            // 2 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
            var horas = new List<int>(2);
            var valorPorHora = new List<int>(2);
            var salarios = new List<int>(2);

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Informe a quantidade de horas do {i + 1}º professor");
                horas.Add(int.Parse(Console.ReadLine()));
                // e o valor por hora recebido por cada um deles.
                Console.WriteLine($"Informe o valor por hora recebido pelo {i + 1}º professor");
                valorPorHora.Add(int.Parse(Console.ReadLine()));
                salarios.Add(horas[i] * valorPorHora[i]);
            }

            var professorDeSalarioMaisAlto = salarios[0] > salarios[1] ? 1 : 2;

            Console.WriteLine($"{professorDeSalarioMaisAlto}º professor recebe mais");
        }

        public static void Exercicio3()
        {
            // 3 - Escreva um programa que pede para o usuário digitar um valor entre 1 e 12,
            Console.WriteLine("Digite valor entre 1 e 12");
            int valor = int.Parse(Console.ReadLine());
            // e então mostre na tela o mês correspondente
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
                // Caso o usuário digite um valor fora do intervalo,
                // mostre uma mensagem indicando que é um mês inválido.
                _ => "Mês inválido"
            });
        }

        public static void Exercicio4()
        {
            // 4 - Escreva um programa que leia um valor entre 0 e 9,
            Console.WriteLine("Digite valor entre 0 e 9");
            int valor = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            // Pergunte também se o usuário quer saber a forma literal em português, inglês ou espanhol.
            Console.WriteLine("Forma literal em [p]ortuguês, [i]nglês ou [e]spanhol?");
            char lingua = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // e então escreva na tela o mesmo na forma literal.
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
            // 5 - Escreva um programa que peça para o usuário digitar uma letra,
            // e então o programa imprime na tela se a letra é uma vogal ou consoante.
            // Utilize no máximo 6 cases em um switch-case para resolver esse exercício.

            Console.WriteLine("Digite uma letra: ");
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
            // 6 - Fazer uma algoritmo que leia valores para as variáveis hora, minuto e segundo;
            // verificando e escrevendo se elas correspondem a um horário válido ou não.
            // Para um horário ser válido, a hora deve estar no intervalo de 0 a 23, o minuto e o segundo no intervalo de 0 a 59.
        }

        public static void Exercicio7()
        {
            // 7 - Escreva um algoritmo para pesquisa de renda per capita que
            // leia o valor da renda familiar e o número de integrantes da família.
            // Calcule o valor da renda per capita da família.
        }

        public static void Exercicio8()
        {
            // 8 - Um comerciante calcula o lucro da venda baseado no valor da compra dos clientes de acordo com os itens a seguir:
            // Valor da Compra < R$ 10,00  então o Lucro é de 70 %
            // R$ 10,00 ≤ Valor da Compra < R$ 30,00 então o Lucro é de 50 %
            // R$ 30,00 ≤ Valor da Compra < R$ 50,00 então o Lucro é de 40 %
            // Valor da Compra ≥ R$ 50,00 então o Lucro é de 30 %
            // Criar um algoritmo que leia o valor da compra e imprima uma mensagem indicando de quantos % é o lucro e o valor.
        }

        public static void Exercicio9()
        {
            // 9 - Faça um algoritmo que leia o tamanho dos lados de um triangulo(lado a, b e c),
            // e então diga se esses lados podem ou não formar um triangulo.
            // Para que os lados formem um triângulo, todos os lados devem ser menores a soma dos outros dois lados.
            // Caso os lados formem um triangulo, diga se o mesmo é equilátero(todos os lados iguais),
            // isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).
        }

        public static void Exercicio10()
        {
            // 10 - Faça um programa que leia um número e apresente a tabuada deste número.
        }

        public static void Exercicio11()
        {
            // 11 - Escreva um programa em C que gera números entre 1000 e 1999 e mostra aqueles que divididos por 11 dão resto 5.
        }

        public static void Exercicio12()
        {
            // 12 - Dado um limite inferior e superior, calcule a soma de todos os números pares contidos nesse intervalo.
        }

        public static void Exercicio13()
        {
            // 13 - Escreva um algoritmo que pergunte ao usuário qual o valor inicial da contagem,
            // qual o valor final, e se ele deseja pular os valores pares ou os valores ímpares.
            // Após, faça um laço de repetição que mostre os valores desejados.
        }

        public static void Exercicio14()
        {
            // 14 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            // e então mostre todos os valores desse intervalo.
        }

        public static void Exercicio15()
        {
            // 15 - Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20.
            // Considere que Polegada = Centímetro * 2,54.
        }

        public static void Exercicio16()
        {
            // 16 - Escreva um programa que pergunte para o usuário os valores iniciais e finais da contagem,
            // e então mostre todos os valores desse intervalo.
        }

        public static void Exercicio17()
        {
            // 17 - Modifique a questão anterior de modo que seja perguntado para o usuário
            // se ele quer que os números apareçam em ordem crescente ou decrescente.
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
        }

        public static void Exercicio19()
        {
            // 19 - Utilize o comando continue de modo que as voltas de número 5 e 7 sejam puladas no código da questão anterior.
        }

        public static void Exercicio20()
        {
            // 20 - Faça um algoritmo para calcular e mostrar o resultado dos 50 primeiros elementos da série
            // 1000 / 1 - 997 / 2 + 994 / 3 - 991 / 4 + ...
        }

        public static void Exercicio21()
        {
            // 21 - Faça um programa que leia um número n e imprima se ele é primo ou não.
            // (um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!)
        }
    }
}
