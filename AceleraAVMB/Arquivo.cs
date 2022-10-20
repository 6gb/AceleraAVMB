using System.Text;

namespace AceleraAVMB
{
    internal class Arquivo
    {
        string nome, mensagem;
        StreamWriter sw;
        StreamReader sr;

        public Arquivo (string nome)
        {
            this.nome = nome;
        }

        public void criaAbreArquivo()
        {
            sw = new StreamWriter("C:\\Arquivo\\" + nome + ".txt", true, Encoding.UTF8);
        }

        public void lerArquivo()
        {
            string linha = sr.ReadLine();
            sr = new StreamReader("C:\\Arquivo\\" + nome + ".txt");

            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
        }

        public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
            sw.Flush();
        }

        public void fecharArquivo()
        {
            sw.Close();
        }
    }
}
