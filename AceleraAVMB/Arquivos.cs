namespace AceleraAVMB
{
    internal class Arquivos
    {
        public static void Teste()
        {
            try
            {
                StreamWriter sw = new StreamWriter(".\\teste.txt");
                sw.WriteLine("Primeira linha.");
                sw.WriteLine("Segunda linha.");
                sw.Close();

                StreamReader sr = new StreamReader(".\\teste.txt");

                //Console.Write(sr.ReadToEnd());

                string line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Fim");
            }
        }
    }
}
