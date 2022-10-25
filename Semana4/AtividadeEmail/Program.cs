using System.Text;

namespace AtividadeEmail
{

    /// 
    /// 1. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
    /// Menu
    /// 1 - Cadastrar email
    /// 2 - Listar 
    /// 3 - Sair 
    /// Opção: 
    /// 

    internal class Program
    {
        public static int Menu()
        {
            Console.Clear();

            Console.WriteLine("Menu\n" +
                "1 - Cadastrar email\n" +
                "2 - Listar emails\n" +
                "3 - Sair\n" +
                "Opção:");

            int op = int.Parse(Console.ReadLine());

            Console.Clear();

            return op;
        }

        private static string LerDados()
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();

            while (true)
            {
                Console.Write("Informe o email: ");
                string email = Console.ReadLine();

                if (email.Contains('@'))
                    return $"{nome};{email}";
                else
                    Console.WriteLine("Email inválido, tente novamente");
            }
        }

        public static void CadastrarEmail()
        {
            Console.WriteLine($"Cadastro de email");
            StreamWriter sw = new StreamWriter($".\\emails.csv", true, Encoding.UTF8);
            sw.WriteLine(LerDados());
            sw.Close();
            Console.WriteLine($"Email cadastrado");
        }

        public static void ListarEmails()
        {
            StreamReader sr;

            try
            {
                sr = new StreamReader(".\\emails.csv");
            }
            catch
            {
                new StreamWriter($".\\emails.csv", true, Encoding.UTF8).Close();
                sr = new StreamReader($".\\emails.csv");
            }

            Console.WriteLine($"Lista de emails\n" +
                "NOME".PadRight(20) + "EMAIL".PadRight(20));

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
                        CadastrarEmail();
                        break;
                    case 2:
                        ListarEmails();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (op == 3)
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