namespace ArquivoAula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do arquivo: ");
            string nomeArquivo = Console.ReadLine();

            Arquivo a = new Arquivo(nomeArquivo);

            int op;

            do
            {
                Console.WriteLine("Digite:\n" +
                "1 - para criar/abrir um arquivo\n" +
                "2 - para gravar um texto no arquivo\n" +
                "3 - para ler o arquivo\n" +
                "0 - para sair do programa");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        a.criaAbreArquivo();
                        a.fecharArquivo();
                        break;
                    case 2:
                        a.criaAbreArquivo();
                        Console.WriteLine("Digite o texto: ");
                        string msg = Console.ReadLine();
                        a.gravaMensagem(msg);
                        a.fecharArquivo();
                        break;
                    case 3:
                        a.lerArquivo();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            while (op != 0);
        }
    }
}
