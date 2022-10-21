using System.Globalization;

namespace Semana0
{
    internal class Program
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

        static void Main(string[] args)
        {
            /*
            int x = 5, y = 10;
            double z;
            z = 3.1415;
            Console.WriteLine("Os valores sao " + x + ", " + y + " e " + z);
            Console.WriteLine("Os valores sao {0}, {1} e {2}", x, y, z);
            Console.WriteLine($"Os valores sao {x}, {y} e {z}");

            double a = double.Parse("3,3", new CultureInfo("pt-BR"));
            Console.WriteLine(a);
            */

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
    }
}