using System.Text;

namespace Semana4
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
            sw = new StreamWriter(".\\" + nome + ".txt", true, Encoding.UTF8);
        }

        public void lerArquivo()
        {
            //Console.Write(sr.ReadToEnd());

            sr = new StreamReader(".\\" + nome + ".txt");
            string linha = sr.ReadLine();

            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }

            sr.Close();
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
