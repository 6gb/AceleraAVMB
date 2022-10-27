using System.Text;

namespace AtividadeAlbum
{

    /// 
    /// 2. Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve possuir um Menu 
    /// 
    /// Menu
    /// 1 - Cadastrar figurinha repetida
    /// 2 - Cadastrar figurinha faltante
    /// 3 - Listar figurinhas repetidas
    /// 4 - Listar figurinhas faltantes
    /// 5 - Sair
    /// Opção:
    /// 
    /// nos arquivos.csv.Por exemplo, arquivo de figurinhas repetidas, repetidas.csv
    /// codigo figurinha; seleçao; nome do jogador
    /// codigo figurinha; seleçao; nome do jogador
    /// codigo figurinha; seleçao; nome do jogador
    /// codigo figurinha; seleçao; nome do jogador
    /// codigo figurinha; seleçao; nome do jogador
    /// 

    internal class Program
    {
        public static int Menu()
        {
            Console.Clear();

            Console.WriteLine("Menu\n" +
                "1 - Cadastrar figurinha repetida\n" +
                "2 - Cadastrar figurinha faltante\n" +
                "3 - Listar figurinhas repetidas\n" +
                "4 - Listar figurinhas faltantes\n" +
                "5 - Sair\n" +
                "Opção:");

            int op = int.Parse(Console.ReadLine());

            Console.Clear();

            return op;
        }

        private static string LerDados()
        {
            Console.Write("Informe o código: ");
            string codigo = Console.ReadLine();

            Console.Write("Informe a seleção: ");
            string selecao = Console.ReadLine();

            Console.Write("Informe o nome do jogador: ");
            string jogador = Console.ReadLine();

            return $"{codigo};{selecao};{jogador}";
        }

        public static void CadastrarFigurinha(string tipo)
        {
            Console.WriteLine($"Cadastro de figurinha {tipo}");
            StreamWriter sw = new StreamWriter($".\\{tipo}s.csv", true, Encoding.UTF8);
            sw.WriteLine(LerDados());
            sw.Close();
            Console.WriteLine($"Figurinha {tipo} cadastrada");
        }

        public static void ListarFigurinhas(string tipo)
        {
            StreamReader sr = new StreamReader($".\\{tipo}.csv");
            Console.WriteLine($"Lista de figurinhas {tipo}\n" +
                "CÓDIGO".PadRight(20) + "PAÍS".PadRight(20) + "NOME DO JOGADOR".PadRight(20));

            string linha = sr.ReadLine();

            while (linha != null)
            {
                string[] dados = linha.Split(';');

                for (int i = 0; i < dados.Length; i++)
                    Console.Write(dados[i].PadRight(20));

                Console.WriteLine();
                linha = sr.ReadLine();
            }

            sr.Close();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int op = Menu();

                switch (op)
                {
                    case 1:
                        CadastrarFigurinha("repetida");
                        break;
                    case 2:
                        CadastrarFigurinha("faltante");
                        break;
                    case 3:
                        ListarFigurinhas("repetidas");
                        break;
                    case 4:
                        ListarFigurinhas("faltantes");
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (op == 5)
                    break;
                else
                {
                    Console.Write("Pressione qualquer tecla para prosseguir...");
                    Console.ReadKey();
                }
            }
        }
    }
}