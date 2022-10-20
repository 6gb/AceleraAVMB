using System.Reflection;

namespace AceleraAVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivo;
            Console.WriteLine("Informe o nome do arquivo: ");
            nomeArquivo = Console.ReadLine();

            Arquivo a = new Arquivo(nomeArquivo);

            a.criaAbreArquivo();
            a.gravaMensagem("alou");

            Console.WriteLine("Digite:\n" +
                "1 - para criar\n" +
                "2 - para" +
                "3 - para" +
                "0 - para");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 0:
                    break;
                default:
                    break;
            }

            //Arquivos.Teste();

            /*
            Type t = new Exercicios().GetType();

            try
            {
                t.InvokeMember($"Exercicio{args[0]}", BindingFlags.InvokeMethod, null, null, null);
            }
            catch
            {
                while (true)
                {
                    Console.Write("Informe o nº do exercício: ");
                    var n = Console.ReadLine();

                    try
                    {
                        t.InvokeMember($"Exercicio{n}", BindingFlags.InvokeMethod, null, null, null);
                    }
                    catch
                    {
                        Console.WriteLine("Argumento inválido informado");
                    }
                }
            }
            */
        }
    }
}