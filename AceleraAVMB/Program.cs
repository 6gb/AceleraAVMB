using System.Reflection;

namespace AceleraAVMB
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}